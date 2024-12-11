using System.Collections;
using System.Collections.Generic;
using cfg;
using QFramework;
using RoundGame.Logic;
using UnityEngine;
using ZToolKit;

namespace RoundGame
{
    [AutoRegister(typeof(GameCoreMgr))]
    public class BattleSystem: AbstractSystem
    {
        protected override void OnInit()
        {
            
        }

        public void StartBattle()
        {
            var enemyIds = new List<Bestiary>();
            var tb = CfgTool.Tables.TbBestiary.DataList;
            var model = this.GetModel<BattleModel>();
            
            model.Enemies.Spawn(tb.GetRandom().ResPrefab);
            model.Enemies.Spawn(tb.GetRandom().ResPrefab);
            model.Enemies.Spawn(tb.GetRandom().ResPrefab);
        }

        public void EndBattle()
        {
            
        }
    }
}
