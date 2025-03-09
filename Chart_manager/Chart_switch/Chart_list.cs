using Org.BouncyCastle.Cms;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author Martin Hamacek, C4c, 2024/2025*/
namespace evidence_clip_about_public_transport.Chart_manager.Chart_switch
{
    /// <summary>
    /// Is used for select of the specific chart
    /// </summary>
    public class Chart_list
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">type of chart</param>
        /// <param name="chart">selected chart</param>
        /// <param name="data">selected data</param>
        /// <param name="hearder">selected header</param>
        public void set_chart(int id,FormsPlot chart,DataGridView data,string hearder) 
        {
            Chart_switcher chart_Switcher = new Chart_switcher();
            chart_Switcher.add_chart(new Point_chart_type_I());
            chart_Switcher.add_chart(new Bar_chart_type_I());
            chart_Switcher.add_chart(new Bar_chart_type_II());
            chart_Switcher.add_chart(new Bar_chart_type_III());
            chart_Switcher.get_chart(id).chart_with_data(chart, data, hearder);
        }
    }
}
