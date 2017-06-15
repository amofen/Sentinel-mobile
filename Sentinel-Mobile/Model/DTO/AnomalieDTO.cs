using System;

using System.Collections.Generic;
using System.Text;
using CodeTitans.JSon;
namespace Sentinel_Mobile.Model.DTO
{
    class AnomalieDTO:IJSonSerializable
    {
        public static int MANQUE = 1;
        public static int AVARIE = 2;
        public static int AUTRE_CATEGORIE = 3;

        public String Id { get; set; }
        public String Designation { get; set; }
        public int Type { get; set; }



        #region IJSonReadable Members

        public void Read(IJSonObject input)
        {
            Id = input["Code"].StringValue;
            Designation = input["Designation"].StringValue;
        }

        #endregion

        #region IJSonWritable Members

        public void Write(IJSonWriter output)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
