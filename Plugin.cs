using System;
using Exiled.API.Features;
using Exiled.Events;

namespace BetterItemSCP
{
    public class BetterItemSCP : Plugin<Config>
    {
        private EventHandler _eventHandler;

        public override string Name => "BetterItemSCP";
        public override string Author => "moncef50g";
        public override string Prefix => "BetterItemSCP";
        public override Version RequiredExiledVersion => new Version(8, 9, 11);

        public static BetterItemSCP Instance;
        public override void OnEnabled()
        {
            _eventHandler = new EventHandler();
            Exiled.Events.Handlers.Player.UsingItemCompleted += _eventHandler.OnUsingItem;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.UsingItemCompleted -= _eventHandler.OnUsingItem;
            _eventHandler = null;
            base.OnDisabled();
        }
    }
}
