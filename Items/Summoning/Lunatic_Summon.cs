using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Items.Summoning
{
	public class Lunatic_Summon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cultist Voodoo Doll");
			Tooltip.SetDefault("It makes a squeaky sound when you squeeze it. What if you totally pop it? \nBe aware of those Pillars!");
			ItemID.Sets.SortingPriorityBossSpawns[item.type] = 12;
		}

		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 50;
			item.maxStack = 20;
			item.rare = ItemRarityID.Cyan;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.consumable = true;
		}

		public override bool CanUseItem(Player player)
		{
			return Main.hardMode && NPC.downedAncientCultist;
		}

		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.CultistBoss);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}