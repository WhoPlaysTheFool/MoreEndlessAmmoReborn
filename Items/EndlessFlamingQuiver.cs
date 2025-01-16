using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreEndlessAmmoReborn.Items
{
	public class EndlessFlamingQuiver : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Endless Flaming Quiver");
		}

		public override void SetDefaults()
		{
			Item.shootSpeed = 5f;
			Item.shoot = 2;
			Item.damage = 7;
			Item.width = 26;
			Item.height = 26;
			Item.ammo = AmmoID.Arrow;
			Item.knockBack = 2f;
			Item.value = Item.sellPrice(0, 2, 0, 0);
			Item.DamageType = DamageClass.Ranged;
			Item.rare = 7;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.EndlessQuiver, 1);
			recipe.AddIngredient(ItemID.MagmaStone, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
