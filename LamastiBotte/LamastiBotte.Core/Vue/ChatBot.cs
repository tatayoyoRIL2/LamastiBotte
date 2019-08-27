using LamastiBotte.Core.Controller;
using LamastiBotte.Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LamastiBotte.Core.Vue
{
    /// <summary>
    /// Gestion del aboite de dialogue.
    /// </summary>
    public partial class chatBotVue : Form
    {
        public chatBotVue()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Initialise la boite de dialogue du chat bot.
        /// </summary>
        private void chatBotVue_Load(object sender, EventArgs e)
        {
            SqlDataReader questions = DataBaseToolService.SendRequestGET("SELECT * FROM [LamastiBotte].[dbo].[Question]");
            LogHelper.WriteLog("Résulat de la requete GET : " + questions.ToString(), "INFO");

            while (questions.Read())
            {
                InsertTextDialogue(questions[1].ToString(), Personnage.ia);
            }
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbConversation_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Surveille l'état du bouton "envoyer".
        /// </summary>
        private void btnEnvoiMessage_Click(object sender, EventArgs e)
        {
            SendMessage();
            tbMessage.Clear();
            
        }

        /// <summary>
        /// Gère la réponse de l'utilisateur.
        /// </summary>
        private void SendMessage()
        {
            string message = tbMessage.Text;
            InsertTextDialogue(message, Personnage.user);

            int result = DataBaseToolService.UpdateBdd("INSERT INTO [LamastiBotte].[dbo].[Reponse]([Message]) VALUES ('" + message + "')");
            LogHelper.WriteLog("Result request INSERT : " + result, "INFO");
        }


        /// <summary>
        /// Surveille la touche entrer etndéclenche une action lorsqu'elle est utilisé.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
            }
        }

        /// <summary>
        /// Ajoute une nouvelle chaine de caractère dans la boite de dialogue.
        /// </summary>
        /// <param name="message">Chainne de caractère à ajouter.</param>
        private void InsertTextDialogue(string message, Personnage personnage)
        {
            message = ServiceTool.FormatOutputMessage(message);

            string nomInterlocuteur = personnage == Personnage.ia ? "Lamastibotte : " : "LamastUser : ";

            tbConversation.Text += nomInterlocuteur + "\n \t" + message + "\n";
        }
    }

    public enum Personnage
    {
        user = 1,
        ia = 2
    }
}
