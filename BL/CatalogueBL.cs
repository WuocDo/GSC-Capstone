using GameShowControls.DA;
using GameShowControls.DO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameShowControls.BL
{
    class CatalogueBL
    {
        DataAccess DA = new DataAccess();

        // Select all item in catalogue table
        public DataTable SelectCata()
        {
            return DA.SelectDatabase("SELECT * FROM Catalogue");
        }


        //Get maximum Catalogue ID
        public int MaxCataID()
        {
            string query = "SELECT * FROM Catalogue";
            DataTable dtb = DA.SelectDatabase(query);
            int i;
            int MaxID = 0;
            foreach (DataRow item in dtb.Rows)
            {
                i = Convert.ToInt32(item["Catalogue_ID"]);
                if (i >= MaxID)
                {
                    MaxID = i;
                }
            }
            MaxID++;
            return MaxID;
        }


        //Query insert command to add catalogue into database
        public void InsertCata(CatalogueDO CataDO)
        {
            string query = "INSERT INTO Catalogue(Catalogue_ID,Catalogue_Name)"
                         + " VALUES ('" + CataDO.Catalogue_ID + "','" + CataDO.Catalogue_Name + "')";

            if (CatalogueExist(CataDO) == true)
            {
                MessageBox.Show("Chủ đề đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DA.InsertDatabase(query);
            }
        }

        //Check catalogue have exist in database
        public bool CatalogueExist(CatalogueDO CataDO)
        {
            string query = "SELECT * FROM Catalogue"
                         + " WHERE Catalogue_Name = '" + CataDO.Catalogue_Name.ToUpper() + "'";

            DataTable dtb = DA.SelectDatabase(query);
            if (dtb.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void EditCataByID(CatalogueDO CataDO)
        {
            string query = "UPDATE Catalogue SET Catalogue_Name = '" + CataDO.Catalogue_Name + "'"
                         + "WHERE Catalogue_ID ='" + CataDO.Catalogue_ID + "'";
            DA.UpdateDatabase(query);

        }

        public void DeleteCataByID(CatalogueDO CataDO)
        {
            string query = "delete from Catalogue where Catalogue_ID='" + CataDO.Catalogue_ID + "'";
            if (DA.DeleteDatabase(query))
            {
                MessageBox.Show("Xóa chủ đề thành công");
            }

        }
    }
}
