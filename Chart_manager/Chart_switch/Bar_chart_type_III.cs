using ScottPlot.WinForms;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* author Martin Hamacek*/
namespace evidence_clip_about_public_transport.Chart_manager.Chart_switch
{
    /// <summary>
    /// Bar Chart type III
    /// </summary>
    public class Bar_chart_type_III:I_Chart_switch
    {
        /// <summary>
        /// draw chart from datagridview to formsplot
        /// </summary>
        /// <param name="chart">selected chart</param>
        /// <param name="data">selected data</param>
        /// <param name="header">selected header</param>
        public void chart_with_data(FormsPlot chart, DataGridView data, string header)
        {
            chart.Dock = DockStyle.Fill;
            Tick[] ticks = new Tick[data.RowCount];

            chart.Reset();
            chart.Refresh();

            chart.Plot.Axes.Title.Label.Text = header;
            chart.Plot.Add.Palette = new ScottPlot.Palettes.Nord();
            int position_ = 0;

            foreach (DataGridViewRow row in data.Rows)
            {
                position_++;
                ticks[position_ - 1] = new Tick(position_, row.Cells[2].Value.ToString() + " - "+row.Cells[1].Value.ToString() + " (" + row.Cells[0].Value.ToString() + ")");
                
                chart.Plot.Add.Bar(position_, Double.Parse(row.Cells[3].Value?.ToString()));
            }

            chart.Width = 500;
            chart.Height = 500;
            chart.Plot.Axes.Bottom.Label.Text = " ";
            chart.Plot.Axes.Bottom.Label.FontSize = 100;
            chart.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);

            chart.Plot.Axes.Bottom.TickLabelStyle.Rotation = -45;
            chart.Plot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleRight;

            chart.Plot.Axes.Margins(bottom: 0);
        }
    }
}
