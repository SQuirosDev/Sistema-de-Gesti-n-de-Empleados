using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class F1Menu : Form
    {
        public F1Menu()
        {
            InitializeComponent();
            pbRestaurar.Visible = false;
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            AbrirForms(new F2AgregarEmpleado());
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            AbrirForms(new F3BuscarEmpleado());
        }

        private void btnListaEmpleados_Click(object sender, EventArgs e)
        {
            AbrirForms(new F4ListaEmpleados());
        }

        private void btnSalarioEmpresa_Click(object sender, EventArgs e)
        {
            AbrirForms(new F5SalarioEmpresa());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //-----------------------------------------------------------------------
        //-----------------------------------------------------------------------

        //Menu Superior

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
        }

        private void pbRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbRestaurar.Visible = false;
            pbMaximizar.Visible = true;
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //-----------------------------------------------------------------------
        //-----------------------------------------------------------------------

        private void AbrirForms(Object forms)
        {
            if (this.pContenedor.Controls.Count > 0) // si existe algun control en el interior del panel
            {
                this.pContenedor.Controls.RemoveAt(0); // si existe alguno se elimina
            }

            Form form = forms as Form; // as para convertirlo en formulario
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pContenedor.Controls.Add(form);
            this.pContenedor.Tag = form;
            form.Show();
        }

        //-----------------------------------------------------------------------
        //-----------------------------------------------------------------------

    }
}