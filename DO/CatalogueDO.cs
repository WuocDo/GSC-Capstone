using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShowControls.DO
{
    class CatalogueDO
    {
        String catalogue_Name;
        String catalogue_ID;

        public CatalogueDO()
        { }

        public CatalogueDO(String pCatalogue_Name, String pCataloue_ID)
        {
            catalogue_Name = pCatalogue_Name;
            catalogue_ID = pCataloue_ID;
        }

        public String Catalogue_Name
        {
            get { return catalogue_Name; }
            set { catalogue_Name = value; }
        }

        public String Catalogue_ID
        {
            get { return catalogue_ID; }
            set { catalogue_ID = value; }
        }
    }
}
