using Terraria;
using Terraria.ModLoader;

namespace Cleave.Buffs.Images
{
    public class BBGrip : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Beryllium Bronze Grip");
            Description.SetDefault("High five! Fist bump! Skull crush!");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.ownedProjectileCounts[ModContent.ProjectileType<Projectiles.Images.BBGrip>()] > 0)
            {
                player.buffTime[buffIndex] = 18000;
            }
            else
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
        }
    }
}