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
    [CustomItem(ItemType.GunCOM18)]
    public class AirsoftCOM18 : AirsoftGun
    {
        [YamlIgnore]
        public override AttachmentName[] Attachments { get; set; } = new[]
{
        AttachmentName.SoundSuppressor,
        AttachmentName.Flashlight,
    };
        public override byte ClipSize { get; set; } = 30;
        public override uint Id { get; set; } = CustomItemsPlugin.pluginInstance.Config.IDPrefix+02;
        public override string Name { get; set; } = "COM-18 airsoft replica";
        public override string Description { get; set; } = "Nobody knows who manufactured this gas-blowback replica of the Foundation Gunworks' COM-18";
    }
}
