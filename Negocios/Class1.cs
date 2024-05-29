using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class ConexionSQLN
    {
        ConexionSQL cn = new ConexionSQL();

        public int conSQL(string user, string pass)
        {
            return cn.consultalogin(user, pass);
        }

    }
    public class ConexionBibliotecaN
    {
        ConexionBiblioteca cb = new ConexionBiblioteca();

        public DataTable BuscarLibros(string autor, string nombreLibro)
        {
            return cb.BuscarLibros(autor, nombreLibro);
        }
    }
}