﻿using System;

namespace SquareVSRectangle.Exercise3
{
    class DocumentExporter : IPDFExportable
    {
        public virtual void ExportToPDF() => Console.WriteLine("Export to PDF...");
    }
}
