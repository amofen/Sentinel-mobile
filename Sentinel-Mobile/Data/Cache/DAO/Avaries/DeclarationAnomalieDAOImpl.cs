using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Model.Domain.Avaries;
using Sentinel_Mobile.Data.Synchronisation;

namespace Sentinel_Mobile.Data.Cache.DAO.Avaries
{
    class DeclarationAnomalieDAOImpl : DeclarationAnomalieDAO
    {


        #region DeclarationAnomalieDAO Members

        public int sauvegarder(DeclarationAnomalie declaration)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                String requete = "INSERT INTO DeclarationAnomalie (codeAnomalie,vin,dateDeclaration,etape,synchronisee,validee)"
                                  + " VALUES (@codeAnomalie,@vin,@dateDeclaration,@etape,@synchronisee,@validee)";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@codeAnomalie", declaration.Anomalie);
                cmd.Parameters.AddWithValue("@vin", declaration.Vin);
                cmd.Parameters.AddWithValue("@dateDeclaration", declaration.Date);
                cmd.Parameters.AddWithValue("@etape", declaration.Etape);
                cmd.Parameters.AddWithValue("@synchronisee", SynchronisationService.SynchronisationParams.NON_SYNCHRONISEE);
                cmd.Parameters.AddWithValue("@validee", Anomalie.NON_VALIDEE);
                return cmd.ExecuteNonQuery();
            }
        }



        public List<DeclarationAnomalie> getDeclarationsByVin(String vin)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT * FROM DeclarationAnomalie WHERE vin=@vin";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@vin", vin);
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<DeclarationAnomalie> declarations = new List<DeclarationAnomalie>();
                while (reader.Read())
                {
                    DeclarationAnomalie declaration = new DeclarationAnomalie();
                    declaration.Anomalie = (String)reader["codeAnomalie"];
                    declaration.Vin = (String)reader["vin"];
                    declaration.Date = (DateTime)reader["dateDeclaration"];
                    //declaration.Etape = (int) reader["etape"];
                    declaration.Etape = 1;
                    declarations.Add(declaration);
                }
                return declarations;
            }
        }


        public void retirerDeclaration(string vin, string codeAnomalie)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "DELETE FROM DeclarationAnomalie WHERE vin=@vin and codeanomalie=@codeanomalie";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@vin", vin);
                cmd.Parameters.AddWithValue("@codeanomalie", codeAnomalie);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        public bool vehiculeAvecAnomalie(String vin)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT COUNT(*) FROM DeclarationAnomalie WHERE vin=@vin";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@vin", vin);

                //Préparation de la requête
                cmd.Prepare();
                if ((int)cmd.ExecuteScalar() > 0) return true;
                else return false;
            }     
        }

        #endregion

        #region DeclarationAnomalieDAO Members


        public List<DeclarationAnomalie> getDeclarationsByEtatSync(int syncEtat)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT * FROM DeclarationAnomalie WHERE synchronisee=@synchronisee AND validee=1";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@synchronisee", syncEtat);
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<DeclarationAnomalie> declarations = new List<DeclarationAnomalie>();
                while (reader.Read())
                {
                    DeclarationAnomalie declaration = new DeclarationAnomalie();
                    declaration.Anomalie = (String)reader["codeAnomalie"];
                    declaration.Vin = (String)reader["vin"];
                    declaration.Date = (DateTime)reader["dateDeclaration"];
                    declaration.Etape = Convert.ToInt32( reader["etape"]);
                    declarations.Add(declaration);
                }
                return declarations;
            }
        }

        public void setDeclarationAnomalieEtatSync(string vin, string codeAnomalie, int syncEtat)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "UPDATE DeclarationAnomalie SET synchronisee=@synchronisee WHERE vin=@vin and codeAnomalie=@codeAnomalie";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@vin", vin);
                cmd.Parameters.AddWithValue("@synchronisee", syncEtat);
                cmd.Parameters.AddWithValue("@codeAnomalie", codeAnomalie);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        public void setDeclarationAnomalieEtatVal(string vin, int syncVal)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "UPDATE DeclarationAnomalie SET validee=@validee WHERE vin=@vin";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@vin", vin);
                cmd.Parameters.AddWithValue("@validee", syncVal);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }


        public bool isDeclarationValidee(DeclarationAnomalie dec)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT COUNT(*) FROM DeclarationAnomalie WHERE vin=@vin AND codeAnomalie=@codeAnomalie AND validee=1";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@vin", dec.Vin);
                cmd.Parameters.AddWithValue("@codeAnomalie", dec.Anomalie);

                //Préparation de la requête
                cmd.Prepare();
                if ((int)cmd.ExecuteScalar() > 0) return true;
                else return false;
            }   
        }
        #endregion
    }
}
