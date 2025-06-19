using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareVSRectangle.Exercise3
{
    class OnleneExporter : DocumentExporter
    {
        public override void ExportToPDF()
        {
            throw new Exception("ExportDocumentError");
        }
    }
}
