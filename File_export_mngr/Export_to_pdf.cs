using PdfSharp.Pdf;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;
//using evidence_clip_about_public_transport.vendor;
using System.Windows.Forms;
using evidence_clip_about_public_transport.Other_classes;
using evidence_clip_about_public_transport.vendor;
using MigraDoc.Rendering;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PdfSharp.Drawing;

namespace evidence_clip_about_public_transport.File_export_mngr
{
    public class Export_to_pdf : I_Export_file
    {
        public string export_file(DataGridView data, string path, string header, params string[] hide_columns)
        {
            try
            {
               

                PdfExport pdfExport = new PdfExport();

                MigraDoc.DocumentObjectModel.Document document = pdfExport.CreatePage(data, hide_columns);
                document.Info.Title = header;

                MigraDoc.DocumentObjectModel.IO.DdlWriter.WriteToFile(document, "MigraDoc.mdddl");

                PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
                
                renderer.Document = document;

                renderer.RenderDocument();
                
                renderer.PdfDocument.Save(path);
                

                return "Hotovo";
            }
            catch (Exception exc) 
            { 
                return exc.ToString();
            }
        }

        public string export_file_chart(DataGridView data, string path, string header, FormsPlot chart, params string[] hide_columns)
        {
            throw new NotImplementedException();
        }
    }
}
