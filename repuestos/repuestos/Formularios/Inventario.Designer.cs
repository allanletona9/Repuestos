﻿namespace repuestos.Formularios
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.tab_kardex = new System.Windows.Forms.TabPage();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.txtcodigoprod1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbKardex = new System.Windows.Forms.GroupBox();
            this.dgvKardex = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigoprod2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_inventario = new System.Windows.Forms.TabPage();
            this.dgv_Inventario = new System.Windows.Forms.DataGridView();
            this.prec4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigofabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descipcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ingresarC = new System.Windows.Forms.Button();
            this.btn_cancelarC = new System.Windows.Forms.Button();
            this.btn_eliminarC = new System.Windows.Forms.Button();
            this.btn_guardarC = new System.Windows.Forms.Button();
            this.btn_modC = new System.Windows.Forms.Button();
            this.tab_compras = new System.Windows.Forms.TabPage();
            this.tabInventarioGeneral = new System.Windows.Forms.TabControl();
            this.label11 = new System.Windows.Forms.Label();
            this.tab_kardex.SuspendLayout();
            this.gbKardex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKardex)).BeginInit();
            this.tab_inventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabInventarioGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_kardex
            // 
            this.tab_kardex.BackColor = System.Drawing.SystemColors.Control;
            this.tab_kardex.Controls.Add(this.label1);
            this.tab_kardex.Controls.Add(this.gbKardex);
            this.tab_kardex.Controls.Add(this.btnConsultar);
            this.tab_kardex.Controls.Add(this.btnBuscar);
            this.tab_kardex.Controls.Add(this.txtcodigoprod1);
            this.tab_kardex.Controls.Add(this.dtp_fin);
            this.tab_kardex.Controls.Add(this.dtp_inicio);
            this.tab_kardex.Location = new System.Drawing.Point(4, 27);
            this.tab_kardex.Name = "tab_kardex";
            this.tab_kardex.Padding = new System.Windows.Forms.Padding(3);
            this.tab_kardex.Size = new System.Drawing.Size(1223, 544);
            this.tab_kardex.TabIndex = 2;
            this.tab_kardex.Text = "Kardex";
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.Location = new System.Drawing.Point(458, 48);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(209, 26);
            this.dtp_inicio.TabIndex = 0;
            // 
            // dtp_fin
            // 
            this.dtp_fin.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.Location = new System.Drawing.Point(691, 46);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(209, 26);
            this.dtp_fin.TabIndex = 1;
            // 
            // txtcodigoprod1
            // 
            this.txtcodigoprod1.Location = new System.Drawing.Point(151, 46);
            this.txtcodigoprod1.Name = "txtcodigoprod1";
            this.txtcodigoprod1.Size = new System.Drawing.Size(150, 26);
            this.txtcodigoprod1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(326, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 43);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.Location = new System.Drawing.Point(917, 37);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(126, 37);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gbKardex
            // 
            this.gbKardex.Controls.Add(this.label4);
            this.gbKardex.Controls.Add(this.txtExistencias);
            this.gbKardex.Controls.Add(this.txtDescripcion);
            this.gbKardex.Controls.Add(this.label3);
            this.gbKardex.Controls.Add(this.txtcodigoprod2);
            this.gbKardex.Controls.Add(this.label2);
            this.gbKardex.Controls.Add(this.dgvKardex);
            this.gbKardex.Location = new System.Drawing.Point(16, 95);
            this.gbKardex.Name = "gbKardex";
            this.gbKardex.Size = new System.Drawing.Size(1174, 441);
            this.gbKardex.TabIndex = 5;
            this.gbKardex.TabStop = false;
            this.gbKardex.Text = "Kardex";
            // 
            // dgvKardex
            // 
            this.dgvKardex.AllowUserToAddRows = false;
            this.dgvKardex.AllowUserToDeleteRows = false;
            this.dgvKardex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKardex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvKardex.Location = new System.Drawing.Point(17, 106);
            this.dgvKardex.Name = "dgvKardex";
            this.dgvKardex.ReadOnly = true;
            this.dgvKardex.Size = new System.Drawing.Size(1088, 319);
            this.dgvKardex.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Movimiento";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "No. Documento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // txtcodigoprod2
            // 
            this.txtcodigoprod2.Location = new System.Drawing.Point(107, 57);
            this.txtcodigoprod2.Name = "txtcodigoprod2";
            this.txtcodigoprod2.Size = new System.Drawing.Size(207, 26);
            this.txtcodigoprod2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(385, 57);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(374, 26);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(855, 57);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(204, 26);
            this.txtExistencias.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(871, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Existencias Actuales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Producto";
            // 
            // tab_inventario
            // 
            this.tab_inventario.BackColor = System.Drawing.SystemColors.Control;
            this.tab_inventario.Controls.Add(this.label11);
            this.tab_inventario.Controls.Add(this.tableLayoutPanel2);
            this.tab_inventario.Controls.Add(this.dgv_Inventario);
            this.tab_inventario.Location = new System.Drawing.Point(4, 27);
            this.tab_inventario.Name = "tab_inventario";
            this.tab_inventario.Padding = new System.Windows.Forms.Padding(3);
            this.tab_inventario.Size = new System.Drawing.Size(1223, 544);
            this.tab_inventario.TabIndex = 1;
            this.tab_inventario.Text = "Inventario";
            // 
            // dgv_Inventario
            // 
            this.dgv_Inventario.AllowUserToAddRows = false;
            this.dgv_Inventario.AllowUserToDeleteRows = false;
            this.dgv_Inventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descipcion,
            this.Tipo,
            this.ultventa,
            this.codigofabricante,
            this.pre1,
            this.prec2,
            this.prec3,
            this.prec4});
            this.dgv_Inventario.Location = new System.Drawing.Point(3, 89);
            this.dgv_Inventario.Name = "dgv_Inventario";
            this.dgv_Inventario.ReadOnly = true;
            this.dgv_Inventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Inventario.Size = new System.Drawing.Size(1120, 347);
            this.dgv_Inventario.TabIndex = 0;
            // 
            // prec4
            // 
            this.prec4.HeaderText = "Prec. 4 Q";
            this.prec4.Name = "prec4";
            this.prec4.ReadOnly = true;
            // 
            // prec3
            // 
            this.prec3.HeaderText = "Prec. 3 Q";
            this.prec3.Name = "prec3";
            this.prec3.ReadOnly = true;
            // 
            // prec2
            // 
            this.prec2.HeaderText = "Prec. 2 Q";
            this.prec2.Name = "prec2";
            this.prec2.ReadOnly = true;
            // 
            // pre1
            // 
            this.pre1.HeaderText = "Prec. 1 Q";
            this.pre1.Name = "pre1";
            this.pre1.ReadOnly = true;
            // 
            // codigofabricante
            // 
            this.codigofabricante.HeaderText = "Codigo Fabricante";
            this.codigofabricante.Name = "codigofabricante";
            this.codigofabricante.ReadOnly = true;
            // 
            // ultventa
            // 
            this.ultventa.HeaderText = "Ultima Venta";
            this.ultventa.Name = "ultventa";
            this.ultventa.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Descipcion
            // 
            this.Descipcion.HeaderText = "Descipcion";
            this.Descipcion.Name = "Descipcion";
            this.Descipcion.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Controls.Add(this.btn_modC, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_guardarC, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_eliminarC, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_cancelarC, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_ingresarC, 0, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(386, 459);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(441, 77);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // btn_ingresarC
            // 
            this.btn_ingresarC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ingresarC.BackgroundImage")));
            this.btn_ingresarC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ingresarC.Image = ((System.Drawing.Image)(resources.GetObject("btn_ingresarC.Image")));
            this.btn_ingresarC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ingresarC.Location = new System.Drawing.Point(3, 3);
            this.btn_ingresarC.Name = "btn_ingresarC";
            this.btn_ingresarC.Size = new System.Drawing.Size(74, 71);
            this.btn_ingresarC.TabIndex = 1;
            this.btn_ingresarC.Text = "Nuevo";
            this.btn_ingresarC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ingresarC.UseVisualStyleBackColor = true;
            // 
            // btn_cancelarC
            // 
            this.btn_cancelarC.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelarC.Image")));
            this.btn_cancelarC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cancelarC.Location = new System.Drawing.Point(328, 3);
            this.btn_cancelarC.Name = "btn_cancelarC";
            this.btn_cancelarC.Size = new System.Drawing.Size(79, 71);
            this.btn_cancelarC.TabIndex = 3;
            this.btn_cancelarC.Text = "Cancelar";
            this.btn_cancelarC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancelarC.UseVisualStyleBackColor = true;
            // 
            // btn_eliminarC
            // 
            this.btn_eliminarC.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminarC.Image")));
            this.btn_eliminarC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_eliminarC.Location = new System.Drawing.Point(248, 3);
            this.btn_eliminarC.Name = "btn_eliminarC";
            this.btn_eliminarC.Size = new System.Drawing.Size(73, 71);
            this.btn_eliminarC.TabIndex = 2;
            this.btn_eliminarC.Text = "Eliminar";
            this.btn_eliminarC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminarC.UseVisualStyleBackColor = true;
            // 
            // btn_guardarC
            // 
            this.btn_guardarC.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardarC.Image")));
            this.btn_guardarC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardarC.Location = new System.Drawing.Point(87, 3);
            this.btn_guardarC.Name = "btn_guardarC";
            this.btn_guardarC.Size = new System.Drawing.Size(72, 71);
            this.btn_guardarC.TabIndex = 4;
            this.btn_guardarC.Text = "Guardar";
            this.btn_guardarC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardarC.UseVisualStyleBackColor = true;
            // 
            // btn_modC
            // 
            this.btn_modC.Image = ((System.Drawing.Image)(resources.GetObject("btn_modC.Image")));
            this.btn_modC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_modC.Location = new System.Drawing.Point(165, 3);
            this.btn_modC.Name = "btn_modC";
            this.btn_modC.Size = new System.Drawing.Size(77, 71);
            this.btn_modC.TabIndex = 5;
            this.btn_modC.Text = "Modificar";
            this.btn_modC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_modC.UseVisualStyleBackColor = true;
            // 
            // tab_compras
            // 
            this.tab_compras.BackColor = System.Drawing.SystemColors.Control;
            this.tab_compras.Location = new System.Drawing.Point(4, 27);
            this.tab_compras.Name = "tab_compras";
            this.tab_compras.Padding = new System.Windows.Forms.Padding(3);
            this.tab_compras.Size = new System.Drawing.Size(1223, 522);
            this.tab_compras.TabIndex = 0;
            this.tab_compras.Text = "Compras";
            // 
            // tabInventarioGeneral
            // 
            this.tabInventarioGeneral.Controls.Add(this.tab_compras);
            this.tabInventarioGeneral.Controls.Add(this.tab_inventario);
            this.tabInventarioGeneral.Controls.Add(this.tab_kardex);
            this.tabInventarioGeneral.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInventarioGeneral.Location = new System.Drawing.Point(2, 2);
            this.tabInventarioGeneral.Name = "tabInventarioGeneral";
            this.tabInventarioGeneral.SelectedIndex = 0;
            this.tabInventarioGeneral.Size = new System.Drawing.Size(1231, 575);
            this.tabInventarioGeneral.TabIndex = 20;
            this.tabInventarioGeneral.SelectedIndexChanged += new System.EventHandler(this.tabInventarioGeneral_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(464, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 38);
            this.label11.TabIndex = 22;
            this.label11.Text = "Inventario";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 577);
            this.Controls.Add(this.tabInventarioGeneral);
            this.Name = "Inventario";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.tab_kardex.ResumeLayout(false);
            this.tab_kardex.PerformLayout();
            this.gbKardex.ResumeLayout(false);
            this.gbKardex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKardex)).EndInit();
            this.tab_inventario.ResumeLayout(false);
            this.tab_inventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabInventarioGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_kardex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbKardex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigoprod2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvKardex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtcodigoprod1;
        private System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.TabPage tab_inventario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_modC;
        private System.Windows.Forms.Button btn_guardarC;
        private System.Windows.Forms.Button btn_eliminarC;
        private System.Windows.Forms.Button btn_cancelarC;
        private System.Windows.Forms.Button btn_ingresarC;
        private System.Windows.Forms.DataGridView dgv_Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descipcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigofabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn pre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prec2;
        private System.Windows.Forms.DataGridViewTextBoxColumn prec3;
        private System.Windows.Forms.DataGridViewTextBoxColumn prec4;
        private System.Windows.Forms.TabPage tab_compras;
        private System.Windows.Forms.TabControl tabInventarioGeneral;
        private System.Windows.Forms.Label label11;
    }
}