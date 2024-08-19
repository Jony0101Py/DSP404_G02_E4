namespace Parte_2_Uso_De_Matriz_De_3x3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtEdad = new TextBox();
            txtInfo = new TextBox();
            cbtipoinfo = new ComboBox();
            lblEdad = new Label();
            lbldig_info = new Label();
            lbltipo_info = new Label();
            gbMantenimiento = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btAgregar = new Button();
            gbMatriz = new GroupBox();
            dgdatos = new DataGridView();
            groupBox1.SuspendLayout();
            gbMantenimiento.SuspendLayout();
            gbMatriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgdatos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(cbtipoinfo);
            groupBox1.Controls.Add(lblEdad);
            groupBox1.Controls.Add(lbldig_info);
            groupBox1.Controls.Add(lbltipo_info);
            groupBox1.Location = new Point(27, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 132);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(45, 94);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(79, 23);
            txtEdad.TabIndex = 5;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(130, 65);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(152, 23);
            txtInfo.TabIndex = 4;
            txtInfo.KeyPress += txtInfo_KeyPress;
            // 
            // cbtipoinfo
            // 
            cbtipoinfo.FormattingEnabled = true;
            cbtipoinfo.Items.AddRange(new object[] { "Nombre ", "Apellido" });
            cbtipoinfo.Location = new Point(126, 26);
            cbtipoinfo.Name = "cbtipoinfo";
            cbtipoinfo.Size = new Size(156, 23);
            cbtipoinfo.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(6, 99);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // lbldig_info
            // 
            lbldig_info.AutoSize = true;
            lbldig_info.Location = new Point(6, 64);
            lbldig_info.Name = "lbldig_info";
            lbldig_info.Size = new Size(118, 15);
            lbldig_info.TabIndex = 1;
            lbldig_info.Text = "Digite la informacion";
            // 
            // lbltipo_info
            // 
            lbltipo_info.AutoSize = true;
            lbltipo_info.Location = new Point(6, 29);
            lbltipo_info.Name = "lbltipo_info";
            lbltipo_info.Size = new Size(114, 15);
            lbltipo_info.TabIndex = 0;
            lbltipo_info.Text = "Tipo de informacion";
            // 
            // gbMantenimiento
            // 
            gbMantenimiento.Controls.Add(button5);
            gbMantenimiento.Controls.Add(button4);
            gbMantenimiento.Controls.Add(button3);
            gbMantenimiento.Controls.Add(button2);
            gbMantenimiento.Controls.Add(btAgregar);
            gbMantenimiento.Location = new Point(421, 26);
            gbMantenimiento.Name = "gbMantenimiento";
            gbMantenimiento.Size = new Size(313, 132);
            gbMantenimiento.TabIndex = 1;
            gbMantenimiento.TabStop = false;
            gbMantenimiento.Text = "Mantenimientos";
            // 
            // button5
            // 
            button5.BackColor = Color.Fuchsia;
            button5.Location = new Point(26, 95);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Location = new Point(174, 60);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Promedio";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(26, 60);
            button3.Name = "button3";
            button3.Size = new Size(102, 23);
            button3.TabIndex = 2;
            button3.Text = "Limpiar Matriz";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(174, 25);
            button2.Name = "button2";
            button2.Size = new Size(102, 23);
            button2.TabIndex = 1;
            button2.Text = "Mostrar Matriz";
            button2.UseVisualStyleBackColor = false;
            // 
            // btAgregar
            // 
            btAgregar.BackColor = Color.Red;
            btAgregar.ForeColor = Color.Black;
            btAgregar.Location = new Point(26, 26);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(75, 23);
            btAgregar.TabIndex = 0;
            btAgregar.Text = "&Agregar";
            btAgregar.UseVisualStyleBackColor = false;
            btAgregar.Click += btAgregar_Click;
            // 
            // gbMatriz
            // 
            gbMatriz.Controls.Add(dgdatos);
            gbMatriz.Location = new Point(27, 182);
            gbMatriz.Name = "gbMatriz";
            gbMatriz.Size = new Size(761, 256);
            gbMatriz.TabIndex = 2;
            gbMatriz.TabStop = false;
            gbMatriz.Text = "Matriz";
            // 
            // dgdatos
            // 
            dgdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdatos.Location = new Point(6, 39);
            dgdatos.Name = "dgdatos";
            dgdatos.Size = new Size(749, 184);
            dgdatos.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(gbMatriz);
            Controls.Add(gbMantenimiento);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Formulario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbMantenimiento.ResumeLayout(false);
            gbMatriz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgdatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblEdad;
        private Label lbldig_info;
        private Label lbltipo_info;
        private GroupBox gbMantenimiento;
        private TextBox txtEdad;
        private TextBox txtInfo;
        private ComboBox cbtipoinfo;
        private Button btAgregar;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private GroupBox gbMatriz;
        private DataGridView dgdatos;
    }
}
