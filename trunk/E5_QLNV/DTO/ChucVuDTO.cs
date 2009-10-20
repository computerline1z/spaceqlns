using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ChucVuDTO
    {
        #region Attribute
        protected int _MaChucVu;


        protected string _ChucVu;

        
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

