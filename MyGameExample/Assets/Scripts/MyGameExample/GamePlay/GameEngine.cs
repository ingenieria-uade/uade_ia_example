using MyGameExample.UI.Screens;
using UADE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MyGameExample.GamePlay
{
    class GameEngine: MonoBehaviour
    { 

        public StackNavigator m_Navigator = null;
        public void Start()
        {
            m_Navigator.Push<SplashScreen>();
        }
    }
}
