using System.Diagnostics;
using MovieTheater.Framework.Common.Contracts;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;

namespace MovieTheater.Framework.Common
{
    public class PdfExporter : IExporter
    {
        public void Export(string textToExport, string fileName)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 10, XFontStyle.BoldItalic);

            XTextFormatter tf = new XTextFormatter(gfx);

            XRect rect = new XRect(10, 10, 250, 232);
            gfx.DrawRectangle(XBrushes.Azure, rect);

            // tf.Alignment = ParagraphAlignment.Left;
            tf.DrawString(textToExport, font, XBrushes.Black, rect, XStringFormats.TopLeft);

            // Save the document...
            // document.Save(fileName + ".pdf");
            document.Save($"../../PDF/{fileName}.pdf");
            // ...and start a viewer.
            // Process.Start($"../../{fileName}.pdf");
        }
    }
}