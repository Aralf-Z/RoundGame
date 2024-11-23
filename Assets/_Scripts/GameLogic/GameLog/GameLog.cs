using System.Collections;
using System.Collections.Generic;
using QFramework;
using RoundGame.Logic;
using UnityEngine;

namespace RoundGame
{
    public static class GameLog
    {
        private class LogController :
            IController
        {
            public IArchitecture GetArchitecture()
            {
                return GameCoreMgr.Interface;
            }
        }

        private static LogController lc = new LogController();
        
    }
}
