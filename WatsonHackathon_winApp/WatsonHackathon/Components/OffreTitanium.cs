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
    public partial class OffreTitanium : UserControl
    {
        public OffreTitanium()
        {
            InitializeComponent();
        }

        public void ShowOffer(int score)
        {
            switch (score)
            {
                case 1 :
                    ShowPlatinium();
                    break;
                case 2:
                    ShowGold();
                    break;
                case 3:
                    ShowSilver();
                    break;
                case 4:
                    ShowBronze();
                    break;
            }
        }

        public void ShowNone()
        {
            labelThumbBronze.Visible = false;
            labelThumbPlatinium.Visible = false;
            labelThumbGold.Visible = false;
            labelThumbSilver.Visible = false;
        }

        public void ShowPlatinium()
        {
            labelThumbBronze.Visible = false;
            labelThumbPlatinium.Visible = true;
            labelThumbGold.Visible = false;
            labelThumbSilver.Visible = false;
        }

        public void ShowBronze()
        {
            labelThumbBronze.Visible = true;
            labelThumbPlatinium.Visible = false;
            labelThumbGold.Visible = false;
            labelThumbSilver.Visible = false;
        }

        public void ShowGold()
        {
            labelThumbBronze.Visible = false;
            labelThumbPlatinium.Visible = false;
            labelThumbGold.Visible = true;
            labelThumbSilver.Visible = false;
        }

        public void ShowSilver()
        {
            labelThumbBronze.Visible = false;
            labelThumbPlatinium.Visible = false;
            labelThumbGold.Visible = false;
            labelThumbSilver.Visible = true;
        }
    }
}
