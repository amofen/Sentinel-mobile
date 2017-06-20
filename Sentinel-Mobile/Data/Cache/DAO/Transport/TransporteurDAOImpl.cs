using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Model.Domain.Transport;
using Sentinel_Mobile.Model.DTO;

namespace Sentinel_Mobile.Data.Cache.DAO.Transport
{
    class TransporteurDAOImpl : TransporteurDAO
    {

        #region TransporteurDAO Members
        public Camion findCamionById(String id)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM camion WHERE id=@id";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@id", id);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                Camion camion = null;
                if (reader.Read())
                {
                    camion = new Camion();
                    camion.NumeroImmatriculation = (String)reader["id"];
                    camion.Transporteur = (String)reader["transporteur"];
                    camion.Modele = (String)reader["modele"];
                }
                return camion;
            }
        }

        public void sauvegarderCamion(Camion camion)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "INSERT INTO camion (id,transporteur,modele) VALUES (@id,@transporteur,@modele) ";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@id",camion.NumeroImmatriculation);
                cmd.Parameters.AddWithValue("@transporteur", camion.Transporteur);
                cmd.Parameters.AddWithValue("@modele", camion.Modele);
                //Préparation de la requête
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                
            }
        }

        public void sauvegarderChauffeur(Chauffeur chauffeur)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "INSERT INTO Chauffeur (id,nomPrenom,transporteur) VALUES (@id,@nomPrenom,@transporteur) ";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@id", chauffeur.NumeroPermis);
                cmd.Parameters.AddWithValue("@transporteur", chauffeur.CodeTransporteur);
                cmd.Parameters.AddWithValue("@nomPrenom", chauffeur.NomPrenom);
                //Préparation de la requête
                cmd.Prepare();
                cmd.ExecuteNonQuery();

            }
        }

        public void setCamionDisponible(bool disponible)
        {

        }

        public List<Camion> getListCamionsByTransporteur(string transporteur)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM camion WHERE transporteur=@transporteur ";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@transporteur", transporteur);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<Camion> camions = new List<Camion>();
                while(reader.Read())
                {
                    Camion camion = new Camion();
                    camion.NumeroImmatriculation = (String)reader["id"];
                    camion.Transporteur = (String)reader["transporteur"];
                    camion.Modele = (String)reader["modele"];
                    camions.Add(camion);
                }   
                if (camions.Count > 0) return camions;
                else return null;
            }
        }

        public List<String> getNomsTransporteurs()
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  transporteur FROM camion GROUP BY transporteur";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<String> transporteurs = new List<String>();
                while (reader.Read())
                {
                    transporteurs.Add((String)reader["transporteur"]);
                }
                if (transporteurs.Count > 0) return transporteurs;
                else return null;
            }

        }

        public List<Chauffeur> getListChauffeursByTransporteur(string transporteur)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM chauffeur WHERE transporteur=@transporteur";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@transporteur", transporteur);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<Chauffeur> chauffeurs = new List<Chauffeur>();
                while (reader.Read())
                {
                    Chauffeur chauffeur = new Chauffeur();
                    chauffeur.NumeroPermis = (String)reader["id"];
                    chauffeur.NomPrenom = (String)reader["nomPrenom"];
                    chauffeur.CodeTransporteur = transporteur;
                    chauffeurs.Add(chauffeur);
                }
                if (chauffeurs.Count > 0) return chauffeurs;
                else return null;
                //TODO: il faut tester la valeur null à l'appel
            }
        }


       public  Chauffeur getChauffeurByCode(string codeScanne)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT  * FROM chauffeur WHERE id=@id";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@id", codeScanne);
                //Préparation de la requête
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    Chauffeur chauffeur = new Chauffeur();
                    chauffeur.NumeroPermis = (String)reader["id"];
                    chauffeur.NomPrenom = (String)reader["nomPrenom"];
                    return chauffeur;
                }
                else return null;
                //TODO: il faut tester la valeur null à l'appel
            }
        }

       public void sauvegarderOperation(OperationTransport operationTransport)
       {
           using (SqlCeConnection cnx = DBConnexionManager.connect())
           {
               string requete = "INSERT INTO Operation (typeOperation,dateDepart,lieuDepart,lieuArrive,chauffeur,numCamion,synchronise) " +
                                             "VALUES (@typeOperation,@dateDepart,@lieuDepart,@lieuArrive,@chauffeur,@numCamion,@synchronise) ";
               SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

               //Préparation des paramètres
               cmd.Parameters.AddWithValue("@typeOperation", operationTransport.TypeOperation);
               cmd.Parameters.AddWithValue("@dateDepart", operationTransport.DateDepart);
               cmd.Parameters.AddWithValue("@lieuDepart", operationTransport.CodeLieuDepart);
               cmd.Parameters.AddWithValue("@lieuArrive", operationTransport.CodeLieuArrivee);
               cmd.Parameters.AddWithValue("@chauffeur", operationTransport.NumPermisChauffeur);
               cmd.Parameters.AddWithValue("@numCamion", operationTransport.NumeroImmatriculation);
               cmd.Parameters.AddWithValue("@synchronise", 0);
               cmd.Prepare();
               cmd.ExecuteNonQuery();


               requete = "SELECT @@IDENTITY";
               cmd = new SqlCeCommand(requete, cnx);
               int id = Convert.ToInt32(cmd.ExecuteScalar());
               foreach (DestinationVehicule destination in operationTransport.DestinationsVehicules)
               {
                    requete = "INSERT INTO DestinationVehicule (codeOperation,vin,destination) VALUES (@codeOperation,@vin,@destination)";
                    cmd = new SqlCeCommand(requete, cnx);
                    cmd.Parameters.AddWithValue("@codeOperation", id);
                    cmd.Parameters.AddWithValue("@vin",destination.Vin);
                    cmd.Parameters.AddWithValue("@destination", destination.CodeDestination);
                    cmd.ExecuteNonQuery();
               }

           }

       }

       public List<OperationTransport> getOperationBySyncEtat(int syn)
       {
           using (SqlCeConnection cnx = DBConnexionManager.connect())
           {
               string requete = "SELECT * FROM  Operation where synchronise=@syncetat";
               SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

               //Préparation des paramètres
               cmd.Parameters.AddWithValue("@syncetat", syn);
               cmd.Prepare();
               SqlCeDataReader reader = cmd.ExecuteReader();
               List<OperationTransport> operations = new List<OperationTransport>();
               while (reader.Read())
               {
                   OperationTransport operation = new OperationTransport();
                   operation.Id = Convert.ToInt32(reader["id"]);
                   operation.TypeOperation = Convert.ToInt32( reader["typeoperation"]);
                   operation.DateDepart = (DateTime)reader["dateDepart"];
                   operation.CodeLieuDepart = (String)reader["lieuDepart"];
                   operation.CodeLieuArrivee = (String)reader["lieuArrive"];
                   operation.NumPermisChauffeur = (String)reader["chauffeur"];
                   operation.NumeroImmatriculation = (String)reader["numCamion"];
                   operation.DestinationsVehicules = new List<DestinationVehicule>();
                   
                   //Récupération des destinations 
                   requete = "SELECT * FROM DestinationVehicule  WHERE codeOperation=@code";
                   cmd = new SqlCeCommand(requete, cnx);
                   cmd.Parameters.AddWithValue("@code", operation.Id);
                   cmd.Prepare();
                   SqlCeDataReader readerD = cmd.ExecuteReader();
                   while (readerD.Read())
                   {
                       DestinationVehicule destination = new DestinationVehicule();
                       destination.Vin = (String)readerD["vin"];
                       destination.CodeDestination = (String) readerD["destination"];
                       operation.DestinationsVehicules.Add(destination);
                   }
                   operations.Add(operation);
               }
               if (operations.Count > 0) return operations;
               else return null;



           }

       }
       public void setOperationEtatSync(OperationTransport opTransport, int p)
       {
           using (SqlCeConnection cnx = DBConnexionManager.connect())
           {
               string requete = "UPDATE Operation SET synchronise=@synchronise WHERE id=@id ";
               SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
               //Préparation des paramètres
               cmd.Parameters.AddWithValue("@id", opTransport.Id);
               cmd.Parameters.AddWithValue("@synchronise", p);
               cmd.Prepare();
               cmd.ExecuteNonQuery();
           }
       }
        #endregion
    }
}
