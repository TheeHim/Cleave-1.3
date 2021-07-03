using Terraria;
using Terraria.ModLoader;
using Cleave.Items.Images;

namespace Cleave.Items
{
    public class BossBags : GlobalItem
    {
        public override void OpenVanillaBag(string bossBag, Player player, int arg)
        {
            if (Main.rand.NextBool(20))
            {
                player.QuickSpawnItem(ModContent.ItemType<Him_Helm>());
                player.QuickSpawnItem(ModContent.ItemType<Him_Chest>());
                player.QuickSpawnItem(ModContent.ItemType<Him_Boot>());
                player.QuickSpawnItem(ModContent.ItemType<Stone_Head>());
                player.QuickSpawnItem(ModContent.ItemType<Him_Wings>());
            }
            {
                if (Main.rand.NextBool(20))
                {
                    player.QuickSpawnItem(ModContent.ItemType<Pyro_Helm>());
                    player.QuickSpawnItem(ModContent.ItemType<Pyro_Chest>());
                    player.QuickSpawnItem(ModContent.ItemType<Pyro_Boot>());
                }
            }
            if (Main.rand.NextBool(3))
            {
                player.QuickSpawnItem(ModContent.ItemType<Bossmatter>(), 1 + Main.rand.Next(3));
            }
        }
    }
}