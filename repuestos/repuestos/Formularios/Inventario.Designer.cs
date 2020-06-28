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
            this.tab_kardex = new System.Windows.Forms.TabPage();
            this.prec4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigofabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descipcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabInventarioGeneral.SuspendLayout();
            this.tab_inventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inventario)).BeginInit();
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
            this.tab_compras.Size = new System.Drawing.Size(1007, 492);
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
            // tab_kardex
            // 
            this.tab_kardex.BackColor = System.Drawing.SystemColors.Control;
            this.tab_kardex.Location = new System.Drawing.Point(4, 22);
            this.tab_kardex.Name = "tab_kardex";
            this.tab_kardex.Padding = new System.Windows.Forms.Padding(3);
            this.tab_kardex.Size = new System.Drawing.Size(1007, 492);
            this.tab_kardex.TabIndex = 2;
            this.tab_kardex.Text = "Kardex";
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
    }
}