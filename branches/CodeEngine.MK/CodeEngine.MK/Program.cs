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

        public static void SwitchView(Form form)
        {
            Form current = null;
            switch (form.Name)
            {
                /*Conversations*/
                case "ConversationAccquire":
                case "ConversationAskMap":
                case "ConversationAskPrice":
                case "ConversationEtc":
                case "ConversationRecommendMenu":
                case "D" :
                case "D1":
                case "D2":
                case "D3":
                case "D4":
                case "F":
                case "G":
                case "G1":
                case "G2":
                case "G3":
                case "H":
                case "I":
                case "I1":
                case "I2":
                case "I3":
                case "I4":
                case "I5":
                    current = new ConversationMain();
                    break;
                /*Informations*/
                case "InformationAboutMk":
                case "InformationAskMember":
                case "InformationIngredient":
                    current = new InformationMain();
                    break;
                /*Trainings*/
                case "J":
                case "J1":
                case "J2":
                case "J3":
                case "J4":
                case "J5":
                case "K":
                case "K1":
                case "K2":
                case "K3":
                case "K4":
                case "K5":
                case "TrainingConversationMk":
                case "TrainingMainVocaburary":
                    current = new TrainingMain();
                    break;
                default:
                    throw new InvalidOperationException("No form name were matched!");
            }
            form.Dispose();
            current.Show();
        }

        public static void SwitchView(SysViewer viewer)
        {

            Form form = null;
            switch (viewer)
            {
                case SysViewer.Portal:
                    form = _Portal;
                    break;
                case SysViewer.ConversationAccquire:
                    form = new ConversationAccquire();
                    break;
                case SysViewer.ConversationRecommendMenu:
                    form = new ConversationRecommendMenu();
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
                case SysViewer.ConversationMain:
                    form = new ConversationMain();
                    break;
                case SysViewer.D:
                    form = new D();
                    break;
                case SysViewer.D1:
                    form = new D1();
                    break;
                case SysViewer.D2:
                    form = new D2();
                    break;
                case SysViewer.D3:
                    form = new D3();
                    break;
                case SysViewer.D4:
                    form = new D4();
                    break;
                case SysViewer.D5:
                    form = new D5();
                    break;
                case SysViewer.F:
                    form = new F();
                    break;
                case SysViewer.G:
                    form = new G();
                    break;
                case SysViewer.G1:
                    form = new G1();
                    break;
                case SysViewer.G2:
                    form = new G2();
                    break;
                case SysViewer.G3:
                    form = new G3();
                    break;
                case SysViewer.H:
                    form = new H();
                    break;
                case SysViewer.I:
                    form = new I();
                    break;
                case SysViewer.I1:
                    form = new I1();
                    break;
                case SysViewer.I2:
                    form = new I2();
                    break;
                case SysViewer.I3:
                    form = new I3();
                    break;
                case SysViewer.I4:
                    form = new I4();
                    break;
                case SysViewer.I5:
                    form = new I5();
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
                case SysViewer.InformationMain:
                    form = new InformationMain();
                    break;
                case SysViewer.J:
                    form = new J();
                    break;
                case SysViewer.J1:
                    form = new J1();
                    break;
                case SysViewer.J2:
                    form = new J2();
                    break;
                case SysViewer.J3:
                    form = new J3();
                    break;
                case SysViewer.J4:
                    form = new J4();
                    break;
                case SysViewer.J5:
                    form = new J5();
                    break;
                case SysViewer.K:
                    form = new K();
                    break;
                case SysViewer.K1:
                    form = new K1();
                    break;
                case SysViewer.K2:
                    form = new K2();
                    break;
                case SysViewer.K3:
                    form = new K3();
                    break;
                case SysViewer.K4:
                    form = new K4();
                    break;
                case SysViewer.K5:
                    form = new K5();
                    break;
                case SysViewer.TrainingConversationMk:
                    form = new TrainingConversationMk();
                    break;
                case SysViewer.TrainingMain:
                    form = new TrainingMain();
                    break;
                case SysViewer.TrainingMainVocaburary:
                    form = new TrainingMainVocaburary();
                    break;
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
            _Portal.Update();
            Program.CurrentView = viewer; //Set current view.

        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(_Portal);
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
            //Application.Run(new H());
            //Application.Run(new G());
            //Application.Run(new I());
            //Application.Run(new I1());
            //Application.Run(new I2());
            //Application.Run(new I3());
            //Application.Run(new I4());
            //Application.Run(new I5());
            //Application.Run(new K());
            //Application.Run(new K1());
            //Application.Run(new K2());
            //Application.Run(new K3());
            //Application.Run(new K4());
            //Application.Run(new K5());
        }


        


    }
}