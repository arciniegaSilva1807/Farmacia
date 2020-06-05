namespace Proyecto___PGP
{
    partial class Domicilio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nid_domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nnumero_interior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nnumero_exterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ncp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ncalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nid_domicilio,
            this.Nnumero_interior,
            this.Nnumero_exterior,
            this.Ncp,
            this.Nciudad,
            this.Ncalle});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(64, 35);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(919, 497);
            this.dataGridView1.TabIndex = 25;
            // 
            // Nid_domicilio
            // 
            this.Nid_domicilio.HeaderText = "ID Domicilio";
            this.Nid_domicilio.Name = "Nid_domicilio";
            this.Nid_domicilio.ReadOnly = true;
            // 
            // Nnumero_interior
            // 
            this.Nnumero_interior.HeaderText = "Numero interior";
            this.Nnumero_interior.Name = "Nnumero_interior";
            this.Nnumero_interior.ReadOnly = true;
            // 
            // Nnumero_exterior
            // 
            this.Nnumero_exterior.HeaderText = "Numero exterior";
            this.Nnumero_exterior.Name = "Nnumero_exterior";
            this.Nnumero_exterior.ReadOnly = true;
            // 
            // Ncp
            // 
            this.Ncp.HeaderText = "Codigo postal";
            this.Ncp.Name = "Ncp";
            this.Ncp.ReadOnly = true;
            // 
            // Nciudad
            // 
            this.Nciudad.HeaderText = "Ciudad";
            this.Nciudad.Name = "Nciudad";
            this.Nciudad.ReadOnly = true;
            // 
            // Ncalle
            // 
            this.Ncalle.HeaderText = "Calle";
            this.Ncalle.Name = "Ncalle";
            this.Ncalle.ReadOnly = true;
            // 
            // Domicilio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 567);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Domicilio";
            this.Text = "Domicilio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nid_domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nnumero_interior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nnumero_exterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ncp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ncalle;
    }
}