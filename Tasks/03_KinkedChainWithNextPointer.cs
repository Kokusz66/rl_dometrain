using System;

public class 03_KinkedChainWithNextPointer
{

    public 03_KinkedChainWithNextPointer()
	{
	}

    // TODO: Declare an abstract LogHandler with a Next pointer and a Handle method.
    public abstract class LogHandler
    {
        private LogHandler _next;
        public LogHandler SetNext(LogHandler next) { _next = next; return next; }
        public string Handle(string level, string message)
        {
            if (CanHandle(level)) return Write(message);
            if (_next != null) return _next.Handle(level, message);
            return "dropped:" + message;
        }
        protected abstract bool CanHandle(string level);
        protected abstract string Write(string message);
    }
    // TODO: Add InfoHandler, WarnHandler, ErrorHandler subclasses.
    public class InfHandler : LogHandler
    {
        protected override bool CanHandle(string level)
        {
            return level == "info";
        }
        protected override string Write(string message)
        {
            return "console:" + message;
        }
    }

    public class WarnHandler : LogHandler
    {
        protected override bool CanHandle(string level)
        {
            return level == "warn";
        }
        protected override string Write(string message)
        {
            return "file:" + message;
        }
    }

    public class ErrorHandler : LogHandler
    {
        protected override bool CanHandle(string level)
        {
            return level == "error";
        }
        protected override string Write(string message)
        {
            return "page:" + message;
        }
    }

    public class Solution
    {
        public static string Handle(string level, string message)
        {
            // TODO: Build info -> warn -> error using SetNext.
            var info = new InfHandler();
            var warning = new WarnHandler();
            var error = new ErrorHandler();

            // TODO: Return head.Handle(level, message).
            info.SetNext(warning).SetNext(error);
            return info.Handle(level, message);
        }
}

/*
Instructions
Intermediate
Each Handler Knows Its Successor

The previous lesson kept handlers in a List<T> and walked it from outside. The classic Chain of Responsibility stores the next handler inside each handler. The caller hands the request to the head and lets the chain forward it.
The Base Class

public abstract class LogHandler
{
    private LogHandler _next;
    public LogHandler SetNext(LogHandler next) { _next = next; return next; }
    public string Handle(string level, string message)
    {
        if (CanHandle(level)) return Write(message);
        if (_next != null) return _next.Handle(level, message);
        return "dropped:" + message;
    }
    protected abstract bool CanHandle(string level);
    protected abstract string Write(string message);
}

Your Task

    Define LogHandler exactly as shown.
    Add InfoHandler, WarnHandler, ErrorHandler that subclass LogHandler and return the same prefixes from earlier lessons.
    Implement Solution.Handle(string level, string message):
        Wire up info -> warn -> error using SetNext.
        Call Handle on the head and return the result.

Method Signature

public static string Handle(string level, string message)

Expected Results

Handle("info", "a")  -> "console:a"
Handle("warn", "b")  -> "file:b"
Handle("error", "c") -> "page:c"
Handle("audit", "d") -> "dropped:d"


*/
}
