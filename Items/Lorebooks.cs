using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Cleave.Items.Images
{
    public class Lorebook_Slime : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookSlime";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of King Slime and slimes");
            Tooltip.SetDefault("A book containining notes about King Slime and slimes, chronicled by lost demigod from Kiplinjar's world. " +
                "\n<right> to flip the page.");
        }
        public override void SetDefaults()
        {
            item.width = 44;
            item.height = 52;
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Slime_Page1"));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.KingSlimeTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Lorebook_Slime_Page1 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookSlime_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of King Slime and slimes: Page 1");
            Tooltip.SetDefault("<right> to flip the page." +
                "\nSlimes. Of course. They're one of the most common creatures just about any universe you're in. " +
                "\nKiplinjar, Terraria, even beyond that, they're everywhere, wreaking havoc and covering worlds in stickiness." +
                "\nThe slimes of Terraria aren't all that special, but instead the environments they inhabit are. " +
                "\nThe likes of the Corruption, Crimson and Hallow, they are all very potent places where slimes can go to gain power.");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 48;
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Slime_Page2"));
        }
    }
    public class Lorebook_Slime_Page2 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookSlime_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of King Slime and slimes: Page 2");
            Tooltip.SetDefault("<right> to close the book." +
                "\nThat's what makes the King Slime interesting. It is entirely composed of normal, blue slime. " +
                "\nPerhaps it is the ninja it managed to capture that has given it its might. " +
                "\nI need to do more research on him.");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 48;
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Slime"));
        }
    }
    public class Lorebook_Eye : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookEye";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Eye of Cthulhu");
            Tooltip.SetDefault("A book containining notes about The Eye of Cthulhu, chronicled by lost demigod from Kiplinjar's world. " +
                "\n<right> to flip the page.");
        }
        public override void SetDefaults()
        {
            item.width = 44;
            item.height = 52;
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Eye_Page1"));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.EyeofCthulhuTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Lorebook_Eye_Page1 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookEye_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Eye of Cthulhu: Page 1");
            Tooltip.SetDefault("<right> to flip the page." +
                "\nThat classic evil eye... that I hardly know anything about. " +
                "\nThis mysterious Cthulhu character has eluded my research. " +
                "\nIt seems like it exists outside of reality, yet leaves traces of itself around. " +
                "\nThe Corruption, Crimson, maybe even the Hallow likely have their roots in this entity.");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 48;
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Eye_Page2"));
        }
    }
    public class Lorebook_Eye_Page2 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookEye_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Eye of Cthulhu: Page 2");
            Tooltip.SetDefault("<right> to close the book." +
                "\nMaybe even the so-called “normal” zones of the world do. " +
                "\nHow else could the ferocity of the Jungle creatures be explained? " +
                "\nHow else could the antlions of the Desert build their great nest? " +
                "\nHow else could the Snow maintain its deep freeze? " +
                "\nThis entity is likely the sole cause for all of these strange happenings in this world. " +
                "\nMaybe even the reason that Kiplinjar was thrust into it.");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 48;
            item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Eye"));
        }
    }
    public class Lorebook_Eater : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookEater";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Eater of Worlds and the Corruption");
            Tooltip.SetDefault("A book containining notes about The Eater of Worlds and the Corruption, chronicled by lost demigod from Kiplinjar's world. " +
                "\n<right> to flip the page.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 5));
        }
        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 62;
            item.rare = ItemRarityID.Green;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Eater_Page1"));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.KingSlimeTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Lorebook_Eater_Page1 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookEater_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Eater of Worlds and the Corruption: Page 1");
            Tooltip.SetDefault("<right> to flip the page." +
                "\nAh yes, the worm. From what I can tell, that worm isn't even a worm at all. " +
                "\nIt’s just a bunch of normal Eaters that managed to eat a few souls, then linked themselves into a twisting form.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 5));
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 60;
            item.rare = ItemRarityID.Green;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Eater_Page2"));
        }
    }
    public class Lorebook_Eater_Page2 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookEater_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Eater of Worlds and the Corruption: Page 2");
            Tooltip.SetDefault("<right> to close the book." +
                "\nAs for the Corruption itself, that's something else. " +
                "\nFrom what I can tell, it’s some sort of biological material from that Cthulhu entity. " +
                "\nIt must've managed to mutate itself into that sickly purple stuff, which then spread across the lands. " +
                "\nAnything it spreads to is instantly overcome by rot, as you can tell. " +
                "\nYou're lucky to have not been caught, it’d be near unstoppable with someone like you.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 5));
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 60;
            item.rare = ItemRarityID.Green;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Eater"));
        }
    }
    public class Lorebook_Brain : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookBrain";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Brain of Cthulhu and the Crimson");
            Tooltip.SetDefault("A book containining notes about The Brain of Cthulhu and the Crimson, chronicled by lost demigod from Kiplinjar's world. " +
                "\n<right> to flip the page.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 5));
        }
        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 62;
            item.rare = ItemRarityID.Green;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Brain_Page1"));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.KingSlimeTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Lorebook_Brain_Page1 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookBrain_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Brain of Cthulhu and the Crimson: Page 1");
            Tooltip.SetDefault("<right> to flip the page." +
                "\nSo this Cthulhu character has more disembodied organs huh? " +
                "\nThat brain should've been significantly more powerful than it is, maybe it was holding back on you? " +
                "\nIt would make sense that a brain that large would be smart enough to maintain itself at least a little bit. " +
                "\nPerhaps it didn't want to be completely destroyed so it could reunite with the rest of the mass of that Crimson.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 5));
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 60;
            item.rare = ItemRarityID.Green;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Brain_Page2"));
        }
    }
    public class Lorebook_Brain_Page2 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookBrain_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Brain of Cthulhu and the Crimson: Page 2");
            Tooltip.SetDefault("<right> to close the book." +
                "\nSpeaking of which, that Crimson is a peculiar place. " +
                "\nEverything seems to be made of organs and blood, bodily tissues and fluids. " +
                "\nIf I had a stomach I would not last a second there. " +
                "\nI believe it might have started from a rogue piece of this Cthulhu’s flesh, or maybe its brain itself that came down upon this world and started converting things to flesh. " +
                "\nWho knows why, but now the Crimson is a great mighty body it is today, with unfortunate souls being taken and converted into it every day.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 5));
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 60;
            item.rare = ItemRarityID.Green;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Brain"));
        }
    }
    public class Lorebook_Bee : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookBee";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Queen Bee");
            Tooltip.SetDefault("A book containining notes about The Queen Bee, chronicled by lost demigod from Kiplinjar's world. " +
                "\n<right> to flip the page.");
        }
        public override void SetDefaults()
        {
            item.width = 44;
            item.height = 52;
            item.rare = ItemRarityID.Orange;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Bee_Page1"));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.KingSlimeTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Lorebook_Bee_Page1 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookBee_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Queen Bee: Page 1");
            Tooltip.SetDefault("<right> to flip the page." +
                "\nA bee? Really? How did your world manage to produce an insect this large? " +
                "\nPerhaps it is this mysterious Jungle... it has a power about it that's unlike anything I've ever seen.");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 48;
            item.rare = ItemRarityID.Orange;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Bee_Page2"));
        }
    }
    public class Lorebook_Bee_Page2 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookBee_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Queen Bee: Page 2");
            Tooltip.SetDefault("<right> to close the book." +
                "\nAnd another thing, there`s numerous of these `Queen Bees`. " +
                "\nI can only imagine they're a separate species from the `normal` bees around the jungle, as their physical and hive appearance are very different. " +
                "\nAnd what about that Witch Doctor that came in after? I need to research him more.");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 48;
            item.rare = ItemRarityID.Orange;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Bee"));
        }
    }
    public class Lorebook_Skele : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookSkele";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of Skeletron and the Dungeon");
            Tooltip.SetDefault("A book containining notes about Skeletron and the Dungeon, chronicled by lost demigod from Kiplinjar's world. " +
                "\n<right> to flip the page.");
        }
        public override void SetDefaults()
        {
            item.width = 44;
            item.height = 52;
            item.rare = ItemRarityID.Orange;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Skele_Page1"));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.KingSlimeTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Lorebook_Skele_Page1 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookSkele_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of Skeletron and the Dungeon: Page 1");
            Tooltip.SetDefault("<right> to flip the page." +
                "\nSkeletron is an interesting... thing. " +
                "\nSkeletron himself doesn't exist from what I can gather, what you fought is merely a manifestation of a curse laid on that Old Man. " +
                "\nQuite the strange manifestation in my opinion, a skull with bleeding arms? Anyway, that Old Man. " +
                "\nHe's been freed of the curse and is a Clothier now, but I want to know what he did to be cursed in the first place.");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 48;
            item.rare = ItemRarityID.Orange;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Skele_Page2"));
        }
    }
    public class Lorebook_Skele_Page2 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookSkele_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of Skeletron and the Dungeon: Page 2");
            Tooltip.SetDefault("<right> to close the book." +
                "\nWhat I do know, is that the Dungeon he guarded seems to be a huge burial ground for... something. " +
                "\nWith all those sorts of skeletons and spirits lurking around, it`s clear that SOMETHING must’ve happened to warrant such a large mass grave. " +
                "\nAnd that Mechanic who was stuck in there, I wonder why? Maybe she was taken there to build something?");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 48;
            item.rare = ItemRarityID.Orange;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Skele"));
        }
    }
    public class Lorebook_Flesh : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookFlesh";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Wall of Flesh");
            Tooltip.SetDefault("A book containining notes about The Wall of Flesh, chronicled by lost demigod from Kiplinjar's world. " +
                "\n<right> to flip the page.");
        }
        public override void SetDefaults()
        {
            item.width = 44;
            item.height = 52;
            item.rare = ItemRarityID.LightRed;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Flesh_Page1"));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.KingSlimeTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Lorebook_Flesh_Page1 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookFlesh_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Wall of Flesh: Page 1");
            Tooltip.SetDefault("<right> to flip the page." +
                "\nThat was gross. Why is the master and core of this world a huge pillar made out of skin? " +
                "\nHowever that works, some things definitely got kicked up once you killed it. " +
                "\nIt appeared to have been holding back a large amount of light and dark spirits, which were then released and unleashed upon the world. " +
                "\nThat seemed to mostly surge the growth of the Evil of the world, as well as unleashed the Hallow.");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 48;
            item.rare = ItemRarityID.LightRed;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Flesh_Page2"));
        }
    }
    public class Lorebook_Flesh_Page2 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookFlesh_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Wall of Flesh: Page 2");
            Tooltip.SetDefault("<right> to close the book." +
                "\nThat Hallow... a land of vivid colors and fairytale creatures, I quite like it there." +
                "\nThough I do know that you unleashing it was not good. " +
                "\nWho knows what sort of threats are lurking in there, waiting for just the right time to come out.");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 48;
            item.rare = ItemRarityID.LightRed;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Flesh"));
        }
    }
    public class Lorebook_QSlime : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookQSlime";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of Queen Slime");
            Tooltip.SetDefault("Look mom! A cheater!" +
                "\nA book containining notes about Queen Slime, chronicled by lost demigod from Kiplinjar's world." +
                "\n<right> to flip the page.");
        }
        public override void SetDefaults()
        {
            item.width = 44;
            item.height = 52;
            item.rare = ItemRarityID.LightRed;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_QSlime_Page1"));
        }
    }
    public class Lorebook_QSlime_Page1 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookQSlime_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of Queen Slime: Page 1");
            Tooltip.SetDefault("<right> to flip the page." +
                "\nOh, another big slime? This one seems to be made up of Hallow-touched slimes, very bouncy and colorful. " +
                "\nSomehow this also enabled it to grow wings, which is a bit strange. " +
                "\nIt makes sense that this one is significantly stronger than the King Slime though, as Hallowed slimes are much stronger than normal blue ones.");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 48;
            item.rare = ItemRarityID.LightRed;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_QSlime_Page2"));
        }
    }
    public class Lorebook_QSlime_Page2 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookQSlime_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of King Slime and slimes: Page 2");
            Tooltip.SetDefault("<right> to close the book." +
                "\nThough, the notable thing about the Queen Slime is its mere existence. " +
                "\nWhat other sort of `boss slimes` might exist out there? " +
                "\nAre there Emperor Slimes that were touched by the Corruption? Are there Pharaoh Slimes touched by the Desert? " +
                "\nThere really isn`t a limit to what could be achieved by these creatures, so watch your back.");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 48;
            item.rare = ItemRarityID.LightRed;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_QSlime"));
        }
    }
    public class Lorebook_Mech : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookMech";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Mechanical Bosses");
            Tooltip.SetDefault("A book containining notes about The Mechanical Bosses, chronicled by lost demigod from Kiplinjar's world. " +
                "\n<right> to flip the page.");
        }
        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 56;
            item.rare = ItemRarityID.Pink;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Mech_Page1"));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.RetinazerTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.SpazmatismTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.DestroyerTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.SkeletronPrimeTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Lorebook_Mech_Page1 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookMech_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Mechanical Bosses: Page 1");
            Tooltip.SetDefault("<right> to flip the page." +
                "\nThe robot copies of your past foes are quite mysterious. " +
                "\nIt is impossible to decipher who constructed them, especially considering you destroyed them.");
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 52;
            item.rare = ItemRarityID.Pink;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Mech_Page2"));
        }
    }
    public class Lorebook_Mech_Page2 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookMech_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Mechanical Bosses: Page 2");
            Tooltip.SetDefault("<right> to close the book." +
                "\nAnother peculiar thing are those Hallowed Bars that they drop. " +
                "\nFrom what I can tell of the wreckage, they weren't constructed of them, so why would they be filled with them? " +
                "\nI could understand if there was some form of Hallowed Ore, as then it seems the Destroyer would be designed to mine it up en masse. " +
                "\nBut that wouldn't explain why the other two would have it. Maybe you know something I don't know about them?");
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 52;
            item.rare = ItemRarityID.Pink;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Mech"));
        }
    }
    public class Lorebook_Plant : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookPlant";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of Plantera and the Jungle");
            Tooltip.SetDefault("A book containining notes about Plantera and the Jungle, chronicled by lost demigod from Kiplinjar's world. " +
                "\n<right> to flip the page.");
        }
        public override void SetDefaults()
        {
            item.width = 44;
            item.height = 52;
            item.rare = ItemRarityID.Lime;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Plant_Page1"));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.PlanteraTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Lorebook_Plant_Page1 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookPlant_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of Plantera and the Jungle: Page 1");
            Tooltip.SetDefault("<right> to flip the page." +
                "\nAh yes, the big flower... Who knows why a guardian of the jungle would take such a form, but that's what she serves as. " +
                "\nIt seems that the commotion of destroying those mechanical menaces might have stirred something in the Jungle, causing Plantera to go on the prowl.");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 48;
            item.rare = ItemRarityID.Lime;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Plant_Page2"));
        }
    }
    public class Lorebook_Plant_Page2 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookPlant_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of Plantera and the Jungle: Page 2");
            Tooltip.SetDefault("<right> to close the book." +
                "\nIt makes sense why she exists though. The Jungle contains a large amount of energy for no discernible reason. " +
                "\nIf it were to be harnessed or destroyed for any reason, it would certainly be bad news. " +
                "\nThat must be why she became enraged when you broke one of her bulbs.");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 48;
            item.rare = ItemRarityID.Lime;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Plant"));
        }
    }
    public class Lorebook_Golem : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookGolem";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of Golem and the Lihzahrds");
            Tooltip.SetDefault("A book containining notes about Golem and the Lihzahrds, chronicled by lost demigod from Kiplinjar's world. " +
                "\n<right> to flip the page.");
        }
        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 56;
            item.rare = ItemRarityID.Yellow;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Golem_Page1"));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.GolemTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Lorebook_Golem_Page1 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookGolem_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of Golem and the Lihzahrds: Page 1");
            Tooltip.SetDefault("<right> to flip the page." +
                "\nThe Lihzahrds are one of the most interesting species in your world." +
                "\nThey remind me of the Kipils, seeming like cavemen on the outside, but in reality being able to do things that are above human’s capabilities." +
                "\nThough, the main difference is that the Lihzahrds draw their power from the sun, rather than me.");
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 52;
            item.rare = ItemRarityID.Yellow;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Golem_Page2"));
        }
    }
    public class Lorebook_Golem_Page2 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookGolem_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of Golem and the Lihzahrds: Page 2");
            Tooltip.SetDefault("<right> to close the book." +
                "\nThey seem to have used some sort of sunlight manipulator or something to that effect to create their famous near-indestructible bricks that compose their temple. " +
                "\nThat’s what their idol, Golem, is made out of, though its mechanical parts took up most of its structure, limiting its defenses. " +
                "\nThey also seem to be able to conjure solar powers using the same bricks, though that seems to serve a different purpose." +
                "\nMaybe you've seen the effects that their dark sun has on the world?");
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 52;
            item.rare = ItemRarityID.Yellow;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Golem"));
        }
    }
    public class Lorebook_Light : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookLight";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Empress of Light");
            Tooltip.SetDefault("Look mom! A cheater!" +
                "\nA book containining notes about The Empress of Light, chronicled by lost demigod from Kiplinjar's world. " +
                "\n<right> to flip the page.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 6));
        }
        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 56;
            item.rare = ItemRarityID.Yellow;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Light_Page1"));
        }
    }
    public class Lorebook_Light_Page1 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookLight_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Empress of Light: Page 1");
            Tooltip.SetDefault("<right> to flip the page." +
                "\nThe Empress of Light, I like her. " +
                "\nShe seems to command the Hallow, similar to the way the Eater of Worlds commanded the Corruption. " +
                "\nMy only guess for her motives to attack you is your killing of that innocent butterfly.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 6));
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 52;
            item.rare = ItemRarityID.Yellow;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Light_Page2"));
        }
    }
    public class Lorebook_Light_Page2 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookLight_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Empress of Light: Page 2");
            Tooltip.SetDefault("<right> to close the book." +
                "\nIt seems she also generally saw you as impure, seeing as how the creatures of the Hallow attacked you well before you attacked any of them. " +
                "\nPerhaps the Empress has a skewed vision of purity and impurity. " +
                "\nEither way, it’s for the better that you dealt with her. The Hallow is a dangerous place and it is good that it is now contained.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 6));
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 52;
            item.rare = ItemRarityID.Yellow;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Light"));
        }
    }
    public class Lorebook_Duke : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookDuke";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of Duke Fishron");
            Tooltip.SetDefault("A book containining notes about Duke Fishron, chronicled by lost demigod from Kiplinjar's world. " +
                "\n<right> to flip the page.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 5));
        }
        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 62;
            item.rare = ItemRarityID.Yellow;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Duke_Page1"));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.DukeFishronTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Lorebook_Duke_Page1 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookDuke_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of Duke Fishron: Page 1");
            Tooltip.SetDefault("<right> to flip the page." +
                "\nThe mutant terror of the sea. I perhaps know the least about that Duke. " +
                "\nFirstly, starting with the Pigrons of the Ice biome, I believe that they may have sprung up due to the spirits of light and dark. " +
                "\nUpon release, they began imbuing themselves in common pigs, causing them to mutate and become what they are.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 5));
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 60;
            item.rare = ItemRarityID.Yellow;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Duke_Page2"));
        }
    }
    public class Lorebook_Duke_Page2 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookDuke_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of Duke Fishron: Page 2");
            Tooltip.SetDefault("<right> to close the book." +
                "\nOf course, this could be wrong, but I do have a different solution. " +
                "\nThe Fishron may be the actual predecessor to the Pigron, and they likely all lived in an ocean at one point. " +
                "\nHowever, whatever thrust the Snow biome into the deep freeze it’s in today could've trapped them underground, which could've led to their adaptations out of their fishy traits.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 5));
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 60;
            item.rare = ItemRarityID.Yellow;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Duke"));
        }
    }
    public class Lorebook_Cult : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookCult";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Lunatic Cultist and the Cultists");
            Tooltip.SetDefault("A book containining notes about The Lunatic Cultist and the Cultists, chronicled by lost demigod from Kiplinjar's world. " +
                "\n<right> to flip the page.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 8));
        }
        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 56;
            item.rare = ItemRarityID.Cyan;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Cult_Page1"));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.AncientCultistTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Lorebook_Cult_Page1 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookCult_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Lunatic Cultist and the Cultists: Page 1");
            Tooltip.SetDefault("<right> to flip the page." +
                "\nThe cultists of the Dungeon are a peculiar folk. " +
                "\nWhile they appeared to be trying to summon the Moon Lord, I have reason to believe they were trying to do the opposite. " +
                "\nYou see, I believe they knew that the Moon Lord would stand no chance against you, so I believe they were trying to permanently seal him on the moon.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 8));
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 52;
            item.rare = ItemRarityID.Cyan;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Cult_Page2"));
        }
    }
    public class Lorebook_Cult_Page2 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookCult_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Lunatic Cultist and the Cultists: Page 2");
            Tooltip.SetDefault("<right> to close the book." +
                "\nAnd in terms of the Lunatic, I think that's just an unfortunate name they acquired. " +
                "\nFrom what I know about them, they aren't actually even crazy at all. They just didn't want you killing their lord. " +
                "\nAlso, I have a loose feeling that I know who the lunatic is, but I don't have enough evidence for it.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 8));
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 52;
            item.rare = ItemRarityID.Cyan;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Cult"));
        }
    }
    public class Lorebook_Moon : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookMoon";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Moon Lord and the Lunar Pillars");
            Tooltip.SetDefault("A book containining notes about The Moon Lord and the Lunar Pillars, chronicled by lost demigod from Kiplinjar's world. " +
                "\n<right> to flip the page.");
        }
        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 56;
            item.rare = ItemRarityID.Red;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Moon_Page1"));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddIngredient(ItemID.MoonLordTrophy);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Lorebook_Moon_Page1 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookMoon_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Moon Lord and the Lunar Pillars: Page 1");
            Tooltip.SetDefault("<right> to flip the page." +
                "\nThe Lord of the Moon himself. You managed to slay him. I'd say good work, but you likely caused more problems than solved. " +
                "\nBut before that, the Pillars of the Moon. Each holding a different power, I believe they served as an extra layer of protection for the Lord. " +
                "\nTheir influence alone likely caused a bit of problems, and I strongly beleive you'll be seeing one issue that arose soon.");
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 52;
            item.rare = ItemRarityID.Red;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Moon_Page2"));
        }
    }
    public class Lorebook_Moon_Page2 : ModItem
    {
        public override string Texture => "Cleave/Items/Images/BookMoon_Open";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lore of The Moon Lord and the Lunar Pillars: Page 2");
            Tooltip.SetDefault("<right> to close the book." +
                "\nBut the Moon Lord was the real issue. " +
                "\nSure, on his own he was a threat, but his destruction doesn't come close to what you got the attention of by killing him. " +
                "\nEven I didn't realise you existed until you killed him. Who knows what else will come for you after me.");
        }
        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 52;
            item.rare = ItemRarityID.Red;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("Lorebook_Moon"));
        }
    }
}