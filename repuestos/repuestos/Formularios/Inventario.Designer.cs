namespace repuestos.Formularios
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
            this.tabInventarioGeneral = new System.Windows.Forms.TabControl();
            this.tab_compras = new System.Windows.Forms.TabPage();
            this.tab_inventario = new System.Windows.Forms.TabPage();
            this.dgv_Inventario = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descipcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigofabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_kardex = new System.Windows.Forms.TabPage();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.txtcodigoprod1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbKardex = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKardex = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigoprod2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabInventarioGeneral.SuspendLayout();
            this.tab_inventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).BeginInit();
            this.tab_kardex.SuspendLayout();
            this.gbKardex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKardex)).BeginInit();
            this.SuspendLayout();
            // 
            // tabInventarioGeneral
            // 
            this.tabInventarioGeneral.Controls.Add(this.tab_compras);
            this.tabInventarioGeneral.Controls.Add(this.tab_inventario);
            this.tabInventarioGeneral.Controls.Add(this.tab_kardex);
            this.tabInventarioGeneral.Location = new System.Drawing.Point(2, 2);
            this.tabInventarioGeneral.Name = "tabInventarioGeneral";
            this.tabInventarioGeneral.SelectedIndex = 0;
            this.tabInventarioGeneral.Size = new System.Drawing.Size(1231, 518);
            this.tabInventarioGeneral.TabIndex = 20;
            this.tabInventarioGeneral.SelectedIndexChanged += new System.EventHandler(this.tabInventarioGeneral_SelectedIndexChanged);
            // 
            // tab_compras
            // 
            this.tab_compras.BackColor = System.Drawing.SystemColors.Control;
            this.tab_compras.Location = new System.Drawing.Point(4, 22);
            this.tab_compras.Name = "tab_compras";
            this.tab_compras.Padding = new System.Windows.Forms.Padding(3);
            this.tab_compras.Size = new System.Drawing.Size(1223, 492);
            this.tab_compras.TabIndex = 0;
            this.tab_compras.Text = "Compras";
            // 
            // tab_inventario
            // 
            this.tab_inventario.BackColor = System.Drawing.SystemColors.Control;
            this.tab_inventario.Controls.Add(this.dgv_Inventario);
            this.tab_inventario.Location = new System.Drawing.Point(4, 22);
            this.tab_inventario.Name = "tab_inventario";
            this.tab_inventario.Padding = new System.Windows.Forms.Padding(3);
            this.tab_inventario.Size = new System.Drawing.Size(1223, 492);
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
            this.dgv_Inventario.Location = new System.Drawing.Point(3, 75);
            this.dgv_Inventario.Name = "dgv_Inventario";
            this.dgv_Inventario.ReadOnly = true;
            this.dgv_Inventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Inventario.Size = new System.Drawing.Size(1210, 316);
            this.dgv_Inventario.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descipcion
            // 
            this.Descipcion.HeaderText = "Descipcion";
            this.Descipcion.Name = "Descipcion";
            this.Descipcion.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // ultventa
            // 
            this.ultventa.HeaderText = "Ultima Venta";
            this.ultventa.Name = "ultventa";
            this.ultventa.ReadOnly = true;
            // 
            // codigofabricante
            // 
            this.codigofabricante.HeaderText = "Codigo Fabricante";
            this.codigofabricante.Name = "codigofabricante";
            this.codigofabricante.ReadOnly = true;
            // 
            // pre1
            // 
            this.pre1.HeaderText = "Prec. 1 Q";
            this.pre1.Name = "pre1";
            this.pre1.ReadOnly = true;
            // 
            // prec2
            // 
            this.prec2.HeaderText = "Prec. 2 Q";
            this.prec2.Name = "prec2";
            this.prec2.ReadOnly = true;
            // 
            // prec3
            // 
            this.prec3.HeaderText = "Prec. 3 Q";
            this.prec3.Name = "prec3";
            this.prec3.ReadOnly = true;
            // 
            // prec4
            // 
            this.prec4.HeaderText = "Prec. 4 Q";
            this.prec4.Name = "prec4";
            this.prec4.ReadOnly = true;
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
            this.tab_kardex.Location = new System.Drawing.Point(4, 22);
            this.tab_kardex.Name = "tab_kardex";
            this.tab_kardex.Padding = new System.Windows.Forms.Padding(3);
            this.tab_kardex.Size = new System.Drawing.Size(1223, 492);
            this.tab_kardex.TabIndex = 2;
            this.tab_kardex.Text = "Kardex";
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Location = new System.Drawing.Point(409, 46);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(200, 20);
            this.dtp_inicio.TabIndex = 0;
            // 
            // dtp_fin
            // 
            this.dtp_fin.Location = new System.Drawing.Point(632, 46);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(200, 20);
            this.dtp_fin.TabIndex = 1;
            // 
            // txtcodigoprod1
            // 
            this.txtcodigoprod1.Location = new System.Drawing.Point(183, 46);
            this.txtcodigoprod1.Name = "txtcodigoprod1";
            this.txtcodigoprod1.Size = new System.Drawing.Size(150, 20);
            this.txtcodigoprod1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(339, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(857, 43);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
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
            this.gbKardex.Size = new System.Drawing.Size(1181, 391);
            this.gbKardex.TabIndex = 5;
            this.gbKardex.TabStop = false;
            this.gbKardex.Text = "Kardex";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Producto";
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
            this.dgvKardex.Location = new System.Drawing.Point(74, 107);
            this.dgvKardex.Name = "dgvKardex";
            this.dgvKardex.ReadOnly = true;
            this.dgvKardex.Size = new System.Drawing.Size(1035, 225);
            this.dgvKardex.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // txtcodigoprod2
            // 
            this.txtcodigoprod2.Location = new System.Drawing.Point(252, 46);
            this.txtcodigoprod2.Name = "txtcodigoprod2";
            this.txtcodigoprod2.Size = new System.Drawing.Size(100, 20);
            this.txtcodigoprod2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(382, 46);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(374, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(782, 46);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(115, 20);
            this.txtExistencias.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(779, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Existencias Actuales";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "No. Documento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Movimiento";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 549);
            this.Controls.Add(this.tabInventarioGeneral);
            this.Name = "Inventario";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.tabInventarioGeneral.ResumeLayout(false);
            this.tab_inventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).EndInit();
            this.tab_kardex.ResumeLayout(false);
            this.tab_kardex.PerformLayout();
            this.gbKardex.ResumeLayout(false);
            this.gbKardex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKardex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInventarioGeneral;
        private System.Windows.Forms.TabPage tab_compras;
        private System.Windows.Forms.TabPage tab_inventario;
        private System.Windows.Forms.TabPage tab_kardex;
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
        private System.Windows.Forms.GroupBox gbKardex;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.Label label1;
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
        public System.Windows.Forms.TextBox txtcodigoprod1;
    }
}