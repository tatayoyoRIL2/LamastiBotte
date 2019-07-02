using LamastiBotte.Core.Controller;
using LamastiBotte.Core.Service;
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
    public partial class chatBotVue : Form
    {
        public chatBotVue()
        {
            InitializeComponent();
        }

        private void chatBotVue_Load(object sender, EventArgs e)
        {

        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbConversation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEnvoiMessage_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void SendMessage()
        {
            string message = this.tbMessage.Text;
            DataBaseToolService.UpdateBdd("");
            LogHelper.WriteLog(message, "INFO");
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendMessage();
            }
        }
    }
}
