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
        Dictionary<String,PlaceRangee> places;
        PositionnementController locaController;
        public FEN_List_Vehi_Pos(Dictionary<String, PlaceRangee> listPlaces)
        {
            InitializeComponent();
            this.places = listPlaces;
            initList();

        }

        private void initList()
        {
            Lst_placeRangee.Items.Clear();
            foreach (PlaceRangee place in places.Values)
            {
                this.Lst_placeRangee.Items.Add(place);
            }
        }


        private void statusBar1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaceRangee placeRange = (PlaceRangee)this.Lst_placeRangee.SelectedItem;
            if (placeRange != null)
            {
                places.Remove(placeRange.Vehicule.Vin);
            }
            initList();
        }
    }   
}