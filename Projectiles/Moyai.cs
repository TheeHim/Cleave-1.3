using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace Cleave.Projectiles.Images
{
    public class Moyai : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.CursedSapling);

            aiType = ProjectileID.CursedSapling;
            Main.projFrames[projectile.type] = 10;
            projectile.width = 38;
            projectile.height = 61;
            Main.projPet[projectile.type] = true;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moyai");
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.cSapling = false; // Relic from aiType
            return true;
        }
        public override void AI()
        {
            if (!ModContent.GetInstance<ClientConfig>().ShutUpPet)
            {
                if (Main.rand.NextBool(1000))
                {
                    string choice = "";
                    switch (Main.rand.Next(3))
                    {
                        case 0:
                            choice = "I am no mere stone, mortal.";
                            break;
                        case 1:
                            choice = "I could wipe you off the timeline right now and no one would notice.";
                            break;
                        case 2:
                            choice = "Hey you, behind the screen. Turn around.";
                            break;

                    }
                    Main.PlaySound(SoundLoader.customSoundType, (int)projectile.Center.X, (int)projectile.Center.Y, mod.GetSoundSlot(SoundType.Custom, "Cleave/Sounds/PetTalk/Moyai"));
                    CombatText.NewText(new Rectangle((int)projectile.Center.X, (int)projectile.Center.Y, 20, 20), new Color(0, 255, 168), choice, true);
                }
            }
        }
    }
}
