using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using scbds.Common;

namespace scbds.Common
{
    public class PlayerClass: ModPlayer
    {
        /// <summary>
        /// An Array of all the damage scalers pulled from the config, in order:
        /// Melee, Ranged, Magic, Summoner, Throwing, Default
        /// </summary>
        float[] DmgScalers = [1f, 1f, 1f, 1f, 1f, 1f];
        /// <summary>
        /// same deal as DmgScalers:
        /// Melee, Ranged, Magic, Summoner, Throwing, Default
        /// </summary>
        float[] CritScalers = [1f, 1f, 1f, 1f, 1f, 1f];
        public override void PreUpdate()
        {
            Config conf = ModContent.GetInstance<Config>();
            DmgScalers[0] = conf.MeleeDamageScaler;
            DmgScalers[1] = conf.RangedDamageScaler;
            DmgScalers[2] = conf.MagicDamageScaler;
            DmgScalers[3] = conf.SummonDamageScaler;
            DmgScalers[4] = conf.ThrowingDamageScaler;
            DmgScalers[5] = conf.DefaultDamageScaler;

            CritScalers[0] = conf.MeleeCritScaler;
            CritScalers[1] = conf.RangedCritScaler;
            CritScalers[2] = conf.MagicCritScaler;
            CritScalers[3] = conf.SummonCritScaler;
            CritScalers[4] = conf.ThrowingCritScaler;
            CritScalers[5] = conf.DefaultCritScaler;
            base.PreUpdate();
        }
        public override void ModifyWeaponDamage(Item item, ref StatModifier damage)
        {
            if (item.CountsAsClass(DamageClass.Melee))
            {
                damage *= DmgScalers[0];
            } else if (item.CountsAsClass(DamageClass.Ranged))
            {
                damage *= DmgScalers[1];
            } else if (item.CountsAsClass(DamageClass.Magic))
            {
                damage *= DmgScalers[2];
            } else if (item.CountsAsClass(DamageClass.Summon))
            {
                damage *= DmgScalers[3];
            } else if (item.CountsAsClass(DamageClass.Throwing))
            {
                damage *= DmgScalers[4];
            } else
            {
                damage *= DmgScalers[5];
            }
            //base.ModifyWeaponDamage(item, ref damage);
        }
        public override void ModifyWeaponCrit(Item item, ref float crit)
        {
            if (item.CountsAsClass(DamageClass.Melee))
            {
                crit *= CritScalers[0];
            }
            else if (item.CountsAsClass(DamageClass.Ranged))
            {
                crit *= CritScalers[1];
            }
            else if (item.CountsAsClass(DamageClass.Magic))
            {
                crit *= CritScalers[2];
            }
            else if (item.CountsAsClass(DamageClass.Summon))
            {
                crit *= CritScalers[3];
            }
            else if (item.CountsAsClass(DamageClass.Throwing))
            {
                crit *= CritScalers[4];
            }
            else
            {
                crit *= CritScalers[5];
            }
            //base.ModifyWeaponCrit(item, ref crit);
        }
    }
}
