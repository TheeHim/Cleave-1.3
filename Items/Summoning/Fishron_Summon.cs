using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Items.Summoning
{
	public class Fishron_Summon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fungal Morsel");
			Tooltip.SetDefault("While the worm needed to be dipped under the water, the compressed fungal power of this can attract sea mutants from any depth.");
			ItemID.Sets.SortingPriorityBossSpawns[item.type] = 12;
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 38;
			item.maxStack = 20;
			item.rare = ItemRarityID.Yellow;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.consumable = true;
		}

		public override bool CanUseItem(Player player)
		{
			return Main.hardMode && NPC.downedFishron;
		}

		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DukeFishron);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}