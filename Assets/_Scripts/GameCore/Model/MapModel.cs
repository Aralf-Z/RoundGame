using System.Collections;
using System.Collections.Generic;
using QFramework;
using RoundGame.Logic;
using UnityEngine;

namespace RoundGame
{
    public enum NodeType
    {
        NormalCombat = 1,
        EliteCombat = 2,
        BossCombat = 3,
    }
    
    [AutoRegister(typeof(GameCoreMgr))]
    public class MapModel : AbstractModel
    {
        protected override void OnInit()
        {
            
        }
    }
}
