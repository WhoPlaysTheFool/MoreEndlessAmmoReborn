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
	public class EndlessGoldenPouch : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Endless Golden Pouch");
		}

		public override void SetDefaults()
		{
			Item.shootSpeed = 4.6f;
			Item.shoot = 287;
			Item.damage = 10;
			Item.width = 26;
			Item.height = 34;
			Item.ammo = AmmoID.Bullet;
			Item.knockBack = 3.6f;
			Item.value = Item.sellPrice(0, 2, 0, 0);
			Item.DamageType = DamageClass.Ranged;
			Item.rare = 3;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GoldenBullet, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.Register();
		}
	}
}
