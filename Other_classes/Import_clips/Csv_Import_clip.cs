using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Martin Hamacek
namespace evidence_clip_about_public_transport.Other_classes.Import_clips
{
    /// <summary>
    /// import data of clip from csv file in simplified format to DataTable
    /// </summary
    public class Csv_Import_clip : I_Import_clip
    {
        public DataTable load(string path)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(path))
            {
                    string[] headers = sr.ReadLine().Split(';');
                    foreach (string header in headers)
                    {
                        dt.Columns.Add(header);
                    }
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(';');
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dr[i] = rows[i];
                        }
                        dt.Rows.Add(dr);
                    }
            }
            return dt;
        }
    }
}
