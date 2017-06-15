﻿using System;

using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using Sentinel_Mobile.Presentation;
using Sentinel_Mobile.Presentation.Forms;
using Sentinel_Mobile.Presentation.Controlers;

namespace Sentinel_Mobile
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            InitController ctrl = new InitController();
            ctrl.demarrerApplication();
            //Application.Run(new FEN_Test());
        }
    }
}