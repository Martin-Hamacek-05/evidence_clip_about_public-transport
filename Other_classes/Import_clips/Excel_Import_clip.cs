using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using evidence_clip_about_public_transport.Entits;
using evidence_clip_about_public_transport.Other_classes.Import_clips;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.Import_clips
{
    public class Excel_Import_clip : I_Import_clip
    {
        public DataTable load(string path)
        {
            DataTable dt = new DataTable();
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (SpreadsheetDocument doc = SpreadsheetDocument.Open(fs, false))
                    {
                        WorkbookPart workbookPart = doc.WorkbookPart;
                        SharedStringTablePart sstpart = workbookPart.GetPartsOfType<SharedStringTablePart>().First();
                        SharedStringTable sst = sstpart.SharedStringTable;

                        WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                        Worksheet sheet = worksheetPart.Worksheet;

                        var cells = sheet.Descendants<DocumentFormat.OpenXml.Spreadsheet.Cell>();
                        var rows = sheet.Descendants<DocumentFormat.OpenXml.Spreadsheet.Row>();
                        int count_of_column = 0;
                        int count_of_row = 0;

                        foreach (DocumentFormat.OpenXml.Spreadsheet.Row row in rows)
                        {
                            object[] list = { null, null, null, null, null, null, null };
                            DataRow dr = dt.NewRow();
                            count_of_row++;
                            foreach (Cell c in row.Elements<Cell>())
                            {
                                if (count_of_row == 1)
                                {
                                    if ((c.DataType != null) && (c.DataType == CellValues.SharedString))
                                        dt.Columns.Add(new DataColumn(sst.ChildElements[int.Parse(c.CellValue.Text)].InnerText));
                                }
                                else
                                {
                                    if (count_of_row != 0 || count_of_row != dt.Rows.Count)
                                    {
                                        sete(c, sst, count_of_column, list);
                                    }
                                }


                                count_of_column++;

                            }

                            if (count_of_row != 0 || count_of_row != dt.Rows.Count)
                            {
                                dt.Rows.Add(list);
                            }

                            count_of_column = 0;


                        }

                        return dt;




                    }
                }
            }
            catch (Exception exc) 
            {
                return dt;
            }
        }

        public static void sete(Cell c, SharedStringTable shh, int index, object[] clip)
        {
            
            switch (index)
            {

                case 0:

                    if ((c.CellValue != null))
                    {

                        clip[0]= DateOnly.FromDateTime(DateTime.FromOADate(double.Parse(c.CellValue.Text))).ToString();
                    }
                    


                    break;

                case 1:

                    
                        clip[1] = c.CellValue.Text;
                    
                    

                    break;

                case 2:
                    if ((c.DataType != null) && (c.DataType == CellValues.SharedString))
                        if (shh.ChildElements[int.Parse(c.CellValue.Text)].InnerText.Equals("p"))
                        {
                            clip[2] = "false";
                        }
                        else
                        {
                            clip[2] = "true";
                        }
                  


                    break;

                case 3:

                    clip[3] = c.CellValue.Text;

                    break;

                case 4:
                    if ((c.DataType != null) && (c.DataType == CellValues.SharedString))
                        clip[4] = shh.ChildElements[int.Parse(c.CellValue.Text)].InnerText.ToString();
    
                    break;

                case 5:
                    
                    if ((c.DataType != null) && (c.DataType == CellValues.SharedString))
                        clip[5] = shh.ChildElements[int.Parse(c.CellValue.Text)].InnerText.ToString();

                    break;
                case 6:

                    if ((c.DataType != null) && (c.DataType == CellValues.SharedString))
                        clip[6] = shh.ChildElements[int.Parse(c.CellValue.Text)].InnerText.ToString();
                  
                    break;

               
            }
        }
    }
}
