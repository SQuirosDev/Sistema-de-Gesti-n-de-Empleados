
namespace Proyecto
{
    partial class F4ListaEmpleados
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
            this.lvListaEmpleados = new System.Windows.Forms.ListView();
            this.lblListaEmpleados = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.gbCategorias = new System.Windows.Forms.GroupBox();
            this.gbCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvListaEmpleados
            // 
            this.lvListaEmpleados.HideSelection = false;
            this.lvListaEmpleados.Location = new System.Drawing.Point(12, 138);
            this.lvListaEmpleados.Name = "lvListaEmpleados";
            this.lvListaEmpleados.Size = new System.Drawing.Size(1066, 610);
            this.lvListaEmpleados.TabIndex = 0;
            this.lvListaEmpleados.UseCompatibleStateImageBehavior = false;
            this.lvListaEmpleados.View = System.Windows.Forms.View.Details;
            // 
            // lblListaEmpleados
            // 
            this.lblListaEmpleados.AutoSize = true;
            this.lblListaEmpleados.Font = new System.Drawing.Font("Bodoni MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaEmpleados.ForeColor = System.Drawing.Color.Black;
            this.lblListaEmpleados.Location = new System.Drawing.Point(12, 9);
            this.lblListaEmpleados.Name = "lblListaEmpleados";
            this.lblListaEmpleados.Size = new System.Drawing.Size(268, 47);
            this.lblListaEmpleados.TabIndex = 1;
            this.lblListaEmpleados.Text = "Lista de Empleados";
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(957, 754);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(121, 55);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Cerrar";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarLista.ForeColor = System.Drawing.Color.Black;
            this.btnMostrarLista.Location = new System.Drawing.Point(309, 20);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(155, 44);
            this.btnMostrarLista.TabIndex = 4;
            this.btnMostrarLista.Text = "Mostrar lista";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(470, 20);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 44);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(6, 32);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(297, 24);
            this.cboEmpleado.TabIndex = 6;
            // 
            // gbCategorias
            // 
            this.gbCategorias.Controls.Add(this.btnLimpiar);
            this.gbCategorias.Controls.Add(this.btnMostrarLista);
            this.gbCategorias.Controls.Add(this.cboEmpleado);
            this.gbCategorias.Location = new System.Drawing.Point(12, 59);
            this.gbCategorias.Name = "gbCategorias";
            this.gbCategorias.Size = new System.Drawing.Size(617, 73);
            this.gbCategorias.TabIndex = 8;
            this.gbCategorias.TabStop = false;
            this.gbCategorias.Text = " ";
            // 
            // F4ListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 821);
            this.Controls.Add(this.gbCategorias);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblListaEmpleados);
            this.Controls.Add(this.lvListaEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F4ListaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Empleados";
            this.Load += new System.EventHandler(this.ListaEmpleados_Load);
            this.gbCategorias.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvListaEmpleados;
        private System.Windows.Forms.Label lblListaEmpleados;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.GroupBox gbCategorias;
    }
}