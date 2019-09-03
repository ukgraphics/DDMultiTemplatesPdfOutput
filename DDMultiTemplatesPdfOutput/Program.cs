using System;
using GrapeCity.Documents.Excel;

namespace DDMultiTemplatesPdfOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 新しいワークブックを生成
            var workbook = new Workbook();

            // Excelファイルをインポート
            workbook.Open("diodocs-excel-templates.xlsx");

            workbook.Save("diodocs-excel-templates.pdf", SaveFileFormat.Pdf);
        }
    }
}
