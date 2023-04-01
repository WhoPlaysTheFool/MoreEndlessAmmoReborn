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
	public class EndlessLuminitePouch : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Endless Luminite Pouch");
		}

		public override void SetDefaults()
		{
			Item.shootSpeed = 2f;
			Item.shoot = 638;
			Item.damage = 20;
			Item.width = 26;
			Item.height = 34;
			Item.ammo = AmmoID.Bullet;
			Item.knockBack = 3f;
			Item.value = Item.sellPrice(0, 2, 0, 0);
			Item.DamageType = DamageClass.Ranged;
			Item.rare = 9;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.MoonlordBullet, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.Register();
		}
	}
}
