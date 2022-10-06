using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRopaMayorista.model.util;

namespace VentaRopaMayorista.model
{
    abstract class Prenda
    {
        protected int codigo; //se agrega este atributo para que se pueda registrar prendas en la base de datos
        protected string nombre; // se considera que el nombre es importante para poder distinguir una prenda
        protected string calidad;
        protected float precioUnitario;
        protected int cantidad;

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

        public virtual float CalcularPrecioFinal()
        {
            float precioFinal = 0f;
            //aplicación reglas de negocio RN5  y RN6 (CALIDAD DE LA PRENDA)
            switch (calidad)
            {
                case CalidadPrendaCte.PREMIUM:
                    {
                        precioFinal = this.precioUnitario + (this.precioUnitario * 0.3f);
                        break;
                    }
                case CalidadPrendaCte.STANDARD:
                    {
                        precioFinal = this.PrecioUnitario;
                        break;
                    }
            }
            return precioFinal;
        }
    }
}
