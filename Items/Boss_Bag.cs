using Cleave.Items.Armor.Vanity;
using Cleave.Items.Pets;
using Cleave.Items.Accessories;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Items
{
    public class BossBags : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (context == "bossBag" && arg == ItemID.WallOfFleshBossBag && Main.rand.NextBool(4))
            {
                player.QuickSpawnItem(ModContent.ItemType<Thrower_Emblem>());
            }
            if (Main.rand.NextBool(20))
            {
                player.QuickSpawnItem(ModContent.ItemType<Him_Helm>());
                player.QuickSpawnItem(ModContent.ItemType<Him_Chest>());
                player.QuickSpawnItem(ModContent.ItemType<Him_Boot>());
                player.QuickSpawnItem(ModContent.ItemType<Stone_Head>());
            }
            {
                if (Main.rand.NextBool(20))
                {
                    player.QuickSpawnItem(ModContent.ItemType<Pyro_Helm>());
                    player.QuickSpawnItem(ModContent.ItemType<Pyro_Chest>());
                    player.QuickSpawnItem(ModContent.ItemType<Pyro_Boot>());
                }
            }
        }
    }
}