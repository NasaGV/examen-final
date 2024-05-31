using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using examen_final.Models;

namespace examen_final.Data.DataAcces
{
    internal class ArmasER
    {
        private string connectionString = "server=localhost;Database=bd_universidad;Uid=root;Pwd=Z3ldaMeteor";
        MySqlConnection connection;

        public ArmasER()
        {
            connection = new MySqlConnection(connectionString);
        }

        public DataTable LeerArmas()
        {
            DataTable armas = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Armas";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(armas);
                    }
                }
            }

            return armas;
        }

        public void Insertar(ArmasModels arma)
        {
            try
            {
                string query = "INSERT INTO Armas (Nombre, Tipo, DañoFisico, DañoMagico, Peso, EscaladoFuerza, EscaladoDestreza, Descripcion) " +
                               "VALUES (@Nombre, @Tipo, @DañoFisico, @DañoMagico, @Peso, @EscaladoFuerza, @EscaladoDestreza, @Descripcion)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", arma.Nombre);
                cmd.Parameters.AddWithValue("@Tipo", arma.Tipo);
                cmd.Parameters.AddWithValue("@DañoFisico", arma.DañoFisico);
                cmd.Parameters.AddWithValue("@DañoMagico", arma.DañoMagico);
                cmd.Parameters.AddWithValue("@Peso", arma.Peso);
                cmd.Parameters.AddWithValue("@EscaladoFuerza", arma.EscaladoFuerza);
                cmd.Parameters.AddWithValue("@EscaladoDestreza", arma.EscaladoDestreza);
                cmd.Parameters.AddWithValue("@Descripcion", arma.Descripcion);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void ActualizarArma(ArmasModels arma)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE Armas SET Nombre = @Nombre, Tipo = @Tipo, DañoFisico = @DañoFisico, DañoMagico = @DañoMagico, Peso = @Peso, EscaladoFuerza = @EscaladoFuerza, EscaladoDestreza = @EscaladoDestreza, Descripcion = @Descripcion WHERE Id = @Id";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", arma.Id);
                        cmd.Parameters.AddWithValue("@Nombre", arma.Nombre);
                        cmd.Parameters.AddWithValue("@Tipo", arma.Tipo);
                        cmd.Parameters.AddWithValue("@DañoFisico", arma.DañoFisico);
                        cmd.Parameters.AddWithValue("@DañoMagico", arma.DañoMagico);
                        cmd.Parameters.AddWithValue("@Peso", arma.Peso);
                        cmd.Parameters.AddWithValue("@EscaladoFuerza", arma.EscaladoFuerza);
                        cmd.Parameters.AddWithValue("@EscaladoDestreza", arma.EscaladoDestreza);
                        cmd.Parameters.AddWithValue("@Descripcion", arma.Descripcion);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void EliminarArma(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM Armas WHERE Id = @Id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        int mensaje = cmd.ExecuteNonQuery();
                        if (mensaje == 0)
                        {
                            MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                        }
                        else
                        {
                            MessageBox.Show("El arma fue eliminada correctamente.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message);
            }
        }

        public ArmasModels BuscarPorId(int id)
        {
            ArmasModels arma = null;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Armas WHERE Id = @Id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                arma = new ArmasModels
                                {
                                    Id = reader.GetInt32("Id"),
                                    Nombre = reader.GetString("Nombre"),
                                    Tipo = reader.GetString("Tipo"),
                                    DañoFisico = reader.GetInt32("DañoFisico"),
                                    DañoMagico = reader.GetInt32("DañoMagico"),
                                    Peso = reader.GetFloat("Peso"),
                                    EscaladoFuerza = reader.GetString("EscaladoFuerza"),
                                    EscaladoDestreza = reader.GetString("EscaladoDestreza"),
                                    Descripcion = reader.GetString("Descripcion")
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar por ID: " + ex.Message);
            }

            return arma;
        }
    }
}
