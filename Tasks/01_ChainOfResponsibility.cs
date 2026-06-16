using System;

public class 01_ChainOfResponsibility
{
    public static string Route(string level, string message)
    {
        if (level == "info")
        {
            return ("console:" + message);
        }
        if (level == "warn")
        {
            return ("file:" + message);
        }
        if (level == "error")
        {
            return ("page:" + message);
        }
        else
        {
            return ("dropped:" + message);
        }

        /*
 Why a Chain Helps

When several different rules can apply to the same input, packing them all into one method turns into a long if/else if ladder. Every new rule edits the same method and risks breaking the existing branches.
A Log Router

A log line has a severity level: info, warn, or error. Each level is written to a different sink:

    info is written to the console.
    warn is written to a file.
    error is paged to oncall.

In this lesson you write the naive version. One method, one if block per level. Later lessons split the rules into separate handlers and link them together.
Your Task

Implement Solution.Route(string level, string message):

    If level is info return "console:" + message.
    If level is warn return "file:" + message.
    If level is error return "page:" + message.
    For any other value return "dropped:" + message.

Method Signature

public static string Route(string level, string message)

Expected Results

Route("info", "started")  -> "console:started"
Route("warn", "slow")     -> "file:slow"
Route("error", "down")    -> "page:down"
Route("trace", "hi")      -> "dropped:hi"

        */
    }
}