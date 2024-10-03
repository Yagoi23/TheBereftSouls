﻿using SOTS.Projectiles.Ores;
using Terraria;
using Terraria.ModLoader;
using TheBereftSouls.Void;

namespace TheBereftSouls.Projectiles.Rogue.Void
{
    public class GoldChakramProjectileOverride : GoldChakram
    {
        public override string Texture => "SOTS/Projectiles/Ores/GoldChakram";
        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ModContent.ProjectileType<GoldChakram>());
            Projectile.DamageType = ModContent.GetInstance<VoidRogue>();
        }
        
    }
}