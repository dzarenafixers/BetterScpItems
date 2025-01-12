using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace BetterItemSCP
{
    public class Config : IConfig
    {
        [Description("Plugin is Enabled?.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug is Enabled?.")]
        public bool Debug { get; set; } = false;

        [Description("Custom Effect for 500 is Enabled?.")]
        public bool Better500 { get; set; } = true;

        [Description("List of Better500 effects. Attention, you must write the name and duration of the effect perfectly")]
        public List<Effect> Effects500 { get; set; } = new() {
      new() { Type = EffectType.Invigorated, Duration = 15f }
};

        [Description("Custom Effect for 1853 is Enabled?.")]
        public bool Better1853 { get; set; } = true;

        [Description("List of Better1853 effects. Attention, you must write the name and duration of the effect perfectly")]
        public List<Effect> Effects1853 { get; set; } = new() {
      new() { Type = EffectType.Invigorated, Duration = 15f }
};



        [Description("Custom Effect for 018 is Enabled?.")]
        public bool Better018 { get; set; } = true;

        [Description("List of Better018 effects. Attention, you must write the name and duration of the effect perfectly")]
        public List<Effect> Effects018 { get; set; } = new() {
      new() { Type = EffectType.Invigorated, Duration = 15f }
};


        [Description("Custom Effect for 268 is Enabled?.")]
        public bool Better268 { get; set; } = true;

        [Description("List of Better268 effects. Attention, you must write the name and duration of the effect perfectly")]
        public List<Effect> Effects268 { get; set; } = new() {
      new() { Type = EffectType.Invigorated, Duration = 15f }
};
        [Description("Custom Effect for 207 is Enabled?.")]
        public bool Better207 { get; set; } = true;

        [Description("List of Better207 effects. Attention, you must write the name and duration of the effect perfectly")]
        public List<Effect> Effects207 { get; set; } = new() {
      new() { Type = EffectType.Invigorated, Duration = 15f }
};

    }
}
