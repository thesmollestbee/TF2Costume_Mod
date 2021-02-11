using TF2Costumes.Items.Armor;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TF2Costumes.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class MannTreads : ModItem
        {
            public override void SetStaticDefaults() {
            base.SetStaticDefaults();
            DisplayName.SetDefault("MannTreads");
            Tooltip.SetDefault("This American boot just kicked your ass back to Russia!");
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