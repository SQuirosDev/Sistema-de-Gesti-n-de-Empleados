
namespace Proyecto
{
    partial class F3BuscarEmpleado
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
            this.lvListaBuscarEmpleados = new System.Windows.Forms.ListView();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblBuscarEmpleado = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cboSalarioBruto = new System.Windows.Forms.ComboBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblTipoEmpleado = new System.Windows.Forms.Label();
            this.gbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvListaBuscarEmpleados
            // 
            this.lvListaBuscarEmpleados.HideSelection = false;
            this.lvListaBuscarEmpleados.Location = new System.Drawing.Point(12, 279);
            this.lvListaBuscarEmpleados.Name = "lvListaBuscarEmpleados";
            this.lvListaBuscarEmpleados.Size = new System.Drawing.Size(1066, 469);
            this.lvListaBuscarEmpleados.TabIndex = 1;
            this.lvListaBuscarEmpleados.UseCompatibleStateImageBehavior = false;
            this.lvListaBuscarEmpleados.View = System.Windows.Forms.View.Details;
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarLista.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarLista.Location = new System.Drawing.Point(12, 754);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(121, 55);
            this.btnLimpiarLista.TabIndex = 5;
            this.btnLimpiarLista.Text = "Limpiar Lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = true;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(6, 147);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 55);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar Empleado";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(957, 754);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(121, 55);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Cerrar";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblBuscarEmpleado
            // 
            this.lblBuscarEmpleado.AutoSize = true;
            this.lblBuscarEmpleado.Font = new System.Drawing.Font("Bodoni MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblBuscarEmpleado.Location = new System.Drawing.Point(12, 9);
            this.lblBuscarEmpleado.Name = "lblBuscarEmpleado";
            this.lblBuscarEmpleado.Size = new System.Drawing.Size(249, 47);
            this.lblBuscarEmpleado.TabIndex = 8;
            this.lblBuscarEmpleado.Text = "Buscar empleado";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(6, 87);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(358, 17);
            this.lblBuscar.TabIndex = 9;
            this.lblBuscar.Text = "Ingrese el id, nombre o edad del empleado para buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 107);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(355, 22);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cboTipoEmpleado
            // 
            this.cboTipoEmpleado.FormattingEnabled = true;
            this.cboTipoEmpleado.Location = new System.Drawing.Point(6, 38);
            this.cboTipoEmpleado.Name = "cboTipoEmpleado";
            this.cboTipoEmpleado.Size = new System.Drawing.Size(281, 24);
            this.cboTipoEmpleado.TabIndex = 12;
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.label1);
            this.gbBuscar.Controls.Add(this.txtEliminar);
            this.gbBuscar.Controls.Add(this.btnEliminarEmpleado);
            this.gbBuscar.Controls.Add(this.btnLimpiar);
            this.gbBuscar.Controls.Add(this.cboSalarioBruto);
            this.gbBuscar.Controls.Add(this.lblSalario);
            this.gbBuscar.Controls.Add(this.lblTipoEmpleado);
            this.gbBuscar.Controls.Add(this.txtBuscar);
            this.gbBuscar.Controls.Add(this.cboTipoEmpleado);
            this.gbBuscar.Controls.Add(this.lblBuscar);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuscar.ForeColor = System.Drawing.Color.Black;
            this.gbBuscar.Location = new System.Drawing.Point(12, 59);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(1066, 214);
            this.gbBuscar.TabIndex = 14;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ingrese el nombre del empleado para eliminarlo";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(755, 109);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(305, 22);
            this.txtEliminar.TabIndex = 17;
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(133, 147);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(121, 55);
            this.btnEliminarEmpleado.TabIndex = 16;
            this.btnEliminarEmpleado.Text = "Eliminar Empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(260, 147);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 55);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cboSalarioBruto
            // 
            this.cboSalarioBruto.FormattingEnabled = true;
            this.cboSalarioBruto.Location = new System.Drawing.Point(373, 107);
            this.cboSalarioBruto.Name = "cboSalarioBruto";
            this.cboSalarioBruto.Size = new System.Drawing.Size(371, 24);
            this.cboSalarioBruto.TabIndex = 15;
            this.cboSalarioBruto.SelectedIndexChanged += new System.EventHandler(this.cboSalarioBruto_SelectedIndexChanged);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(370, 87);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(374, 17);
            this.lblSalario.TabIndex = 14;
            this.lblSalario.Text = "Seleccione el intervalo del salario bruto que desea buscar";
            // 
            // lblTipoEmpleado
            // 
            this.lblTipoEmpleado.AutoSize = true;
            this.lblTipoEmpleado.Location = new System.Drawing.Point(6, 18);
            this.lblTipoEmpleado.Name = "lblTipoEmpleado";
            this.lblTipoEmpleado.Size = new System.Drawing.Size(205, 17);
            this.lblTipoEmpleado.TabIndex = 13;
            this.lblTipoEmpleado.Text = "Seleccione el tipo de empleado";
            // 
            // F3BuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 821);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.lblBuscarEmpleado);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnLimpiarLista);
            this.Controls.Add(this.lvListaBuscarEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F3BuscarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Empleado";
            this.Load += new System.EventHandler(this.F3BuscarEmpleado_Load);
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvListaBuscarEmpleados;
        private System.Windows.Forms.Button btnLimpiarLista;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblBuscarEmpleado;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboTipoEmpleado;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Label lblTipoEmpleado;
        private System.Windows.Forms.ComboBox cboSalarioBruto;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Label label1;
    }
}