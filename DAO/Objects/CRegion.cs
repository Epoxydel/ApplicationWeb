using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Objects
{
    public class CRegion
    {
        int _id;
        String _nom;
        int _id_pays;

        public String Nom { get { return this._nom} set { this._nom = value; } }
        public int Id { get { return this._id; } set { this._id = value; } }
        public int Id_pays { get { return this._id_pays; } set { this._id_pays = value; } }

        public CRegion() {}

        public CRegion(int id, String nom, int id_pays)
        {
            this._id = id;
            this._nom = nom;
            this._id_pays = id_pays;
        }

        public override string ToString()
        {
            return this.Nom;
        }

    }
}
