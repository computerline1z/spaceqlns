using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
  public   class QuocTichDTO
    {
        #region Attribute
        protected int _MaQuocTich;
        protected string _QuocTich;       
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
