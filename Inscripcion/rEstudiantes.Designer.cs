namespace Inscripcion
{
    partial class rEstudiantes
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
            this.Consulta = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.PersonaIdtextBox = new System.Windows.Forms.TextBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.Montolabel = new System.Windows.Forms.Label();
            this.MontonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Observacioneslabel = new System.Windows.Forms.Label();
            this.txObservacion = new System.Windows.Forms.TextBox();
            this.Modificarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Consulta
            // 
            this.Consulta.Location = new System.Drawing.Point(314, 51);
            this.Consulta.Margin = new System.Windows.Forms.Padding(2);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(64, 27);
            this.Consulta.TabIndex = 25;
            this.Consulta.Text = "Consulta";
            this.Consulta.UseVisualStyleBackColor = true;
            this.Consulta.Click += new System.EventHandler(this.Consultabutton);
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(51, 313);
            this.Nuevo.Margin = new System.Windows.Forms.Padding(2);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(86, 37);
            this.Nuevo.TabIndex = 24;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevobutto);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(221, 51);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(64, 27);
            this.Buscarbutton.TabIndex = 23;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(237, 313);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(86, 37);
            this.Eliminarbutton.TabIndex = 22;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(144, 313);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(86, 37);
            this.Guardarbutton.TabIndex = 21;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "IDEstudiante";
    
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(106, 112);
            this.NombrestextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(272, 20);
            this.NombrestextBox.TabIndex = 18;
            // 
            // PersonaIdtextBox
            // 
            this.PersonaIdtextBox.Location = new System.Drawing.Point(106, 55);
            this.PersonaIdtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PersonaIdtextBox.Name = "PersonaIdtextBox";
            this.PersonaIdtextBox.Size = new System.Drawing.Size(101, 20);
            this.PersonaIdtextBox.TabIndex = 17;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Location = new System.Drawing.Point(106, 87);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(255, 20);
            this.FechadateTimePicker.TabIndex = 26;
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(34, 93);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(37, 13);
            this.Fechalabel.TabIndex = 27;
            this.Fechalabel.Text = "Fecha";
            // 
            // Montolabel
            // 
            this.Montolabel.AutoSize = true;
            this.Montolabel.Location = new System.Drawing.Point(34, 144);
            this.Montolabel.Name = "Montolabel";
            this.Montolabel.Size = new System.Drawing.Size(37, 13);
            this.Montolabel.TabIndex = 28;
            this.Montolabel.Text = "Monto";
            // 
            // MontonumericUpDown
            // 
            this.MontonumericUpDown.DecimalPlaces = 2;
            this.MontonumericUpDown.Location = new System.Drawing.Point(106, 137);
            this.MontonumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MontonumericUpDown.Name = "MontonumericUpDown";
            this.MontonumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MontonumericUpDown.TabIndex = 29;
     
            // 
            // Observacioneslabel
            // 
            this.Observacioneslabel.AutoSize = true;
            this.Observacioneslabel.Location = new System.Drawing.Point(38, 175);
            this.Observacioneslabel.Name = "Observacioneslabel";
            this.Observacioneslabel.Size = new System.Drawing.Size(78, 13);
            this.Observacioneslabel.TabIndex = 30;
            this.Observacioneslabel.Text = "Observaciones";
            // 
            // txObservacion
            // 
            this.txObservacion.Location = new System.Drawing.Point(106, 201);
            this.txObservacion.Multiline = true;
            this.txObservacion.Name = "txObservacion";
            this.txObservacion.Size = new System.Drawing.Size(217, 95);
            this.txObservacion.TabIndex = 31;
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(327, 313);
            this.Modificarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(86, 37);
            this.Modificarbutton.TabIndex = 32;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // rEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 379);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.txObservacion);
            this.Controls.Add(this.Observacioneslabel);
            this.Controls.Add(this.MontonumericUpDown);
            this.Controls.Add(this.Montolabel);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Consulta);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombrestextBox);
            this.Controls.Add(this.PersonaIdtextBox);
            this.Name = "rEstudiantes";
            this.Text = "Registro";
  
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Consulta;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.TextBox PersonaIdtextBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label Montolabel;
        private System.Windows.Forms.NumericUpDown MontonumericUpDown;
        private System.Windows.Forms.Label Observacioneslabel;
        private System.Windows.Forms.TextBox txObservacion;
        private System.Windows.Forms.Button Modificarbutton;
    }
}

