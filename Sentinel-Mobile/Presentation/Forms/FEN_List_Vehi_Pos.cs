using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sentinel_Mobile.Model.Domain.Localisation;
using Sentinel_Mobile.Presentation.Controlers;

namespace Sentinel_Mobile.Presentation.Forms
{
    public partial class FEN_List_Vehi_Pos : Form
    {
        Dictionary<String,Positionnement> places;
        PositionnementController locaController;
        public FEN_List_Vehi_Pos(Dictionary<String, Positionnement> listPlaces)
        {
            InitializeComponent();
            this.places = listPlaces;
            initList();

        }

        private void initList()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[5]
                          { new DataColumn("Châssis", typeof(string)),
                            new DataColumn("Modele", typeof(string)),
                            new DataColumn("Parc",typeof(string)),
                            new DataColumn("Zone",typeof(string)),
                            new DataColumn("Position",typeof(string))
                          });
           
            foreach (Positionnement place in places.Values)
            {
                dt.Rows.Add(place.Veicule.Vin,
                            place.Veicule.Model
                            , place.CodeParc
                            , place.Zone
                            , place.Rangee+"-"+place.NumeroDsRangee);
            }
          
            Grd_List_Posi.DataSource = dt;
            if(places.Count>0)
            Grd_List_Posi.Select(0);
            
        }


        private void statusBar1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String vin = Grd_List_Posi[Grd_List_Posi.CurrentCell.RowNumber, 0].ToString();
            if (vin != null)
            {
                places.Remove(vin);
            }
            initList();
        }

        private void Grd_List_Posi_CurrentCellChanged(object sender, EventArgs e)
        {
            Grd_List_Posi.Select(Grd_List_Posi.CurrentRowIndex);
        }
    }   
}