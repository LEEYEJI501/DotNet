using static System.Console;

class TupleLiteral
{
    static void Main()
    {
        var fhd = (1920, 1080);
        WriteLine($"Full HD : {fhd.Item1} * {fhd.Item2}");

        var uhd = (Width: 3840, Height: 2160);
        WriteLine($"4K UHD : {uhd.Width} * {uhd.Height}");

        (ushort Width, ushort Height) hd = (1366, 76);
        Write($"HD : {hd.Width} * {hd.Height}");
        WriteLine($"Type({hd.Width.GetType()}, {hd.Height.GetType()})");
    }
}