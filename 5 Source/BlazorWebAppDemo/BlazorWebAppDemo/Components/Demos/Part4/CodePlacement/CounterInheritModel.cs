using Microsoft.AspNetCore.Components;

namespace BlazorWebAppDemo.Components.Demos.Part4.CodePlacement;

public class CounterInheritModel:ComponentBase
{
    protected int currentCount = 0;
    protected void IncrementCount()
    {
        currentCount++;
    }
}
