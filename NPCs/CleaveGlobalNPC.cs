using Cleave.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.NPCs
{
    public class CleaveGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.WallofFlesh && Main.rand.NextBool(4))
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Accessories.Thrower_Emblem>());
            }
        }
    }
}