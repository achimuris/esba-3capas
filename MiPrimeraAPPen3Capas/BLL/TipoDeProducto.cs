using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class TipoDeProducto
    {
        private int _codigo;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _descrip;

        public string Descripcion
        {
            get { return _descrip; }
            set { _descrip = value; }
        }



        public DataTable Listar()
        {
            TipoDeProductoDAL dal = new TipoDeProductoDAL();

            return dal.DevolverTodosLosTiposDeProductosDeMiBaseDeDatos();
           
        }

        public DataTable ReporteDeStore()
        {

            TipoDeProductoDAL dal = new TipoDeProductoDAL();


            return dal.DevolverReporteDeUnStoreProceudreOProcedimientoAlmacenado();
        }


    }
}
