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
	public class EndlessVenomQuiver : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Endless Venom Quiver");
		}

		public override void SetDefaults()
		{
			Item.shootSpeed = 5f;
			Item.shoot = 282;
			Item.damage = 19;
			Item.width = 26;
			Item.height = 26;
			Item.ammo = AmmoID.Arrow;
			Item.knockBack = 4.5f;
			Item.value = Item.sellPrice(0, 2, 0, 0);
			Item.DamageType = DamageClass.Ranged;
			Item.rare = 7;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.EndlessQuiver, 1);
			recipe.AddIngredient(ItemID.VialofVenom, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
