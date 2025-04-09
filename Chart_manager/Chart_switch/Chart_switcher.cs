using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Chart_manager.Chart_switch
{

    public class Chart_switcher
    {
        private List<I_Chart_switch> charts = new List<I_Chart_switch>();



        public void add_chart(I_Chart_switch type_of_chart)
        {
            charts.Add(type_of_chart);
        }

        public I_Chart_switch get_chart(int id)
        {
            return charts[id];
        }

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
