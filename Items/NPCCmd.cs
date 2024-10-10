using CommandSystem;
using Exiled.API.Features;

namespace Omni_Customitems.Items
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class NPCCmd : ICommand
    {
        public string Command { get; } = "npc";

        public string[] Aliases { get; } = new[] { "dummy" };

        public string Description { get; } = "Spawn NPC";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = Player.Get(sender);
            Npc npc = Npc.Spawn("NPC", PlayerRoles.RoleTypeId.Tutorial, 0, "ID_Dedicated", player.Position);
            response = "spawned npc";
            return true;
        }
    }
}
