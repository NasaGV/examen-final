using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace examen_final
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer;
        public Form1()
        {
            InitializeComponent();
            PesonalizarDiseno();
            soundPlayer = new SoundPlayer("D:/Descargas/examen/Elden.wav");
        }
        private void PesonalizarDiseno() 
        { 
            panelsubmenu.Visible = false;
        }
        private void OcultarMenu ()
        {
            if (panelsubmenu.Visible == true)
                panelsubmenu.Visible = false;  
        }
        private void MostrarMenu (Panel submenu)
        {
            if(submenu.Visible == false)
            {
                OcultarMenu ();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void Media_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelsubmenu);
        }

        private void verbd_Click(object sender, EventArgs e)
        {
            OcultarMenu();
            abrirPanelHijos(new Form2());
        }

        private void editar_Click(object sender, EventArgs e)
        {
            OcultarMenu();
            abrirPanelHijos(new Form3());
        }

        private Form FormularioActivo= null;
        private void abrirPanelHijos(Form FormularioHijo)
        {
           if (FormularioActivo!= null)
               FormularioActivo.Close();
            FormularioActivo = FormularioHijo; 
            FormularioHijo.TopLevel= false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            PanelHijos.Controls.Add(FormularioHijo);
            PanelHijos.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                soundPlayer.PlayLooping(); // Reproduce la música en bucle al cargar el formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir la musica: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonReproducir_Click(object sender, EventArgs e)
        {
            try
            {
                soundPlayer.PlayLooping(); // Reproduce la música en bucle al hacer clic en el botón Reproducir
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir la musica: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPausar_Click(object sender, EventArgs e)
        {
            try
            {
                soundPlayer.Stop(); // Detiene la musica al hacer clic en el boton Detener
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al detener la musica: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

