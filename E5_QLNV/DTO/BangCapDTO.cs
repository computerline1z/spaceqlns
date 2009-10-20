using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DTO
{
    public class BangCapDTO
    {
        #region Attribute
        protected int _MaBangCap;
        protected string _BangCap;
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
