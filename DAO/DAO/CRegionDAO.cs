using DAO.Objects;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO.DAO
{
    public abstract class CRegionDAO : DAO<CRegion, int>
    {
        public CRegionDAO(String connexionString) : base(connexionString) { }

        public override List<CRegion> getAll()
        {
            List<CRegion> region = new List<CRegion>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM region";

            OracleDataReader res = req.ExecuteReader();

            while (res.Read())
            {
                region.Add(new CRegion(int.Parse(res["id"].ToString()), res["nom"].ToString(), int.Parse(res["id_pays"].ToString())));
            }

            res.Close();

            return region;
            
        }
        public override int create(CRegion obj)
        {
            throw new NotImplementedException();
        }

        public override bool delete(CRegion obj)
        {
            throw new NotImplementedException();
        }

        public override bool update(CRegion obj)
        {
            throw new NotImplementedException();
        }
        public override CRegion find(int critere)
        {
            throw new NotImplementedException();
        }
}
}
