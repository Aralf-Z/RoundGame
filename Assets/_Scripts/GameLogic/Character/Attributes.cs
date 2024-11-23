using System.Collections;
using System.Collections.Generic;

namespace RoundGame.Logic
{
    public class CoreAttributes
    {
        
    }

    public class PanelAttributes
    {
        
    }
    
    /// <summary>
    /// 角色资源属性
    /// </summary>
    public class ResAttributes
    {
        private int mHealth;
        private int mEndurance;
        private int mActionPoints;
        private int mExtraAction;
        private int mShield;
        
        /// <summary> 生命 </summary>
        public int health
        {
            get => mHealth;
            set
            {
                mHealth = value;
            }
        }

        /// <summary> 耐力 </summary>
        public int endurance
        {
            get => mEndurance;
            set
            {
                mEndurance = value;
            }
        }
        
        /// <summary> 行动点 </summary>
        public int actionPoints
        {
            get => mActionPoints;
            set
            {
                mActionPoints = value;
            }
        }
        
        /// <summary> 额外行动 </summary>
        public int extraAction
        {
            get => mExtraAction;
            set
            {
                mExtraAction = value;
            }
        }
        
        /// <summary> 护盾 </summary>
        public int shield
        {
            get => mShield;
            set
            {
                mShield = value;
            }
        }

        /// <summary>
        /// 回合开始时
        /// </summary>
        public void OnRoundStart()
        {
            
        }

        /// <summary>
        /// 战斗开始时
        /// </summary>
        public void OnBattleEnded()
        {
            
        }
    }
}