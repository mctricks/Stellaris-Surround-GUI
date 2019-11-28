using System;
using System.Collections.Generic;

namespace SurroundGUIBuilder
{
    public class Template
    {
        public string Filename { get; set; }
        public IEnumerable<Replacement> Replacements { get; set; }
    }
    public class Replacement
    {
        public string Name { get; set; }
        public int BaseValue { get; set; }
        public int ScreenLengths { get; set;}
        public bool IncludeBevel { get; set; }
    }
    public class ReplacementConfiguration
    {
        public int singleMonitorWidth { get; set; }
        public int bevelSize { get; set; }
    }
    public enum ReplacementType
    {
        CenterScreenCenterAnchor,
        CenterScreenRightAnchor,
        CenterScreenLeftAnchor,
        LeftScreenRightAnchor,
        RightScreenLeftAnchor
    }
}
