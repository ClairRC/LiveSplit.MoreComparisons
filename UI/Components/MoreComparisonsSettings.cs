using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;

namespace LiveSplit.UI.Components
{
    public partial class MoreComparisonsSettings : UserControl
    {

        public LayoutMode Mode { get; set; }
        public String CompName { get; set; }
        public Time FinalTime { get; set; }
        public int Method { get; set; }
        public LiveSplitState CurrentState { get; set; }
        public MoreComparisonsGenerator Generator { get; set; }
        public int NumericPercent { get; set; }



        public MoreComparisonsSettings(LiveSplitState state)
        {
            InitializeComponent();

            CurrentState = state;
            CompName = "";
            FinalTime = Time.Zero;
            Method = 0;
            labelCompAlrExists.Visible = false;
            numericPercent.Visible = false;
            labelPercent.Visible = false;
        }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.0");
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
        }

        private void MoreComparisonsSettings_Load(object sender, EventArgs e)
        {
            textName.Text = "New Comparison";
            textFinalTime.Text = "";
            checkForRepeatComp();
            
            if(dropDownMethod.SelectedIndex == 2)
            {
                numericPercent.Visible = true;
                labelPercent.Visible = true;
            }

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            checkForRepeatComp();
        }

        private void tableFinalTime_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dropDownMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*  
             *  Constant
             *  Length
             *  Random
             */

            if(dropDownMethod.SelectedIndex == 2)
            {
                numericPercent.Visible = true;
                labelPercent.Visible = true;
            }
            else
            {
                numericPercent.Visible = false;
                labelPercent.Visible = false;
            }
        }

        private void textFinalTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkNewCompAtStart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            CompName = textName.Text;
            textName.Text = "";
            FinalTime = parseInput(textFinalTime.Text);
            Method = dropDownMethod.SelectedIndex;
            NumericPercent = (int)numericPercent.Value;

            Generator = new MoreComparisonsGenerator(CurrentState.Run, CompName, Method, FinalTime, NumericPercent);
            Generator.Generate(CurrentState.Settings);

            checkForRepeatComp();
        }

        private void topTableContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCompAlrExists_Click(object sender, EventArgs e)
        {

        }

        //Not to be confused with Time.ParseText()...
        //I'm really not sure if this is a super roundabout way to do this buuut im trying
        private Time parseInput(string s)
        {
            int parsedHours = 0;
            int parsedMinutes = 0;
            int parsedSeconds = 0;
            int parsedMillis = 0;

            try
            {
                parsedMillis = Int32.Parse(s.Split('.')[1]);
            }

            catch { }

            string[] individualTimes = s.Split('.')[0].Split(':');
            int[] individualTimesInt = new int[individualTimes.Length];

            int index = 0;
            foreach (string time in individualTimes)
            {
                try
                {
                    individualTimesInt[index] = Int32.Parse(time);
                    index++;
                }

                catch
                {
                    return CurrentState.Run[CurrentState.Run.Count-1].PersonalBestSplitTime;
                }
            }

            if (individualTimes.Length == 1)
            {
                parsedSeconds = individualTimesInt[0];
            }
            else if (individualTimes.Length == 2)
            {
                parsedMinutes = individualTimesInt[0];
                parsedSeconds = individualTimesInt[1];
            }
            else if (individualTimes.Length == 3)
            {
                parsedHours = individualTimesInt[0];
                parsedMinutes = individualTimesInt[1];
                parsedSeconds = individualTimesInt[2];
            }
            else
                return CurrentState.Run[CurrentState.Run.Count - 1].PersonalBestSplitTime;

            return new Time(new TimeSpan(0, parsedHours, parsedMinutes, parsedSeconds, parsedMillis));
        }

        private void checkForRepeatComp()
        {
            if (CurrentState.Run.Comparisons.Contains(textName.Text))
            {
                labelCompAlrExists.Visible = true;
                buttonGenerate.Enabled = false;
            }
            else
            {
                labelCompAlrExists.Visible = false;
                buttonGenerate.Enabled = true;
            }
        }

        private void labelPercent_Click(object sender, EventArgs e)
        {

        }
    }
}
