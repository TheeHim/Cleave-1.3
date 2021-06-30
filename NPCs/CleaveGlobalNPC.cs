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
            if (npc.type == NPCID.Worm)
            {
                if (Main.rand.NextFloat() < .01f)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("Moon_Scarf"));
                }
            }
            if (npc.type == NPCID.GoldWorm)
            {
                if (Main.rand.NextFloat() < .1f)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("Moon_Scarf"));
                }
            }
            if (npc.type == NPCID.GiantWormHead)
            {
                if (Main.rand.NextFloat(0) < .01f)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("Moon_Scarf"));
                }
            }
            if (npc.type == NPCID.DiggerHead)
            {
                if (Main.rand.NextFloat(0) < .05f)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("Moon_Scarf"));
                }
            }
            if (npc.boss == true)
            {
                if (Main.rand.NextBool(5))
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("Boss_Matter"), 1 + Main.rand.Next(2));
                }
            }
        }
    }
}