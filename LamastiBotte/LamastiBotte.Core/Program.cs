using LamastiBotte.Core.Service;
using LamastiBotte.Core.Vue;
using LamastiBotte.Core.Controller;
using System;
using System.Data.SqlClient;

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
            try
            {
                // VUE : Appel de la vue.
                LogHelper.WriteLog("Lancement de la vue.", "INFO");
                accueilVue vue = new accueilVue();
                vue.ShowDialog();
            }
            catch (Exception e)
            {
                LogHelper.WriteLog(string.Format("L'erreur suivante a été rencontrée :" + e.Message + " " + e), "ERROR");
            }
            Console.ReadKey(true);

        }
    }
}
