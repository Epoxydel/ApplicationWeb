using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAO.Objects;
using DAO.DAO;

namespace ws
{
    public partial class ServiceRegion
    {
        public List<CRegion> GetAllRegion(CRegion obj)
        { 
            return DAOFactory.GetCRegionDAO().getAll();
        }
    }
}