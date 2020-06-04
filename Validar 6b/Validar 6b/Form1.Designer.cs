namespace Validar_6b
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_t = new System.Windows.Forms.TextBox();
            this.Age_t = new System.Windows.Forms.TextBox();
            this.Dir_t = new System.Windows.Forms.TextBox();
            this.Age_cbx = new System.Windows.Forms.ComboBox();
            this.Salir = new System.Windows.Forms.Button();
            this.Add_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // Name_t
            // 
            this.Name_t.Location = new System.Drawing.Point(120, 32);
            this.Name_t.Name = "Name_t";
            this.Name_t.Size = new System.Drawing.Size(265, 22);
            this.Name_t.TabIndex = 3;
            // 
            // Age_t
            // 
            this.Age_t.Location = new System.Drawing.Point(120, 102);
            this.Age_t.Name = "Age_t";
            this.Age_t.Size = new System.Drawing.Size(53, 22);
            this.Age_t.TabIndex = 4;
            // 
            // Dir_t
            // 
            this.Dir_t.Location = new System.Drawing.Point(120, 173);
            this.Dir_t.Name = "Dir_t";
            this.Dir_t.Size = new System.Drawing.Size(265, 22);
            this.Dir_t.TabIndex = 5;
            // 
            // Age_cbx
            // 
            this.Age_cbx.FormattingEnabled = true;
            this.Age_cbx.Location = new System.Drawing.Point(275, 102);
            this.Age_cbx.Name = "Age_cbx";
            this.Age_cbx.Size = new System.Drawing.Size(78, 24);
            this.Age_cbx.TabIndex = 6;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(13, 306);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 7;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            // 
            // Add_b
            // 
            this.Add_b.Location = new System.Drawing.Point(372, 306);
            this.Add_b.Name = "Add_b";
            this.Add_b.Size = new System.Drawing.Size(75, 23);
            this.Add_b.TabIndex = 8;
            this.Add_b.Text = "Agregar";
            this.Add_b.UseVisualStyleBackColor = true;
            this.Add_b.Click += new System.EventHandler(this.Add_b_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 370);
            this.Controls.Add(this.Add_b);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Age_cbx);
            this.Controls.Add(this.Dir_t);
            this.Controls.Add(this.Age_t);
            this.Controls.Add(this.Name_t);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_t;
        private System.Windows.Forms.TextBox Age_t;
        private System.Windows.Forms.TextBox Dir_t;
        private System.Windows.Forms.ComboBox Age_cbx;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Add_b;
    }
}

