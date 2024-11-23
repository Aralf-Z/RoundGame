using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZToolKit;

namespace RoundGame.Logic
{
    public struct EvtArchivesChanged
    {
        private Dictionary<string, Archive> mArchives;
        private bool mSuccess;

        public EvtArchivesChanged(Dictionary<string, Archive> archives, bool success)
        {
            mArchives = archives;
            mSuccess = success;
        }
    }

    public struct EvtNameRepeat
    {

    }

    public struct EvtNameEmpty
    {

    }
}