using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ThanhVienDTO
    {

        #region Attribute
        protected String _MaUser;
        protected String _Password;

        #endregion
        #region Property

        public String MaUser
        {
            get { return _MaUser; }
            set { _MaUser = value; }
        }
        public String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        #endregion
    }
}
