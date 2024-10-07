using Exiled.API.Extensions;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Features;
using InventorySystem.Items.Firearms.Attachments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace Omni_Customitems.Items
{

    public abstract class AirsoftGun : CustomWeapon
    {

        public override uint Id { get; set; }
        [YamlIgnore]
        public override float Damage { get; set; } = 0f;

        protected override void SubscribeEvents()
        {
            Exiled.Events.Handlers.Player.UnloadingWeapon += new CustomEventHandler<UnloadingWeaponEventArgs>(OnUnload);
            base.SubscribeEvents();
        }

        protected override void UnsubscribeEvents()
        {
            Exiled.Events.Handlers.Player.UnloadingWeapon -= new CustomEventHandler<UnloadingWeaponEventArgs>(OnUnload);
            base.UnsubscribeEvents();
        }
        protected void OnUnload(UnloadingWeaponEventArgs ev)
        {
            if (Check(ev.Player.CurrentItem))
            {
                ev.IsAllowed = false;
            }

        }
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override bool ShouldMessageOnGban { get; } = true;
        public override float Weight { get; set; }
        public override SpawnProperties? SpawnProperties {get; set;}
        protected override void OnHurting(HurtingEventArgs ev)
        {
            if (Check(ev.Attacker.CurrentItem))
            {
                ev.IsAllowed = false;
            }
            if (ev.Attacker.Role.Team==ev.Player.Role.Team)
            {
                ev.IsAllowed = false;
            }

        }
        protected override void OnShooting(ShootingEventArgs ev)
        {
            if(Check(ev.Player.CurrentItem))
            {
                ev.Firearm.Ammo = ev.Firearm.MaxAmmo;
            }

        }
        protected override void OnReloading(ReloadingWeaponEventArgs ev)
        {
            if (Check(ev.Player.CurrentItem))
            {
                ev.IsAllowed = false;
            }
        }
    }
}
