using Blazor.Extensions.Canvas.Canvas2D;

namespace BlazorApp.NewFolder;

public class Grid
{
  public async Task DrawAsync(Canvas2DContext context)
  {
    var height = 1024;
    var width = 1024;

    await context.SetFillStyleAsync("white");
    await context.FillRectAsync(0, 0, width, height);

    for (int y = 0; y < height; y++)
    {
      if (y % 100 == 0)
      {
        await DrawLineAsync(context, 0, y, width, y, "cyan", 3);
      }
      else if (y % 10 == 1)
      {
        await DrawLineAsync(context, 0, y, width, y, "cyan", 1);
      }
    }

    for (int x = 0; x < width; x++)
    {
      if (x % 100 == 0)
      {
        await DrawLineAsync(context, x, 0, x, height, "cyan", 3);
      }
      else if (x % 10 == 1)
      {
        await DrawLineAsync(context, x, 0, x, height, "cyan", 1);
      }
    }

    await DrawLineAsync(context, 0, 0, width, height, "blue");
  }

  private async Task DrawLineAsync(Canvas2DContext context, double x1, double y1, double x2, double y2, string color, int width = 1)
  {
    await context.SetStrokeStyleAsync(color);
    await context.SetLineWidthAsync(width);
    await context.BeginPathAsync();
    await context.MoveToAsync(x1, y1);
    await context.LineToAsync(x2, y2);
    await context.StrokeAsync();
  }
}
