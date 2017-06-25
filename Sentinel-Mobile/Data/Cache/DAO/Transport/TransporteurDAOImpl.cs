using System;

using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Sentinel_Mobile.Data.Util;
using Sentinel_Mobile.Model.Domain.Transport;
using Sentinel_Mobile.Model.DTO;
using Sentinel_Mobile.Model.Util;
using Sentinel_Mobile.Model.Domain.Avaries;
using Sentinel_Mobile.Data.Synchronisation;

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
                cmd.Parameters.AddWithValue("@id", camion.NumeroImmatriculation);
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
                while (reader.Read())
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


        public Chauffeur getChauffeurByCode(string codeScanne)
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
                    cmd.Parameters.AddWithValue("@vin", destination.Vin);
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
                    operation.TypeOperation = Convert.ToInt32(reader["typeoperation"]);
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
                        destination.CodeDestination = (String)readerD["destination"];
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



        public void sauvegarderOperation(OpTransportReceptionneeDTO operationTransport)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "INSERT INTO OperationReceptionnee (code,dateDepart,lieuDepart,lieuArrive,chauffeur,numCamion,typeOperation,validee,synchronise) " +
                                              "VALUES (@code,@dateDepart,@lieuDepart,@lieuArrive,@chauffeur,@numCamion,@typeOperation,@validee,@synchronise) ";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@code", operationTransport.Code);
                cmd.Parameters.AddWithValue("@dateDepart", operationTransport.DateDepart);
                cmd.Parameters.AddWithValue("@lieuDepart", operationTransport.CodeLieuDepart);
                cmd.Parameters.AddWithValue("@lieuArrive", operationTransport.CodeLieuArrive);
                cmd.Parameters.AddWithValue("@chauffeur", operationTransport.NumPermisChauffeur);
                cmd.Parameters.AddWithValue("@numCamion", operationTransport.NumeroImmatriculation);
                cmd.Parameters.AddWithValue("@typeOperation", operationTransport.TypeOperation);
                cmd.Parameters.AddWithValue("@synchronise", 0);
                cmd.Parameters.AddWithValue("@validee", 0);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                foreach (VehiculeDTO vehicule in operationTransport.Vehicules)
                {
                    requete = "INSERT INTO VehiculeReceptionne (codeOpRecep,vin,receptionne) VALUES  (@codeOpRecep,@vin,0)";
                    cmd = new SqlCeCommand(requete, cnx);
                    cmd.Parameters.Add("@codeOpRecep", operationTransport.Code);
                    cmd.Parameters.Add("@vin", vehicule.Vin);
                    cmd.ExecuteNonQuery();

                    requete = "INSERT INTO Vehicule (vin,couleur,lot,model) VALUES (@vin,@couleur,0,@model)";
                    cmd = new SqlCeCommand(requete, cnx);
                    cmd.Parameters.Add("@vin", vehicule.Vin);
                    cmd.Parameters.Add("@couleur", vehicule.Couleur);
                    cmd.Parameters.Add("@model", vehicule.Marque + " " + vehicule.Modele);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch { }

                    foreach (DeclarationAnomalieDTO declaration in vehicule.Anomalies)
                    {
                        requete = "INSERT INTO DeclarationAnomalie (codeAnomalie,vin,dateDeclaration,etape,synchronisee,validee)"
                                    + " VALUES (@codeAnomalie,@vin,@dateDeclaration,@etape,@synchronisee,@validee)";
                        cmd = new SqlCeCommand(requete, cnx);
                        cmd.Parameters.AddWithValue("@codeAnomalie", declaration.Anomalie);
                        cmd.Parameters.AddWithValue("@vin", declaration.Vin);
                        cmd.Parameters.AddWithValue("@dateDeclaration", declaration.Date);
                        cmd.Parameters.AddWithValue("@etape", declaration.Etape);
                        cmd.Parameters.AddWithValue("@synchronisee", SynchronisationService.SynchronisationParams.NON_SYNCHRONISEE);
                        cmd.Parameters.AddWithValue("@validee", Anomalie.VALIDEE);

                        cmd.ExecuteNonQuery();
                    }
                }

            }
        }


        public int getNombreVehiculeByOperation(int idOperation)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT COUNT(vin) FROM DestinationVehicule where codeOperation=@id";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@id", idOperation);
                cmd.Prepare();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public int getNombreVehiculeByOperationReceptionne(long code)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT COUNT(vin) FROM VehiculeReceptionne where codeOpRecep=@code";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Prepare();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }


        public List<OpTransportReceptionneeDTO> getOperationRecepByEtats(int syn, int val)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT * FROM  OperationReceptionnee where synchronise=@syncetat AND validee=@validee";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@syncetat", syn);
                cmd.Parameters.AddWithValue("@validee", val);
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                List<OpTransportReceptionneeDTO> operations = new List<OpTransportReceptionneeDTO>();
                while (reader.Read())
                {
                    OpTransportReceptionneeDTO operation = new OpTransportReceptionneeDTO();
                    operation.Code = Convert.ToInt64(reader["Code"]);
                    operation.DateDepart = (DateTime)reader["dateDepart"];
                    operation.CodeLieuDepart = (String)reader["lieuDepart"];
                    operation.CodeLieuArrive = (String)reader["lieuArrive"];
                    operation.NumPermisChauffeur = (String)reader["chauffeur"];
                    operation.NumeroImmatriculation = (String)reader["numCamion"];
                    operation.TypeOperation = Convert.ToInt32(reader["typeOperation"]);
                    operation.Vehicules = new List<VehiculeDTO>();

                    //Récupération des destinations 
                    requete = "SELECT * FROM VehiculeReceptionne  WHERE CodeOpRecep=@code AND receptionne=1";
                    cmd = new SqlCeCommand(requete, cnx);
                    cmd.Parameters.AddWithValue("@code", operation.Code);
                    cmd.Prepare();
                    SqlCeDataReader readerD = cmd.ExecuteReader();
                    while (readerD.Read())
                    {
                        VehiculeDTO vehicule = new VehiculeDTO();
                        vehicule.Vin = (String)readerD["vin"];
                        int rec = Convert.ToInt32(readerD["receptionne"]);
                        if (rec == 0) vehicule.Receptionne = false;
                        else vehicule.Receptionne = true;
                        operation.Vehicules.Add(vehicule);
                    }
                    operations.Add(operation);
                }
                if (operations.Count > 0) return operations;
                else return null;



            }

        }


        public OpTransportReceptionneeDTO getOperationRecepByCode(long code)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT * FROM  OperationReceptionnee where code=@code";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);

                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Prepare();
                SqlCeDataReader reader = cmd.ExecuteReader();
                reader.Read();
                OpTransportReceptionneeDTO operation = new OpTransportReceptionneeDTO();
                operation.Code = Convert.ToInt64(reader["Code"]);
                operation.DateDepart = (DateTime)reader["dateDepart"];
                operation.CodeLieuDepart = (String)reader["lieuDepart"];
                operation.CodeLieuArrive = (String)reader["lieuArrive"];
                operation.NumPermisChauffeur = (String)reader["chauffeur"];
                operation.NumeroImmatriculation = (String)reader["numCamion"];
                operation.TypeOperation = Convert.ToInt32(reader["typeOperation"]);
                operation.Vehicules = new List<VehiculeDTO>();

                //Récupération des destinations 
                requete = "SELECT * FROM VehiculeReceptionne  WHERE CodeOpRecep=@code";
                cmd = new SqlCeCommand(requete, cnx);
                cmd.Parameters.AddWithValue("@code", operation.Code);
                cmd.Prepare();
                SqlCeDataReader readerD = cmd.ExecuteReader();
                while (readerD.Read())
                {
                    VehiculeDTO vehicule = new VehiculeDTO();
                    vehicule.Vin = (String)readerD["vin"];
                    int rec = Convert.ToInt32(readerD["receptionne"]);
                    if (rec == 0) vehicule.Receptionne = false;
                    else vehicule.Receptionne = true;
                    operation.Vehicules.Add(vehicule);
                }
                return operation;
            }
        }
        public void setVehiculeReceptionne(string p)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "UPDATE VehiculeReceptionne SET receptionne=1 WHERE vin=@vin ";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@vin", p);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }


        public void validerOperationReceptionne(string p)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "UPDATE OperationReceptionnee SET validee=1 WHERE code=@code ";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@code", p);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        public void setOperationReceptionneSynchronise(long p)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "UPDATE OperationReceptionnee SET synchronise=1 WHERE code=@code ";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@code", p);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }

        public bool isVehiculeReceptionne(string p)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "SELECT COUNT(*) FROM VehiculeReceptionne WHERE vin=@vin AND receptionne=1";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@vin", p);
                
                //Préparation de la requête
                cmd.Prepare();
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                if (i > 0) return true;
                else return false;
            }
        }
        public void validerReception(long p)
        {
            using (SqlCeConnection cnx = DBConnexionManager.connect())
            {
                string requete = "UPDATE OperationReceptionnee SET validee=1 WHERE code=@code ";
                SqlCeCommand cmd = new SqlCeCommand(requete, cnx);
                //Préparation des paramètres
                cmd.Parameters.AddWithValue("@code", p);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion


    }



}
