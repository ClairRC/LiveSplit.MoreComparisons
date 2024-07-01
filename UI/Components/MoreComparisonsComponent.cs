using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

//I am a beginner please don't judge my code too harshly.,.,.

namespace LiveSplit.UI.Components
{
    public class MoreComparisonsComponent : LogicComponent
    {
        protected LogicComponent InternalComponent { get; set; }
        public MoreComparisonsSettings Settings { get; set; }
        protected LiveSplitState CurrentState { get; set; }

        public override string ComponentName => "More Comparisons";

        public MoreComparisonsComponent(LiveSplitState state) 
        {

            CurrentState = state;
            Settings = new MoreComparisonsSettings(state);
        }


        public override Control GetSettingsControl(LayoutMode mode)
        {
            Settings.Mode = mode;
            return Settings;
        }

        public override System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public override void SetSettings(System.Xml.XmlNode settings)
        {
            Settings.SetSettings(settings);
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {

        }

        public override void Dispose()
        {

        }

        public int GetSettingsHashCode() => Settings.GetSettingsHashCode();
    }
}
