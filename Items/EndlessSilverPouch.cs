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
	public class EndlessSilverPouch : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Endless Silver Pouch");
		}

		public override void SetDefaults()
		{
			Item.shootSpeed = 4.5f;
			Item.shoot = 981;
			Item.damage = 9;
			Item.width = 26;
			Item.height = 34;
			Item.ammo = AmmoID.Bullet;
			Item.knockBack = 3f;
			Item.value = Item.sellPrice(0, 2, 0, 0);
			Item.DamageType = DamageClass.Ranged;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverBar, 20);
			recipe.AddIngredient(ItemID.EndlessMusketPouch);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
