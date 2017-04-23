using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using OpenNETCF.ORM;
using Sentinel_Mobile.Data;
using Sentinel_Mobile.Data.DAO;
using System.Threading;
using CodeTitans.JSon;
using System.Diagnostics;
using System.IO;
using Sentinel_Mobile.Data.Config;
using Sentinel_Mobile.Data.DAO.Cache.Vehicules;


namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_Test : Form
    {
        public FEN_Test()
        {
            InitializeComponent();
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Parametres_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Parametres_Click_1(object sender, EventArgs e)
        {
            
        }

        private void FEN_Test_Load(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.CertificatePolicy = new TrustAllCertificatePolicy();
            ScanDAO dao = new ScanDAOImpl();
            Debug.Write("TMBED4NJ1GZ168626 est scanne : "+ dao.vehiculeScanne("TMBED4NJ1GZ168626")+"\n");
            Debug.Write("VSSZZZ6JZGR127409 est scanne : " + dao.vehiculeScanne("VSSZZZ6JZGR127409") + "\n");
            Debug.Write("Nombre de vehxules scanne : " + dao.getNbVehiculesScannes() + "\n");
            dao.scannerVehicule("VSSZZZ6JZGR127409");
            Debug.Write("VSSZZZ6JZGR127409 est scanne : " + dao.vehiculeScanne("VSSZZZ6JZGR127409") + "\n");
            Debug.Write("Nombre de vehxules scanne : " + dao.getNbVehiculesScannes() + "\n");


       }
        
    }
}