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
	public class BUNNYBUNNYBUNNY : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Mysterious Hat");
		}

		public override void SetDefaults()
		{
			Item.shootSpeed = 20.0f;
			Item.shoot = 281;
			Item.damage = 350;
			Item.width = 26;
			Item.height = 34;
			Item.ammo = AmmoID.Bullet;
			Item.knockBack = 4.1f;
			Item.value = Item.sellPrice(0, 0, 69, 0);
			Item.DamageType = DamageClass.Ranged;
			Item.rare = 7;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.ExplosiveBunny, 100);
			recipe.AddIngredient(ItemID.GoldBunny, 1);
			recipe.AddIngredient(ItemID.PlatinumCoin, 420);
			recipe.AddIngredient(ItemID.MoonLordTrophy, 1);
			recipe.AddIngredient(ItemID.TopHat, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
}
