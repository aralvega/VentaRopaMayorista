using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRopaMayorista.model.util
{
    static class ConversorUtil
    {
        public static bool ValidarConversion(string dato, string tipoDato)
        {
            switch (tipoDato)
            {
                case "int":
                    {
                        try
                        {
                            Convert.ToInt32(dato);
                            return true;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                case "float":
                    {
                        try
                        {
                            Convert.ToDecimal(dato);
                            return true;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                default:
                    return false;
            }
        }

        public static int ConvertirStringToInt(string dato)
        {
            return Convert.ToInt32(dato);
        }

        public static float ConvertirStringToFloat(string dato)
        {
            return float.Parse(dato);
        }
    }
}
