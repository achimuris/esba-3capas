using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TipoDeProductoDAL
    {

        public DataTable DevolverTodosLosTiposDeProductosDeMiBaseDeDatos()
        {
            Conexion unBD = new Conexion();

            return unBD.LeerPorComando("select * from tTipoDeProducto");
        }

        public DataTable DevolverReporteDeUnStoreProceudreOProcedimientoAlmacenado()
        {
            Conexion unaBaseDeDatos = new Conexion();


            return unaBaseDeDatos.LeerPorStoreProcedure("sp_un_reporte");
        }
    }
}
