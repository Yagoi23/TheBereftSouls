using SOTS.Items.Permafrost;
using SOTS;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SOTS.Void;
using SOTS.Items.Pyramid;
using SOTS.Items.Void;

namespace TheBereftSouls.Content.Items.Accessories.Enchantment
{
    public class CursedMatterEnchantment : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 20;
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = ItemRarityID.Blue;
            Item.accessory = true;
        }
        public override void SetStaticDefaults()
        {
            this.SetResearchCost(1);
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetAttackSpeed<VoidGeneric>() += 0.1f;
            //player.iceSkate = true;
            //player.moveSpeed += 0.1f;
            //player.GetDamage<VoidGeneric>() -= 0.15f;
            VoidPlayer voidPlayer = VoidPlayer.ModPlayer(player);
            SOTSPlayer modPlayer = SOTSPlayer.ModPlayer(player);
            //player.GetDamage<VoidGeneric>() += 0.10f;
            voidPlayer.voidCost -= 0.15f;
            player.manaCost -= 0.15f;
            voidPlayer.voidMeterMax2 += 80;
            player.statManaMax2 += 80;
            modPlayer.RubyMonolith = true;
            modPlayer.RubyMonolithIsNOTVanity = true;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient<CursedHood>()
                .AddIngredient<CursedRobe>()
                .AddIngredient<VoidenBracelet>()
                .AddIngredient<VoidenAnkh>()
                .AddIngredient<CursedMatter>(3)
                .AddTile(TileID.DemonAltar).Register();
        }
    }
}