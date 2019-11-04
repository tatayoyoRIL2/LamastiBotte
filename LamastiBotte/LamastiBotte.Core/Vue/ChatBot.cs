using LamastiBotte.Core.Controller;
using LamastiBotte.Core.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LamastiBotte.Core.Vue
{
    /// <summary>
    /// Gestion del aboite de dialogue.
    /// </summary>
    public partial class chatBotVue : Form
    {
        /// <summary>
        /// Variable qui indique si c'est la première fois que l'utilisateur parle.
        /// </summary>
        private bool question = true;

        /// <summary>
        /// Constructeur qui initialise la vue.
        /// </summary>
        public chatBotVue()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialise la boite de dialogue du lamasti bot.
        /// </summary>
        private void chatBotVue_Load(object sender, EventArgs e)
        {
            // On récupère les questions que le bot connaît déjà.
            SqlDataReader questions = DataBaseToolService.SendRequestGET("SELECT * FROM [LamastiBotte].[dbo].[Question]");
            LogHelper.WriteLog("Résulat de la requete GET : " + questions.ToString(), "INFO");

            // On les lit et on les affiches
            int cpt = 0;
            while (questions.Read())
            {
                if (cpt <= 1)
                {
                    InsertTextDialogue(questions[1].ToString(), Personnage.ia);
                }
                cpt++;
            }
        }


        private void tbMessage_TextChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Gestion du comportement de la boite de dialogue lorsqu'on ajoute du texte.
        /// </summary>
        private void tbConversation_TextChanged(object sender, EventArgs e)
        {
            tbConversation.SelectionStart = tbConversation.Text.Length;
            tbConversation.ScrollToCaret();

        }

        /// <summary>
        /// Surveille l'état du bouton "Envoyer".
        /// </summary>
        private void btnEnvoiMessage_Click(object sender, EventArgs e)
        {
            SendMessage();
        }


        /// <summary>
        /// Surveille la touche entrer et déclenche une action lorsqu'elle est utilisé.
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
        /// Gère la réponse de l'utilisateur.
        /// </summary>
        private void SendMessage()
        {
            // Récupération du texte de l'utilisateur et insertion dans la boite de dialogue.
            string message = tbMessage.Text;
            InsertTextDialogue(message, Personnage.user);
            tbMessage.Clear();

            // On fait parler le bot.
            ServiceTool.SpeechSynthesizer(message);

            // Récupération des listes de questions et réponses connues.
            var questionsData = this.getQuestions();
            var reponsesData = this.getReponses();

            // fonction qui nous renvoie la réponse du Lamastibot. Gestion de la réponse.
            var reponseIA = QuestionService.SendResponse(message, questionsData, reponsesData);
            InsertTextDialogue(reponseIA, Personnage.ia);
            ServiceTool.SpeechSynthesizer(reponseIA);

            // Logique d'insertion de la donnée en BDD.
            if (reponseIA == questionsData[2])
            {
                if (question)
                {
                    int resultInsertQuestion = DataBaseToolService.UpdateBdd("INSERT INTO [LamastiBotte].[dbo].[Question]([Message]) VALUES ('" + message + "')");
                    LogHelper.WriteLog("Result request INSERT : " + resultInsertQuestion, "INFO");
                    question = false;
                }
                else
                {
                    int resultInsertReponse = DataBaseToolService.UpdateBdd("INSERT INTO [LamastiBotte].[dbo].[Reponse]([Message]) VALUES ('" + message + "')");
                    LogHelper.WriteLog("Result request INSERT : " + resultInsertReponse, "INFO");
                    question = true;
                }
            }
        }

        /// <summary>
        /// Récupère toutes les questions de la BDD.
        /// </summary>
        /// <returns></returns>
        private List<string> getQuestions()
        {
            List<string> listQuestions = new List<string>() { };

            SqlDataReader questions = DataBaseToolService.SendRequestGET("SELECT * FROM [LamastiBotte].[dbo].[Question]");
            LogHelper.WriteLog("Résulat de la requete GET ALL questions :  " + questions.ToString(), "INFO");

            while (questions.Read())
            {
                listQuestions.Add(questions[1].ToString());
            }

            return listQuestions;
        }

        /// <summary>
        /// Récupère toutes les réponses de la BDD.
        /// </summary>
        /// <returns></returns>
        private List<string> getReponses()
        {
            List<string> listReponses = new List<string>() { };

            SqlDataReader reponses = DataBaseToolService.SendRequestGET("SELECT * FROM [LamastiBotte].[dbo].[Reponse]");
            LogHelper.WriteLog("Résulat de la requete GET ALL reponses :  " + reponses.ToString(), "INFO");

            while (reponses.Read())
            {
                listReponses.Add(reponses[1].ToString());
            }

            return listReponses;
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

    /// <summary>
    /// Énum qui permet de typer le type d'utilisateur.
    /// </summary>
    public enum Personnage
    {
        user = 1,
        ia = 2
    }
}
