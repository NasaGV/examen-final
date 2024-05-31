using examen_final.Data.DataAcces;
using examen_final.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinForms = System.Windows.Forms;  // Alias para System.Windows.Forms

namespace examen_final
{

    public partial class Form2 : Form
    {
        private string[] TipoArmas = {
    "Espada recta",
    "Espada curba",
    "Arco",
    "Hacha",
    "Daga",
    "Katana",
    "Espadon",
    "Baculo",
    "Escudo"
    };
        private string[] Escalado = { "S", "A", "B", "C", "D", "E", };
        private ArmasER conexion;
        public Form2()   
        {
            InitializeComponent();
            conexion = new ArmasER();
           
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            DataTable armas = conexion.LeerArmas(); 
            dataGridView1.DataSource = armas; 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxTipo.Items.AddRange(TipoArmas);
            comboBoxFuerza.Items.AddRange(Escalado);
            comboBoxDestreza.Items.AddRange(Escalado);

            ConfigurarComboBox(comboBoxTipo);
            ConfigurarComboBox(comboBoxFuerza);
            ConfigurarComboBox(comboBoxDestreza);
        }

        private void ConfigurarComboBox(WinForms.ComboBox comboBox)
        {
            comboBox.DropDownStyle = WinForms.ComboBoxStyle.DropDownList;
            comboBox.BackColor = Color.Black;
            comboBox.ForeColor = Color.White;
            comboBox.FlatStyle = WinForms.FlatStyle.Flat;
            
        }


        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(textBoxID.Text);
                string nombre = textBoxNombre.Text;
                string tipo = comboBoxTipo.Text;
                int dañoFisico = int.Parse(textBoxDañoFisico.Text);
                int dañoMagico = int.Parse(textBoxDañoMagico.Text);
                float peso = float.Parse(textBoxPeso.Text);
                string escaladoFuerza = comboBoxFuerza.Text;
                string escaladoDestreza = comboBoxDestreza.Text;
                string descripcion = textBoxDescripcion.Text;


                DialogResult result = MessageBox.Show("¿Estas seguro de querer actualizar esta arma?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ArmasModels armaActualizada = new ArmasModels
                    {
                        Id = id,
                        Nombre = nombre,
                        Tipo = tipo,
                        DañoFisico = dañoFisico,
                        DañoMagico = dañoMagico,
                        Peso = peso,
                        EscaladoFuerza = escaladoFuerza,
                        EscaladoDestreza = escaladoDestreza,
                        Descripcion = descripcion
                    };

                    // Llamar al metodo ActualizarArma de la clase ArmasER para actualizar el registro en la base de datos
                    conexion.ActualizarArma(armaActualizada);

                    MessageBox.Show("El registro se actualizo correctamente. :D ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarDatos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al actualizar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarCampos()
        {
            textBoxNombre.Clear();
            comboBoxTipo.SelectedIndex = -1;
            textBoxDañoFisico.Clear();
            textBoxDañoMagico.Clear();
            textBoxPeso.Clear();
            comboBoxFuerza.SelectedIndex= -1;
            comboBoxDestreza.SelectedIndex = -1;
            textBoxDescripcion.Clear();
        }

        //Boton Crear
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Estas seguro de crear este nuevo registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Obtener los valores de los campos
                    string nombre = textBoxNombre.Text;
                    string tipo = comboBoxTipo.SelectedItem?.ToString();
                    int dañoFisico = int.Parse(textBoxDañoFisico.Text);
                    int dañoMagico = int.Parse(textBoxDañoMagico.Text);
                    float peso = float.Parse(textBoxPeso.Text);
                    string escaladoFuerza = comboBoxFuerza.SelectedItem?.ToString();
                    string escaladoDestreza = comboBoxDestreza.SelectedItem?.ToString();
                    string descripcion = textBoxDescripcion.Text;

                    // Verificar que todos los campos necesarios esten completos
                    if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(escaladoFuerza) || string.IsNullOrEmpty(escaladoDestreza))
                    {
                        MessageBox.Show("Por favor, complete todos los campos.🙂🙂", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Crear un nuevo objeto ArmasModels 
                    ArmasModels nuevaArma = new ArmasModels
                    {
                        Nombre = nombre,
                        Tipo = tipo,
                        DañoFisico = dañoFisico,
                        DañoMagico = dañoMagico,
                        Peso = peso,
                        EscaladoFuerza = escaladoFuerza,
                        EscaladoDestreza = escaladoDestreza,
                        Descripcion = descripcion
                    };

                    // Llamar al metodo Insertar de la clase ArmasER para insertar el nuevo registro
                    conexion.Insertar(nuevaArma);

                    // Actualizar los datos en el DataGridView
                    CargarDatos();

                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo falló al crear el nuevo registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxID.Text, out int id))
                {
                    ArmasER armasER = new ArmasER();

                    // Llama al metodo BuscarPorId 
                    ArmasModels armaEncontrado = armasER.BuscarPorId(id);

                    // Verifica si se encontro un arma con el ID especificado
                    if (armaEncontrado != null)
                    {
                        textBoxNombre.Text = armaEncontrado.Nombre;
                        comboBoxTipo.Text = armaEncontrado.Tipo;
                        textBoxDañoFisico.Text = armaEncontrado.DañoFisico.ToString();
                        textBoxDañoMagico.Text = armaEncontrado.DañoMagico.ToString();
                        textBoxPeso.Text = armaEncontrado.Peso.ToString();
                        comboBoxFuerza.Text = armaEncontrado.EscaladoFuerza;
                        comboBoxDestreza.Text = armaEncontrado.EscaladoDestreza;
                        textBoxDescripcion.Text = armaEncontrado.Descripcion;

              
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("ID");
                        dataTable.Columns.Add("Nombre");
                        dataTable.Columns.Add("Tipo");
                        dataTable.Columns.Add("DañoFisico");
                        dataTable.Columns.Add("DañoMagico");
                        dataTable.Columns.Add("Peso");
                        dataTable.Columns.Add("EscaladoFuerza");
                        dataTable.Columns.Add("EscaladoDestreza");
                        dataTable.Columns.Add("Descripcion");

                        DataRow row = dataTable.NewRow();
                        row["ID"] = armaEncontrado.Id;
                        row["Nombre"] = armaEncontrado.Nombre;
                        row["Tipo"] = armaEncontrado.Tipo;
                        row["DañoFisico"] = armaEncontrado.DañoFisico;
                        row["DañoMagico"] = armaEncontrado.DañoMagico;
                        row["Peso"] = armaEncontrado.Peso;
                        row["EscaladoFuerza"] = armaEncontrado.EscaladoFuerza;
                        row["EscaladoDestreza"] = armaEncontrado.EscaladoDestreza;
                        row["Descripcion"] = armaEncontrado.Descripcion;
                        dataTable.Rows.Add(row);

                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No se encontro un arma con el ID especificado.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un ID valido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonElimiar_Click(object sender, EventArgs e)
        {
            try
            {              
                if (int.TryParse(textBoxID.Text, out int id))
                {                    
                    DialogResult result = MessageBox.Show("¿Estas seguro de eliminar este registro? 🙀🙀🙀", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                   
                    if (result == DialogResult.Yes)
                    {
                        // Llamar al metodo EliminarArma de la clase ArmasER 
                        conexion.EliminarArma(id);

                        // Actualizar los datos en el DataGridView
                        CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al limpiar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}
