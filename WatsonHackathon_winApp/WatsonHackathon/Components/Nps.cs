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
    public partial class Nps : UserControl
    {
        public Nps(int nps, int time)
        {
            InitializeComponent();
            SetNps(nps);
            labelInfo.Text = time.ToString() + " sec";
        }

        public void SetNps(int value)
        {
            SetColor(this, value);
        }

        private void SetColor(Control control, int value)
        {
            switch (value)
            {
                case 0:
                    control.BackColor = Color.Gray;
                    labelStatus.Text = "";
                    break;
                case 1:
                    control.BackColor = Color.Green;
                    labelStatus.Text = "Promotor";
                    break;
                case 2:
                    control.BackColor = Color.Yellow;
                    labelStatus.Text = "Passive";
                    break;
                case 3:
                    control.BackColor = Color.Red;
                    labelStatus.Text = "Detractor";
                    break;
            }
        }
    }
}
