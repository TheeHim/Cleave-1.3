using System;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Items.Images
{
    public class Astral_Baton : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astral Bladed Baton");
            Tooltip.SetDefault("An astral baton with a blade on each end.\nSpins faster and faster before launching a devastating astral wave.");
        }
        public override void SetDefaults()
        {
            item.damage = 140;
            item.melee = true;
            item.width = 50;
            item.height = 50;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 100;
            item.rare = ItemRarityID.Cyan;
            item.UseSound = SoundID.Item7;
            item.value = Item.sellPrice(0, 10);
            item.autoReuse = true;
            item.useTurn = false;
            item.channel = true;
            item.knockBack = 3f;
            item.shoot = mod.ProjectileType("Astral_Baton");
            item.shootSpeed = 1f;
            item.noMelee = true;
            item.noUseGraphic = true;

        }
        public override bool UseItemFrame(Player player)
        {
            player.bodyFrame.Y = 3 * player.bodyFrame.Height;
            return true;
        }
    }
    public class Astral_Starcannon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astral Star Cannon");
            Tooltip.SetDefault("A blaster that fires mines that linger in place. \nWhen they explode, they fire out a blast of bolts. If there's an enemy nearby, the bolts will aim at it.");
        }
        public override void SetDefaults()
        {
            item.damage = 400;
            item.ranged = true;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.shootSpeed = 20f;
            item.width = 50;
            item.height = 32;
            item.useTime = 30;
            item.useAnimation = 30;
            item.reuseDelay = 20;
            item.knockBack = 4;
            item.shoot = mod.ProjectileType("Astral_Mine");
            item.value = Item.sellPrice(0, 10);
            item.useTurn = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item117;
            item.rare = ItemRarityID.Cyan;
            item.useAmmo = AmmoID.FallenStar;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-20, -9);
        }
    }
    public class Astral_Knowledge : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astral Knowledge");
            Tooltip.SetDefault("An intricate guide on how to channel astral magic. You have no idea who inscribed this, though there are pink hairs are embedded in the stone.\nHold down left click to charge up an astral star.");
        }
        public override void SetDefaults()
        {
            item.useStyle = 100;
            item.useAnimation = 20;
            item.useTime = 20;
            item.shootSpeed = 0f;
            item.knockBack = 2f;
            item.width = 38;
            item.height = 50;
            item.damage = 130;
            item.UseSound = SoundID.Item8;
            item.shoot = mod.ProjectileType("Astral_Knowledge");
            item.rare = ItemRarityID.Cyan;
            item.value = Item.sellPrice(0, 10);
            item.noMelee = true;
            item.noUseGraphic = true;
            item.magic = true;
            item.channel = true;
            item.autoReuse = false;
        }
        public override bool UseItemFrame(Player player)
        {
            player.bodyFrame.Y = 1 * player.bodyFrame.Height;
            return true;
        }
    }
    public class Astral_Brush : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astral Brush");
            Tooltip.SetDefault("A starry brush that paints blotches of astral goop that linger for a while.\nThe amount of blotches you can paint is equal to your sentry capacity. Holding the weapon grants three extra slots.");
        }
        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 27;
            item.useTime = 27;
            item.shootSpeed = 15f;
            item.knockBack = 7f;
            item.width = 28;
            item.height = 28;
            item.UseSound = SoundID.NPCDeath21;
            item.shoot = mod.ProjectileType("Astral_Blot");
            item.rare = ItemRarityID.Cyan;
            item.value = Item.sellPrice(0, 10);
            item.noMelee = true;
            item.noUseGraphic = false;
            item.autoReuse = true;
            item.summon = true;
            item.damage = 15;
        }
        public override void HoldItem(Player player)
        {
            player.maxTurrets += 3;
        }
    }
}