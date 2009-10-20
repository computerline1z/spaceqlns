using System;
using System.Collections.Generic;
using System.Text;

namespace E5_QLNV
{
    class ChucVuDTO
    {
        #region Attribute
        private int _MaChucVu;

        
        private string _ChucVu;

        
        #endregion
        #region Property
        public int MaChucVu
        {
            get { return _MaChucVu; }
            set { _MaChucVu = value; }
        }
        public string ChucVu
        {
            get { return _ChucVu; }
            set { _ChucVu = value; }
        }
        #endregion
    }
}

