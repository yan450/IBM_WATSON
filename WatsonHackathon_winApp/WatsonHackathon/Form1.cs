using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.DAL;
using WatsonHackathon.Components;
using System.Threading;
using System.Reflection;

namespace WatsonHackathon
{
    public partial class Form1 : Form
    {
        int interval = 30000;
        SplitCall splitCall;
        int round = 0;
        HackathonLogic logic;
        Thread threadAnalysis;


        public Form1()
        {
            InitializeComponent();
            offreTitanium.ShowNone();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            logic = new HackathonLogic();
            splitCall = logic.Get_Call_Array("952085"); //  67110002355133

            threadAnalysis = new Thread(SentimentAnalysis);
            threadAnalysis.Start();

            timerSeconde.Start();

            //timer.Interval = interval;
            //timer.Start();

        }


        private delegate void SetControlOfferRangeThreadSafeDelegate(
        Control control,
        int v1);

        public static void SetControlOfferThreadSafe(
            Control control,
            int v1)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlOfferRangeThreadSafeDelegate
                (SetControlOfferThreadSafe),
                new object[] { control, v1 });
            }
            else
            {
                control.GetType().InvokeMember(
                    "ShowOffer",
                    BindingFlags.InvokeMethod,
                    null,
                    control,
                    new object[] { v1 });
            }
        }

        //***********************************

        private delegate void SetControlAddTimeRangeThreadSafeDelegate(
                Control control,
                int v1);

        public static void SetControlAddTimeRangeThreadSafe(
            Control control,
            int v1)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlAddTimeRangeThreadSafeDelegate
                (SetControlAddTimeRangeThreadSafe),
                new object[] { control, v1 });
            }
            else
            {
                control.GetType().InvokeMember(
                    "AddNps",
                    BindingFlags.InvokeMethod,
                    null,
                    control,
                    new object[] { v1 });
            }
        }

        private delegate void SetControlPropertyThreadSafeDelegate(
            Control control,
            string propertyName,
            object propertyValue);

        public static void SetControlPropertyThreadSafe(
            Control control,
            string propertyName,
            object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate
                (SetControlPropertyThreadSafe),
                new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(
                    propertyName,
                    BindingFlags.SetProperty,
                    null,
                    control,
                    new object[] { propertyValue });
            }
        }


        private void SentimentAnalysis()
        {
            SetControlPropertyThreadSafe(Start, "Enabled", false);
            int scoreTotal = 0;
            while(splitCall.Nbr_Splits > round)
            {
                string analyse = logic.Watson_Sentiment(splitCall.Arr_Calls[round]);
                SentimentWatson sentiment = JsonHelper.DeserializeObject<SentimentWatson>(analyse);
                int sentimentScore = logic.NpsAnalysis(sentiment);
                scoreTotal = logic.PackageAnalysis(sentiment);
                round++;
                while(progressBarFiles.Value < 30)
                {
                    Thread.Sleep(250);
                }
                SetControlAddTimeRangeThreadSafe(panelNps, sentimentScore);
                SetControlOfferThreadSafe(offreTitanium, scoreTotal);
                SetControlPropertyThreadSafe(progressBarFiles, "Value", 0);
            }

            buttonStop_Click(null, null);
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            //var th = new Thread(SentimentAnalysis);
            //th.Start();

            //Random r = new Random();
            

            //panelTimeRange.AddTimeRange(r.Next(2) + 1, r.Next(2) + 1, r.Next(2) + 1);


            //if (r.Next(3) < 2)
            //    offreTitanium.ShowBronze();
            //else
            //    offreTitanium.ShowGold();

        }

        private void timerSeconde_Tick(object sender, EventArgs e)
        {
            if (Start.Enabled)
            {
                progressBarFiles.Value = 0;
                return;
            }

            if(progressBarFiles.Value < 30)
                progressBarFiles.Value++;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(threadAnalysis != null)
            {
                threadAnalysis.Abort();
            }
                
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (threadAnalysis != null)
            {
                threadAnalysis.Abort();
            }
            round = 0;

            while (threadAnalysis.IsAlive) { }

            SetControlPropertyThreadSafe(Start, "Enabled", true);

        }
    }
}
