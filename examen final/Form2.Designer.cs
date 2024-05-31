namespace examen_final
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonCargarBD = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.textBoxDañoFisico = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDañoMagico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFuerza = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDestreza = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonBuscarID = new System.Windows.Forms.Button();
            this.buttonElimiar = new System.Windows.Forms.Button();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(229, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.buttonActualizar.Location = new System.Drawing.Point(646, 121);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 41);
            this.buttonActualizar.TabIndex = 1;
            this.buttonActualizar.Text = "Actualizar Registro";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrar.BackColor = System.Drawing.Color.Red;
            this.buttonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrar.Location = new System.Drawing.Point(646, 12);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonCargarBD
            // 
            this.buttonCargarBD.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.buttonCargarBD.Location = new System.Drawing.Point(646, 83);
            this.buttonCargarBD.Name = "buttonCargarBD";
            this.buttonCargarBD.Size = new System.Drawing.Size(75, 35);
            this.buttonCargarBD.TabIndex = 3;
            this.buttonCargarBD.Text = "Cargar BD";
            this.buttonCargarBD.UseVisualStyleBackColor = true;
            this.buttonCargarBD.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCrear.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.buttonCrear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCrear.Location = new System.Drawing.Point(565, 83);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(75, 35);
            this.buttonCrear.TabIndex = 4;
            this.buttonCrear.Text = "Crear Registro";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxNombre.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxNombre.Location = new System.Drawing.Point(25, 31);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(119, 20);
            this.textBoxNombre.TabIndex = 6;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tipo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.ForeColor = System.Drawing.Color.White;
            this.Tipo.Location = new System.Drawing.Point(21, 69);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(47, 19);
            this.Tipo.TabIndex = 7;
            this.Tipo.Text = "Tipo";
            // 
            // textBoxDañoFisico
            // 
            this.textBoxDañoFisico.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxDañoFisico.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxDañoFisico.Location = new System.Drawing.Point(25, 151);
            this.textBoxDañoFisico.Name = "textBoxDañoFisico";
            this.textBoxDañoFisico.Size = new System.Drawing.Size(119, 20);
            this.textBoxDañoFisico.TabIndex = 9;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxTipo.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(25, 91);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 10;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Daño Fisico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "DañoMagico";
            // 
            // textBoxDañoMagico
            // 
            this.textBoxDañoMagico.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxDañoMagico.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxDañoMagico.Location = new System.Drawing.Point(27, 208);
            this.textBoxDañoMagico.Name = "textBoxDañoMagico";
            this.textBoxDañoMagico.Size = new System.Drawing.Size(119, 20);
            this.textBoxDañoMagico.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Escalado fuerza";
            // 
            // comboBoxFuerza
            // 
            this.comboBoxFuerza.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxFuerza.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBoxFuerza.FormattingEnabled = true;
            this.comboBoxFuerza.Location = new System.Drawing.Point(23, 334);
            this.comboBoxFuerza.Name = "comboBoxFuerza";
            this.comboBoxFuerza.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFuerza.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Escalado Destreza";
            // 
            // comboBoxDestreza
            // 
            this.comboBoxDestreza.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxDestreza.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBoxDestreza.FormattingEnabled = true;
            this.comboBoxDestreza.Location = new System.Drawing.Point(23, 390);
            this.comboBoxDestreza.Name = "comboBoxDestreza";
            this.comboBoxDestreza.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDestreza.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Descripcion";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxDescripcion.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxDescripcion.Location = new System.Drawing.Point(23, 447);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(200, 20);
            this.textBoxDescripcion.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(220, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Location = new System.Drawing.Point(224, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(408, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxID.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxID.Location = new System.Drawing.Point(402, 28);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(119, 20);
            this.textBoxID.TabIndex = 23;
            // 
            // buttonBuscarID
            // 
            this.buttonBuscarID.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.buttonBuscarID.Location = new System.Drawing.Point(565, 121);
            this.buttonBuscarID.Name = "buttonBuscarID";
            this.buttonBuscarID.Size = new System.Drawing.Size(75, 40);
            this.buttonBuscarID.TabIndex = 24;
            this.buttonBuscarID.Text = "Buscar por ID";
            this.buttonBuscarID.UseVisualStyleBackColor = true;
            this.buttonBuscarID.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonElimiar
            // 
            this.buttonElimiar.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.buttonElimiar.Location = new System.Drawing.Point(646, 168);
            this.buttonElimiar.Name = "buttonElimiar";
            this.buttonElimiar.Size = new System.Drawing.Size(75, 37);
            this.buttonElimiar.TabIndex = 25;
            this.buttonElimiar.Text = "Eliminar Registro";
            this.buttonElimiar.UseVisualStyleBackColor = true;
            this.buttonElimiar.Click += new System.EventHandler(this.buttonElimiar_Click);
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxPeso.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxPeso.Location = new System.Drawing.Point(25, 276);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(119, 20);
            this.textBoxPeso.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(23, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Peso";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.buttonLimpiar.Location = new System.Drawing.Point(565, 168);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 37);
            this.buttonLimpiar.TabIndex = 28;
            this.buttonLimpiar.Text = "Limpiar Datos";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::examen_final.Properties.Resources._1366_2000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 546);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.buttonElimiar);
            this.Controls.Add(this.buttonBuscarID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxDestreza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxFuerza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDañoMagico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.textBoxDañoFisico);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonCargarBD);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonCargarBD;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.TextBox textBoxDañoFisico;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDañoMagico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFuerza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDestreza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonBuscarID;
        private System.Windows.Forms.Button buttonElimiar;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}