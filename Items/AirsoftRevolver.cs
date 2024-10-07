using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs.Player;
using InventorySystem.Items.Firearms.Attachments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace Omni_Customitems.Items
{
    [CustomItem(ItemType.GunRevolver)]
    public class AirsoftRevolver : AirsoftGun
    {
        [YamlIgnore]
        public override AttachmentName[] Attachments { get; set; } = new[]
{
        AttachmentName.CylinderMag6,
    };
        public override byte ClipSize { get; set; } = 6;
        public override uint Id { get; set; } = CustomItemsPlugin.pluginInstance.Config.IDPrefix+03;
        public override string Name { get; set; } = "CO2 Airsoft Revolver";
        public override float Damage { get; set; } = 3;
        public override string Description { get; set; } = "This airsoft replica of a .44 Smith & Wesson packs quite the punch, using CO2 to propel its plastic BBs.";
        protected override void OnReloading(ReloadingWeaponEventArgs ev)
        {
            if (Check(ev.Player.CurrentItem))
            {
                ev.IsAllowed = true;
            }
        }
    }
}
