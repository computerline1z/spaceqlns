using System;
using System.Collections.Generic;
using System.Text;

namespace E5_QLNV
{
    class QuocTichDTO
    {
        #region Attribute
        private int _MaQuocTich;       
        private string _QuocTich;       
        #endregion
        #region Property
        public int MaQuocTich
        {
            get { return _MaQuocTich; }
            set { _MaQuocTich = value; }
        }
        public string QuocTich
        {
            get { return _QuocTich; }
            set { _QuocTich = value; }
        }
        #endregion

    }
}
