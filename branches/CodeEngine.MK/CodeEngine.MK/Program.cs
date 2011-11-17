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

        private static Form _Portal;
        private static Stack<Form> _Forms = new Stack<Form>();

        public static string Language { get; set; }
        public static SysViewer CurrentView { get; private set; }

        private static Program()
        {
            _Portal = new Form();
        }

        public static void SwitchView(SysViewer viewer)
        {
            Form form = null;
            switch (viewer)
            {
                case SysViewer.Portal:
                    form = new Portal();
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
                default:
                    throw new Exception("Unexpected SysViewer!");
            }

            
            if (Program._Forms.Count > 0)
            {
                Program._Forms.Pop().Close();
            }

            form.Show();
            Program._Forms.Push(form);
            Program.CurrentView = viewer; //Set current view.

        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(_Portal);
        }


        


    }
}