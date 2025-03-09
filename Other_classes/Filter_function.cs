using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Other_classes
{
    /// <summary>
    /// Filter data
    /// </summary>
    public class Filter_function
    {
        /// <summary>
        /// Generator of SQL where clause
        /// </summary>
        /// <param name="data_for_filter"></param>
        /// <param name="column_to_filter"></param>
        /// <returns></returns>
        public static string filter_from_clip(List<List<string>> data_for_filter,List<string>column_to_filter)
        {
            List<string> final = new List<string>();

            if (column_to_filter != null) 
            {
                for (int i = 0; i < column_to_filter.Count(); i++) 
                {
                    if ((i % column_to_filter.Count()) == 0) 
                    {
                        for (int j = 0; j < data_for_filter.Count(); j++) 
                        {
                                final.Add(parametr_to_column(data_for_filter[j], column_to_filter[j]));
                        }
                    }
                }
            }
            return parametrs_to_list(final);
        }
        /// <summary>
        /// Split every atribute to some clause
        /// </summary>
        /// <param name="final_string"></param>
        /// <returns></returns>
        private static string parametrs_to_list(List<string>final_string) 
        {
            string result = "";
            for (int i = 0; i < final_string.Count(); i++)
            {
                if (i != final_string.Count() - 1) 
                {
                    result = result + "(" + final_string[i] + ") and ";
                }
                else
                {
                    result = result + "(" + final_string[i] + ")"; //pokud je nakonci pak uk
                }
            }
            return result;
        }
        /// <summary>
        /// Split more propeties to some clause
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="column_"></param>
        /// <returns></returns>
        private static string parametr_to_column(List<string> parameters,string column_) 
        {
            string parametrs_for_filtr = "";
            if (parameters != null) 
            {
                for (int i = 0; i < parameters.Count(); i++)
                {

                    if (i != parameters.Count() - 1) 
                    {
                        parametrs_for_filtr = parametrs_for_filtr + " "+column_+"='" + parameters[i] + "' or ";
                    }
                    else 
                    {
                        parametrs_for_filtr = parametrs_for_filtr + " "+column_+"='" + parameters[i] + "'";
                    }
                }
            }
            return parametrs_for_filtr;
        }
    }
}
