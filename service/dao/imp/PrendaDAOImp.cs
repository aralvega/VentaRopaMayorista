using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaRopaMayorista.model;
using VentaRopaMayorista.model.util;

namespace VentaRopaMayorista.service.dao.imp
{
    class PrendaDAOImp
    {
        public void GenerarCatalogo()
        {
            MySqlConnection conexionBD = new MySqlConnection("Server=localhost;User=root;Password=root;Port=3306;database=tienda_ropa_mayorista;");
            try
            {

                MySqlCommand command = new MySqlCommand("SELECT * FROM prendas;", conexionBD);
                conexionBD.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    reader.Close();
                    string stringCommand = "INSERT INTO prendas (pre_nombre,pre_cantidad,pre_calidad,pre_tipo_manga,pre_tipo_cuello,pre_tipo_pantalon)" +
                                            "VALUES ('CAMISA',100,'STANDARD','MANGA CORTA','CUELLO MAO','')";
                    command = new MySqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    stringCommand = "INSERT INTO prendas (pre_nombre,pre_cantidad,pre_calidad,pre_tipo_manga,pre_tipo_cuello,pre_tipo_pantalon)" +
                                            "VALUES ('CAMISA',100,'PREMIUM','MANGA CORTA','CUELLO MAO','')";
                    command = new MySqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    stringCommand = "INSERT INTO prendas (pre_nombre,pre_cantidad,pre_calidad,pre_tipo_manga,pre_tipo_cuello,pre_tipo_pantalon)" +
                                            "VALUES ('CAMISA',150,'STANDARD','MANGA CORTA','CUELLO COMUN','')";
                    command = new MySqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    stringCommand = "INSERT INTO prendas (pre_nombre,pre_cantidad,pre_calidad,pre_tipo_manga,pre_tipo_cuello,pre_tipo_pantalon)" +
                                            "VALUES ('CAMISA',150,'PREMIUM','MANGA CORTA','CUELLO COMUN','')";
                    command = new MySqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    stringCommand = "INSERT INTO prendas (pre_nombre,pre_cantidad,pre_calidad,pre_tipo_manga,pre_tipo_cuello,pre_tipo_pantalon)" +
                                            "VALUES ('CAMISA',75,'STANDARD','MANGA LARGA','CUELLO MAO','')";
                    command = new MySqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    stringCommand = "INSERT INTO prendas (pre_nombre,pre_cantidad,pre_calidad,pre_tipo_manga,pre_tipo_cuello,pre_tipo_pantalon)" +
                                            "VALUES ('CAMISA',75,'PREMIUM','MANGA LARGA','CUELLO MAO','')";
                    command = new MySqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    stringCommand = "INSERT INTO prendas (pre_nombre,pre_cantidad,pre_calidad,pre_tipo_manga,pre_tipo_cuello,pre_tipo_pantalon)" +
                                            "VALUES ('CAMISA',175,'PREMIUM','MANGA LARGA','CUELLO COMUN','')";
                    command = new MySqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    stringCommand = "INSERT INTO prendas (pre_nombre,pre_cantidad,pre_calidad,pre_tipo_manga,pre_tipo_cuello,pre_tipo_pantalon)" +
                                            "VALUES ('CAMISA',175,'STANDARD','MANGA LARGA','CUELLO COMUN','')";
                    command = new MySqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    stringCommand = "INSERT INTO prendas (pre_nombre,pre_cantidad,pre_calidad,pre_tipo_manga,pre_tipo_cuello,pre_tipo_pantalon)" +
                                            "VALUES ('PANTALON',750,'STANDARD','','','CHUPIN')";
                    command = new MySqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    stringCommand = "INSERT INTO prendas (pre_nombre,pre_cantidad,pre_calidad,pre_tipo_manga,pre_tipo_cuello,pre_tipo_pantalon)" +
                                            "VALUES ('PANTALON',750,'PREMIUM','','','CHUPIN')";
                    command = new MySqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    stringCommand = "INSERT INTO prendas (pre_nombre,pre_cantidad,pre_calidad,pre_tipo_manga,pre_tipo_cuello,pre_tipo_pantalon)" +
                                            "VALUES ('PANTALON',250,'STANDARD','','','COMUN')";
                    command = new MySqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                    stringCommand = "INSERT INTO prendas (pre_nombre,pre_cantidad,pre_calidad,pre_tipo_manga,pre_tipo_cuello,pre_tipo_pantalon)" +
                                            "VALUES ('PANTALON',250,'PREMIUM','','','COMUN')";
                    command = new MySqlCommand(stringCommand, conexionBD);
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conexionBD.Close();
        }

        public Prenda ObtenerPrenda(string tipoPrenda, string calidad, string tipoManga, string tipoCuello, string tipoPantalon)
        {
            Prenda prendaBuscada = null;
            string query = "";
            switch (tipoPrenda)
            {
                case NombrePrendaCte.CAMISA:
                    {
                        query = "SELECT * FROM prendas WHERE pre_nombre='" + tipoPrenda + "' AND pre_calidad='" + calidad +
                                "' AND pre_tipo_manga='" + tipoManga + "' AND pre_tipo_cuello='" + tipoCuello + "';";
                        break;
                    }
                case NombrePrendaCte.PANTALON:
                    {
                        query = "SELECT * FROM prendas WHERE pre_nombre='" + tipoPrenda + "' AND pre_calidad='" + calidad +
                                "' AND pre_tipo_pantalon='" + tipoPantalon + "';";
                        break;
                    }
            }
            MySqlConnection conexionBD = new MySqlConnection("Server=localhost;User=root;Password=root;Port=3306;database=tienda_ropa_mayorista;");

            try
            {
                MySqlCommand command = new MySqlCommand(query, conexionBD);
                conexionBD.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        switch (reader.GetString(1))
                        {
                            case NombrePrendaCte.CAMISA:
                                {
                                    Camisa camisa = new Camisa(reader.GetInt32(0),
                                                                reader.GetString(1),
                                                                reader.GetString(3),
                                                                0f,
                                                                reader.GetInt32(2),
                                                                reader.GetString(4),
                                                                reader.GetString(5));
                                    prendaBuscada = camisa;
                                    break;
                                }
                            case NombrePrendaCte.PANTALON:
                                {
                                    Pantalon pantalon = new Pantalon(reader.GetInt32(0),
                                                                reader.GetString(1),
                                                                reader.GetString(3),
                                                                0f,
                                                                reader.GetInt32(2),
                                                                reader.GetString(6));
                                    prendaBuscada = pantalon;
                                    break;
                                }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conexionBD.Close();
            return prendaBuscada;
        }

        public List<Prenda> ObtenerPrendas()
        {
            List<Prenda> prendas = new List<Prenda>();
            MySqlConnection conexionBD = new MySqlConnection("Server=localhost;User=root;Password=root;Port=3306;database=tienda_ropa_mayorista;");
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM prendas;", conexionBD);
                conexionBD.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        switch (reader.GetString(1))
                        {
                            case NombrePrendaCte.CAMISA:
                                {
                                    Camisa camisa = new Camisa(reader.GetInt32(0),
                                                                reader.GetString(1),
                                                                reader.GetString(3),
                                                                0f,
                                                                reader.GetInt32(2),
                                                                reader.GetString(4),
                                                                reader.GetString(5));
                                    prendas.Add(camisa);
                                    break;
                                }
                            case NombrePrendaCte.PANTALON:
                                {
                                    Pantalon pantalon = new Pantalon(reader.GetInt32(0),
                                                                reader.GetString(1),
                                                                reader.GetString(3),
                                                                0f,
                                                                reader.GetInt32(2),
                                                                reader.GetString(6));
                                    prendas.Add(pantalon);
                                    break;
                                }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conexionBD.Close();
            return prendas;
        }

        public int ObtenerUnidadesDisponibles(string tipoPrenda, string calidad, string tipoManga, string tipoCuello, string tipoPantalon)
        {
            int cantUnidadesDisponibles = 0;
            string query = "";
            switch (tipoPrenda)
            {
                case NombrePrendaCte.CAMISA:
                    {
                        query = "SELECT pre_cantidad FROM prendas WHERE pre_nombre='" + tipoPrenda + "' AND pre_calidad='" + calidad +
                                "' AND pre_tipo_manga='" + tipoManga + "' AND pre_tipo_cuello='" + tipoCuello + "';";
                        break;
                    }
                case NombrePrendaCte.PANTALON:
                    {
                        query = "SELECT pre_cantidad FROM prendas WHERE pre_nombre='" + tipoPrenda + "' AND pre_calidad='" + calidad +
                                "' AND pre_tipo_pantalon='" + tipoPantalon + "';";
                        break;
                    }
            }
            MySqlConnection conexionBD = new MySqlConnection("Server=localhost;User=root;Password=root;Port=3306;database=tienda_ropa_mayorista;");
            try
            {
                MySqlCommand command = new MySqlCommand(query, conexionBD);
                conexionBD.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cantUnidadesDisponibles = reader.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conexionBD.Close();
            return cantUnidadesDisponibles;
        }

    }
}
