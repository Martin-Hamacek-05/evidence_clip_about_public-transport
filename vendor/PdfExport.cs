using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using PdfSharp.Drawing;
using ScottPlot.Finance;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace evidence_clip_about_public_transport.vendor
{
    public class PdfExport
    {

        public Document CreatePage(DataGridView dataGridView,params string[]hide_columns)
        {
            // Each MigraDoc document needs at least one section.
            Document document = new Document();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("styles.xml");

            XmlNodeList xml_parse_fonts = xmlDoc.GetElementsByTagName("font");
            XmlNodeList xml_parse_rows = xmlDoc.GetElementsByTagName("font");
            XmlNodeList xml_parse_background = xmlDoc.GetElementsByTagName("background");
            XmlNodeList xml_parse_border = xmlDoc.GetElementsByTagName("border");
            XmlNodeList xml_parse_levels_of_rows = xmlDoc.GetElementsByTagName("row");
            XmlNodeList xml_parse_enable_odd_rows = xmlDoc.GetElementsByTagName("enable_odd_rows");
            XmlNodeList xml_parse_pagestyle = xmlDoc.GetElementsByTagName("pagestyle");


            //XFont font = new XFont("Verdana", 20, XFontStyleEx.BoldItalic);
            // Put a logo in the header
            //MigraDoc.DocumentObjectModel.Shapes.Image image = section.Headers.Primary.AddImage("../../PowerBooks.png");
            /*image.Height = "2.5cm";
            image.LockAspectRatio = true;
            image.RelativeVertical = RelativeVertical.Line;
            image.RelativeHorizontal = RelativeHorizontal.Margin;
            image.Top = ShapePosition.Top;
            image.Left = ShapePosition.Right;
            image.WrapFormat.Style = WrapStyle.Through;*/

            Table table = new Table();

            table.Borders.Visible = true;
            table.Borders.Width = Int32.Parse(xml_parse_border[0].Attributes[0].InnerText);
            table.Borders.Color = MigraDoc.DocumentObjectModel.Color.Parse("#"+ xml_parse_border[0].Attributes[1].InnerText);

            int len = 1;


            
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                
                if (!(dataGridView.Columns[i].HeaderText.ToString().Equals("id")))
                {
                    if (!(dataGridView.Columns[i].HeaderText.ToString().Equals(hide_columns[0])))
                    {
                        table.AddColumn(Unit.FromCentimeter(1.5));
                    }
                }
            }
            var row2 = table.AddRow();
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                
                if (!(dataGridView.Columns[i].HeaderText.ToString().Equals("id")))
                {
                    if (!(dataGridView.Columns[i].HeaderText.ToString().Equals(hide_columns[0])))
                    {
                        var cellA1 = row2[i-1];
                        cellA1.Shading.Color = MigraDoc.DocumentObjectModel.Color.Parse("#"+ xml_parse_levels_of_rows[0].Attributes[1].InnerText);
                        cellA1.AddParagraph(dataGridView.Columns[i].HeaderText.ToString());
                    }

                }

            }
            
            int count = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                var row1 = table.AddRow();
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    if (!(dataGridView.Columns[i].HeaderText.ToString().Equals("id")))
                    {
                        if (!(dataGridView.Columns[i].HeaderText.ToString().Equals(hide_columns[0])))
                        {
                            var cellA1 = row1[i - 1];
                            if (count % 2 == 0)
                            {
                                cellA1.Shading.Color = MigraDoc.DocumentObjectModel.Color.Parse("#" + xml_parse_levels_of_rows[2].Attributes[1].InnerText);
                            }
                            else 
                            {
                                cellA1.Shading.Color = MigraDoc.DocumentObjectModel.Color.Parse("#" + xml_parse_levels_of_rows[1].Attributes[1].InnerText);
                            }       
                            cellA1.AddParagraph(row.Cells[i].Value?.ToString());   
                        }
                    }
                }
                count++;
            }
            document.LastSection.PageSetup = pageformat(Int32.Parse(xml_parse_pagestyle[0].Attributes[0].InnerText),Int32.Parse(xml_parse_pagestyle[0].Attributes[1].InnerText),Decimal.Parse(xml_parse_pagestyle[0].Attributes[2].InnerText), Decimal.Parse(xml_parse_pagestyle[0].Attributes[3].InnerText), Int32.Parse(xml_parse_pagestyle[0].Attributes[4].InnerText));

            //MessageBox.Show(Int32.Parse(xml_parse_pagestyle[0].Attributes[0].InnerText).ToString() + ", "+Int32.Parse(xml_parse_pagestyle[0].Attributes[1].InnerText).ToString() + ", " + Decimal.Parse(xml_parse_pagestyle[0].Attributes[2].InnerText).ToString() + ", " + Decimal.Parse(xml_parse_pagestyle[0].Attributes[3].InnerText).ToString() + ", " + Int32.Parse(xml_parse_pagestyle[0].Attributes[4].InnerText).ToString());

            document.LastSection.Add(table);

            return document;
        }

        private static PageSetup pageformat(int type,int unit,decimal width, decimal height,int orientation) 
        {
            PageSetup pageFormat = new PageSetup();
            if (type == 11)
            {
                pageFormat.PageWidth = get_unit(unit, Decimal.ToDouble(width));
                pageFormat.PageHeight = get_unit(unit, Decimal.ToDouble(height));

                return pageFormat;
            }
            else 
            {
                pageFormat.PageFormat = (PageFormat)type;
                pageFormat.Orientation = (MigraDoc.DocumentObjectModel.Orientation)orientation;
                return pageFormat;
            }
        }

        private static Unit get_unit(int type,double value) 
        { 
            List<Unit> units = new List<Unit>();
            units.Add(Unit.FromCentimeter(value));
            units.Add(Unit.FromMillimeter(value));
            units.Add(Unit.FromPoint(value));
            units.Add(Unit.FromInch(value));
            return units[type];
        }

        

        
        
    }
}
