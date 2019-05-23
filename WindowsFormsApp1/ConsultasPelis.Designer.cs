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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.listaDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(778, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // listaDatos
            // 
            this.listaDatos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDatos.Location = new System.Drawing.Point(12, 101);
            this.listaDatos.Name = "listaDatos";
            this.listaDatos.Size = new System.Drawing.Size(490, 266);
            this.listaDatos.TabIndex = 3;
            // 
            // desplegable
            // 
            this.desplegable.Cursor = System.Windows.Forms.Cursors.Default;
            this.desplegable.FormattingEnabled = true;
            this.desplegable.Location = new System.Drawing.Point(12, 51);
            this.desplegable.Name = "desplegable";
            this.desplegable.Size = new System.Drawing.Size(285, 21);
            this.desplegable.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID pelicula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DNI cliente";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(73, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "reservar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(589, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(299, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "dar de alta un nuevo cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(589, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 265);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "datos reserva";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "fecha";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // ConsultasPelis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.desplegable);
            this.Controls.Add(this.listaDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscador);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ConsultasPelis";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ConsultasPelis";
            ((System.ComponentModel.ISupportInitialize)(this.listaDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox buscador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView listaDatos;
        private System.Windows.Forms.ComboBox desplegable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}