using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRopaMayorista.model.util;
using VentaRopaMayorista.presenter.views;

namespace VentaRopaMayorista.presenter
{
    class ValidadorPresenter
    {
        private IViewValidator formularioCotizador;

        public ValidadorPresenter(IViewValidator formularioCotizador)
        {
            this.formularioCotizador = formularioCotizador;
        }

        public bool validarCampos(string unidadesDisponibles, string precioUnitario, string cantidadSolicitada)
        {
            bool sonCamposValidos = true;
            string mensajeResultadoValidacion = "";
            bool precioVacio = false;
            bool cantidadVacia = false;


            if (precioUnitario.Length == 0)
            {
                mensajeResultadoValidacion += "El Precio Unitario no puede estar vacío. Ingrese valores aceptables\n";
                sonCamposValidos = false;
                precioVacio = true;
            }

            if (cantidadSolicitada.Length == 0)
            {
                mensajeResultadoValidacion += "La Cantidad Solicitada no puede estar vacío. Ingrese valores aceptables\n";
                sonCamposValidos = false;
                cantidadVacia = true;
            }

            if (cantidadVacia != true && precioVacio != true)
            {
                if (!ConversorUtil.ValidarConversion(precioUnitario, "float"))
                {
                    mensajeResultadoValidacion += "Precio Unitario Inválido. Ingrese valores aceptables.\n";
                    sonCamposValidos = false;
                }

                if (!ConversorUtil.ValidarConversion(cantidadSolicitada, "int"))
                {
                    mensajeResultadoValidacion += "Cantidad solicitada Inválida. Ingrese valores aceptables.\n";
                    sonCamposValidos = false;
                }
                else
                {
                    if (ConversorUtil.ConvertirStringToInt(cantidadSolicitada) > ConversorUtil.ConvertirStringToInt(unidadesDisponibles))
                    {
                        mensajeResultadoValidacion += "La cantidad solicitada es mayor a la disponible. Modifique la cantidad solicitada\n";
                        sonCamposValidos = false;
                    }
                }

                if (ConversorUtil.ConvertirStringToInt(cantidadSolicitada) <= 0)
                {
                    mensajeResultadoValidacion += "La cantidad solicitada no puede ser 0 o valor negativo. Modifique la cantidad solicitada\n";
                    sonCamposValidos = false;
                }

                if (ConversorUtil.ConvertirStringToFloat(precioUnitario) <= 0f)
                {
                    mensajeResultadoValidacion += "El precio unitario no puede ser 0 o valor negativo. Modifique el precio unitario\n";
                    sonCamposValidos = false;
                }
            }

            if (sonCamposValidos != true)
            {
                formularioCotizador.VisualizarResultadoValidaciones(mensajeResultadoValidacion);
            }

            return sonCamposValidos;

        }
    }
}
