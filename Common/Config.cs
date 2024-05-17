using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;

namespace scbds.Common
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("DamageScalers")]
        [Range(0f, 10f)]
        [Increment(0.1f)]
        [DefaultValue(1)]
        public float MeleeDamageScaler;

        [Range(0f, 10f)]
        [Increment(0.1f)]
        [DefaultValue(1)]
        public float RangedDamageScaler;

        [Range(0f, 10f)]
        [Increment(0.1f)]
        [DefaultValue(1)]
        public float MagicDamageScaler;

        [Range(0f, 10f)]
        [Increment(0.1f)]
        [DefaultValue(1)]
        public float SummonDamageScaler;

        [Range(0f, 10f)]
        [Increment(0.1f)]
        [DefaultValue(1)]
        public float ThrowingDamageScaler;

        [Range(0f, 10f)]
        [Increment(0.1f)]
        [DefaultValue(1)]
        public float DefaultDamageScaler;

        //Crit Chance Changes
        [Header("CritChanceScalers")]
        [Range(0f, 10f)]
        [Increment(0.1f)]
        [DefaultValue(1)]
        public float MeleeCritScaler;

        [Range(0f, 10f)]
        [Increment(0.1f)]
        [DefaultValue(1)]
        public float RangedCritScaler;

        [Range(0f, 10f)]
        [Increment(0.1f)]
        [DefaultValue(1)]
        public float MagicCritScaler;

        [Range(0f, 10f)]
        [Increment(0.1f)]
        [DefaultValue(1)]
        public float SummonCritScaler;

        [Range(0f, 10f)]
        [Increment(0.1f)]
        [DefaultValue(1)]
        public float ThrowingCritScaler;

        [Range(0f, 10f)]
        [Increment(0.1f)]
        [DefaultValue(1)]
        public float DefaultCritScaler;
    }
}
