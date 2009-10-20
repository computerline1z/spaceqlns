using System;
using System.Collections.Generic;
using System.Text;

namespace E5_QLNV
{
    class BangCapDTO
    {
        #region Attribute
        private int _MaBangCap;
        private string _BangCap;
        #endregion
        #region Property
        public int MaBangCap
        {
            get { return _MaBangCap; }
            set { _MaBangCap = value; }
        }      
        public string BangCap
        {
            get { return _BangCap; }
            set { _BangCap = value; }
        }
        #endregion
    }
}
