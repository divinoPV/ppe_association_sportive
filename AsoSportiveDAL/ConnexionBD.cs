using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace AsoSportiveDAL
{
    public class ConnexionBD
    {
        private SqlConnection maConnexion;
        private static ConnexionBD uneConnexionBD;
        private string chaineConnexion;

        private ConnexionBD() { }

        public string GetChaineConnexion()
        {
            return chaineConnexion;
        }

        public void SetChaineConnexion(string ch)
        {
            chaineConnexion = ch;
        }

        public static ConnexionBD GetConnexionBD()
        {
            if (uneConnexionBD == null)
            {
                uneConnexionBD = new ConnexionBD();
            }

            return uneConnexionBD;
        }

        public SqlConnection GetSqlConnection()
        {
            if (maConnexion == null)
            {
                maConnexion = new SqlConnection();
            }
            maConnexion.ConnectionString = chaineConnexion;

            if (maConnexion.State == ConnectionState.Closed)
            {
                try {
                    maConnexion.Open();
                }
                catch (SqlException)
                {
                    maConnexion.ConnectionString = ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
                    SetChaineConnexion(maConnexion.ConnectionString);

                    maConnexion.Open();
                }
            }

            return maConnexion;
        }

        public void CloseConnexion()
        {
            if (this.maConnexion != null && this.maConnexion.State != System.Data.ConnectionState.Closed)
            {
                this.maConnexion.Close();
            }
        }
    }
}
