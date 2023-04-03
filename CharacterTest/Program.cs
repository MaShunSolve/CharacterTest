using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var encoding = Encoding.GetEncoding(950);//使用Big5編碼
        string eng = "a";
        int valueByte = encoding.GetBytes(eng).Count();
        Console.WriteLine($@"英文字佔{valueByte}Byte");
        string chn = "扯";
        valueByte = encoding.GetBytes(chn).Count();
        Console.WriteLine($"中文字佔{valueByte}Byte");
        encoding = Encoding.UTF8;
        valueByte = encoding.GetBytes(eng).Count();
        Console.WriteLine($@"英文字佔{valueByte}Byte");
        valueByte = encoding.GetBytes(chn).Count();
        Console.WriteLine($"中文字佔{valueByte}Byte");
    }
}