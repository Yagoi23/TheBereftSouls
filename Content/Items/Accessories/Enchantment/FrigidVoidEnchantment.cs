using SOTS.Items.Permafrost;
using SOTS;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SOTS.Void;
using ThoriumMod.PlayerLayers;
using Terraria.Localization;

namespace TheBereftSouls.Content.Items.Accessories.Enchantment
{
    public class FrigidVoidEnchantment : ModItem
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
            
            player.buffImmune[BuffID.Chilled] = true;
            player.buffImmune[BuffID.Frozen] = true;
            player.buffImmune[BuffID.Frostburn] = true;

            player.moveSpeed += 0.1f;
            player.iceSkate = true;
            player.lifeRegen += 2;
        }
        /*public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            //if (hit.DamageType == ModContent.GetInstance<VoidMagic>() || hit.DamageType == ModContent.GetInstance<VoidMelee>() || hit.DamageType == ModContent.GetInstance<VoidRanged>()|| hit.DamageType == ModContent.GetInstance<VoidSummon>()) 
            //{   //currently only applies to vanilla damage types will need to add others such as rogue, bard and healer
                target.AddBuff(BuffID.Frostburn, 30 * 60);
            //}
            //target.AddBuff(BuffID.Frostburn, 30 * 60); //this needs to be changed so it only applies on void damage
        }*/
        public override void UpdateEquip(Player player)
        {
            SOTSPlayer modPlayer = SOTSPlayer.ModPlayer(player);
            int rand = Main.rand.Next(10);
            if (rand >= 0 && rand <= 2) //0,1,2 30%
                modPlayer.shardOnHit += 1;
            if (rand >= 3 && rand <= 6) //3,4,5,6 40%
                modPlayer.shardOnHit += 2;
            if (rand >= 7) //7, 8, 9 30%
                modPlayer.shardOnHit += 3;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient<FrigidCrown>()
                .AddIngredient<FrigidRobe>()
                .AddIngredient<FrigidGreaves>()
                .AddIngredient<ShatterShardChestplate>()
                .AddIngredient<ShatterBlade>()
                .AddIngredient<FrigidBar>(3)
                .AddTile(TileID.DemonAltar).Register();
        }
    }
}