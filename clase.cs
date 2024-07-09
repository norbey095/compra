using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progreso
{
    internal class clase
    {
        private double _valorproducto;
        private double _cantidad;
        private double _totalcompra;

        public double cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        public double valor
        {
            get { return _valorproducto; }
            set { _valorproducto = value; }
        }

        public double totalcompra
        {
            get { return _totalcompra; }
            set { _totalcompra = value; }
        }


        public double multiplicar(double valor, double cantidad)
        {
           return valor * cantidad;
        }

        public void agregar(double valueAgregar)
        {
            _totalcompra += valueAgregar;
        }

        public void eliminar(double valueEliminar)
        {
            _totalcompra -= valueEliminar;
        }
        
    }
}
