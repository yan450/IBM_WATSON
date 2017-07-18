using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatsonHackathon.Components
{
    public partial class PanelTimeRange : UserControl
    {
        private int count = 0;
        public PanelTimeRange()
        {
            InitializeComponent();
        }

        public void AddTimeRange(int sentiment, int personnality, int perseption)
        {
            TimeRange timeRange = new TimeRange(sentiment, personnality, perseption, 30*(count+1));
            timeRange.Location = new Point(240*count, 0);

            this.Controls.Add(timeRange);
            count++;
        }
    }
}
