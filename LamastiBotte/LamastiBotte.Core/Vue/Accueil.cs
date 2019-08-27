using LamastiBotte.Core.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LamastiBotte.Core.Vue
{
    public partial class accueilVue : Form
    {
        public accueilVue()
        {
            InitializeComponent();
        }

        private void lbTitre_Click(object sender, EventArgs e)
        {

        }

        private void Vue_Load(object sender, EventArgs e)
        {

        }

        private void logoBotte_Click(object sender, EventArgs e)
        {

            //Gestion de l'exception
            try
            {
                bool[] H = new bool[5] { true, false, true, false, true };
                H[6] = false;
            }
            catch (System.IndexOutOfRangeException ex)
            {
                LogHelper.WriteLog(ex.Message, "ERROR");
                Console.WriteLine("CECI EST UN TEST POUR LES LOGS");               
                LogHelper.WriteLog("UN LOG INFO DE QUALITE","INFO");
                
            }

        }

        private void lbSlogan_Click(object sender, EventArgs e)
        {

        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            this.Dispose();
            chatBotVue chat = new chatBotVue();
            chat.ShowDialog();
        }
    }
}
