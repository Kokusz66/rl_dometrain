using System;
using System.Collections.Generic;

public class 02_BasicHandlerInterface
{

    public 02_BasicHandlerInterface()
	{

	}

    public interface ILogHandler
    {
        bool CanHandle(string level);
        string Write(string message);
    }

    public class InfoHandler : ILogHandler
    {
        public bool CanHandle(string level)
        {
            return level == "info";
        }
        public string Write(string message)
        {
            return "console:" + message;
        }
    }

    public class WarnHandler : ILogHandler
    {
        public bool CanHandle(string level)
        {
            return level == "warn";
        }

        public string Write(string message)
        {
            return "file:" + message;
        }
    }

    public class ErrorHandler : ILogHandler
    {
        public bool CanHandle(string level)
        {
            return level == "error";
        }

        public string Write(string message)
        {
            return "page:" + message;
        }
    }

    public class Solution
    {
        public static string Handle(string level, string message)
        {
            var handlers = new List<ILogHandler>
        {
            new InfoHandler(),
            new WarnHandler(),
            new ErrorHandler()
        };

            foreach (var handler in handlers)
            {
                if (handler.CanHandle(level))
                {
                    return handler.Write(message);
                }
            }

            return "dropped:" + message;
        }
}

/*
One Handler Per Rule

A handler is a small class that decides whether to act on a request, and what to return when it does. Each level gets its own handler. A coordinator picks the first handler whose CanHandle returns true.
The Interface

public interface ILogHandler
{
    bool CanHandle(string level);
    string Write(string message);
}

Your Task

    Define ILogHandler as shown above.
    Add three classes that implement it: InfoHandler, WarnHandler, ErrorHandler. Each returns the prefix from the previous lesson when Write is called.
    Implement Solution.Handle(string level, string message):
        Build a list with one instance of each handler.
        Walk the list. Return Write(message) from the first handler whose CanHandle returns true.
        If none match, return "dropped:" + message.

Method Signature

public static string Handle(string level, string message)

Expected Results

Handle("info", "x")   -> "console:x"
Handle("warn", "x")   -> "file:x"
Handle("error", "x")  -> "page:x"
Handle("debug", "x")  -> "dropped:x"

*/
}
