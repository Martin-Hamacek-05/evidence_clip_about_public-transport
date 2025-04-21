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
    /// Teplate for class, witch draw a chart 
    /// </summary>
    public interface I_Chart_switch
    {
        public void chart_with_data(FormsPlot chart, DataGridView data, string header);
    }
}
