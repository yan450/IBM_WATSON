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
    public partial class TimeRange : UserControl
    {
        public TimeRange(int sentiment, int personnality, int perseption, int time)
        {
            InitializeComponent();
            SetSentiment(sentiment);
            SetPerseption(perseption);
            SetPersonnality(personnality);
            labelInfo.Text = time.ToString() + " sec";

        }

        public void SetSentiment(int value)
        {
            SetColor(sentimentLabel, value);
        }

        public void SetPerseption(int value)
        {
            SetColor(PerseptionPanel, value);
        }

        public void SetPersonnality(int value)
        {
            SetColor(PersonnalityPanel, value);
        }

        private void SetColor(Label label, int value)
        {
            switch (value)
            {
                case 0: label.BackColor = Color.Gray; break;
                case 1: label.BackColor = Color.Green; break;
                case 2: label.BackColor = Color.Yellow; break;
                case 3: label.BackColor = Color.Red; break;
            }
        }
    }
}
