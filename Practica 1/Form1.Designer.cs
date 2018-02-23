namespace Practica_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.iListNivel = new System.Windows.Forms.ImageList(this.components);
            this.iListSensores = new System.Windows.Forms.ImageList(this.components);
            this.iListDireccion = new System.Windows.Forms.ImageList(this.components);
            this.lblSensores = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblDirecciones = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaDown = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnNuevaFecha = new System.Windows.Forms.Button();
            this.txtFechaNew = new System.Windows.Forms.TextBox();
            this.lblx = new System.Windows.Forms.Label();
            this.pBoxSensores2 = new System.Windows.Forms.PictureBox();
            this.pBoxSensores = new System.Windows.Forms.PictureBox();
            this.pBoxNivel = new System.Windows.Forms.PictureBox();
            this.pBoxDireccion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSensores2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSensores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDireccion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(86, 27);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(44, 13);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Entrada";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(136, 24);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(263, 28);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(100, 20);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click_1);
            // 
            // iListNivel
            // 
            this.iListNivel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iListNivel.ImageStream")));
            this.iListNivel.TransparentColor = System.Drawing.Color.Transparent;
            this.iListNivel.Images.SetKeyName(0, "vacio.PNG");
            this.iListNivel.Images.SetKeyName(1, "nivel medio.PNG");
            this.iListNivel.Images.SetKeyName(2, "lleno.PNG");
            this.iListNivel.Images.SetKeyName(3, "llenando.PNG");
            // 
            // iListSensores
            // 
            this.iListSensores.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iListSensores.ImageStream")));
            this.iListSensores.TransparentColor = System.Drawing.Color.Transparent;
            this.iListSensores.Images.SetKeyName(0, "sensor1A.png");
            this.iListSensores.Images.SetKeyName(1, "sensor1E.png");
            // 
            // iListDireccion
            // 
            this.iListDireccion.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iListDireccion.ImageSize = new System.Drawing.Size(16, 16);
            this.iListDireccion.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblSensores
            // 
            this.lblSensores.AutoSize = true;
            this.lblSensores.Location = new System.Drawing.Point(183, 80);
            this.lblSensores.Name = "lblSensores";
            this.lblSensores.Size = new System.Drawing.Size(51, 13);
            this.lblSensores.TabIndex = 3;
            this.lblSensores.Text = "Sensores";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(27, 80);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(31, 13);
            this.lblNivel.TabIndex = 4;
            this.lblNivel.Text = "Nivel";
            // 
            // lblDirecciones
            // 
            this.lblDirecciones.AutoSize = true;
            this.lblDirecciones.Location = new System.Drawing.Point(478, 80);
            this.lblDirecciones.Name = "lblDirecciones";
            this.lblDirecciones.Size = new System.Drawing.Size(63, 13);
            this.lblDirecciones.TabIndex = 5;
            this.lblDirecciones.Text = "Direcciones";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(119, 248);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(76, 13);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha Lectura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "_________________________________________________________________________________" +
    "_________________";
            // 
            // lblFechaDown
            // 
            this.lblFechaDown.AutoSize = true;
            this.lblFechaDown.Location = new System.Drawing.Point(119, 309);
            this.lblFechaDown.Name = "lblFechaDown";
            this.lblFechaDown.Size = new System.Drawing.Size(37, 13);
            this.lblFechaDown.TabIndex = 12;
            this.lblFechaDown.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(173, 309);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 13;
            // 
            // btnNuevaFecha
            // 
            this.btnNuevaFecha.Location = new System.Drawing.Point(186, 335);
            this.btnNuevaFecha.Name = "btnNuevaFecha";
            this.btnNuevaFecha.Size = new System.Drawing.Size(75, 23);
            this.btnNuevaFecha.TabIndex = 14;
            this.btnNuevaFecha.Text = "Ajustar Fecha";
            this.btnNuevaFecha.UseVisualStyleBackColor = true;
            this.btnNuevaFecha.Click += new System.EventHandler(this.btnNuevaFecha_Click_1);
            // 
            // txtFechaNew
            // 
            this.txtFechaNew.Location = new System.Drawing.Point(173, 371);
            this.txtFechaNew.Name = "txtFechaNew";
            this.txtFechaNew.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNew.TabIndex = 15;
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(397, 35);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(16, 13);
            this.lblx.TabIndex = 16;
            this.lblx.Text = "...";
            // 
            // pBoxSensores2
            // 
            this.pBoxSensores2.Location = new System.Drawing.Point(307, 106);
            this.pBoxSensores2.Name = "pBoxSensores2";
            this.pBoxSensores2.Size = new System.Drawing.Size(100, 118);
            this.pBoxSensores2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxSensores2.TabIndex = 9;
            this.pBoxSensores2.TabStop = false;
            // 
            // pBoxSensores
            // 
            this.pBoxSensores.Location = new System.Drawing.Point(186, 106);
            this.pBoxSensores.Name = "pBoxSensores";
            this.pBoxSensores.Size = new System.Drawing.Size(100, 118);
            this.pBoxSensores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxSensores.TabIndex = 8;
            this.pBoxSensores.TabStop = false;
            // 
            // pBoxNivel
            // 
            this.pBoxNivel.Location = new System.Drawing.Point(30, 106);
            this.pBoxNivel.Name = "pBoxNivel";
            this.pBoxNivel.Size = new System.Drawing.Size(100, 118);
            this.pBoxNivel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxNivel.TabIndex = 7;
            this.pBoxNivel.TabStop = false;
            // 
            // pBoxDireccion
            // 
            this.pBoxDireccion.Location = new System.Drawing.Point(480, 106);
            this.pBoxDireccion.Name = "pBoxDireccion";
            this.pBoxDireccion.Size = new System.Drawing.Size(100, 118);
            this.pBoxDireccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxDireccion.TabIndex = 6;
            this.pBoxDireccion.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 403);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.txtFechaNew);
            this.Controls.Add(this.btnNuevaFecha);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFechaDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pBoxSensores2);
            this.Controls.Add(this.pBoxSensores);
            this.Controls.Add(this.pBoxNivel);
            this.Controls.Add(this.pBoxDireccion);
            this.Controls.Add(this.lblDirecciones);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblSensores);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblEntrada);
            this.Name = "Form1";
            this.Text = "Bits y Bytes";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSensores2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSensores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ImageList iListNivel;
        private System.Windows.Forms.ImageList iListSensores;
        private System.Windows.Forms.ImageList iListDireccion;
        private System.Windows.Forms.Label lblSensores;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblDirecciones;
        private System.Windows.Forms.PictureBox pBoxDireccion;
        private System.Windows.Forms.PictureBox pBoxNivel;
        private System.Windows.Forms.PictureBox pBoxSensores;
        private System.Windows.Forms.PictureBox pBoxSensores2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaDown;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnNuevaFecha;
        private System.Windows.Forms.TextBox txtFechaNew;
        private System.Windows.Forms.Label lblx;
    }
}

