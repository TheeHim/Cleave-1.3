using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Items.Summoning
{
	public class Golem_Summon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lihzahrd Doll");
			Tooltip.SetDefault("Impossible to be charged with Voodoo due to the Lihzahrd ways, but will still surely attract attention if treated poorly.\nOnly works in the temple.");
			ItemID.Sets.SortingPriorityBossSpawns[item.type] = 12;
		}

		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 34;
			item.maxStack = 20;
			item.rare = ItemRarityID.Yellow;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.consumable = true;
		}

		public override bool CanUseItem(Player player)
		{
			return Main.hardMode && NPC.downedGolemBoss;
		}

		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.Golem);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}