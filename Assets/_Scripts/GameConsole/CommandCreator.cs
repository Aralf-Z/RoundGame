using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using RedSaw.CommandLineInterface;
using UnityEngine;

namespace RoundGame.Logic
{
    public class CommandCreator :
        ICommandCreator
    {
        public Type[] GetAssemblyTypes() => Assembly.GetExecutingAssembly().GetTypes();
    }
}