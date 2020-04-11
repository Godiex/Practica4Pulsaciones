namespace ConsoleApp1
{
    partial class EliminacioConfirmarGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminacioConfirmarGui));
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.LbTextoCedula = new System.Windows.Forms.Label();
            this.LBNumeroDeCedula = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PbCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BntEliminar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LbRespuesta = new System.Windows.Forms.Label();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BarraSuperior.Controls.Add(this.PbCerrar);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(545, 35);
            this.BarraSuperior.TabIndex = 0;
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // LbTextoCedula
            // 
            this.LbTextoCedula.AutoSize = true;
            this.LbTextoCedula.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTextoCedula.Location = new System.Drawing.Point(12, 60);
            this.LbTextoCedula.Name = "LbTextoCedula";
            this.LbTextoCedula.Size = new System.Drawing.Size(402, 23);
            this.LbTextoCedula.TabIndex = 1;
            this.LbTextoCedula.Text = "Numero de cedula de persona a eliminar :";
            // 
            // LBNumeroDeCedula
            // 
            this.LBNumeroDeCedula.AutoSize = true;
            this.LBNumeroDeCedula.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNumeroDeCedula.Location = new System.Drawing.Point(414, 60);
            this.LBNumeroDeCedula.Name = "LBNumeroDeCedula";
            this.LBNumeroDeCedula.Size = new System.Drawing.Size(0, 23);
            this.LBNumeroDeCedula.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PbCerrar
            // 
            this.PbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("PbCerrar.Image")));
            this.PbCerrar.Location = new System.Drawing.Point(503, 5);
            this.PbCerrar.Name = "PbCerrar";
            this.PbCerrar.Size = new System.Drawing.Size(30, 30);
            this.PbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCerrar.TabIndex = 4;
            this.PbCerrar.TabStop = false;
            this.PbCerrar.Click += new System.EventHandler(this.PbCerrar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(266, 127);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // BntEliminar
            // 
            this.BntEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BntEliminar.FlatAppearance.BorderSize = 0;
            this.BntEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.BntEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BntEliminar.Location = new System.Drawing.Point(312, 127);
            this.BntEliminar.Name = "BntEliminar";
            this.BntEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BntEliminar.Size = new System.Drawing.Size(197, 45);
            this.BntEliminar.TabIndex = 28;
            this.BntEliminar.Text = "Eliminar";
            this.BntEliminar.UseVisualStyleBackColor = false;
            this.BntEliminar.Click += new System.EventHandler(this.BntEliminar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(266, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.Location = new System.Drawing.Point(312, 194);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCancelar.Size = new System.Drawing.Size(197, 45);
            this.BtnCancelar.TabIndex = 30;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LbRespuesta
            // 
            this.LbRespuesta.AutoSize = true;
            this.LbRespuesta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRespuesta.ForeColor = System.Drawing.Color.Lime;
            this.LbRespuesta.Location = new System.Drawing.Point(25, 303);
            this.LbRespuesta.Name = "LbRespuesta";
            this.LbRespuesta.Size = new System.Drawing.Size(0, 23);
            this.LbRespuesta.TabIndex = 31;
            // 
            // EliminacioConfirmarGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 335);
            this.Controls.Add(this.LbRespuesta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BntEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBNumeroDeCedula);
            this.Controls.Add(this.LbTextoCedula);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminacioConfirmarGui";
            this.Text = "EliminacioConfirmarGui";
            this.BarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label LbTextoCedula;
        private System.Windows.Forms.PictureBox PbCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Button BntEliminar;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.Label LBNumeroDeCedula;
        private System.Windows.Forms.Label LbRespuesta;
    }
}