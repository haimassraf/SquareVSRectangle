using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareVSRectangle.Exercise3;

namespace SquareVSRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            void exportDocument(DocumentExporter exporter)
            {
                exporter.ExportToPDF();
            }
            DocumentExporter d = new DocumentExporter();
            OnleneExporter o = new OnleneExporter();
            exportDocument(d);
        }
    }
}
