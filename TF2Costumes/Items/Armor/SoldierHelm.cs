using TF2Costumes.Items.Armor;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TF2Costumes.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class SoldierHelm : ModItem
        {
            
            public override void SetStaticDefaults() {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Soldier's Helmet");
            Tooltip.SetDefault("This is a bucket!");
            }

            public override void SetDefaults() {
            item.width = 16;
            item.height = 16;
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