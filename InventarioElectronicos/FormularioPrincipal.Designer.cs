namespace GestionInventariosElectronicos
{
    partial class FormularioPrincipal
    {
        private System.ComponentModel.IContainer G5_componentes = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (G5_componentes != null))
            {
                G5_componentes.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.G5_etiquetaNombre = new System.Windows.Forms.Label();
            this.G5_etiquetaCategoria = new System.Windows.Forms.Label();
            this.G5_etiquetaPrecio = new System.Windows.Forms.Label();
            this.G5_etiquetaCantidad = new System.Windows.Forms.Label();
            this.G5_cuadroNombre = new System.Windows.Forms.TextBox();
            this.G5_cuadroCategoria = new System.Windows.Forms.TextBox();
            this.G5_cuadroPrecio = new System.Windows.Forms.TextBox();
            this.G5_cuadroCantidad = new System.Windows.Forms.TextBox();
            this.G5_botonRegistrar = new System.Windows.Forms.Button();
            this.G5_botonBuscar = new System.Windows.Forms.Button();
            this.G5_botonOrdenAsc = new System.Windows.Forms.Button();
            this.G5_botonOrdenDesc = new System.Windows.Forms.Button();
            this.G5_botonCalcularStock = new System.Windows.Forms.Button();
            this.G5_vistaProductos = new System.Windows.Forms.ListView();
            this.G5_columnaNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.G5_columnaCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.G5_columnaPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.G5_columnaCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.G5_botonMostrarTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // G5_etiquetaNombre
            // 
            this.G5_etiquetaNombre.AutoSize = true;
            this.G5_etiquetaNombre.Location = new System.Drawing.Point(24, 24);
            this.G5_etiquetaNombre.Name = "G5_etiquetaNombre";
            this.G5_etiquetaNombre.Size = new System.Drawing.Size(96, 15);
            this.G5_etiquetaNombre.TabIndex = 0;
            this.G5_etiquetaNombre.Text = "Nombre del producto";
            // 
            // G5_etiquetaCategoria
            // 
            this.G5_etiquetaCategoria.AutoSize = true;
            this.G5_etiquetaCategoria.Location = new System.Drawing.Point(24, 72);
            this.G5_etiquetaCategoria.Name = "G5_etiquetaCategoria";
            this.G5_etiquetaCategoria.Size = new System.Drawing.Size(57, 15);
            this.G5_etiquetaCategoria.TabIndex = 1;
            this.G5_etiquetaCategoria.Text = "Categoría";
            // 
            // G5_etiquetaPrecio
            // 
            this.G5_etiquetaPrecio.AutoSize = true;
            this.G5_etiquetaPrecio.Location = new System.Drawing.Point(24, 120);
            this.G5_etiquetaPrecio.Name = "G5_etiquetaPrecio";
            this.G5_etiquetaPrecio.Size = new System.Drawing.Size(40, 15);
            this.G5_etiquetaPrecio.TabIndex = 2;
            this.G5_etiquetaPrecio.Text = "Precio";
            // 
            // G5_etiquetaCantidad
            // 
            this.G5_etiquetaCantidad.AutoSize = true;
            this.G5_etiquetaCantidad.Location = new System.Drawing.Point(24, 168);
            this.G5_etiquetaCantidad.Name = "G5_etiquetaCantidad";
            this.G5_etiquetaCantidad.Size = new System.Drawing.Size(54, 15);
            this.G5_etiquetaCantidad.TabIndex = 3;
            this.G5_etiquetaCantidad.Text = "Cantidad";
            // 
            // G5_cuadroNombre
            // 
            this.G5_cuadroNombre.Location = new System.Drawing.Point(24, 42);
            this.G5_cuadroNombre.Name = "G5_cuadroNombre";
            this.G5_cuadroNombre.Size = new System.Drawing.Size(240, 23);
            this.G5_cuadroNombre.TabIndex = 4;
            // 
            // G5_cuadroCategoria
            // 
            this.G5_cuadroCategoria.Location = new System.Drawing.Point(24, 90);
            this.G5_cuadroCategoria.Name = "G5_cuadroCategoria";
            this.G5_cuadroCategoria.Size = new System.Drawing.Size(240, 23);
            this.G5_cuadroCategoria.TabIndex = 5;
            // 
            // G5_cuadroPrecio
            // 
            this.G5_cuadroPrecio.Location = new System.Drawing.Point(24, 138);
            this.G5_cuadroPrecio.Name = "G5_cuadroPrecio";
            this.G5_cuadroPrecio.Size = new System.Drawing.Size(240, 23);
            this.G5_cuadroPrecio.TabIndex = 6;
            // 
            // G5_cuadroCantidad
            // 
            this.G5_cuadroCantidad.Location = new System.Drawing.Point(24, 186);
            this.G5_cuadroCantidad.Name = "G5_cuadroCantidad";
            this.G5_cuadroCantidad.Size = new System.Drawing.Size(240, 23);
            this.G5_cuadroCantidad.TabIndex = 7;
            // 
            // G5_botonRegistrar
            // 
            this.G5_botonRegistrar.Location = new System.Drawing.Point(288, 42);
            this.G5_botonRegistrar.Name = "G5_botonRegistrar";
            this.G5_botonRegistrar.Size = new System.Drawing.Size(140, 27);
            this.G5_botonRegistrar.TabIndex = 8;
            this.G5_botonRegistrar.Text = "Registrar";
            this.G5_botonRegistrar.UseVisualStyleBackColor = true;
            this.G5_botonRegistrar.Click += new System.EventHandler(this.G5_botonRegistrar_Click);
            // 
            // G5_botonBuscar
            // 
            this.G5_botonBuscar.Location = new System.Drawing.Point(288, 90);
            this.G5_botonBuscar.Name = "G5_botonBuscar";
            this.G5_botonBuscar.Size = new System.Drawing.Size(140, 27);
            this.G5_botonBuscar.TabIndex = 9;
            this.G5_botonBuscar.Text = "Buscar por nombre";
            this.G5_botonBuscar.UseVisualStyleBackColor = true;
            this.G5_botonBuscar.Click += new System.EventHandler(this.G5_botonBuscar_Click);
            // 
            // G5_botonOrdenAsc
            // 
            this.G5_botonOrdenAsc.Location = new System.Drawing.Point(288, 138);
            this.G5_botonOrdenAsc.Name = "G5_botonOrdenAsc";
            this.G5_botonOrdenAsc.Size = new System.Drawing.Size(140, 27);
            this.G5_botonOrdenAsc.TabIndex = 10;
            this.G5_botonOrdenAsc.Text = "Ordenar por precio ↑";
            this.G5_botonOrdenAsc.UseVisualStyleBackColor = true;
            this.G5_botonOrdenAsc.Click += new System.EventHandler(this.G5_botonOrdenAsc_Click);
            // 
            // G5_botonOrdenDesc
            // 
            this.G5_botonOrdenDesc.Location = new System.Drawing.Point(288, 186);
            this.G5_botonOrdenDesc.Name = "G5_botonOrdenDesc";
            this.G5_botonOrdenDesc.Size = new System.Drawing.Size(140, 27);
            this.G5_botonOrdenDesc.TabIndex = 11;
            this.G5_botonOrdenDesc.Text = "Ordenar por precio ↓";
            this.G5_botonOrdenDesc.UseVisualStyleBackColor = true;
            this.G5_botonOrdenDesc.Click += new System.EventHandler(this.G5_botonOrdenDesc_Click);
            // 
            // G5_botonCalcularStock
            // 
            this.G5_botonCalcularStock.Location = new System.Drawing.Point(288, 234);
            this.G5_botonCalcularStock.Name = "G5_botonCalcularStock";
            this.G5_botonCalcularStock.Size = new System.Drawing.Size(140, 27);
            this.G5_botonCalcularStock.TabIndex = 12;
            this.G5_botonCalcularStock.Text = "Calcular stock";
            this.G5_botonCalcularStock.UseVisualStyleBackColor = true;
            this.G5_botonCalcularStock.Click += new System.EventHandler(this.G5_botonCalcularStock_Click);
            // 
            // G5_vistaProductos
            // 
            this.G5_vistaProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.G5_columnaNombre,
            this.G5_columnaCategoria,
            this.G5_columnaPrecio,
            this.G5_columnaCantidad});
            this.G5_vistaProductos.FullRowSelect = true;
            this.G5_vistaProductos.HideSelection = false;
            this.G5_vistaProductos.Location = new System.Drawing.Point(24, 234);
            this.G5_vistaProductos.MultiSelect = false;
            this.G5_vistaProductos.Name = "G5_vistaProductos";
            this.G5_vistaProductos.Size = new System.Drawing.Size(444, 192);
            this.G5_vistaProductos.TabIndex = 13;
            this.G5_vistaProductos.UseCompatibleStateImageBehavior = false;
            this.G5_vistaProductos.View = System.Windows.Forms.View.Details;
            // 
            // G5_columnaNombre
            // 
            this.G5_columnaNombre.Text = "Nombre";
            this.G5_columnaNombre.Width = 120;
            // 
            // G5_columnaCategoria
            // 
            this.G5_columnaCategoria.Text = "Categoría";
            this.G5_columnaCategoria.Width = 120;
            // 
            // G5_columnaPrecio
            // 
            this.G5_columnaPrecio.Text = "Precio";
            this.G5_columnaPrecio.Width = 100;
            // 
            // G5_columnaCantidad
            // 
            this.G5_columnaCantidad.Text = "Cantidad";
            this.G5_columnaCantidad.Width = 80;
            // 
            // G5_botonMostrarTodos
            // 
            this.G5_botonMostrarTodos.Location = new System.Drawing.Point(288, 282);
            this.G5_botonMostrarTodos.Name = "G5_botonMostrarTodos";
            this.G5_botonMostrarTodos.Size = new System.Drawing.Size(140, 27);
            this.G5_botonMostrarTodos.TabIndex = 14;
            this.G5_botonMostrarTodos.Text = "Mostrar todos";
            this.G5_botonMostrarTodos.UseVisualStyleBackColor = true;
            this.G5_botonMostrarTodos.Click += new System.EventHandler(this.G5_botonMostrarTodos_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 448);
            this.Controls.Add(this.G5_botonMostrarTodos);
            this.Controls.Add(this.G5_vistaProductos);
            this.Controls.Add(this.G5_botonCalcularStock);
            this.Controls.Add(this.G5_botonOrdenDesc);
            this.Controls.Add(this.G5_botonOrdenAsc);
            this.Controls.Add(this.G5_botonBuscar);
            this.Controls.Add(this.G5_botonRegistrar);
            this.Controls.Add(this.G5_cuadroCantidad);
            this.Controls.Add(this.G5_cuadroPrecio);
            this.Controls.Add(this.G5_cuadroCategoria);
            this.Controls.Add(this.G5_cuadroNombre);
            this.Controls.Add(this.G5_etiquetaCantidad);
            this.Controls.Add(this.G5_etiquetaPrecio);
            this.Controls.Add(this.G5_etiquetaCategoria);
            this.Controls.Add(this.G5_etiquetaNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de inventario electrónico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label G5_etiquetaNombre;
        private System.Windows.Forms.Label G5_etiquetaCategoria;
        private System.Windows.Forms.Label G5_etiquetaPrecio;
        private System.Windows.Forms.Label G5_etiquetaCantidad;
        private System.Windows.Forms.TextBox G5_cuadroNombre;
        private System.Windows.Forms.TextBox G5_cuadroCategoria;
        private System.Windows.Forms.TextBox G5_cuadroPrecio;
        private System.Windows.Forms.TextBox G5_cuadroCantidad;
        private System.Windows.Forms.Button G5_botonRegistrar;
        private System.Windows.Forms.Button G5_botonBuscar;
        private System.Windows.Forms.Button G5_botonOrdenAsc;
        private System.Windows.Forms.Button G5_botonOrdenDesc;
        private System.Windows.Forms.Button G5_botonCalcularStock;
        private System.Windows.Forms.ListView G5_vistaProductos;
        private System.Windows.Forms.ColumnHeader G5_columnaNombre;
        private System.Windows.Forms.ColumnHeader G5_columnaCategoria;
        private System.Windows.Forms.ColumnHeader G5_columnaPrecio;
        private System.Windows.Forms.ColumnHeader G5_columnaCantidad;
        private System.Windows.Forms.Button G5_botonMostrarTodos;
    }
}
