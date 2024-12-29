
namespace Proyecto
{
    partial class F5SalarioEmpresa
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
            this.btnCalcularSalarioEmpresa = new System.Windows.Forms.Button();
            this.lvSalarioEmpresa = new System.Windows.Forms.ListView();
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtTotalSalarioBruto = new System.Windows.Forms.TextBox();
            this.lblTotalSalarioNeto = new System.Windows.Forms.Label();
            this.txtTotalSalarioNeto = new System.Windows.Forms.TextBox();
            this.lblTotalSalarioBruto = new System.Windows.Forms.Label();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.lblListaEmpleados = new System.Windows.Forms.Label();
            this.gbFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcularSalarioEmpresa
            // 
            this.btnCalcularSalarioEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularSalarioEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSalarioEmpresa.ForeColor = System.Drawing.Color.Black;
            this.btnCalcularSalarioEmpresa.Location = new System.Drawing.Point(12, 631);
            this.btnCalcularSalarioEmpresa.Name = "btnCalcularSalarioEmpresa";
            this.btnCalcularSalarioEmpresa.Size = new System.Drawing.Size(121, 55);
            this.btnCalcularSalarioEmpresa.TabIndex = 2;
            this.btnCalcularSalarioEmpresa.Text = "Calcular";
            this.btnCalcularSalarioEmpresa.UseVisualStyleBackColor = true;
            this.btnCalcularSalarioEmpresa.Click += new System.EventHandler(this.btnCalcularSalarioEmpresa_Click);
            // 
            // lvSalarioEmpresa
            // 
            this.lvSalarioEmpresa.HideSelection = false;
            this.lvSalarioEmpresa.Location = new System.Drawing.Point(12, 59);
            this.lvSalarioEmpresa.Name = "lvSalarioEmpresa";
            this.lvSalarioEmpresa.Size = new System.Drawing.Size(1066, 566);
            this.lvSalarioEmpresa.TabIndex = 3;
            this.lvSalarioEmpresa.UseCompatibleStateImageBehavior = false;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(957, 754);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(121, 55);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Cerrar";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // txtTotalSalarioBruto
            // 
            this.txtTotalSalarioBruto.Location = new System.Drawing.Point(6, 38);
            this.txtTotalSalarioBruto.Name = "txtTotalSalarioBruto";
            this.txtTotalSalarioBruto.Size = new System.Drawing.Size(396, 22);
            this.txtTotalSalarioBruto.TabIndex = 5;
            // 
            // lblTotalSalarioNeto
            // 
            this.lblTotalSalarioNeto.AutoSize = true;
            this.lblTotalSalarioNeto.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSalarioNeto.Location = new System.Drawing.Point(6, 63);
            this.lblTotalSalarioNeto.Name = "lblTotalSalarioNeto";
            this.lblTotalSalarioNeto.Size = new System.Drawing.Size(122, 17);
            this.lblTotalSalarioNeto.TabIndex = 9;
            this.lblTotalSalarioNeto.Text = "Total Salario Neto";
            // 
            // txtTotalSalarioNeto
            // 
            this.txtTotalSalarioNeto.Location = new System.Drawing.Point(6, 83);
            this.txtTotalSalarioNeto.Name = "txtTotalSalarioNeto";
            this.txtTotalSalarioNeto.Size = new System.Drawing.Size(396, 22);
            this.txtTotalSalarioNeto.TabIndex = 8;
            // 
            // lblTotalSalarioBruto
            // 
            this.lblTotalSalarioBruto.AutoSize = true;
            this.lblTotalSalarioBruto.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSalarioBruto.Location = new System.Drawing.Point(6, 18);
            this.lblTotalSalarioBruto.Name = "lblTotalSalarioBruto";
            this.lblTotalSalarioBruto.Size = new System.Drawing.Size(126, 17);
            this.lblTotalSalarioBruto.TabIndex = 7;
            this.lblTotalSalarioBruto.Text = "Total Salario Bruto";
            // 
            // gbFactura
            // 
            this.gbFactura.Controls.Add(this.lblTotalSalarioBruto);
            this.gbFactura.Controls.Add(this.txtTotalSalarioBruto);
            this.gbFactura.Controls.Add(this.txtTotalSalarioNeto);
            this.gbFactura.Controls.Add(this.lblTotalSalarioNeto);
            this.gbFactura.Location = new System.Drawing.Point(12, 692);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(412, 118);
            this.gbFactura.TabIndex = 11;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = " ";
            // 
            // lblListaEmpleados
            // 
            this.lblListaEmpleados.AutoSize = true;
            this.lblListaEmpleados.Font = new System.Drawing.Font("Bodoni MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaEmpleados.ForeColor = System.Drawing.Color.Black;
            this.lblListaEmpleados.Location = new System.Drawing.Point(12, 9);
            this.lblListaEmpleados.Name = "lblListaEmpleados";
            this.lblListaEmpleados.Size = new System.Drawing.Size(306, 47);
            this.lblListaEmpleados.TabIndex = 12;
            this.lblListaEmpleados.Text = "Salario de la Empresa";
            // 
            // F5SalarioEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 821);
            this.Controls.Add(this.lblListaEmpleados);
            this.Controls.Add(this.gbFactura);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lvSalarioEmpresa);
            this.Controls.Add(this.btnCalcularSalarioEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F5SalarioEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salario de la Empresa";
            this.Load += new System.EventHandler(this.SalarioEmpresa_Load);
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalcularSalarioEmpresa;
        private System.Windows.Forms.ListView lvSalarioEmpresa;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtTotalSalarioBruto;
        private System.Windows.Forms.Label lblTotalSalarioBruto;
        private System.Windows.Forms.Label lblTotalSalarioNeto;
        private System.Windows.Forms.TextBox txtTotalSalarioNeto;
        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.Label lblListaEmpleados;
    }
}