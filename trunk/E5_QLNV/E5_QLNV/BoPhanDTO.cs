using System;
using System.Collections.Generic;
using System.Text;

namespace E5_QLNV
{
    class BoPhanDTO
    {
        #region Attribute
        private int _MaBoPhan;    
        private string _BoPhan;
             
        #endregion
        #region Attribute
        public int MaBoPhan
        {
            get { return _MaBoPhan; }
            set { _MaBoPhan = value; }
        }
        public string BoPhan
        {
            get { return _BoPhan; }
            set { _BoPhan = value; }
        }
        #endregion
    }
}
