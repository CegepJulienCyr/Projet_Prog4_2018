using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data;
using System.Data.Sql;


namespace PorjetProg4
{
    public static class ConnexionDB
    {


        private static SqlConnection connexion;

        public static SqlConnection Connexion { get { return connexion; } }

        public static void ConnexionProvider()
        {
            // Connexion Local
            string connection = "Data Source=localhost;Initial Catalog=BD_LEGO_JulienCyr;User ID=sa;Password=Admin";
           
            // Connexion Serveur
            //string connection = "Data Source=192.168.2.24;Initial Catalog=BD_LEGO_JulienCyr;Integrated Security=False;User ID=Sa;Password=Admin;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connexion = new SqlConnection(connection);
           
        }

        public static bool OpenConnection() {
            try
            {
                connexion.Open();
                return true;
            }
            catch (SqlException Ex)
            {
                Console.WriteLine(Ex);
                return false;
            }
        }
       

public static string[] Connection(string users, string password)
        {
            if (OpenConnection() == true)
            {
                string requete = "SELECT type, COUNT(*) AS nbrTot FROM connexion WHERE users = '" + users + "' AND password = '" + password + "' GROUP BY type; ";
                string[] tbldonnes = new string[2];
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tbldonnes[0] = reader.GetString(0);
                    tbldonnes[1] = reader.GetInt32(1).ToString();
                }
               
                reader.Close();
                connexion.Close();
                return tbldonnes;
            }
            return null;
            
        }

        public static void CreeUtilisateur(string users, string password,string type)
        {
            if (OpenConnection() == true)
            {
                string requete = "USE BD_LEGO_JULIENCYR INSERT INTO connexion VALUES ('" + users + "','" + password + "','"+type+"');";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connexion.Close();
            }
        }

        public static void CreeSet(string set_id, string years, string pieces, string theme,string descr)
        {
            if (OpenConnection() == true)
            {
                string requete = "INSERT INTO dbo.setstemps VALUES ('" + set_id + "','" + years + "','" + pieces + "','" + theme + "','" + descr + "');";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connexion.Close();
            }
           
        }

        public static void SupprimerPieces(string id)
        {
            if (OpenConnection() == true)
            {
                
                string requete = "DELETE dbo.piecetemps WHERE piece_id = '" + id + "'";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();      
                reader.Close();
                connexion.Close();
            }
        }

        public static void SupprimerSets(string id)
        {
            if (OpenConnection() == true)
            {

                string requete = "DELETE dbo.setstemps WHERE set_id = '" + id + "'";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connexion.Close();
            }
        }
        public static void TransfererSet(string idSet)
        {

        }

        public static void TransfererPiece(string idPieces)
        {

        }

        public static bool ModifierSet(string id_set,string years, string pieces,string theme,string descr)
        {
            if (OpenConnection() == true)
            {
                string requete = "UPDATE dbo.sets SET year = '" + years + "', pieces = '" + pieces + "', theme = '" + theme + "', descr = '" + descr + "' WHERE set_id = '" + id_set + "';";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.IsDBNull(0))
                {
                    return false;
                }
                reader.Close();
                connexion.Close();
                return true;
            }
            else
                return false;
        }

        public static bool ModifierPiece(string id_piece, string descr,string catego)
        {
            if (OpenConnection() == true)
            {
                string requete = "UPDATE dbo.pieces SET piece_id = '" + id_piece + "', descr = '" + descr + "', category = '" + catego + "' WHERE piece_id = '" + id_piece + "';";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.IsDBNull(0))
                {
                    return false;
                }
                reader.Close();
                connexion.Close();
                return true;
            }
            else
                return false;
        }

          public static void AjouterSet(string id_set,string years,string nbrpieces, string theme,string descr)
          {
            if (OpenConnection() == true)
            {
                string requete = "INSERT INTO dbo.setstemps VALUES ('" + id_set + "','" + nbrpieces + "','" + theme + "','" + descr + "');";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
            }
          }

        public static void AjouterPiece(string id_piece,string catego, string descr)
        {
            if (OpenConnection() == true)
            {
                string requete = "INSERT INTO dbo.piecetemps VALUES ('" + id_piece + "','" + descr + "','" + catego + "');";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
            }
        }


        public static List<Noeu> RechercherSet(string recherche)
        {
            if(OpenConnection() == true)
            {
                List<Noeu> list = new List<Noeu>();
                string requete = "SELECT set_id, descr FROM sets WHERE descr LIKE '%"+ recherche +"%'";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                   list.Add(new Noeu(reader.GetString(0), reader.GetString(1)));
                }      
                reader.Close();
                connexion.Close();
                return list;
            }
            else
                return null;
        }


        public static List<Noeu> RechercherInventairePieces(string idUsers,string idPiece,string idSets)
        {
            if (OpenConnection() == true)
            {
                List<Noeu> list = new List<Noeu>();
                string requete = "SELECT inv.piece_id, descr FROM inventaire as inv JOIN dbo.pieces as piece ON inv.piece_id = piece.piece_id WHERE user_id = '" + idUsers + "'";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Noeu(reader.GetString(0), reader.GetString(1)));
                }
                reader.Close();
                connexion.Close();
                return list;
            }
            else
                return null;
        }

        public static List<Noeu> RechercherInventaireSets(string idUsers, string idSets)
        {
            if (OpenConnection() == true)
            {
                List<Noeu> list = new List<Noeu>();
                string requete = "SELECT inv.set_id, descr FROM inventaire as inv JOIN dbo.sets as set ON inv.set_id = set.set_id WHERE user_id = '" + idUsers + "'";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Noeu(reader.GetString(0), reader.GetString(1)));
                }
                reader.Close();
                connexion.Close();
                return list;
            }
            else
                return null;
        }

        public static List<Noeu> RechercherPieces(string recherche)
        {
            if (OpenConnection() == true)
            {
                List<Noeu> list = new List<Noeu>();
                string requete = "SELECT piece_id, descr FROM piece WHERE descr LIKE '%" + recherche + "%'";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Noeu(reader.GetString(0), reader.GetString(1)));
                }
                reader.Close();
                connexion.Close();
                return list;
            }
            else
                return null;
        }

        public static List<Noeu> RechercherPieceTemp()
        {
            if (OpenConnection() == true)
            {
                List<Noeu> list = new List<Noeu>();
                string requete = "SELECT piece_id, descr FROM dbo.piecetemp";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Noeu(reader.GetString(0), reader.GetString(1)));
                }
                reader.Close();
                connexion.Close();
                return list;
            }
            else
                return null;
        }

        public static List<Noeu> RechercherSetTemp()
        {
            if (OpenConnection() == true)
            {
                List<Noeu> list = new List<Noeu>();
                string requete = "SELECT set_id, descr FROM dbo.setstemps";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Noeu(reader.GetString(0), reader.GetString(1)));
                }
                reader.Close();
                connexion.Close();
                return list;
            }
            else
                return null;
        }




        public static List<Noeu> RechercherSetPieces(string idSets)
        {
            if (OpenConnection() == true)
            {
                List<Noeu> list = new List<Noeu>();
                string requete = "SELECT piec.piece_id, piec.descr FROM set_pieces as se JOIN piece as piec ON se.piece_id = piec.piece_id WHERE se.set_id = '" + idSets + "';";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Noeu(reader.GetString(0), reader.GetString(1)));
                }
                reader.Close();
                connexion.Close();
                return list;
            }
            else
                return null;
        }
        public static List<Noeu> ChercherTabPiece() 
        {
            if (OpenConnection() == true)
            {
                List<Noeu> list = new List<Noeu>();
                string requete = "SELECT * FROM dbo.piece";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    reader.GetName(0);
                    list.Add(new Noeu(reader.GetString(0), reader.GetString(1)));
                  
                }
                reader.Close();
                connexion.Close();
                return list;
            }
            else
                return null;
        }

        public static List<Noeu> ChercherTabSet()
        {
            if (OpenConnection() == true)
            {
                List<Noeu> list = new List<Noeu>();

                string requete = "SELECT set_id, descr FROM sets";
                SqlCommand command = connexion.CreateCommand();
                command.CommandText = requete;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Noeu(reader.GetString(0), reader.GetString(1)));
                }
                reader.Close();
                connexion.Close();
                return list;
            }
            else
                return null;
        }

    }
}
