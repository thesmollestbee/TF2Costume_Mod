using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TF2Costumes.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class SoldierBody : ModItem
        {
            public override void SetStaticDefaults() {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Soldier's Shirt");
            Tooltip.SetDefault("If fighting is sure to result in victory, then you must fight!");
            }

            public override void SetDefaults() {
            item.width = 18;
            item.height = 18;
            item.value = 100;
            item.rare = ItemRarityID.Red;
            item.defense = 0;
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