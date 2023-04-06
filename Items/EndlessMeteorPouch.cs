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
	public class EndlessMeteorPouch : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Endless Meteor Pouch");
		}

		public override void SetDefaults()
		{
			Item.shootSpeed = 3f;
			Item.shoot = 36;
			Item.damage = 9;
			Item.width = 26;
			Item.height = 34;
			Item.ammo = AmmoID.Bullet;
			Item.knockBack = 1f;
			Item.value = Item.sellPrice(0, 2, 0, 0);
			Item.rare = 1;
			Item.DamageType = DamageClass.Ranged;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.MeteoriteBar, 20);
			recipe.AddIngredient(ItemID.EndlessMusketPouch);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
