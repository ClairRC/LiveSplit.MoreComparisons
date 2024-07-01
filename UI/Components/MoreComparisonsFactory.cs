using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class MoreComparisonsFactory : IComponentFactory
    {
        public string ComponentName => "More Comparisons";

        public string Description => "Component that generates new custom comparisons.";

        public ComponentCategory Category => ComponentCategory.Other;

        public IComponent Create(LiveSplitState state) => new MoreComparisonsComponent(state);

        public string UpdateName => ComponentName;

        public string UpdateURL => "";

        public string XMLURL => UpdateURL + "";

        public Version Version => Version.Parse("1.0.0");
    }
}