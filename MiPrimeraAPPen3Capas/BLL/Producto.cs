using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Producto
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


        private TipoDeProducto _tipo;

        public TipoDeProducto Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }


    }
}
