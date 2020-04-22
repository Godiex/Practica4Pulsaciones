namespace ConsoleApp1
{
    partial class ConsultarGui
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarGui));
            this.LbTitulo = new System.Windows.Forms.Label();
            this.DgvPersonas = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.LbTotalPersonas = new System.Windows.Forms.Label();
            this.LbTotalHombres = new System.Windows.Forms.Label();
            this.LbTotalMujeres = new System.Windows.Forms.Label();
            this.LbCantidadPersonas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbCantidadDeMujeres = new System.Windows.Forms.Label();
            this.CbTipoDeConsulta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbTitulo.Location = new System.Drawing.Point(163, 0);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(616, 77);
            this.LbTitulo.TabIndex = 64;
            this.LbTitulo.Text = "Consultar Personas";
            // 
            // DgvPersonas
            // 
            this.DgvPersonas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPersonas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersonas.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.DgvPersonas.Location = new System.Drawing.Point(107, 188);
            this.DgvPersonas.Name = "DgvPersonas";
            this.DgvPersonas.Size = new System.Drawing.Size(647, 264);
            this.DgvPersonas.TabIndex = 65;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(595, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 70;
            this.pictureBox3.TabStop = false;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsultar.Location = new System.Drawing.Point(635, 118);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnConsultar.Size = new System.Drawing.Size(178, 45);
            this.BtnConsultar.TabIndex = 71;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // LbTotalPersonas
            // 
            this.LbTotalPersonas.AutoSize = true;
            this.LbTotalPersonas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalPersonas.Location = new System.Drawing.Point(102, 520);
            this.LbTotalPersonas.Name = "LbTotalPersonas";
            this.LbTotalPersonas.Size = new System.Drawing.Size(173, 25);
            this.LbTotalPersonas.TabIndex = 72;
            this.LbTotalPersonas.Text = "Total Personas : ";
            // 
            // LbTotalHombres
            // 
            this.LbTotalHombres.AutoSize = true;
            this.LbTotalHombres.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalHombres.Location = new System.Drawing.Point(677, 520);
            this.LbTotalHombres.Name = "LbTotalHombres";
            this.LbTotalHombres.Size = new System.Drawing.Size(173, 25);
            this.LbTotalHombres.TabIndex = 73;
            this.LbTotalHombres.Text = "Total Hombres : ";
            // 
            // LbTotalMujeres
            // 
            this.LbTotalMujeres.AutoSize = true;
            this.LbTotalMujeres.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalMujeres.Location = new System.Drawing.Point(396, 520);
            this.LbTotalMujeres.Name = "LbTotalMujeres";
            this.LbTotalMujeres.Size = new System.Drawing.Size(156, 25);
            this.LbTotalMujeres.TabIndex = 74;
            this.LbTotalMujeres.Text = "Total Mujeres :";
            // 
            // LbCantidadPersonas
            // 
            this.LbCantidadPersonas.AutoSize = true;
            this.LbCantidadPersonas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCantidadPersonas.Location = new System.Drawing.Point(281, 520);
            this.LbCantidadPersonas.Name = "LbCantidadPersonas";
            this.LbCantidadPersonas.Size = new System.Drawing.Size(0, 25);
            this.LbCantidadPersonas.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(850, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 76;
            // 
            // LbCantidadDeMujeres
            // 
            this.LbCantidadDeMujeres.AutoSize = true;
            this.LbCantidadDeMujeres.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCantidadDeMujeres.Location = new System.Drawing.Point(552, 520);
            this.LbCantidadDeMujeres.Name = "LbCantidadDeMujeres";
            this.LbCantidadDeMujeres.Size = new System.Drawing.Size(0, 25);
            this.LbCantidadDeMujeres.TabIndex = 77;
            // 
            // CbTipoDeConsulta
            // 
            this.CbTipoDeConsulta.FormattingEnabled = true;
            this.CbTipoDeConsulta.Items.AddRange(new object[] {
            "Todos",
            "Hombres",
            "Mujeres"});
            this.CbTipoDeConsulta.Location = new System.Drawing.Point(328, 142);
            this.CbTipoDeConsulta.Name = "CbTipoDeConsulta";
            this.CbTipoDeConsulta.Size = new System.Drawing.Size(150, 21);
            this.CbTipoDeConsulta.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 79;
            this.label2.Text = "Tipo Consulta :";
            // 
            // ConsultarGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1034, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbTipoDeConsulta);
            this.Controls.Add(this.LbCantidadDeMujeres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbCantidadPersonas);
            this.Controls.Add(this.LbTotalMujeres);
            this.Controls.Add(this.LbTotalHombres);
            this.Controls.Add(this.LbTotalPersonas);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.DgvPersonas);
            this.Controls.Add(this.LbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarGui";
            this.Text = "ConsultarGui";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.DataGridView DgvPersonas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label LbTotalPersonas;
        private System.Windows.Forms.Label LbTotalHombres;
        private System.Windows.Forms.Label LbTotalMujeres;
        private System.Windows.Forms.Label LbCantidadPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbCantidadDeMujeres;
        private System.Windows.Forms.ComboBox CbTipoDeConsulta;
        private System.Windows.Forms.Label label2;
    }
}