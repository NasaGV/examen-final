namespace examen_final
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenuLatera = new System.Windows.Forms.Panel();
            this.panelsubmenu = new System.Windows.Forms.Panel();
            this.editar = new System.Windows.Forms.Button();
            this.verbd = new System.Windows.Forms.Button();
            this.PanelHijos = new System.Windows.Forms.Panel();
            this.buttonReproducir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Media = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPausar = new System.Windows.Forms.Button();
            this.panelMenuLatera.SuspendLayout();
            this.panelsubmenu.SuspendLayout();
            this.PanelHijos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuLatera
            // 
            this.panelMenuLatera.AutoScroll = true;
            this.panelMenuLatera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenuLatera.Controls.Add(this.panel2);
            this.panelMenuLatera.Controls.Add(this.panelsubmenu);
            this.panelMenuLatera.Controls.Add(this.Media);
            this.panelMenuLatera.Controls.Add(this.panel1);
            this.panelMenuLatera.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLatera.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLatera.Name = "panelMenuLatera";
            this.panelMenuLatera.Size = new System.Drawing.Size(205, 585);
            this.panelMenuLatera.TabIndex = 0;
            // 
            // panelsubmenu
            // 
            this.panelsubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelsubmenu.Controls.Add(this.editar);
            this.panelsubmenu.Controls.Add(this.verbd);
            this.panelsubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubmenu.Location = new System.Drawing.Point(0, 156);
            this.panelsubmenu.Name = "panelsubmenu";
            this.panelsubmenu.Size = new System.Drawing.Size(205, 82);
            this.panelsubmenu.TabIndex = 2;
            // 
            // editar
            // 
            this.editar.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.editar.Dock = System.Windows.Forms.DockStyle.Top;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editar.Location = new System.Drawing.Point(0, 40);
            this.editar.Name = "editar";
            this.editar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.editar.Size = new System.Drawing.Size(205, 40);
            this.editar.TabIndex = 1;
            this.editar.Text = "Creditos";
            this.editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // verbd
            // 
            this.verbd.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.verbd.Dock = System.Windows.Forms.DockStyle.Top;
            this.verbd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verbd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.verbd.Location = new System.Drawing.Point(0, 0);
            this.verbd.Name = "verbd";
            this.verbd.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.verbd.Size = new System.Drawing.Size(205, 40);
            this.verbd.TabIndex = 0;
            this.verbd.Text = "Ver base de datos";
            this.verbd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verbd.UseVisualStyleBackColor = true;
            this.verbd.Click += new System.EventHandler(this.verbd_Click);
            // 
            // PanelHijos
            // 
            this.PanelHijos.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PanelHijos.BackgroundImage = global::examen_final.Properties.Resources.elden1;
            this.PanelHijos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHijos.Controls.Add(this.buttonPausar);
            this.PanelHijos.Controls.Add(this.buttonReproducir);
            this.PanelHijos.Controls.Add(this.label1);
            this.PanelHijos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHijos.Location = new System.Drawing.Point(205, 0);
            this.PanelHijos.Name = "PanelHijos";
            this.PanelHijos.Size = new System.Drawing.Size(749, 585);
            this.PanelHijos.TabIndex = 1;
            // 
            // buttonReproducir
            // 
            this.buttonReproducir.BackgroundImage = global::examen_final.Properties.Resources._500_333;
            this.buttonReproducir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonReproducir.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReproducir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReproducir.Location = new System.Drawing.Point(187, 490);
            this.buttonReproducir.Name = "buttonReproducir";
            this.buttonReproducir.Size = new System.Drawing.Size(139, 43);
            this.buttonReproducir.TabIndex = 1;
            this.buttonReproducir.Text = "Reproducir";
            this.buttonReproducir.UseVisualStyleBackColor = true;
            this.buttonReproducir.Click += new System.EventHandler(this.buttonReproducir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido Tiznado ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::examen_final.Properties.Resources.f07e0655da057ab666941c4ac352042f;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 154);
            this.panel2.TabIndex = 1;
            // 
            // Media
            // 
            this.Media.BackgroundImage = global::examen_final.Properties.Resources.golden_seed_consumable_elden_ring_wiki_guide_200;
            this.Media.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Media.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Media.Dock = System.Windows.Forms.DockStyle.Top;
            this.Media.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Media.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Media.Location = new System.Drawing.Point(0, 109);
            this.Media.Name = "Media";
            this.Media.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Media.Size = new System.Drawing.Size(205, 47);
            this.Media.TabIndex = 1;
            this.Media.Text = "Menú";
            this.Media.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Media.UseVisualStyleBackColor = true;
            this.Media.Click += new System.EventHandler(this.Media_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::examen_final.Properties.Resources.Elden_Ring_Logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 109);
            this.panel1.TabIndex = 0;
            // 
            // buttonPausar
            // 
            this.buttonPausar.BackgroundImage = global::examen_final.Properties.Resources._500_333;
            this.buttonPausar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPausar.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPausar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPausar.Location = new System.Drawing.Point(413, 490);
            this.buttonPausar.Name = "buttonPausar";
            this.buttonPausar.Size = new System.Drawing.Size(139, 43);
            this.buttonPausar.TabIndex = 2;
            this.buttonPausar.Text = "Pausar";
            this.buttonPausar.UseVisualStyleBackColor = true;
            this.buttonPausar.Click += new System.EventHandler(this.buttonPausar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 585);
            this.Controls.Add(this.PanelHijos);
            this.Controls.Add(this.panelMenuLatera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenuLatera.ResumeLayout(false);
            this.panelsubmenu.ResumeLayout(false);
            this.PanelHijos.ResumeLayout(false);
            this.PanelHijos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLatera;
        private System.Windows.Forms.Button Media;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelsubmenu;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button verbd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelHijos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReproducir;
        private System.Windows.Forms.Button buttonPausar;
    }
}

