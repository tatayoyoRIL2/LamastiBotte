using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamastiBotte.Core.Service
{
    public class SQLConnexion
    {
        public static void Main()
        {
            string strConnexion = "Data Source=localhost; Integrated Security=SSPI;" 
                                    + "Initial Catalog=Northwind";
            try
            {
                SqlConnection oConnection = new SqlConnection(strConnexion);
                oConnection.Open();

                Console.WriteLine("Etat de la connexion : " + oConnection.State);

                oConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("L'erreur suivante a été rencontrée :" + e.Message);
            }
        }
    }
}
