namespace Proyecto___PGP
{
    partial class Contenedor
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contenedor));
            this.label1 = new System.Windows.Forms.Label();
            this.panel_barra = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Indicador = new System.Windows.Forms.Panel();
            this.panel_navegacion = new System.Windows.Forms.Panel();
            this.btn_clientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_inicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_empleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AnimarIndicador = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btn_receta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_domicilio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_datos_generales_clientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_submenu1 = new System.Windows.Forms.Panel();
            this.panel_submenu2 = new System.Windows.Forms.Panel();
            this.btn_datos_personales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_datos_generales_empleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_maximizar = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.panel_barra.SuspendLayout();
            this.panel_navegacion.SuspendLayout();
            this.panel_submenu1.SuspendLayout();
            this.panel_submenu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.AnimarIndicador.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario2020";
            // 
            // panel_barra
            // 
            this.panel_barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.panel_barra.Controls.Add(this.btn_restaurar);
            this.panel_barra.Controls.Add(this.panel2);
            this.panel_barra.Controls.Add(this.pictureBox1);
            this.panel_barra.Controls.Add(this.label3);
            this.panel_barra.Controls.Add(this.label1);
            this.panel_barra.Controls.Add(this.label2);
            this.panel_barra.Controls.Add(this.btn_maximizar);
            this.panel_barra.Controls.Add(this.btn_minimizar);
            this.panel_barra.Controls.Add(this.btn_cerrar);
            this.AnimarIndicador.SetDecoration(this.panel_barra, BunifuAnimatorNS.DecorationType.None);
            this.panel_barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barra.Location = new System.Drawing.Point(0, 0);
            this.panel_barra.Name = "panel_barra";
            this.panel_barra.Size = new System.Drawing.Size(1086, 125);
            this.panel_barra.TabIndex = 1;
            this.panel_barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.AnimarIndicador.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(93, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 3);
            this.panel2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.AnimarIndicador.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(980, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "07:00 p.m";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.AnimarIndicador.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(866, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "03 de junio de 2020";
            // 
            // Indicador
            // 
            this.Indicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.AnimarIndicador.SetDecoration(this.Indicador, BunifuAnimatorNS.DecorationType.None);
            this.Indicador.Location = new System.Drawing.Point(26, 61);
            this.Indicador.Name = "Indicador";
            this.Indicador.Size = new System.Drawing.Size(114, 3);
            this.Indicador.TabIndex = 20;
            // 
            // panel_navegacion
            // 
            this.panel_navegacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_navegacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_navegacion.Controls.Add(this.btn_clientes);
            this.panel_navegacion.Controls.Add(this.btn_inicio);
            this.panel_navegacion.Controls.Add(this.btn_empleados);
            this.panel_navegacion.Controls.Add(this.Indicador);
            this.AnimarIndicador.SetDecoration(this.panel_navegacion, BunifuAnimatorNS.DecorationType.None);
            this.panel_navegacion.Location = new System.Drawing.Point(0, 105);
            this.panel_navegacion.Name = "panel_navegacion";
            this.panel_navegacion.Size = new System.Drawing.Size(1086, 65);
            this.panel_navegacion.TabIndex = 21;
            // 
            // btn_clientes
            // 
            this.btn_clientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_clientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clientes.BorderRadius = 0;
            this.btn_clientes.ButtonText = "Clientes";
            this.btn_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimarIndicador.SetDecoration(this.btn_clientes, BunifuAnimatorNS.DecorationType.None);
            this.btn_clientes.DisabledColor = System.Drawing.Color.Gray;
            this.btn_clientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_clientes.Iconimage = null;
            this.btn_clientes.Iconimage_right = null;
            this.btn_clientes.Iconimage_right_Selected = null;
            this.btn_clientes.Iconimage_Selected = null;
            this.btn_clientes.IconMarginLeft = 0;
            this.btn_clientes.IconMarginRight = 0;
            this.btn_clientes.IconRightVisible = true;
            this.btn_clientes.IconRightZoom = 0D;
            this.btn_clientes.IconVisible = true;
            this.btn_clientes.IconZoom = 90D;
            this.btn_clientes.IsTab = false;
            this.btn_clientes.Location = new System.Drawing.Point(159, 25);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_clientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_clientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_clientes.selected = false;
            this.btn_clientes.Size = new System.Drawing.Size(114, 31);
            this.btn_clientes.TabIndex = 26;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clientes.Textcolor = System.Drawing.Color.Gray;
            this.btn_clientes.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click_1);
            // 
            // btn_inicio
            // 
            this.btn_inicio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_inicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inicio.BorderRadius = 0;
            this.btn_inicio.ButtonText = "Inicio";
            this.btn_inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimarIndicador.SetDecoration(this.btn_inicio, BunifuAnimatorNS.DecorationType.None);
            this.btn_inicio.DisabledColor = System.Drawing.Color.Gray;
            this.btn_inicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_inicio.Iconimage = null;
            this.btn_inicio.Iconimage_right = null;
            this.btn_inicio.Iconimage_right_Selected = null;
            this.btn_inicio.Iconimage_Selected = null;
            this.btn_inicio.IconMarginLeft = 0;
            this.btn_inicio.IconMarginRight = 0;
            this.btn_inicio.IconRightVisible = true;
            this.btn_inicio.IconRightZoom = 0D;
            this.btn_inicio.IconVisible = true;
            this.btn_inicio.IconZoom = 90D;
            this.btn_inicio.IsTab = false;
            this.btn_inicio.Location = new System.Drawing.Point(26, 25);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_inicio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_inicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_inicio.selected = false;
            this.btn_inicio.Size = new System.Drawing.Size(114, 31);
            this.btn_inicio.TabIndex = 25;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_inicio.Textcolor = System.Drawing.Color.Gray;
            this.btn_inicio.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_empleados
            // 
            this.btn_empleados.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_empleados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_empleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_empleados.BorderRadius = 0;
            this.btn_empleados.ButtonText = "Empleados";
            this.btn_empleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimarIndicador.SetDecoration(this.btn_empleados, BunifuAnimatorNS.DecorationType.None);
            this.btn_empleados.DisabledColor = System.Drawing.Color.Gray;
            this.btn_empleados.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_empleados.Iconimage = null;
            this.btn_empleados.Iconimage_right = null;
            this.btn_empleados.Iconimage_right_Selected = null;
            this.btn_empleados.Iconimage_Selected = null;
            this.btn_empleados.IconMarginLeft = 0;
            this.btn_empleados.IconMarginRight = 0;
            this.btn_empleados.IconRightVisible = true;
            this.btn_empleados.IconRightZoom = 0D;
            this.btn_empleados.IconVisible = true;
            this.btn_empleados.IconZoom = 90D;
            this.btn_empleados.IsTab = false;
            this.btn_empleados.Location = new System.Drawing.Point(292, 25);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_empleados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_empleados.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_empleados.selected = false;
            this.btn_empleados.Size = new System.Drawing.Size(114, 31);
            this.btn_empleados.TabIndex = 24;
            this.btn_empleados.Text = "Empleados";
            this.btn_empleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_empleados.Textcolor = System.Drawing.Color.Gray;
            this.btn_empleados.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // AnimarIndicador
            // 
            this.AnimarIndicador.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimarIndicador.Cursor = null;
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
            animation2.TransparencyCoeff = 0F;
            this.AnimarIndicador.DefaultAnimation = animation2;
            // 
            // btn_receta
            // 
            this.btn_receta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_receta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_receta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_receta.BorderRadius = 0;
            this.btn_receta.ButtonText = "            Receta";
            this.btn_receta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimarIndicador.SetDecoration(this.btn_receta, BunifuAnimatorNS.DecorationType.None);
            this.btn_receta.DisabledColor = System.Drawing.Color.Gray;
            this.btn_receta.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_receta.Iconimage = null;
            this.btn_receta.Iconimage_right = null;
            this.btn_receta.Iconimage_right_Selected = null;
            this.btn_receta.Iconimage_Selected = null;
            this.btn_receta.IconMarginLeft = 0;
            this.btn_receta.IconMarginRight = 0;
            this.btn_receta.IconRightVisible = true;
            this.btn_receta.IconRightZoom = 0D;
            this.btn_receta.IconVisible = true;
            this.btn_receta.IconZoom = 90D;
            this.btn_receta.IsTab = false;
            this.btn_receta.Location = new System.Drawing.Point(0, 8);
            this.btn_receta.Name = "btn_receta";
            this.btn_receta.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_receta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_receta.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_receta.selected = false;
            this.btn_receta.Size = new System.Drawing.Size(197, 25);
            this.btn_receta.TabIndex = 30;
            this.btn_receta.Text = "            Receta";
            this.btn_receta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_receta.Textcolor = System.Drawing.Color.Gray;
            this.btn_receta.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_receta.Click += new System.EventHandler(this.btn_receta_Click);
            // 
            // btn_domicilio
            // 
            this.btn_domicilio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_domicilio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_domicilio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_domicilio.BorderRadius = 0;
            this.btn_domicilio.ButtonText = "            Domicilio";
            this.btn_domicilio.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.AnimarIndicador.SetDecoration(this.btn_domicilio, BunifuAnimatorNS.DecorationType.None);
            this.btn_domicilio.DisabledColor = System.Drawing.Color.Gray;
            this.btn_domicilio.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_domicilio.Iconimage = null;
            this.btn_domicilio.Iconimage_right = null;
            this.btn_domicilio.Iconimage_right_Selected = null;
            this.btn_domicilio.Iconimage_Selected = null;
            this.btn_domicilio.IconMarginLeft = 0;
            this.btn_domicilio.IconMarginRight = 0;
            this.btn_domicilio.IconRightVisible = true;
            this.btn_domicilio.IconRightZoom = 0D;
            this.btn_domicilio.IconVisible = true;
            this.btn_domicilio.IconZoom = 90D;
            this.btn_domicilio.IsTab = false;
            this.btn_domicilio.Location = new System.Drawing.Point(0, 39);
            this.btn_domicilio.Name = "btn_domicilio";
            this.btn_domicilio.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_domicilio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_domicilio.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_domicilio.selected = false;
            this.btn_domicilio.Size = new System.Drawing.Size(197, 25);
            this.btn_domicilio.TabIndex = 31;
            this.btn_domicilio.Text = "            Domicilio";
            this.btn_domicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_domicilio.Textcolor = System.Drawing.Color.Gray;
            this.btn_domicilio.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_domicilio.Click += new System.EventHandler(this.btn_domicilio_Click);
            // 
            // btn_datos_generales_clientes
            // 
            this.btn_datos_generales_clientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_datos_generales_clientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_datos_generales_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_datos_generales_clientes.BorderRadius = 0;
            this.btn_datos_generales_clientes.ButtonText = "            Datos generales";
            this.btn_datos_generales_clientes.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.AnimarIndicador.SetDecoration(this.btn_datos_generales_clientes, BunifuAnimatorNS.DecorationType.None);
            this.btn_datos_generales_clientes.DisabledColor = System.Drawing.Color.Gray;
            this.btn_datos_generales_clientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_datos_generales_clientes.Iconimage = null;
            this.btn_datos_generales_clientes.Iconimage_right = null;
            this.btn_datos_generales_clientes.Iconimage_right_Selected = null;
            this.btn_datos_generales_clientes.Iconimage_Selected = null;
            this.btn_datos_generales_clientes.IconMarginLeft = 0;
            this.btn_datos_generales_clientes.IconMarginRight = 0;
            this.btn_datos_generales_clientes.IconRightVisible = true;
            this.btn_datos_generales_clientes.IconRightZoom = 0D;
            this.btn_datos_generales_clientes.IconVisible = true;
            this.btn_datos_generales_clientes.IconZoom = 90D;
            this.btn_datos_generales_clientes.IsTab = false;
            this.btn_datos_generales_clientes.Location = new System.Drawing.Point(0, 70);
            this.btn_datos_generales_clientes.Name = "btn_datos_generales_clientes";
            this.btn_datos_generales_clientes.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_datos_generales_clientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_datos_generales_clientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_datos_generales_clientes.selected = false;
            this.btn_datos_generales_clientes.Size = new System.Drawing.Size(197, 27);
            this.btn_datos_generales_clientes.TabIndex = 32;
            this.btn_datos_generales_clientes.Text = "            Datos generales";
            this.btn_datos_generales_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_datos_generales_clientes.Textcolor = System.Drawing.Color.Gray;
            this.btn_datos_generales_clientes.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datos_generales_clientes.Click += new System.EventHandler(this.btn_datos_generales_clientes_Click);
            // 
            // panel_submenu1
            // 
            this.panel_submenu1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_submenu1.Controls.Add(this.btn_receta);
            this.panel_submenu1.Controls.Add(this.btn_datos_generales_clientes);
            this.panel_submenu1.Controls.Add(this.btn_domicilio);
            this.AnimarIndicador.SetDecoration(this.panel_submenu1, BunifuAnimatorNS.DecorationType.None);
            this.panel_submenu1.Location = new System.Drawing.Point(159, 170);
            this.panel_submenu1.Name = "panel_submenu1";
            this.panel_submenu1.Size = new System.Drawing.Size(197, 106);
            this.panel_submenu1.TabIndex = 33;
            // 
            // panel_submenu2
            // 
            this.panel_submenu2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_submenu2.Controls.Add(this.btn_datos_personales);
            this.panel_submenu2.Controls.Add(this.btn_datos_generales_empleados);
            this.AnimarIndicador.SetDecoration(this.panel_submenu2, BunifuAnimatorNS.DecorationType.None);
            this.panel_submenu2.Location = new System.Drawing.Point(290, 170);
            this.panel_submenu2.Name = "panel_submenu2";
            this.panel_submenu2.Size = new System.Drawing.Size(197, 75);
            this.panel_submenu2.TabIndex = 34;
            // 
            // btn_datos_personales
            // 
            this.btn_datos_personales.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_datos_personales.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_datos_personales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_datos_personales.BorderRadius = 0;
            this.btn_datos_personales.ButtonText = "          Datos personales";
            this.btn_datos_personales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimarIndicador.SetDecoration(this.btn_datos_personales, BunifuAnimatorNS.DecorationType.None);
            this.btn_datos_personales.DisabledColor = System.Drawing.Color.Gray;
            this.btn_datos_personales.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_datos_personales.Iconimage = null;
            this.btn_datos_personales.Iconimage_right = null;
            this.btn_datos_personales.Iconimage_right_Selected = null;
            this.btn_datos_personales.Iconimage_Selected = null;
            this.btn_datos_personales.IconMarginLeft = 0;
            this.btn_datos_personales.IconMarginRight = 0;
            this.btn_datos_personales.IconRightVisible = true;
            this.btn_datos_personales.IconRightZoom = 0D;
            this.btn_datos_personales.IconVisible = true;
            this.btn_datos_personales.IconZoom = 90D;
            this.btn_datos_personales.IsTab = false;
            this.btn_datos_personales.Location = new System.Drawing.Point(0, 8);
            this.btn_datos_personales.Name = "btn_datos_personales";
            this.btn_datos_personales.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_datos_personales.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_datos_personales.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_datos_personales.selected = false;
            this.btn_datos_personales.Size = new System.Drawing.Size(197, 25);
            this.btn_datos_personales.TabIndex = 30;
            this.btn_datos_personales.Text = "          Datos personales";
            this.btn_datos_personales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_datos_personales.Textcolor = System.Drawing.Color.Gray;
            this.btn_datos_personales.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datos_personales.Click += new System.EventHandler(this.btn_datos_personales_Click);
            // 
            // btn_datos_generales_empleados
            // 
            this.btn_datos_generales_empleados.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_datos_generales_empleados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_datos_generales_empleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_datos_generales_empleados.BorderRadius = 0;
            this.btn_datos_generales_empleados.ButtonText = "          Datos generales";
            this.btn_datos_generales_empleados.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.AnimarIndicador.SetDecoration(this.btn_datos_generales_empleados, BunifuAnimatorNS.DecorationType.None);
            this.btn_datos_generales_empleados.DisabledColor = System.Drawing.Color.Gray;
            this.btn_datos_generales_empleados.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_datos_generales_empleados.Iconimage = null;
            this.btn_datos_generales_empleados.Iconimage_right = null;
            this.btn_datos_generales_empleados.Iconimage_right_Selected = null;
            this.btn_datos_generales_empleados.Iconimage_Selected = null;
            this.btn_datos_generales_empleados.IconMarginLeft = 0;
            this.btn_datos_generales_empleados.IconMarginRight = 0;
            this.btn_datos_generales_empleados.IconRightVisible = true;
            this.btn_datos_generales_empleados.IconRightZoom = 0D;
            this.btn_datos_generales_empleados.IconVisible = true;
            this.btn_datos_generales_empleados.IconZoom = 90D;
            this.btn_datos_generales_empleados.IsTab = false;
            this.btn_datos_generales_empleados.Location = new System.Drawing.Point(0, 39);
            this.btn_datos_generales_empleados.Name = "btn_datos_generales_empleados";
            this.btn_datos_generales_empleados.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_datos_generales_empleados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(171)))), ((int)(((byte)(147)))));
            this.btn_datos_generales_empleados.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_datos_generales_empleados.selected = false;
            this.btn_datos_generales_empleados.Size = new System.Drawing.Size(197, 27);
            this.btn_datos_generales_empleados.TabIndex = 32;
            this.btn_datos_generales_empleados.Text = "          Datos generales";
            this.btn_datos_generales_empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_datos_generales_empleados.Textcolor = System.Drawing.Color.Gray;
            this.btn_datos_generales_empleados.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datos_generales_empleados.Click += new System.EventHandler(this.btn_datos_generales_empleados_Click);
            // 
            // panel_contenedor
            // 
            this.AnimarIndicador.SetDecoration(this.panel_contenedor, BunifuAnimatorNS.DecorationType.None);
            this.panel_contenedor.Location = new System.Drawing.Point(0, 170);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1086, 573);
            this.panel_contenedor.TabIndex = 36;
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimarIndicador.SetDecoration(this.btn_restaurar, BunifuAnimatorNS.DecorationType.None);
            this.btn_restaurar.FlatAppearance.BorderSize = 0;
            this.btn_restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restaurar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restaurar.ForeColor = System.Drawing.Color.Silver;
            this.btn_restaurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_restaurar.Image")));
            this.btn_restaurar.Location = new System.Drawing.Point(1000, 0);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(39, 32);
            this.btn_restaurar.TabIndex = 20;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Text = "                                                                           ";
            this.btn_restaurar.UseVisualStyleBackColor = true;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // pictureBox1
            // 
            this.AnimarIndicador.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 54);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimarIndicador.SetDecoration(this.btn_maximizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_maximizar.FlatAppearance.BorderSize = 0;
            this.btn_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximizar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_maximizar.ForeColor = System.Drawing.Color.Silver;
            this.btn_maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximizar.Image")));
            this.btn_maximizar.Location = new System.Drawing.Point(1000, 0);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(39, 32);
            this.btn_maximizar.TabIndex = 15;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Text = " ";
            this.btn_maximizar.UseVisualStyleBackColor = true;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimarIndicador.SetDecoration(this.btn_minimizar, BunifuAnimatorNS.DecorationType.None);
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizar.ForeColor = System.Drawing.Color.Silver;
            this.btn_minimizar.Image = global::Proyecto___PGP.Properties.Resources.Minimizar_Principal;
            this.btn_minimizar.Location = new System.Drawing.Point(955, 0);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(39, 32);
            this.btn_minimizar.TabIndex = 14;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Text = " ";
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimarIndicador.SetDecoration(this.btn_cerrar, BunifuAnimatorNS.DecorationType.None);
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Image = global::Proyecto___PGP.Properties.Resources.Cerrar_Principal;
            this.btn_cerrar.Location = new System.Drawing.Point(1046, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(39, 32);
            this.btn_cerrar.TabIndex = 13;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Text = " ";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 743);
            this.Controls.Add(this.panel_barra);
            this.Controls.Add(this.panel_navegacion);
            this.Controls.Add(this.panel_submenu2);
            this.Controls.Add(this.panel_submenu1);
            this.Controls.Add(this.panel_contenedor);
            this.AnimarIndicador.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_barra.ResumeLayout(false);
            this.panel_barra.PerformLayout();
            this.panel_navegacion.ResumeLayout(false);
            this.panel_submenu1.ResumeLayout(false);
            this.panel_submenu2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_barra;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_maximizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Indicador;
        private System.Windows.Forms.Panel panel_navegacion;
        private Bunifu.Framework.UI.BunifuFlatButton btn_empleados;
        private Bunifu.Framework.UI.BunifuFlatButton btn_inicio;
        private BunifuAnimatorNS.BunifuTransition AnimarIndicador;
        private Bunifu.Framework.UI.BunifuFlatButton btn_receta;
        private Bunifu.Framework.UI.BunifuFlatButton btn_domicilio;
        private Bunifu.Framework.UI.BunifuFlatButton btn_datos_generales_clientes;
        private System.Windows.Forms.Panel panel_submenu1;
        private System.Windows.Forms.Panel panel_submenu2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_datos_personales;
        private Bunifu.Framework.UI.BunifuFlatButton btn_datos_generales_empleados;
        private Bunifu.Framework.UI.BunifuFlatButton btn_clientes;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Button btn_restaurar;
    }
}

