namespace BlazorWebAppDemo.Services;

public class MyService: IMyService
{
    public List<string> Names { get; set; } = new();

    public void AddName(string name)
    {
        Names.Add(name);
    }

    public MyService() 
    {
        AddName("Steve Sandersson");
        AddName("Dan Roth");
        AddName("Scott Hanselman");
    }
}

public interface IMyService
{
    List<string> Names { get; set; }
    void AddName(string name); 
}
