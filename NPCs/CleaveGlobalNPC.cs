using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.NPCs
{
    public class CleaveGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public override void NPCLoot(NPC npc)
        {
            #region Astral Weapons
            if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneSkyHeight && NPC.downedAncientCultist && !NPC.downedMoonlord && Main.rand.Next(30) < 1)
            {
                switch (Main.rand.Next(4))
                {
                    case 0:
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Astral_Baton"));
                        break;
                    case 1:
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Astral_Starcannon"));
                        break;
                    case 2:
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Astral_Knowledge"));
                        break;
                    case 3:
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Astral_Brush"));
                        break;
                }
            }
            if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneSkyHeight && NPC.downedMoonlord && (Main.rand.Next(50) < 1))
            {
                switch (Main.rand.Next(4))
                {
                    case 0:
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Astral_Baton"));
                        break;
                    case 1:
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Astral_Starcannon"));
                        break;
                    case 2:
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Astral_Knowledge"));
                        break;
                    case 3:
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Astral_Brush"));
                        break;
                }
            }
            #endregion
            #region Worm
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
            #endregion
            if (npc.boss == true)
            {
                if (Main.rand.NextBool(5))
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("Boss_Matter"), 1 + Main.rand.Next(2));
                }
            }
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Demolitionist:
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("Mystic_Stone"));
                        nextSlot++;
                    }
                    break;
            }
            switch (type)
            {
                case NPCID.Painter:
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("Magic_Canvas"));
                        nextSlot++;
                    }
                    break;
            }
        }
    }
}