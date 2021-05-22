using Terraria;
using Terraria.ModLoader;

namespace Cleave.Buffs
{
    public class Moyai : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Moyai");
            Description.SetDefault("Holds an untold power.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            CleavePlayer modPlayer = (CleavePlayer)player.GetModPlayer(mod, "CleavePlayer");
            modPlayer.Moyai = true;
            bool petProjectileNotSpawned = true;
            if (player.ownedProjectileCounts[mod.ProjectileType("Moyai")] > 0)
            {
                petProjectileNotSpawned = false;
            }
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + player.width / 2, player.position.Y + player.height / 2, 0f, 0f, mod.ProjectileType("Moyai"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}