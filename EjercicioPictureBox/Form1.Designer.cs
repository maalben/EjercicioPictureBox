namespace EjercicioPictureBox
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
            this.ptbimagen1 = new System.Windows.Forms.PictureBox();
            this.ptbimagen4 = new System.Windows.Forms.PictureBox();
            this.ptbimagen2 = new System.Windows.Forms.PictureBox();
            this.ptbimagen3 = new System.Windows.Forms.PictureBox();
            this.ptbimagen5 = new System.Windows.Forms.PictureBox();
            this.btnocultar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.txtimagen = new System.Windows.Forms.TextBox();
            this.btntodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimagen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimagen4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimagen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimagen3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimagen5)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbimagen1
            // 
            this.ptbimagen1.Image = global::EjercicioPictureBox.Properties.Resources.arrozcaribe;
            this.ptbimagen1.Location = new System.Drawing.Point(12, 12);
            this.ptbimagen1.Name = "ptbimagen1";
            this.ptbimagen1.Size = new System.Drawing.Size(176, 181);
            this.ptbimagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbimagen1.TabIndex = 0;
            this.ptbimagen1.TabStop = false;
            this.ptbimagen1.DoubleClick += new System.EventHandler(this.ptbimagen1_DoubleClick);
            // 
            // ptbimagen4
            // 
            this.ptbimagen4.Image = global::EjercicioPictureBox.Properties.Resources.bimbo;
            this.ptbimagen4.Location = new System.Drawing.Point(12, 199);
            this.ptbimagen4.Name = "ptbimagen4";
            this.ptbimagen4.Size = new System.Drawing.Size(244, 160);
            this.ptbimagen4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbimagen4.TabIndex = 1;
            this.ptbimagen4.TabStop = false;
            // 
            // ptbimagen2
            // 
            this.ptbimagen2.Image = global::EjercicioPictureBox.Properties.Resources.cocacola;
            this.ptbimagen2.Location = new System.Drawing.Point(194, 12);
            this.ptbimagen2.Name = "ptbimagen2";
            this.ptbimagen2.Size = new System.Drawing.Size(270, 181);
            this.ptbimagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbimagen2.TabIndex = 2;
            this.ptbimagen2.TabStop = false;
            // 
            // ptbimagen3
            // 
            this.ptbimagen3.Image = global::EjercicioPictureBox.Properties.Resources.maltaleona;
            this.ptbimagen3.Location = new System.Drawing.Point(470, 12);
            this.ptbimagen3.Name = "ptbimagen3";
            this.ptbimagen3.Size = new System.Drawing.Size(162, 181);
            this.ptbimagen3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbimagen3.TabIndex = 3;
            this.ptbimagen3.TabStop = false;
            // 
            // ptbimagen5
            // 
            this.ptbimagen5.Image = global::EjercicioPictureBox.Properties.Resources.supermercadocaribe;
            this.ptbimagen5.Location = new System.Drawing.Point(262, 199);
            this.ptbimagen5.Name = "ptbimagen5";
            this.ptbimagen5.Size = new System.Drawing.Size(202, 160);
            this.ptbimagen5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbimagen5.TabIndex = 4;
            this.ptbimagen5.TabStop = false;
            // 
            // btnocultar
            // 
            this.btnocultar.Location = new System.Drawing.Point(133, 408);
            this.btnocultar.Name = "btnocultar";
            this.btnocultar.Size = new System.Drawing.Size(137, 39);
            this.btnocultar.TabIndex = 5;
            this.btnocultar.Text = "Ocultar";
            this.btnocultar.UseVisualStyleBackColor = true;
            this.btnocultar.Click += new System.EventHandler(this.btnocultar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(132, 451);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(138, 37);
            this.btnmostrar.TabIndex = 6;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // txtimagen
            // 
            this.txtimagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimagen.Location = new System.Drawing.Point(287, 408);
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.Size = new System.Drawing.Size(100, 80);
            this.txtimagen.TabIndex = 0;
            // 
            // btntodos
            // 
            this.btntodos.Location = new System.Drawing.Point(133, 494);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(137, 39);
            this.btntodos.TabIndex = 7;
            this.btntodos.Text = "Mostrar Todos";
            this.btntodos.UseVisualStyleBackColor = true;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 545);
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.txtimagen);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btnocultar);
            this.Controls.Add(this.ptbimagen5);
            this.Controls.Add(this.ptbimagen3);
            this.Controls.Add(this.ptbimagen2);
            this.Controls.Add(this.ptbimagen4);
            this.Controls.Add(this.ptbimagen1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbimagen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimagen4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimagen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimagen3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimagen5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbimagen1;
        private System.Windows.Forms.PictureBox ptbimagen4;
        private System.Windows.Forms.PictureBox ptbimagen2;
        private System.Windows.Forms.PictureBox ptbimagen3;
        private System.Windows.Forms.PictureBox ptbimagen5;
        private System.Windows.Forms.Button btnocultar;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.TextBox txtimagen;
        private System.Windows.Forms.Button btntodos;
    }
}

