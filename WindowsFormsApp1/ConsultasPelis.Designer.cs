namespace WindowsFormsApp1
{
    partial class ConsultasPelis
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
            this.buscador = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listaDatos = new System.Windows.Forms.DataGridView();
            this.desplegable = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.listaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // buscador
            // 
            this.buscador.Location = new System.Drawing.Point(342, 53);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(395, 20);
            this.buscador.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // listaDatos
            // 
            this.listaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDatos.Location = new System.Drawing.Point(12, 101);
            this.listaDatos.Name = "listaDatos";
            this.listaDatos.Size = new System.Drawing.Size(876, 348);
            this.listaDatos.TabIndex = 3;
            // 
            // desplegable
            // 
            this.desplegable.FormattingEnabled = true;
            this.desplegable.Location = new System.Drawing.Point(12, 51);
            this.desplegable.Name = "desplegable";
            this.desplegable.Size = new System.Drawing.Size(285, 21);
            this.desplegable.TabIndex = 4;
            // 
            // ConsultasPelis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 461);
            this.Controls.Add(this.desplegable);
            this.Controls.Add(this.listaDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscador);
            this.Name = "ConsultasPelis";
            this.Text = "ConsultasPelis";
            ((System.ComponentModel.ISupportInitialize)(this.listaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox buscador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView listaDatos;
        private System.Windows.Forms.ComboBox desplegable;
    }
}