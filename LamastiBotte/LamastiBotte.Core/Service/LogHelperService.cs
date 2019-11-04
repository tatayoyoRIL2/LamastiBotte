using System;
using System.Diagnostics.Tracing;
using System.IO;

namespace LamastiBotte.Core.Controller
{
    /// <summary>
    /// Class utilitaire permettant de gérer les log.
    /// </summary>
    public class LogHelper
    {
        /// <summary>
        /// Permet de générer un log afficher dans la console et enregistrer dans un fichier.
        /// Ce log est généré suivant sont type et un message transmit.
        /// </summary>
        /// <param name="errorMessage">Message définit</param>
        /// <param name="className">Type du log</param>
        public static void WriteLog(string errorMessage, string className)
        {
            DateTime nowDate = DateTime.Now;
            string shortDate = String.Format("{0:yyyy-MM-dd}", nowDate);
            string filename = string.Format("{0}.log", shortDate);

            //création du nom de fichier .log
            filename = filename.Replace("/", "-");

            //récupérer le path complet, application PC
            string rootPath = Path.GetFullPath("Log/");
            string fullFilename = string.Format(@"{0}{1}", rootPath, filename);

            //vérifier le dossier Log
            if (!Directory.Exists(rootPath))
            {

                //création du dossier
                Directory.CreateDirectory(rootPath);
            }

            //vérifier le fichier
            if (!File.Exists(fullFilename))
            {

                //création du fichier log du jour
                FileStream f = File.Create(fullFilename);
                f.Close();
            }

            using (StreamWriter writer = new StreamWriter(fullFilename, true))
            {
                //écriture dans le fichier log du jour
                writer.WriteLine(string.Format(
                                       "[{0}][{1}] {2}",
                                       DateTime.Now,
                                       className,
                                       errorMessage));
                Console.WriteLine(string.Format(
                                       "[{0}][{1}] {2}",
                                       DateTime.Now,
                                       className,
                                       errorMessage));
            }
        }
    }
}
