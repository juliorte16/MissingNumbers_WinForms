namespace MissingNumbersApplication_JO
{
    partial class MissingNumbersForm
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
            this.LblTamañoLista1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxbList1 = new System.Windows.Forms.TextBox();
            this.TxbTamanoLista1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxbList2 = new System.Windows.Forms.TextBox();
            this.TxbTamanoLista2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMissingNumbers = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTamañoLista1
            // 
            this.LblTamañoLista1.AutoSize = true;
            this.LblTamañoLista1.Location = new System.Drawing.Point(50, 16);
            this.LblTamañoLista1.Name = "LblTamañoLista1";
            this.LblTamañoLista1.Size = new System.Drawing.Size(27, 13);
            this.LblTamañoLista1.TabIndex = 1;
            this.LblTamañoLista1.Text = "Size";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxbList1);
            this.groupBox1.Controls.Add(this.TxbTamanoLista1);
            this.groupBox1.Controls.Add(this.LblTamañoLista1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 98);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List 1";
            // 
            // TxbList1
            // 
            this.TxbList1.Location = new System.Drawing.Point(6, 45);
            this.TxbList1.Multiline = true;
            this.TxbList1.Name = "TxbList1";
            this.TxbList1.Size = new System.Drawing.Size(540, 47);
            this.TxbList1.TabIndex = 4;
            // 
            // TxbTamanoLista1
            // 
            this.TxbTamanoLista1.Location = new System.Drawing.Point(102, 16);
            this.TxbTamanoLista1.Name = "TxbTamanoLista1";
            this.TxbTamanoLista1.Size = new System.Drawing.Size(85, 20);
            this.TxbTamanoLista1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxbList2);
            this.groupBox2.Controls.Add(this.TxbTamanoLista2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 99);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List 2";
            // 
            // TxbList2
            // 
            this.TxbList2.Location = new System.Drawing.Point(6, 42);
            this.TxbList2.Multiline = true;
            this.TxbList2.Name = "TxbList2";
            this.TxbList2.Size = new System.Drawing.Size(540, 51);
            this.TxbList2.TabIndex = 4;
            // 
            // TxbTamanoLista2
            // 
            this.TxbTamanoLista2.Location = new System.Drawing.Point(102, 13);
            this.TxbTamanoLista2.Name = "TxbTamanoLista2";
            this.TxbTamanoLista2.Size = new System.Drawing.Size(85, 20);
            this.TxbTamanoLista2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size";
            // 
            // BtnMissingNumbers
            // 
            this.BtnMissingNumbers.Location = new System.Drawing.Point(6, 19);
            this.BtnMissingNumbers.Name = "BtnMissingNumbers";
            this.BtnMissingNumbers.Size = new System.Drawing.Size(110, 32);
            this.BtnMissingNumbers.TabIndex = 7;
            this.BtnMissingNumbers.Text = "Missing Numbers";
            this.BtnMissingNumbers.UseVisualStyleBackColor = true;
            this.BtnMissingNumbers.Click += new System.EventHandler(this.BtnMissingNumbers_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.BtnMissingNumbers);
            this.groupBox3.Location = new System.Drawing.Point(22, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(552, 96);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(122, 19);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(424, 72);
            this.textBox4.TabIndex = 0;
            // 
            // MissingNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 320);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MissingNumbersForm";
            this.Text = "Missing Numers Julián Ortega Orozco";
            this.Load += new System.EventHandler(this.MissingNumbersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTamañoLista1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxbList1;
        private System.Windows.Forms.TextBox TxbTamanoLista1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxbList2;
        private System.Windows.Forms.TextBox TxbTamanoLista2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMissingNumbers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

