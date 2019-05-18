﻿using LamastiBotte.Core.Vue;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamastiBotte.Core
{
    /// <summary>
    /// Point d'entrée de lancement de l'application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Méthode principal.
        /// </summary>
        public static void Main(string[] args)
        {
            string strConnexion = "Data Source=localhost;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True";
            try
            {
                // BDD : Connection à la BDD.
                SqlConnection oConnection = new SqlConnection(strConnexion);
                oConnection.Open();
                Console.WriteLine("Etat de la connexion : " + oConnection.State);

                // VUE : Appel de la vue.
                accueilVue vue = new accueilVue();
                vue.ShowDialog();
                vue.Dispose();

                // BDD : Fermeture de la connection à la BDD.
                oConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("L'erreur suivante a été rencontrée :" + e.Message);
            }
        }
    }
}
