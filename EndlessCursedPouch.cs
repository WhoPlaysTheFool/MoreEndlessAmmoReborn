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
	public class EndlessCursedPouch : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Endless Cursed Pouch");
		}

		public override void SetDefaults()
		{
			Item.shootSpeed = 5f;
			Item.shoot = 104;
			Item.damage = 12;
			Item.width = 26;
			Item.height = 34;
			Item.ammo = AmmoID.Bullet;
			Item.knockBack = 4f;
			Item.value = Item.sellPrice(0, 2, 0, 0);
			Item.rare = 1;
			Item.DamageType = DamageClass.Ranged;
			Item.rare = 3;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.CursedFlame, 20);
			recipe.AddIngredient(ItemID.EndlessMusketPouch);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
