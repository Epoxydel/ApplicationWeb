using DAO.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO.DAO
{
    public abstract class CPaysDAO : DAO<CPays, int>
    {
        public CPaysDAO(String connexionString) : base(connexionString) { }

        public override List<CPays> getAll()
        {
            throw new NotImplementedException();
        }
        public override int create(CPays obj)
        {
            throw new NotImplementedException();
        }

        public override bool delete(CPays obj)
        {
            throw new NotImplementedException();
        }

        public override bool update(CPays obj)
        {
            throw new NotImplementedException();
        }
        public override CPays find(int critere)
        {
            throw new NotImplementedException();
        }
    }
}