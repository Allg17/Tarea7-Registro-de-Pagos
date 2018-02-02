namespace Inscripcion
{
    partial class Contactos
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
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.PersonasdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PersonasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(116, 44);
            this.CriteriotextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(211, 20);
            this.CriteriotextBox.TabIndex = 27;
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Items.AddRange(new object[] {
            "Nombre",
            "EstudianteId"});
            this.FiltrarcomboBox.Location = new System.Drawing.Point(21, 44);
            this.FiltrarcomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(92, 21);
            this.FiltrarcomboBox.TabIndex = 26;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(334, 81);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(74, 45);
            this.Buscarbutton.TabIndex = 28;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // PersonasdataGridView
            // 
            this.PersonasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonasdataGridView.Location = new System.Drawing.Point(21, 81);
            this.PersonasdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.PersonasdataGridView.Name = "PersonasdataGridView";
            this.PersonasdataGridView.RowTemplate.Height = 24;
            this.PersonasdataGridView.Size = new System.Drawing.Size(293, 145);
            this.PersonasdataGridView.TabIndex = 29;
            // 
            // Contactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 272);
            this.Controls.Add(this.PersonasdataGridView);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Name = "Contactos";
            this.Text = "Contactos";
            ((System.ComponentModel.ISupportInitialize)(this.PersonasdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DataGridView PersonasdataGridView;
    }
}