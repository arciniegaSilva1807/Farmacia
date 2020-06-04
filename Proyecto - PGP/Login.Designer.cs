namespace Proyecto___PGP
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IconoFarmacia = new System.Windows.Forms.PictureBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_contraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AnimacionIcono = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_minizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoFarmacia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.AnimacionIcono.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Farmacia";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IconoFarmacia);
            this.AnimacionIcono.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 502);
            this.panel1.TabIndex = 1;
            // 
            // IconoFarmacia
            // 
            this.AnimacionIcono.SetDecoration(this.IconoFarmacia, BunifuAnimatorNS.DecorationType.None);
            this.IconoFarmacia.Image = global::Proyecto___PGP.Properties.Resources.Icono_Login;
            this.IconoFarmacia.Location = new System.Drawing.Point(104, 179);
            this.IconoFarmacia.Name = "IconoFarmacia";
            this.IconoFarmacia.Size = new System.Drawing.Size(120, 124);
            this.IconoFarmacia.TabIndex = 1;
            this.IconoFarmacia.TabStop = false;
            // 
            // btn_ingresar
            // 
            this.AnimacionIcono.SetDecoration(this.btn_ingresar, BunifuAnimatorNS.DecorationType.None);
            this.btn_ingresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_ingresar.Location = new System.Drawing.Point(341, 335);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(279, 43);
            this.btn_ingresar.TabIndex = 15;
            this.btn_ingresar.TabStop = false;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.AnimacionIcono.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(493, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Paseo Gómez Palacio 2020";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AnimacionIcono.SetDecoration(this.txt_usuario, BunifuAnimatorNS.DecorationType.None);
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_usuario.HintForeColor = System.Drawing.Color.Empty;
            this.txt_usuario.HintText = "";
            this.txt_usuario.isPassword = false;
            this.txt_usuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.txt_usuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_usuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.txt_usuario.LineThickness = 3;
            this.txt_usuario.Location = new System.Drawing.Point(370, 195);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(250, 33);
            this.txt_usuario.TabIndex = 17;
            this.txt_usuario.TabStop = false;
            this.txt_usuario.Text = "Usuario";
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AnimacionIcono.SetDecoration(this.txt_contraseña, BunifuAnimatorNS.DecorationType.None);
            this.txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_contraseña.HintForeColor = System.Drawing.Color.Empty;
            this.txt_contraseña.HintText = "";
            this.txt_contraseña.isPassword = true;
            this.txt_contraseña.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.txt_contraseña.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_contraseña.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.txt_contraseña.LineThickness = 3;
            this.txt_contraseña.Location = new System.Drawing.Point(370, 250);
            this.txt_contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(250, 33);
            this.txt_contraseña.TabIndex = 18;
            this.txt_contraseña.TabStop = false;
            this.txt_contraseña.Text = "Contaseña";
            this.txt_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AnimacionIcono
            // 
            this.AnimacionIcono.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.AnimacionIcono.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.AnimacionIcono.DefaultAnimation = animation2;
            // 
            // pictureBox3
            // 
            this.AnimacionIcono.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::Proyecto___PGP.Properties.Resources.Contraseña;
            this.pictureBox3.Location = new System.Drawing.Point(338, 260);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.AnimacionIcono.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Proyecto___PGP.Properties.Resources.Usuario;
            this.pictureBox1.Location = new System.Drawing.Point(340, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.AnimacionIcono.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::Proyecto___PGP.Properties.Resources.Usuario_Icono;
            this.pictureBox2.Location = new System.Drawing.Point(454, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 72);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // btn_minizar
            // 
            this.AnimacionIcono.SetDecoration(this.btn_minizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_minizar.FlatAppearance.BorderSize = 0;
            this.btn_minizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minizar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minizar.ForeColor = System.Drawing.Color.Silver;
            this.btn_minizar.Image = global::Proyecto___PGP.Properties.Resources.Minimizar_login;
            this.btn_minizar.Location = new System.Drawing.Point(581, 7);
            this.btn_minizar.Name = "btn_minizar";
            this.btn_minizar.Size = new System.Drawing.Size(39, 32);
            this.btn_minizar.TabIndex = 12;
            this.btn_minizar.TabStop = false;
            this.btn_minizar.Text = " ";
            this.btn_minizar.UseVisualStyleBackColor = true;
            this.btn_minizar.Click += new System.EventHandler(this.btn_minizar_Click);
            // 
            // btn_cerrar
            // 
            this.AnimacionIcono.SetDecoration(this.btn_cerrar, BunifuAnimatorNS.DecorationType.None);
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Image = global::Proyecto___PGP.Properties.Resources.Cerrar_login;
            this.btn_cerrar.Location = new System.Drawing.Point(624, 7);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(39, 32);
            this.btn_cerrar.TabIndex = 11;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Text = " ";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 502);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_minizar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.panel1);
            this.AnimacionIcono.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoFarmacia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox IconoFarmacia;
        private System.Windows.Forms.Panel panel1;
        private BunifuAnimatorNS.BunifuTransition AnimacionIcono;
        private System.Windows.Forms.Button btn_minizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_usuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_contraseña;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}