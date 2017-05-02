using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Model.Domain.Avaries;

namespace Sentinel_Mobile.Data.Cache.DAO.Avaries
{
    class DeclarationAnomalieDAOImpl:DeclarationAnomalieDAO
    {


        #region DeclarationAnomalieDAO Members

        public int sauvegarder(DeclarationAnomalie declaration)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                String requete = "INSERT INTO DeclarationAnomalie (codeAnomalie,vin,dateDeclaration,etape)"
                                  + " VALUES (@codeAnomalie,@vin,@dateDeclaration,@etape)";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@codeAnomalie",declaration.Anomalie);
                cmd.Parameters.AddWithValue("@vin",declaration.Vin);
                cmd.Parameters.AddWithValue("@dateDeclaration", declaration.Date);
                cmd.Parameters.AddWithValue("@etape", declaration.Etape);
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
                    declaration.Date = (DateTime) reader["dateDeclaration"];
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
                cmd.Parameters.AddWithValue("@vin",vin);
                cmd.Parameters.AddWithValue("@codeanomalie", codeAnomalie);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        #endregion
    }
}
