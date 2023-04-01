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
	public class EndlessGelGlob : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Endless Gel Glob");
		}

		public override void SetDefaults()
		{
			Item.shootSpeed = 5f;
			/*Item.shoot = 282;*/
			/*Item.damage = 19;*/
			Item.width = 26;
			Item.height = 26;
			Item.ammo = AmmoID.Gel;
			/*Item.knockBack = 4.5f;*/
			Item.value = Item.sellPrice(0, 2, 0, 0);
			Item.DamageType = DamageClass.Ranged;
			Item.rare = 7;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Gel, 3996);
			recipe.AddIngredient(ItemID.PinkGel, 5);
			recipe.AddTile(TileID.CrystalBall);
			recipe.Register();
		}
	}
}
