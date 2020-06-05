namespace Proyecto___PGP
{
    partial class Recetas
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
            this.Nfolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nid_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nid_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nid_emisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nid_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nfecha_emision = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Nfolio,
            this.Nid_cliente,
            this.Nid_producto,
            this.Nid_emisor,
            this.Nid_medicamento,
            this.Nfecha_emision});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(64, 38);
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
            this.dataGridView1.TabIndex = 23;
            // 
            // Nfolio
            // 
            this.Nfolio.HeaderText = "Folio";
            this.Nfolio.Name = "Nfolio";
            this.Nfolio.ReadOnly = true;
            // 
            // Nid_cliente
            // 
            this.Nid_cliente.HeaderText = "ID Cliente";
            this.Nid_cliente.Name = "Nid_cliente";
            this.Nid_cliente.ReadOnly = true;
            // 
            // Nid_producto
            // 
            this.Nid_producto.HeaderText = "ID Producto";
            this.Nid_producto.Name = "Nid_producto";
            this.Nid_producto.ReadOnly = true;
            // 
            // Nid_emisor
            // 
            this.Nid_emisor.HeaderText = "Emisor";
            this.Nid_emisor.Name = "Nid_emisor";
            this.Nid_emisor.ReadOnly = true;
            // 
            // Nid_medicamento
            // 
            this.Nid_medicamento.HeaderText = "ID Medicamento";
            this.Nid_medicamento.Name = "Nid_medicamento";
            this.Nid_medicamento.ReadOnly = true;
            // 
            // Nfecha_emision
            // 
            this.Nfecha_emision.HeaderText = "Fecha de emision";
            this.Nfecha_emision.Name = "Nfecha_emision";
            this.Nfecha_emision.ReadOnly = true;
            // 
            // Recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 572);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Recetas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nfolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nid_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nid_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nid_emisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nid_medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nfecha_emision;
    }
}