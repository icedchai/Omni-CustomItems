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
    [CustomItem(ItemType.GunE11SR)]
    public class AirsoftE11 : AirsoftGun
    {
        [YamlIgnore]
        public override AttachmentName[] Attachments { get; set; } = new[]
{
        AttachmentName.SoundSuppressor,
        AttachmentName.Flashlight,
    };
        public override byte ClipSize { get; set; } = 100;
        public override uint Id { get; set; } = CustomItemsPlugin.pluginInstance.Config.IDPrefix+01;
        public override string Name { get; set; } = "Epsilon-11 Standard Rifle airsoft replica";
        public override string Description { get; set; } = "This airsoft replica was created by the Foundation for training & entertainment.";
    }
}
