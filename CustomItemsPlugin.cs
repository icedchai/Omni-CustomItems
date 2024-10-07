using Exiled.API.Features;
using Exiled.CustomItems.API;
using Exiled.CustomItems.API.Features;
using MEC;
using Omni_Customitems.Items;

namespace Omni_Customitems
{
    public class CustomItemsPlugin : Plugin<Config>
    {
        public static CustomItemsPlugin pluginInstance;

        public override string Name => "Omni-2 Custom Items";

        public override string Author => "icedchqi";

        public override string Prefix => "omni-customitems";

        public override Version Version => new(1, 0, 0);
        public override void OnEnabled()
        {
            pluginInstance = this;
            Timing.CallDelayed(6f, () =>  CustomItem.RegisterItems());
        }

        public override void OnDisabled()
        {
            CustomItem.UnregisterItems();
        }

    }
}