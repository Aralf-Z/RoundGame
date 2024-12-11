using System.Collections;
using System.Collections.Generic;
using QFramework;
using RoundGame.Logic;
using UnityEngine;

namespace RoundGame
{
    [AutoRegister(typeof(GameCoreMgr))]
    public class BattleModel : AbstractModel
    {
        public Characters Allies => mAllies;
        public Characters Enemies => mEnemies;
        
        private Characters mAllies = new Characters();
        private Characters mEnemies = new Characters();
        
        protected override void OnInit()
        {
           
        }
        
        public void Clear()
        {
            mAllies.Clear();
            mEnemies.Clear();
        }
    }
}
