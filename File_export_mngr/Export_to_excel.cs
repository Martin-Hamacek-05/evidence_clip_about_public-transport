using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Org.BouncyCastle.Asn1.X509.Qualified;
using ScottPlot.Palettes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.File_export_mngr
{
    /// <summary>
    /// Convert selected data to xlsx file
    /// </summary>
    public class Export_to_excel : I_Export_file
    {
        public string export_file(DataGridView data, string path, string header, params string[] hide_columns)
        {
            try
            {
                string new_header = "";

                if (header.Length >= 30)
                {
                    for (int i = 0; i < 31; i++)
                    {
                        new_header = new_header + header[i];
                    }
                }
                else 
                {
                    new_header = header;
                }
                

                using (var workbook = SpreadsheetDocument.Create(path, DocumentFormat.OpenXml.SpreadsheetDocumentType.Workbook))
                {
                    var workbookPart = workbook.AddWorkbookPart();

                    workbook.WorkbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

                    workbook.WorkbookPart.Workbook.Sheets = new DocumentFormat.OpenXml.Spreadsheet.Sheets();

                    Worksheet_Style(workbook);


                    /* foreach (System.Data.DataTable table in dataSet.Tables)
                    {*/

                    var sheetPart = workbook.WorkbookPart.AddNewPart<WorksheetPart>();
                    var sheetData = new DocumentFormat.OpenXml.Spreadsheet.SheetData();
                    sheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(sheetData);

                    DocumentFormat.OpenXml.Spreadsheet.Sheets sheets = workbook.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>();
                    string relationshipId = workbook.WorkbookPart.GetIdOfPart(sheetPart);

                    uint sheetId = 1;
                    if (sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Count() > 0)
                    {
                        sheetId =
                            sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Select(s => s.SheetId.Value).Max() + 1;
                    }

                    DocumentFormat.OpenXml.Spreadsheet.Sheet sheet = new DocumentFormat.OpenXml.Spreadsheet.Sheet() { Id = relationshipId, SheetId = sheetId, Name = new_header };
                    sheets.Append(sheet);

                    DocumentFormat.OpenXml.Spreadsheet.Row headerRow = new DocumentFormat.OpenXml.Spreadsheet.Row();

                    List<String> columns = new List<string>();

                    for (int i = 0; i < data.Columns.Count; i++)
                    {

                        if (!(data.Columns[i].HeaderText.ToString().Equals("id")))
                        {
                            if (!(data.Columns[i].HeaderText.ToString().Equals(hide_columns[0])))
                            {

                                columns.Add(data.Columns[i].HeaderText.ToString());

                                DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                                cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                                cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(data.Columns[i].HeaderText.ToString());
                                headerRow.AppendChild(cell);
                            }

                        }

                    }

                    sheetData.AppendChild(headerRow);
                  
                    foreach (DataGridViewRow row in data.Rows)
                    {
                        DocumentFormat.OpenXml.Spreadsheet.Row newRow = new DocumentFormat.OpenXml.Spreadsheet.Row();
                        for (int i = 0; i < data.Columns.Count; i++)
                        {
                            if (!(data.Columns[i].HeaderText.ToString().Equals("id")))
                            {
                                if (!(data.Columns[i].HeaderText.ToString().Equals(hide_columns[0])))
                                {
                                    DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                                    CellFormats cfs = new CellFormats();
                                    /*cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                                    cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(row.Cells[i].Value?.ToString().ToString()); //*/

                                    switch (data.Columns[i].ValueType.Name) 
                                    {
                                        case "Int128":
                                            cell.DataType = CellValues.Number;
                                            cell.CellValue = new CellValue(Decimal.Parse(row.Cells[i].Value?.ToString()));
                                            cell.StyleIndex = 3;
                                            break;

                                        case "UInt128":
                                            cell.DataType = CellValues.Number;
                                            cell.CellValue = new CellValue(Decimal.Parse(row.Cells[i].Value?.ToString()));
                                            cell.StyleIndex = 3;
                                            break;

                                        case "Int64":
                                            cell.DataType = CellValues.Number;
                                            cell.CellValue = new CellValue(Decimal.Parse(row.Cells[i].Value?.ToString()));
                                            cell.StyleIndex = 3;
                                            break;

                                        case "Int32":
                                            cell.DataType = CellValues.Number;
                                            cell.CellValue = new CellValue(Int32.Parse(row.Cells[i].Value?.ToString()));
                                            cell.StyleIndex = 3;
                                            break;

                                        case "Int16":
                                            cell.DataType = CellValues.Number;
                                            cell.CellValue = new CellValue(Int16.Parse(row.Cells[i].Value?.ToString()));
                                            cell.StyleIndex = 3;
                                            break;

                                        case "DateTimeOffset":
                                            cell.DataType = CellValues.Number;
                                            cell.StyleIndex = 1;
                                            cell.CellValue = new CellValue(DateTime.Parse(row.Cells[i].Value.ToString()).ToOADate());
                                            break;

                                        case "DateTime":
                                            cell.DataType = CellValues.Number;
                                            cell.CellValue = new CellValue(DateTime.Parse(row.Cells[i].Value?.ToString()).ToOADate());
                                            cell.StyleIndex = 1;
                                            break;

                                        case "DateOnly":
                                            cell.DataType = CellValues.Number;
                                            cell.StyleIndex = 1;
                                            cell.CellValue = new CellValue(DateTime.Parse(row.Cells[i].Value.ToString()).ToOADate());
                                            break;

                                        case "Decimal":
                                            cell.DataType = CellValues.Number;
                                            cell.StyleIndex = 2;
                                            cell.CellValue = new CellValue(Decimal.Parse(row.Cells[i].Value?.ToString()));
                                        break;

                                        case "Single":
                                            cell.DataType = CellValues.Number;
                                            cell.StyleIndex = 2;
                                            cell.CellValue = new CellValue(Decimal.Parse(row.Cells[i].Value?.ToString()));
                                        break;

                                        case "Boolean":
                                            cell.DataType = CellValues.Boolean;
                                            cell.CellValue = new CellValue(bool.Parse(row.Cells[i].Value?.ToString()));
                                        break;

                                        case "Bool":
                                            cell.DataType = CellValues.Boolean;
                                            cell.CellValue = new CellValue(bool.Parse(row.Cells[i].Value?.ToString()));
                                            break;

                                        case "Double":
                                            cell.DataType = CellValues.Number;
                                            cell.StyleIndex = 2;
                                            cell.CellValue = new CellValue(Convert.ToDouble(row.Cells[i].Value?.ToString()));
                                        break;

                                        case "Float":
                                            cell.DataType = CellValues.Number;
                                            cell.StyleIndex = 2;
                                            cell.CellValue = new CellValue(float.Parse(row.Cells[i].Value?.ToString()));
                                            break;

                                        case "UInt64":
                                            cell.DataType = CellValues.Number;
                                            cell.CellValue = new CellValue(Convert.ToDecimal(row.Cells[i].Value?.ToString()));
                                            cell.StyleIndex = 3;
                                            break;

                                        case "UInt32":
                                            cell.DataType = CellValues.Number;
                                            cell.CellValue = new CellValue(Convert.ToDecimal(row.Cells[i].Value?.ToString()));
                                            cell.StyleIndex = 3;
                                            break;

                                        case "UInt16":
                                            cell.DataType = CellValues.Number;
                                            cell.CellValue = new CellValue(Convert.ToDecimal(row.Cells[i].Value?.ToString()));
                                            cell.StyleIndex = 3;
                                            break;

                                        case "Long":
                                            cell.DataType = CellValues.Number;
                                            cell.CellValue = new CellValue(Convert.ToDecimal(row.Cells[i].Value?.ToString()));
                                            cell.StyleIndex = 3;
                                            break;

                                        default:
                                            cell.DataType = CellValues.String;
                                            cell.CellValue = new CellValue(row.Cells[i].Value?.ToString());
                                        break;
                                    }
                                    newRow.AppendChild(cell);
                                }
                            }
                        }
                        sheetData.AppendChild(newRow);
                    }

                }
                return "OK";
            }
            catch (Exception exc)
            {
                return "Došlo k neočekavané chybě:\n" + exc.Message;
            }

            

        }
        /// <summary>
        /// declaration of stylesheet
        /// </summary>
        /// <param name="document">SpreadsheetDocument</param>
        /// <returns>create_style</returns>
        private static WorkbookStylesPart Worksheet_Style(SpreadsheetDocument document)
        {
            WorkbookStylesPart create_style = document.WorkbookPart.AddNewPart<WorkbookStylesPart>();
            Stylesheet workbookstylesheet = new Stylesheet();

            DocumentFormat.OpenXml.Spreadsheet.Font font0 = new DocumentFormat.OpenXml.Spreadsheet.Font();
            FontName arial = new FontName() { Val = "Calibri" };
            DocumentFormat.OpenXml.Spreadsheet.FontSize size = new DocumentFormat.OpenXml.Spreadsheet.FontSize() { Val = 11 };
            font0.Append(arial);
            font0.Append(size);

            DocumentFormat.OpenXml.Spreadsheet.Font font1 = new DocumentFormat.OpenXml.Spreadsheet.Font();
            DocumentFormat.OpenXml.Spreadsheet.Bold bold = new DocumentFormat.OpenXml.Spreadsheet.Bold();
            font1.Append(bold);

            DocumentFormat.OpenXml.Spreadsheet.Fonts fonts = new DocumentFormat.OpenXml.Spreadsheet.Fonts();
            fonts.Append(font0);
            fonts.Append(font1);

            Fill fill0 = new Fill();
            Fills fills = new Fills();
            fills.Append(fill0);

            DocumentFormat.OpenXml.Spreadsheet.Border border0 = new DocumentFormat.OpenXml.Spreadsheet.Border();     
            Borders borders = new Borders();
            
            borders.Append(border0);

            // CellFormats
            CellFormats cellformats = new CellFormats();

            CellFormat cellformat0 = new CellFormat() { FontId = 0, FillId = 0, BorderId = 0 };
            CellFormat date_format = new CellFormat() { BorderId = 0, FillId = 0, FontId = 0, NumberFormatId = 14, FormatId = 0, ApplyNumberFormat = true };
            CellFormat number_format = new CellFormat() { BorderId = 0, FillId = 0, FontId = 0, NumberFormatId = 4, FormatId = 0, ApplyNumberFormat = true };
            CellFormat int_number = new CellFormat() { BorderId = 0, FillId = 0, FontId = 0, NumberFormatId = 1, FormatId = 0, ApplyNumberFormat = true };

            cellformats.Append(cellformat0);
            cellformats.Append(date_format);
            cellformats.Append(number_format);
            cellformats.Append(int_number);

            workbookstylesheet.Append(fonts);
            workbookstylesheet.Append(fills);
            workbookstylesheet.Append(borders);
            workbookstylesheet.Append(cellformats);

            //Save style for finish
            create_style.Stylesheet = workbookstylesheet;
            create_style.Stylesheet.Save();

            return create_style;
        }

    }
}
