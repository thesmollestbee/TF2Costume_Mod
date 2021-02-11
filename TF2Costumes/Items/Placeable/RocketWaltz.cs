using Terraria.ModLoader;
using Terraria.ID;

namespace TF2Costumes.Items.Placeable
{
	public class RocketWaltz : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rocket Jump Waltz");
		}

		public override void SetDefaults() {
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.RocketWaltz>();
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Red;
			item.value = 1000000;
			item.accessory = true;
		}
		public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}