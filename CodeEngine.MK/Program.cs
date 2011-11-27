using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using CodeEngine.MK.Views;
using CodeEngine.MK.Models;
using CodeEngine.MK.Views.Conversations;
using CodeEngine.MK.Views.Informations;
using CodeEngine.MK.Views.Trainings;

namespace CodeEngine.MK
{


    static class Program
    {

        private static Portal _Portal;
        private static Stack<Form> _Forms = new Stack<Form>();


        public static string Language { get; set; }
        public static SysViewer CurrentView { get; private set; }
        public const string FixLanguage = "th";
        public static string[] ZeroArrayString = new string[] { };

        static Program()
        {
            Program.Language = "en";
            _Portal = new Portal();
        }

        public static void SwitchView(SysViewer viewer)
        {
            Form form = null;
            switch (viewer)
            {
                case SysViewer.Portal:
                    form = _Portal;
                    break;
                case SysViewer.ConversationMain:
                    form = new ConversationMain();
                    break;
                case SysViewer.InformationMain:
                    form = new InformationMain();
                    break;
                case SysViewer.TrainingMain:
                    form = new TrainingMain();
                    break;
                case SysViewer.ConversationAccquire:
                    form = new ConversationAccquire();
                    break;
                case SysViewer.ConversationAskMap:
                    form = new ConversationAskMap();
                    break;
                case SysViewer.ConversationAskPrice:
                    form = new ConversationAskPrice();
                    break;
                case SysViewer.ConversationEtc:
                    form = new ConversationEtc();
                    break;
                case SysViewer.ConversationRecommendMenu:
                    form = new ConversationRecommendMenu();
                    break;
                case SysViewer.InformationAboutMk:
                    form = new InformationAboutMk();
                    break;
                case SysViewer.InformationAskMember:
                    form = new InformationAskMember();
                    break;
                case SysViewer.InformationIngredient:
                    form = new InformationIngredient();
                    break;

                default:
                    throw new Exception("Unexpected SysViewer!");
            }

            
            if (Program._Forms.Count > 0)
            {
                Program._Forms.Pop().Close();
            }
            if (!form.Equals(Program._Portal)) //Avoid duplicate form portal.
            {
                Program._Forms.Push(form);
                form.Show();
            }
            Program.CurrentView = viewer; //Set current view.

        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            //Application.Run(_Portal);
            //Application.Run(new InformationAboutMk());
            //Application.Run(new InformationAskMember());
            //Application.Run(new G1());
            //Application.Run(new G2());
            //Application.Run(new G3());
            //Application.Run(new J1());
            //Application.Run(new J2());
            //Application.Run(new J3());
            //Application.Run(new J4());
            //Application.Run(new J5());
            //Application.Run(new D1());
            //Application.Run(new D2());
            //Application.Run(new D3());
            //Application.Run(new D4());
            //Application.Run(new D5());
            //Application.Run(new F());
            //Application.Run(new J());
            //Application.Run(new D());

        }


        


    }
}