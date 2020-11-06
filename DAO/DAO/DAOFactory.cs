using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    public class DAOFactory
    {
        protected static String _connexionString = "SERVER=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.19)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));uid=c##yanis;pwd=J6kcm;";
    
        public static _CPaysDAO GetCPaysDAO()
        {
            return new _CPaysDAO(_connexionString);
        }

        public static _CRegionDAO GetCRegionDAO()
        {
            return new _CRegionDAO(_connexionString);
        }
    }
}
