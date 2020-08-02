namespace repuestos.Formularios
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.NIT = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaddrep = new System.Windows.Forms.GroupBox();
            this.txt_facturarsinexistencias = new System.Windows.Forms.TextBox();
            this.txtexistencias_actuales = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcodrep = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreRep = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.RichTextBox();
            this.btnGuardarImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_tipoPago = new System.Windows.Forms.ComboBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsubtotal_desc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvFactDet = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.btnaddrep.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactDet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtCodCliente);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNit);
            this.groupBox1.Controls.Add(this.NIT);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNoFactura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(774, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cliente Nuevo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(163, 53);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(31, 21);
            this.txtCodCliente.TabIndex = 11;
            this.txtCodCliente.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(953, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(17, 14);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(891, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha";
            // 
            // txtNit
            // 
            this.txtNit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNit.Location = new System.Drawing.Point(608, 55);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(160, 21);
            this.txtNit.TabIndex = 8;
            this.txtNit.Enter += new System.EventHandler(this.txtNit_Enter);
            this.txtNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNit_KeyPress);
            // 
            // NIT
            // 
            this.NIT.AutoSize = true;
            this.NIT.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIT.Location = new System.Drawing.Point(671, 37);
            this.NIT.Name = "NIT";
            this.NIT.Size = new System.Drawing.Size(31, 14);
            this.NIT.TabIndex = 7;
            this.NIT.Text = "NIT";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(501, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 38);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(200, 53);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(295, 21);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Location = new System.Drawing.Point(10, 53);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(116, 21);
            this.txtNoFactura.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. Factura";
            // 
            // btnaddrep
            // 
            this.btnaddrep.Controls.Add(this.txt_facturarsinexistencias);
            this.btnaddrep.Controls.Add(this.txtexistencias_actuales);
            this.btnaddrep.Controls.Add(this.txtPrecio);
            this.btnaddrep.Controls.Add(this.label14);
            this.btnaddrep.Controls.Add(this.txtcodrep);
            this.btnaddrep.Controls.Add(this.button1);
            this.btnaddrep.Controls.Add(this.txtCant);
            this.btnaddrep.Controls.Add(this.label13);
            this.btnaddrep.Controls.Add(this.txtNombreRep);
            this.btnaddrep.Controls.Add(this.label12);
            this.btnaddrep.Controls.Add(this.label11);
            this.btnaddrep.Controls.Add(this.txtComentario);
            this.btnaddrep.Controls.Add(this.btnGuardarImprimir);
            this.btnaddrep.Controls.Add(this.btnGuardar);
            this.btnaddrep.Controls.Add(this.btnCancelar);
            this.btnaddrep.Controls.Add(this.groupBox3);
            this.btnaddrep.Controls.Add(this.btnEliminar);
            this.btnaddrep.Controls.Add(this.btnAgregar);
            this.btnaddrep.Controls.Add(this.txtTotal);
            this.btnaddrep.Controls.Add(this.label8);
            this.btnaddrep.Controls.Add(this.txtsubtotal_desc);
            this.btnaddrep.Controls.Add(this.label7);
            this.btnaddrep.Controls.Add(this.txtDesc);
            this.btnaddrep.Controls.Add(this.label6);
            this.btnaddrep.Controls.Add(this.txtSubtotal);
            this.btnaddrep.Controls.Add(this.label5);
            this.btnaddrep.Controls.Add(this.dgvFactDet);
            this.btnaddrep.Location = new System.Drawing.Point(15, 130);
            this.btnaddrep.Name = "btnaddrep";
            this.btnaddrep.Size = new System.Drawing.Size(1135, 499);
            this.btnaddrep.TabIndex = 1;
            this.btnaddrep.TabStop = false;
            this.btnaddrep.Text = "Detalle Factura";
            // 
            // txt_facturarsinexistencias
            // 
            this.txt_facturarsinexistencias.Location = new System.Drawing.Point(892, 12);
            this.txt_facturarsinexistencias.Name = "txt_facturarsinexistencias";
            this.txt_facturarsinexistencias.Size = new System.Drawing.Size(40, 21);
            this.txt_facturarsinexistencias.TabIndex = 32;
            this.txt_facturarsinexistencias.Visible = false;
            // 
            // txtexistencias_actuales
            // 
            this.txtexistencias_actuales.Location = new System.Drawing.Point(938, 12);
            this.txtexistencias_actuales.Name = "txtexistencias_actuales";
            this.txtexistencias_actuales.Size = new System.Drawing.Size(41, 21);
            this.txtexistencias_actuales.TabIndex = 31;
            this.txtexistencias_actuales.Visible = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(727, 36);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(116, 21);
            this.txtPrecio.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(615, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 14);
            this.label14.TabIndex = 29;
            this.label14.Text = "Precio Unitario";
            // 
            // txtcodrep
            // 
            this.txtcodrep.Location = new System.Drawing.Point(0, 34);
            this.txtcodrep.Name = "txtcodrep";
            this.txtcodrep.Size = new System.Drawing.Size(39, 21);
            this.txtcodrep.TabIndex = 28;
            this.txtcodrep.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1015, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 52);
            this.button1.TabIndex = 27;
            this.button1.Text = "Agregar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(929, 39);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(66, 21);
            this.txtCant.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(853, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 14);
            this.label13.TabIndex = 25;
            this.label13.Text = "Cantidad";
            // 
            // txtNombreRep
            // 
            this.txtNombreRep.Location = new System.Drawing.Point(111, 32);
            this.txtNombreRep.Name = "txtNombreRep";
            this.txtNombreRep.Size = new System.Drawing.Size(362, 21);
            this.txtNombreRep.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 14);
            this.label12.TabIndex = 23;
            this.label12.Text = "Repuesto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(526, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 14);
            this.label11.TabIndex = 22;
            this.label11.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(506, 346);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(304, 55);
            this.txtComentario.TabIndex = 21;
            this.txtComentario.Text = "";
            // 
            // btnGuardarImprimir
            // 
            this.btnGuardarImprimir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarImprimir.Image")));
            this.btnGuardarImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarImprimir.Location = new System.Drawing.Point(592, 443);
            this.btnGuardarImprimir.Name = "btnGuardarImprimir";
            this.btnGuardarImprimir.Size = new System.Drawing.Size(104, 50);
            this.btnGuardarImprimir.TabIndex = 20;
            this.btnGuardarImprimir.Text = "Guardar, Imprimir";
            this.btnGuardarImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarImprimir.UseVisualStyleBackColor = true;
            this.btnGuardarImprimir.Click += new System.EventHandler(this.btnGuardarImprimir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(479, 443);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 50);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(366, 443);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 50);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSaldo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbo_tipoPago);
            this.groupBox3.Controls.Add(this.txtPago);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(20, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 100);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pagos";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(346, 43);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(116, 21);
            this.txtSaldo.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(383, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 14);
            this.label10.TabIndex = 17;
            this.label10.Text = "Saldo";
            // 
            // cbo_tipoPago
            // 
            this.cbo_tipoPago.FormattingEnabled = true;
            this.cbo_tipoPago.Location = new System.Drawing.Point(25, 43);
            this.cbo_tipoPago.Name = "cbo_tipoPago";
            this.cbo_tipoPago.Size = new System.Drawing.Size(140, 21);
            this.cbo_tipoPago.TabIndex = 3;
            this.cbo_tipoPago.SelectedIndexChanged += new System.EventHandler(this.cbo_tipoPago_SelectedIndexChanged);
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(187, 43);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(116, 21);
            this.txtPago.TabIndex = 16;
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            this.txtPago.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPago_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo de Pago";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(230, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 14);
            this.label9.TabIndex = 15;
            this.label9.Text = "Pago";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(1015, 117);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 53);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(486, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 42);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Buscar Rep.";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(972, 407);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(116, 21);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(913, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtsubtotal_desc
            // 
            this.txtsubtotal_desc.Location = new System.Drawing.Point(972, 365);
            this.txtsubtotal_desc.Name = "txtsubtotal_desc";
            this.txtsubtotal_desc.Size = new System.Drawing.Size(116, 21);
            this.txtsubtotal_desc.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(935, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "%";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(874, 365);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(53, 21);
            this.txtDesc.TabIndex = 8;
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesc_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(815, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dscto.";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(972, 334);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(116, 21);
            this.txtSubtotal.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(896, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sub-total";
            // 
            // dgvFactDet
            // 
            this.dgvFactDet.AllowUserToAddRows = false;
            this.dgvFactDet.AllowUserToDeleteRows = false;
            this.dgvFactDet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvFactDet.Location = new System.Drawing.Point(18, 72);
            this.dgvFactDet.Name = "dgvFactDet";
            this.dgvFactDet.ReadOnly = true;
            this.dgvFactDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFactDet.Size = new System.Drawing.Size(991, 242);
            this.dgvFactDet.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 73.00939F;
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 161.5333F;
            this.Column2.HeaderText = "Repuesto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 100.1693F;
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 89.14587F;
            this.Column4.HeaderText = "Precio Unitario";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 76.14214F;
            this.Column5.HeaderText = "Sub-total Q";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1196, 675);
            this.Controls.Add(this.btnaddrep);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Facturacion";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.btnaddrep.ResumeLayout(false);
            this.btnaddrep.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactDet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NIT;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox btnaddrep;
        private System.Windows.Forms.TextBox txtsubtotal_desc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_tipoPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtComentario;
        private System.Windows.Forms.Button btnGuardarImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtNit;
        public System.Windows.Forms.TextBox txtNombreCliente;
        public System.Windows.Forms.TextBox txtCodCliente;
        public System.Windows.Forms.DataGridView dgvFactDet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtNombreRep;
        public System.Windows.Forms.TextBox txtcodrep;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txt_facturarsinexistencias;
        public System.Windows.Forms.TextBox txtexistencias_actuales;
    }
}