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

        internal static Portal _Portal;
        private static Stack<Form> _Forms = new Stack<Form>();


        public static string Language { get; set; }
        public static SysViewer CurrentView { get; private set; }
        public const string FixLanguage = "th";
        public static string[] ZeroArrayString = new string[] { };

        public static void EnhanceCopy(Control ctrl)
        {
            foreach (Control i in ctrl.Controls)
            {
                if (i is TextBox)
                {
                    TextBox iTextBox = i as TextBox;
                    iTextBox.ContextMenu = new ContextMenu();
                    iTextBox.ContextMenu.Popup += new EventHandler(delegate(object o, EventArgs e)
                    {
                        Clipboard.SetDataObject((o as ContextMenu).SourceControl.Text.Trim());
                    });
                }
                else if (i.Controls.Count > 0)
                {
                    Program.EnhanceCopy(i);
                }
            }
        }

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
                case "Portal" :
                    current = _Portal;
                    break;
            }
            if (!(current is Portal))
            {
                form.Dispose();
            }
            current.Show();
        }

        public static void SwitchView(Form from, Form to)
        {
            if (!(from is Portal))
            {
<<<<<<< .mine
                Program._Forms.Push(form);
                Program.EnhanceCopy(form);
                form.Show();
=======
                from.Close();
>>>>>>> .r35
            }
            to.Show();
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
            //Application.Run(new K6());
            //Application.Run(new K7());
        }

    }
}