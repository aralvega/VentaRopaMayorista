using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRopaMayorista.model
{
    class Prenda
    {
        private int codigo; //se agrega este atributo para que se pueda registrar prendas en la base de datos
        private string nombre; // se considera que el nombre es importante para poder distinguir una prenda
        private string calidad;
        private float precioUnitario;
        private int cantidad;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Calidad { get => calidad; set => calidad = value; }
        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Prenda(int codigo, string nombre, string calidad, float precioUnitario, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Calidad = calidad;
            PrecioUnitario = precioUnitario;
            Cantidad = cantidad;
            Codigo = codigo;
            Nombre = nombre;
            Calidad = calidad;
            PrecioUnitario = precioUnitario;
            Cantidad = cantidad;
        }
    }
}
