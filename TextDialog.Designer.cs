namespace Multiberso
{
    partial class TextDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextDialog));
            this.txtResult = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.checkBoxInvertir = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 60);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(394, 20);
            this.txtResult.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(331, 96);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "Aceptar";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 13);
            this.lblText.TabIndex = 4;
            // 
            // checkBoxInvertir
            // 
            this.checkBoxInvertir.AutoSize = true;
            this.checkBoxInvertir.Location = new System.Drawing.Point(15, 86);
            this.checkBoxInvertir.Name = "checkBoxInvertir";
            this.checkBoxInvertir.Size = new System.Drawing.Size(229, 17);
            this.checkBoxInvertir.TabIndex = 1;
            this.checkBoxInvertir.Text = "Formula = Escala - (Valor * Escala)/Maximo";
            this.checkBoxInvertir.UseVisualStyleBackColor = true;
            this.checkBoxInvertir.CheckStateChanged += new System.EventHandler(this.CheckBoxInvertir_CheckStateChanged);
            // 
            // TextDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 131);
            this.Controls.Add(this.checkBoxInvertir);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.txtResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextDialog";
            this.Text = "TextDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtResult;
        public System.Windows.Forms.Button OK;
        public System.Windows.Forms.Label lblText;
        public System.Windows.Forms.CheckBox checkBoxInvertir;
    }
}