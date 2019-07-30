namespace Multiberso
{
    partial class Multiberso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multiberso));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIndicador = new System.Windows.Forms.TextBox();
            this.txtIndicadorMin = new System.Windows.Forms.TextBox();
            this.txtIndicadorMax = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAceptarIndicador = new System.Windows.Forms.Button();
            this.btnEliminarIndicador = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.comboParametros = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvParametros = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIndicadores = new System.Windows.Forms.DataGridView();
            this.Indicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicadores)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PARAMETROS";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // txtParam
            // 
            this.txtParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParam.Location = new System.Drawing.Point(65, 53);
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(617, 20);
            this.txtParam.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "INDICADORES";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor Min.:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Valor Max. :";
            // 
            // txtIndicador
            // 
            this.txtIndicador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIndicador.Location = new System.Drawing.Point(63, 261);
            this.txtIndicador.Name = "txtIndicador";
            this.txtIndicador.Size = new System.Drawing.Size(617, 20);
            this.txtIndicador.TabIndex = 10;
            // 
            // txtIndicadorMin
            // 
            this.txtIndicadorMin.Location = new System.Drawing.Point(73, 287);
            this.txtIndicadorMin.Name = "txtIndicadorMin";
            this.txtIndicadorMin.Size = new System.Drawing.Size(101, 20);
            this.txtIndicadorMin.TabIndex = 11;
            this.txtIndicadorMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIndicadorMin_KeyPress);
            // 
            // txtIndicadorMax
            // 
            this.txtIndicadorMax.Location = new System.Drawing.Point(249, 287);
            this.txtIndicadorMax.Name = "txtIndicadorMax";
            this.txtIndicadorMax.Size = new System.Drawing.Size(104, 20);
            this.txtIndicadorMax.TabIndex = 12;
            this.txtIndicadorMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIndicadorMax_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(688, 50);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(688, 79);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnAceptarIndicador
            // 
            this.btnAceptarIndicador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptarIndicador.Location = new System.Drawing.Point(686, 260);
            this.btnAceptarIndicador.Name = "btnAceptarIndicador";
            this.btnAceptarIndicador.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarIndicador.TabIndex = 14;
            this.btnAceptarIndicador.Text = "Aceptar";
            this.btnAceptarIndicador.UseVisualStyleBackColor = true;
            this.btnAceptarIndicador.Click += new System.EventHandler(this.BtnAceptarIndicador_Click);
            // 
            // btnEliminarIndicador
            // 
            this.btnEliminarIndicador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarIndicador.Location = new System.Drawing.Point(686, 290);
            this.btnEliminarIndicador.Name = "btnEliminarIndicador";
            this.btnEliminarIndicador.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarIndicador.TabIndex = 16;
            this.btnEliminarIndicador.Text = "Eliminar";
            this.btnEliminarIndicador.UseVisualStyleBackColor = true;
            this.btnEliminarIndicador.Click += new System.EventHandler(this.BtnEliminarIndicador_Click);
            // 
            // btnGraficar
            // 
            this.btnGraficar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGraficar.Location = new System.Drawing.Point(350, 422);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(413, 23);
            this.btnGraficar.TabIndex = 17;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.BtnGraficar_Click);
            // 
            // comboParametros
            // 
            this.comboParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboParametros.FormattingEnabled = true;
            this.comboParametros.Location = new System.Drawing.Point(420, 286);
            this.comboParametros.Name = "comboParametros";
            this.comboParametros.Size = new System.Drawing.Size(260, 21);
            this.comboParametros.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Parametro";
            // 
            // dgvParametros
            // 
            this.dgvParametros.AllowUserToAddRows = false;
            this.dgvParametros.AllowUserToDeleteRows = false;
            this.dgvParametros.AllowUserToOrderColumns = true;
            this.dgvParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParametros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvParametros.Location = new System.Drawing.Point(12, 79);
            this.dgvParametros.Name = "dgvParametros";
            this.dgvParametros.ReadOnly = true;
            this.dgvParametros.Size = new System.Drawing.Size(670, 163);
            this.dgvParametros.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Parametro";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dgvIndicadores
            // 
            this.dgvIndicadores.AllowUserToAddRows = false;
            this.dgvIndicadores.AllowUserToDeleteRows = false;
            this.dgvIndicadores.AllowUserToOrderColumns = true;
            this.dgvIndicadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIndicadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndicadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indicador,
            this.Minimo,
            this.Maximo,
            this.Parametro});
            this.dgvIndicadores.Location = new System.Drawing.Point(12, 313);
            this.dgvIndicadores.Name = "dgvIndicadores";
            this.dgvIndicadores.Size = new System.Drawing.Size(670, 103);
            this.dgvIndicadores.TabIndex = 15;
            // 
            // Indicador
            // 
            this.Indicador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.Indicador.DefaultCellStyle = dataGridViewCellStyle1;
            this.Indicador.HeaderText = "Indicador";
            this.Indicador.Name = "Indicador";
            this.Indicador.ReadOnly = true;
            // 
            // Minimo
            // 
            this.Minimo.HeaderText = "Minimo";
            this.Minimo.Name = "Minimo";
            this.Minimo.ReadOnly = true;
            // 
            // Maximo
            // 
            this.Maximo.HeaderText = "Maximo";
            this.Maximo.Name = "Maximo";
            this.Maximo.ReadOnly = true;
            // 
            // Parametro
            // 
            this.Parametro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.Parametro.DefaultCellStyle = dataGridViewCellStyle2;
            this.Parametro.HeaderText = "Parametro";
            this.Parametro.Name = "Parametro";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // Multiberso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 457);
            this.Controls.Add(this.dgvIndicadores);
            this.Controls.Add(this.dgvParametros);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboParametros);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.btnEliminarIndicador);
            this.Controls.Add(this.btnAceptarIndicador);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtIndicadorMax);
            this.Controls.Add(this.txtIndicadorMin);
            this.Controls.Add(this.txtIndicador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Multiberso";
            this.Text = "MULTIBERSO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndicadores)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIndicador;
        private System.Windows.Forms.TextBox txtIndicadorMin;
        private System.Windows.Forms.TextBox txtIndicadorMax;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAceptarIndicador;
        private System.Windows.Forms.Button btnEliminarIndicador;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.ComboBox comboParametros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvParametros;
        private System.Windows.Forms.DataGridView dgvIndicadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indicador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parametro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

