namespace Cines
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            btnVentas = new Button();
            LblCine = new Label();
            btnConsultas = new Button();
            btnReportes = new Button();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            soporteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.Red;
            btnVentas.BackgroundImageLayout = ImageLayout.Zoom;
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.FromArgb(255, 255, 254);
            btnVentas.Location = new Point(12, 122);
            btnVentas.Name = "btnVentas";
            btnVentas.RightToLeft = RightToLeft.No;
            btnVentas.Size = new Size(776, 85);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // LblCine
            // 
            LblCine.AutoSize = true;
            LblCine.BackColor = Color.Black;
            LblCine.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblCine.ForeColor = Color.White;
            LblCine.ImageAlign = ContentAlignment.TopCenter;
            LblCine.Location = new Point(282, 54);
            LblCine.Name = "LblCine";
            LblCine.Size = new Size(236, 44);
            LblCine.TabIndex = 1;
            LblCine.Text = "CINES HOYTS";
            LblCine.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnConsultas
            // 
            btnConsultas.BackColor = Color.Red;
            btnConsultas.BackgroundImageLayout = ImageLayout.Zoom;
            btnConsultas.Cursor = Cursors.Hand;
            btnConsultas.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultas.ForeColor = Color.FromArgb(255, 255, 254);
            btnConsultas.Location = new Point(12, 230);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.RightToLeft = RightToLeft.No;
            btnConsultas.Size = new Size(776, 85);
            btnConsultas.TabIndex = 2;
            btnConsultas.Text = "Consultas";
            btnConsultas.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.Red;
            btnReportes.BackgroundImageLayout = ImageLayout.Zoom;
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnReportes.ForeColor = Color.FromArgb(255, 255, 254);
            btnReportes.Location = new Point(12, 340);
            btnReportes.Name = "btnReportes";
            btnReportes.RightToLeft = RightToLeft.No;
            btnReportes.Size = new Size(776, 85);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, soporteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(127, 20);
            soporteToolStripMenuItem.Text = "A Cerca de Nosotros";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReportes);
            Controls.Add(btnConsultas);
            Controls.Add(LblCine);
            Controls.Add(btnVentas);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FrmPrincipal";
            Text = "Pagina Principal";
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVentas;
        private Label LblCine;
        private Button btnConsultas;
        private Button btnReportes;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem soporteToolStripMenuItem;
    }
}