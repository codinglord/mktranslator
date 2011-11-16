using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using CodeEngine.MK.Views;
using CodeEngine.MK.Models;

namespace CodeEngine.MK
{


    static class Program
    {



        public static string Language { get; set; }

        public static SysViewer CurrentView { get; private set; }

        public static void SwitchView(SysViewer viewer)
        {
            if (viewer == SysViewer.MainInformation)
            {
                Application.Run(new MainInformation());
            }

            //Set current view.
            Program.CurrentView = viewer;
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            //Application.Run(new frmPortal());
            //Application.Run(new MainInformation());
            SwitchView(SysViewer.MainInformation);
        }


        


    }
}