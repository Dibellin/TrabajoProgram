namespace Cines.Presentacion
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            dateTimePicker1 = new DateTimePicker();
            lblFecha = new Label();
            lblFacturaNro = new Label();
            lblEmpleado = new Label();
            lblCliente = new Label();
            lblCantidad = new Label();
            lblDescuento = new Label();
            lblCine = new Label();
            lblPelicula = new Label();
            cboCine = new ComboBox();
            cboPelicula = new ComboBox();
            txtEmpleado = new TextBox();
            txtCliente = new TextBox();
            txtDescuento = new TextBox();
            nudCantidad = new NumericUpDown();
            btnS1 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            gpPantalla = new GroupBox();
            dataGridView1 = new DataGridView();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColCine = new DataGridViewTextBoxColumn();
            ColEmpleado = new DataGridViewTextBoxColumn();
            ColCliente = new DataGridViewTextBoxColumn();
            ColDescuento = new DataGridViewTextBoxColumn();
            ColQuitar = new DataGridViewButtonColumn();
            lblSubTotal = new Label();
            lblTotal = new Label();
            txtSubTotal = new TextBox();
            txtTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(74, 63);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(235, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.FromArgb(255, 255, 128);
            lblFecha.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(20, 69);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(48, 17);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // lblFacturaNro
            // 
            lblFacturaNro.AutoSize = true;
            lblFacturaNro.BackColor = Color.FromArgb(255, 255, 128);
            lblFacturaNro.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFacturaNro.Location = new Point(20, 34);
            lblFacturaNro.Name = "lblFacturaNro";
            lblFacturaNro.Size = new Size(126, 17);
            lblFacturaNro.TabIndex = 2;
            lblFacturaNro.Text = "Factura Numero";
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.BackColor = Color.FromArgb(255, 255, 128);
            lblEmpleado.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpleado.Location = new Point(20, 132);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(77, 17);
            lblEmpleado.TabIndex = 3;
            lblEmpleado.Text = "Empleado";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.FromArgb(255, 255, 128);
            lblCliente.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(20, 165);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(60, 17);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.FromArgb(255, 255, 128);
            lblCantidad.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(20, 198);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(140, 17);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad Asientos";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.BackColor = Color.FromArgb(255, 255, 128);
            lblDescuento.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescuento.Location = new Point(20, 228);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(85, 17);
            lblDescuento.TabIndex = 6;
            lblDescuento.Text = "Descuento";
            // 
            // lblCine
            // 
            lblCine.AutoSize = true;
            lblCine.BackColor = Color.FromArgb(255, 255, 128);
            lblCine.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCine.Location = new Point(20, 100);
            lblCine.Name = "lblCine";
            lblCine.Size = new Size(37, 17);
            lblCine.TabIndex = 7;
            lblCine.Text = "Cine";
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.BackColor = Color.FromArgb(255, 255, 128);
            lblPelicula.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPelicula.Location = new Point(20, 259);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(69, 17);
            lblPelicula.TabIndex = 8;
            lblPelicula.Text = "Pelicula";
            // 
            // cboCine
            // 
            cboCine.FormattingEnabled = true;
            cboCine.Location = new Point(74, 94);
            cboCine.Name = "cboCine";
            cboCine.Size = new Size(235, 23);
            cboCine.TabIndex = 9;
            // 
            // cboPelicula
            // 
            cboPelicula.FormattingEnabled = true;
            cboPelicula.Location = new Point(104, 253);
            cboPelicula.Name = "cboPelicula";
            cboPelicula.Size = new Size(205, 23);
            cboPelicula.TabIndex = 10;
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(116, 126);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(193, 23);
            txtEmpleado.TabIndex = 11;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(95, 159);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(214, 23);
            txtCliente.TabIndex = 12;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(116, 224);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(193, 23);
            txtDescuento.TabIndex = 13;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(166, 192);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(143, 23);
            nudCantidad.TabIndex = 14;
            // 
            // btnS1
            // 
            btnS1.BackgroundImage = Properties.Resources.silla;
            btnS1.BackgroundImageLayout = ImageLayout.Zoom;
            btnS1.Location = new Point(561, 179);
            btnS1.Name = "btnS1";
            btnS1.Size = new Size(23, 23);
            btnS1.TabIndex = 15;
            btnS1.UseVisualStyleBackColor = true;
            btnS1.Click += btnS1_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.silla;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(619, 259);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 16;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.silla;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(590, 259);
            button2.Name = "button2";
            button2.Size = new Size(23, 23);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.silla;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(561, 259);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 18;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.silla;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(735, 221);
            button4.Name = "button4";
            button4.Size = new Size(23, 23);
            button4.TabIndex = 19;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.silla;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Location = new Point(706, 221);
            button5.Name = "button5";
            button5.Size = new Size(23, 23);
            button5.TabIndex = 20;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.silla;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Location = new Point(677, 222);
            button6.Name = "button6";
            button6.Size = new Size(23, 23);
            button6.TabIndex = 21;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackgroundImage = Properties.Resources.silla;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Location = new Point(619, 221);
            button7.Name = "button7";
            button7.Size = new Size(23, 23);
            button7.TabIndex = 22;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackgroundImage = Properties.Resources.silla;
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Location = new Point(590, 221);
            button8.Name = "button8";
            button8.Size = new Size(23, 23);
            button8.TabIndex = 23;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.BackgroundImage = Properties.Resources.silla;
            button9.BackgroundImageLayout = ImageLayout.Zoom;
            button9.Location = new Point(561, 221);
            button9.Name = "button9";
            button9.Size = new Size(23, 23);
            button9.TabIndex = 24;
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.BackgroundImage = Properties.Resources.silla;
            button10.BackgroundImageLayout = ImageLayout.Zoom;
            button10.Location = new Point(735, 179);
            button10.Name = "button10";
            button10.Size = new Size(23, 23);
            button10.TabIndex = 25;
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.BackgroundImage = Properties.Resources.silla;
            button11.BackgroundImageLayout = ImageLayout.Zoom;
            button11.Location = new Point(706, 179);
            button11.Name = "button11";
            button11.Size = new Size(23, 23);
            button11.TabIndex = 26;
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.BackgroundImage = Properties.Resources.silla;
            button12.BackgroundImageLayout = ImageLayout.Zoom;
            button12.Location = new Point(677, 179);
            button12.Name = "button12";
            button12.Size = new Size(23, 23);
            button12.TabIndex = 27;
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.BackgroundImage = Properties.Resources.silla;
            button13.BackgroundImageLayout = ImageLayout.Zoom;
            button13.Location = new Point(619, 179);
            button13.Name = "button13";
            button13.Size = new Size(23, 23);
            button13.TabIndex = 28;
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.BackgroundImage = Properties.Resources.silla;
            button14.BackgroundImageLayout = ImageLayout.Zoom;
            button14.Location = new Point(590, 179);
            button14.Name = "button14";
            button14.Size = new Size(23, 23);
            button14.TabIndex = 29;
            button14.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.BackgroundImage = Properties.Resources.silla;
            button16.BackgroundImageLayout = ImageLayout.Zoom;
            button16.Location = new Point(735, 259);
            button16.Name = "button16";
            button16.Size = new Size(23, 23);
            button16.TabIndex = 31;
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.BackgroundImage = Properties.Resources.silla;
            button17.BackgroundImageLayout = ImageLayout.Zoom;
            button17.Location = new Point(706, 259);
            button17.Name = "button17";
            button17.Size = new Size(23, 23);
            button17.TabIndex = 32;
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.BackgroundImage = Properties.Resources.silla;
            button18.BackgroundImageLayout = ImageLayout.Zoom;
            button18.Location = new Point(677, 259);
            button18.Name = "button18";
            button18.Size = new Size(23, 23);
            button18.TabIndex = 33;
            button18.UseVisualStyleBackColor = true;
            // 
            // gpPantalla
            // 
            gpPantalla.BackColor = Color.Yellow;
            gpPantalla.BackgroundImage = Properties.Resources.pantalla_de_cine;
            gpPantalla.BackgroundImageLayout = ImageLayout.Zoom;
            gpPantalla.Location = new Point(556, 63);
            gpPantalla.Name = "gpPantalla";
            gpPantalla.Size = new Size(202, 110);
            gpPantalla.TabIndex = 34;
            gpPantalla.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColPelicula, ColCantidad, ColCine, ColEmpleado, ColCliente, ColDescuento, ColQuitar });
            dataGridView1.Location = new Point(20, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(828, 183);
            dataGridView1.TabIndex = 35;
            // 
            // ColPelicula
            // 
            ColPelicula.HeaderText = "Pelicula";
            ColPelicula.Name = "ColPelicula";
            ColPelicula.ReadOnly = true;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.Name = "ColCantidad";
            ColCantidad.ReadOnly = true;
            // 
            // ColCine
            // 
            ColCine.HeaderText = "Cine";
            ColCine.Name = "ColCine";
            ColCine.ReadOnly = true;
            // 
            // ColEmpleado
            // 
            ColEmpleado.HeaderText = "Empleado";
            ColEmpleado.Name = "ColEmpleado";
            ColEmpleado.ReadOnly = true;
            // 
            // ColCliente
            // 
            ColCliente.HeaderText = "Cliente";
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            // 
            // ColDescuento
            // 
            ColDescuento.HeaderText = "Descuento";
            ColDescuento.Name = "ColDescuento";
            ColDescuento.ReadOnly = true;
            // 
            // ColQuitar
            // 
            ColQuitar.HeaderText = "QUITAR";
            ColQuitar.Name = "ColQuitar";
            ColQuitar.ReadOnly = true;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.BackColor = Color.FromArgb(255, 255, 128);
            lblSubTotal.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubTotal.Location = new Point(677, 501);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(77, 17);
            lblSubTotal.TabIndex = 36;
            lblSubTotal.Text = "SubTotal";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(255, 255, 128);
            lblTotal.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(677, 531);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(51, 17);
            lblTotal.TabIndex = 37;
            lblTotal.Text = "Total";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(763, 495);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(85, 23);
            txtSubTotal.TabIndex = 38;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(735, 525);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(113, 23);
            txtTotal.TabIndex = 39;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gr_stocks_q8P8YoR6erg_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(917, 557);
            Controls.Add(txtTotal);
            Controls.Add(txtSubTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblSubTotal);
            Controls.Add(dataGridView1);
            Controls.Add(gpPantalla);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnS1);
            Controls.Add(nudCantidad);
            Controls.Add(txtDescuento);
            Controls.Add(txtCliente);
            Controls.Add(txtEmpleado);
            Controls.Add(cboPelicula);
            Controls.Add(cboCine);
            Controls.Add(lblPelicula);
            Controls.Add(lblCine);
            Controls.Add(lblDescuento);
            Controls.Add(lblCantidad);
            Controls.Add(lblCliente);
            Controls.Add(lblEmpleado);
            Controls.Add(lblFacturaNro);
            Controls.Add(lblFecha);
            Controls.Add(dateTimePicker1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "FrmVentas";
            Text = "Ventas";
            WindowState = FormWindowState.Maximized;
            Load += FrmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label lblFecha;
        private Label lblFacturaNro;
        private Label lblEmpleado;
        private Label lblCliente;
        private Label lblCantidad;
        private Label lblDescuento;
        private Label lblCine;
        private Label lblPelicula;
        private ComboBox cboCine;
        private ComboBox cboPelicula;
        private TextBox txtEmpleado;
        private TextBox txtCliente;
        private TextBox txtDescuento;
        private NumericUpDown nudCantidad;
        private Button btnS1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button16;
        private Button button17;
        private Button button18;
        private GroupBox gpPantalla;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColCine;
        private DataGridViewTextBoxColumn ColEmpleado;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColDescuento;
        private DataGridViewButtonColumn ColQuitar;
        private Label lblSubTotal;
        private Label lblTotal;
        private TextBox txtSubTotal;
        private TextBox txtTotal;
    }
}