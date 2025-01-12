using Exiled.API;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using Exiled.Events.Commands.PluginManager;
using Exiled.Events.EventArgs.Player;
using System.Collections.Generic;
using System.Linq;

namespace BetterItemSCP
{
    public class EventHandler
    {
        private readonly BetterItemSCP plugin;
        public void OnUsingItem(UsingItemCompletedEventArgs ev)
        {
            if (ev.Item.Type == ItemType.SCP500)

                if (plugin.Config.IsEnabled)
                {
                    bool Effects500 = plugin.Config.IsEnabled;

                }
            if (ev.Item.Type == ItemType.SCP1853)
            
                if (plugin.Config.IsEnabled)
                {
                    bool Effects1853 = plugin.Config.IsEnabled;
                }

            if (ev.Item.Type == ItemType.SCP018)

                if (plugin.Config.IsEnabled)
                {
                    bool Effects018 = plugin.Config.IsEnabled;
                }
            
            if (ev.Item.Type == ItemType.SCP268)

                if (plugin.Config.IsEnabled)
                {
                    bool Effects268 = plugin.Config.IsEnabled;
                }

            if (ev.Item.Type == ItemType.SCP207)

                if (plugin.Config.IsEnabled)
                {
                    bool Effects207 = plugin.Config.IsEnabled;
                }
        }

    }
}
