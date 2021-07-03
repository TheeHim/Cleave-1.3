using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace Cleave
{
    public class Cleave : Mod
	{
		public override void PostSetupContent()
		{
			Mod censusMod = ModLoader.GetMod("Census");
			if (censusMod != null)
			{
				censusMod.Call("TownNPCCondition", NPCType("Kipil Wizard"), "Defeat the King Slime");
			}
		}
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => "Any Lunar Fragment", new int[]
			{
		ItemID.FragmentSolar,
		ItemID.FragmentVortex,
		ItemID.FragmentNebula,
		ItemID.FragmentStardust
			});
			RecipeGroup.RegisterGroup("Cleave:LFragments", group);
			group = new RecipeGroup(() => "Any Tier 1 Gem", new int[]
			{
		ItemID.Amethyst,
		ItemID.Topaz
			});
			RecipeGroup.RegisterGroup("Cleave:Gem1", group);
			group = new RecipeGroup(() => "Any Tier 2 Gem", new int[]
			{
		ItemID.Sapphire,
		ItemID.Emerald
			});
			RecipeGroup.RegisterGroup("Cleave:Gem2", group);
			group = new RecipeGroup(() => "Any Tier 3 Gem", new int[]
			{
		ItemID.Ruby,
		ItemID.Diamond
			});
			RecipeGroup.RegisterGroup("Cleave:Gem3", group);
			group = new RecipeGroup(() => "Any Evil Bar", new int[]
			{
		ItemID.DemoniteBar,
		ItemID.CrimtaneBar
			});
			RecipeGroup.RegisterGroup("Cleave:EvilBar", group);
			group = new RecipeGroup(() => "Any Evil Flesh", new int[]
			{
		ItemID.ShadowScale,
		ItemID.TissueSample
			});
			RecipeGroup.RegisterGroup("Cleave:EvilFlesh", group);
			group = new RecipeGroup(() => "Any Tier 3 Hardmode Bar", new int[]
			{
		ItemID.AdamantiteBar,
		ItemID.TitaniumBar
			});
			RecipeGroup.RegisterGroup("Cleave:Tier3HMBar", group);
			group = new RecipeGroup(() => "Any Tier 3 Bar", new int[]
			{
		ItemID.GoldBar,
		ItemID.PlatinumBar
			});
			RecipeGroup.RegisterGroup("Cleave:Tier3Bar", group);
			group = new RecipeGroup(() => "Any Evil Magic", new int[]
			{
		ItemID.CursedFlame,
		ItemID.Ichor
			});
			RecipeGroup.RegisterGroup("Cleave:EvilJuice", group);
			group = new RecipeGroup(() => "Any Ocean Fish", new int[]
			{
		ItemID.RedSnapper,
		ItemID.Shrimp,
		ItemID.Trout,
		ItemID.Tuna
			});
			RecipeGroup.RegisterGroup("Cleave:SaltFish", group);
			group = new RecipeGroup(() => "Any Evil Fish", new int[]
			{
		ItemID.Hemopiranha,
		ItemID.CrimsonTigerfish,
		ItemID.Ebonkoi
			});
			RecipeGroup.RegisterGroup("Cleave:EvilFish", group);
			group = new RecipeGroup(() => "Any Alcohol", new int[]
			{
		ItemID.Sake,
		ItemID.Ale
			});
			RecipeGroup.RegisterGroup("Cleave:ALCOHOL", group);
			group = new RecipeGroup(() => "Any Travelling Merchant Food", new int[]
			{
		ItemID.PadThai,
		ItemID.Pho
			});
			RecipeGroup.RegisterGroup("Cleave:GourmetFood", group);
		}
	}
}