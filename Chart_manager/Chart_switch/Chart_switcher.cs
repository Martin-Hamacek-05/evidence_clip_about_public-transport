using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author Martin Hamacek*/
namespace evidence_clip_about_public_transport.Chart_manager.Chart_switch
{
    /// <summary>
    /// Switcher of file formats fot charts
    /// </summary>
    public class Chart_switcher
    {
        /// <summary>
        /// list of formats
        /// </summary>
        private List<I_Chart_switch> charts = new List<I_Chart_switch>();


        /// <summary>
        /// add format to list
        /// </summary>
        /// <param name="type_of_chart"></param>
        public void add_chart(I_Chart_switch type_of_chart)
        {
            charts.Add(type_of_chart);
        }

        /// <summary>
        /// load selected file format
        /// </summary>
        /// <param name="id">index in list</param>
        /// <returns>selected file format</returns>
        public I_Chart_switch get_chart(int id)
        {
            return charts[id];
        }

        /// <summary>
        /// save chart to file
        /// </summary>
        /// <param name="path"></param>
        /// <param name="format"></param>
        /// <param name="chart"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static void file_chart(string path,int format,FormsPlot chart, int width, int height) 
        {
                switch (format)
                {
                    case 1:
                        chart.Plot.SavePng(path, width, height);
                        break;

                    case 2:
                        chart.Plot.SaveSvg(path, width, height);
                        break;

                    case 3:
                        chart.Plot.SaveBmp(path, width, height);
                        break;

                    case 4:
                        chart.Plot.SaveWebp(path, width, height);
                        break;

                    case 5:
                        chart.Plot.SaveJpeg(path, width, height);
                        break;

                    default:
                        chart.Plot.SavePng(path, width, height);
                        break;
                }
               
            
        }
        

       


    }
}
