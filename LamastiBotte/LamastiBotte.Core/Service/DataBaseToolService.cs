using LamastiBotte.Core.Controller;
using System;
using System.Data.SqlClient;

namespace LamastiBotte.Core.Service
{
    /// <summary>
    /// Service permettant d'intéragir avec la base de donnée.
    /// </summary>
    public static class DataBaseToolService
    {
        /// <summary>
        /// Chaine de connection à la BDD local.
        /// </summary>
        private const string STR_CONEXTION = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True";


        /// <summary>
        /// Éxécute une requête de type GET.
        /// </summary>
        /// <param name="request">Requête à exécuter.</param>
        /// <returns>Objet de type SqlDataReader.</returns>
        public static SqlDataReader SendRequestGET(string request)
        {
            try
            {
                // BDD : Connection à la BDD.
                SqlConnection connection = new SqlConnection(STR_CONEXTION);
                connection.Open();
                Console.WriteLine("État de la connexion : " + connection.State);

                
                // Créer la commande à exécuté
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = request;

                // Réponse de la BDD suite à la requête.
                SqlDataReader response;

                try
                {
                    //command.ExecuteNonQuery();
                    response = command.ExecuteReader();
                    Console.WriteLine("Command exécuté.");

                    return response;
                }
                catch (SqlException eSql)
                {
                    Console.WriteLine("Erreur sql : " + eSql.Message);
                }
                catch 
                (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);
         
                }

                // BDD : Fermeture de la connection à la BDD.
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur : " + e.Message);
            }

            return null;
        }

        /// <summary>
        /// Exécute une requete de type INSERT, UPDATE ou DELETE.
        /// </summary>
        /// <param name="request">Requête à exécuter.</param>
        /// <returns>Nombre de ligne affecté.</returns>
        public static int UpdateBdd(string request)
        {
            try
            {
                // BDD : Connection à la BDD.
                SqlConnection connection = new SqlConnection(STR_CONEXTION);
                connection.Open();
                Console.WriteLine("État de la connexion : " + connection.State);


                // Créer la commande à exécuté
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = request;

                // Réponse de la BDD suite à la requête.
                int response;

                try
                {
                    //command.ExecuteNonQuery();
                    response = command.ExecuteNonQuery();
                    LogHelper.WriteLog("La requete a été exécuté", "INFO");

                    return response;
                }
                catch (SqlException eSql)
                {
                    Console.WriteLine("Erreur SQL : " + eSql.Message);
                }
                catch
                (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                }

                // BDD : Fermeture de la connection à la BDD.
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur : " + e.Message);
            }

            return -1;
        }
    }
}
