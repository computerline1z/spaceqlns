using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DTO
{
    public   class BoPhanDTO
    {
        #region Attribute
        protected int _MaBoPhan;
        protected string _BoPhan;

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
