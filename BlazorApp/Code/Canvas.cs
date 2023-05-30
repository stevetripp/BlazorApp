using Blazor.Extensions.Canvas.Canvas2D;
using BlazorApp.NewFolder;

namespace BlazorApp.Code;

public class Canvas
{
    public Grid Grid { get; set; } = new Grid();

    public int Width { get; set; } = 1024;
    public int Height { get; set; } = 1024;

    public async Task DrawAsync(Canvas2DContext context)
    {
        await Grid.DrawAsync(context);
    }
}
