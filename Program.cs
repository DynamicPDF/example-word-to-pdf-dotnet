using System;
using ceTe.DynamicPDF.Conversion;

namespace WordToPdfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            WordConversionOptions options = new WordConversionOptions(false);
            options.Author = "John Doe";
            options.TopMargin = 144;
            options.BottomMargin = 72;
            options.LeftMargin = 72;
            options.RightMargin = 72;

            WordConverter converter = new WordConverter("../../../resources/sample.docx", options);
            converter.Convert("sample.pdf");
        }
    }
}
