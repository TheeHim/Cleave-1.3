using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Items.Pets
{
    public class Stone_Head : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.CursedSapling);

            item.width = 12;
            item.height = 16;
            item.useTime = 25;
            item.useAnimation = 25;

            item.shoot = mod.ProjectileType("Moyai");
            item.buffType = mod.BuffType("Moyai");
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Head");
            Tooltip.SetDefault("A weird looking head made of stone. \nSummons a Moyai.");
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}
