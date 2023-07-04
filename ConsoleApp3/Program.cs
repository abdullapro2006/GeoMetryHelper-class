// See https://aka.ms/new-console-template for more information

using System.Drawing;

public static class GeometryHelper 
{
    public static int RectangleArea(int a,int b)
    {
        return a * b;
    }
    public static int Triangle(int a,int b,int c,int p)
    {
        return p = (a * b * c) / 2;
    }
    public static int CircleArea(double r,int s)
    {
        return  s = (int)(r * 2);
    }
}
public class Program 
{
    public static void Main(string[] args)
    {
         int Rectangle = GeometryHelper.RectangleArea(8, 6);
         int Circlearea = GeometryHelper.CircleArea(3.14,1);
         int Triangle = GeometryHelper.Triangle(3, 5, 7, 1);
        Console.WriteLine(Rectangle);
        Console.WriteLine(Triangle);
        Console.WriteLine(Circlearea);
    }

}


