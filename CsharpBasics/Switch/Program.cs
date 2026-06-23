

int dayOfWeek = 4;
switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wetnesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day!");
        break;
}

Console.WriteLine("This is out from the switch!");

//another innotation:
string dayOfWeekName = "Sunday";
string result = dayOfWeekName switch
{
    "Monday" => "First day.",
    "Thuesday" => "Second day.",
    "Wetnesday" => "Third day.",
    "Thursday" => "Fourth day.",
    "Friday" => "Fifth day.",
    "Saturday" => "Sixth day.",
    "Sunday" => "Seventh day.",
    _ => "Invalid day!"
};