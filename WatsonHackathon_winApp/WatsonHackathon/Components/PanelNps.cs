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
    public partial class PanelNps : UserControl
    {
        int count = 0;
        List<Nps> npsList = new List<Nps>();

        public PanelNps()
        {
            InitializeComponent();
            labelFirst.Visible = false;
        }

        public void reset()
        {
            foreach (var comp in npsList)
            {
                comp.Dispose();
            }
            count = 0;
            npsList = new List<Nps>();
        }

        public void AddNps(int nps)
        {
            labelFirst.Visible = false;
            Nps npsComponent = new Nps(nps, 30 * (count + 1));
            npsList.Add(npsComponent);
            int i = npsList.Count;
            foreach(var comp in npsList)
            {
                i--;
                if(i == 0)
                {
                    comp.Location = new Point(12, 0);
                }
                else
                {
                    comp.Location = new Point(102 + 78 * (i-1), 0);
                }

                comp.BringToFront();
                labelFirst.SendToBack();



            }
            

            this.Controls.Add(npsComponent);
            count++;
        }
    }
}
