using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCM_SEARCHPAGE_V2
{
    public class Controls_URL_Properties
    {

        #region Declaration
        private String findproduct;
        private int currentpage;
        private int productLimitView;
        private int brandLimit;
        #endregion



        #region GETTER SETTER
        public string Findproduct
        {
            get
            {
                return findproduct;
            }

            set
            {
                findproduct = value;
            }
        }
        public int Currentpage
        {
            get
            {
                return currentpage;
            }

            set
            {
                currentpage = value;
            }
        }
        public int ProductLimitView
        {
            get
            {
                return productLimitView;
            }

            set
            {
                productLimitView = value;
            }
        }
        public int BrandLimit
        {
            get
            {
                return brandLimit;
            }

            set
            {
                brandLimit = value;
            }
        }
        #endregion

        

        

      
        // GET NUMFOUND
        

    }

}