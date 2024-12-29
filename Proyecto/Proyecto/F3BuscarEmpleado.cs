using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class F3BuscarEmpleado : Form
    {
        private const string ArchivoPath1 = "C:\\Users\\se13q\\OneDrive\\Desktop\\Proyecto\\Proyecto\\Datos\\Lista de Empleados Tiempo Completo.txt";
        private const string ArchivoPath2 = "C:\\Users\\se13q\\OneDrive\\Desktop\\Proyecto\\Proyecto\\Datos\\Lista de Empleados Tiempo Parcial.txt";
        
        LogicaNegocios LN = new LogicaNegocios();

        public F3BuscarEmpleado()
        {
            InitializeComponent();
            CargarcboTipoEmpleado();
            CargarcboSalarioBruto();
        }

        private void F3BuscarEmpleado_Load(object sender, EventArgs e)
        {
            lvListaBuscarEmpleados.View = View.Details;
            lvListaBuscarEmpleados.Columns.Add("Id", 100);
            lvListaBuscarEmpleados.Columns.Add("Nombre Completo", 200);
            lvListaBuscarEmpleados.Columns.Add("Cedula", 120);
            lvListaBuscarEmpleados.Columns.Add("Edad", 100);
            lvListaBuscarEmpleados.Columns.Add("Salario Bruto", 120);
            lvListaBuscarEmpleados.Columns.Add("Salario Neto", 120);
            lvListaBuscarEmpleados.Columns.Add("Impuestos", 150);
            lvListaBuscarEmpleados.Columns.Add("Salario Trimestral", 150);
            lvListaBuscarEmpleados.Columns.Add("Salario Semestral", 150);
            lvListaBuscarEmpleados.Columns.Add("Salario Anual", 150);
            lvListaBuscarEmpleados.Columns.Add("Tipo", 160);
        }

        public void CargarcboTipoEmpleado()
        {
            string[] Tipos = {"Empleado de Tiempo Completo", "Empleado de Tiempo Parcial" };
            cboTipoEmpleado.DataSource = Tipos;
            cboTipoEmpleado.SelectedIndex = -1;
            cboTipoEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void CargarcboSalarioBruto()
        {
            string[] SalariosBrutos = { "Menor o igual a 800000", "Mayor a 800000 y menor o igual a 1000000", "Mayor a 1000000 y menor o igual a 1500000", "Mayor a 1500000" };
            cboSalarioBruto.DataSource = SalariosBrutos;
            cboSalarioBruto.SelectedIndex = -1;
            cboSalarioBruto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboTipoEmpleado.Text == "Empleado de Tiempo Completo")
            {
                if (!string.IsNullOrWhiteSpace(txtBuscar.Text) || cboSalarioBruto.SelectedIndex != -1)
                {
                    lvListaBuscarEmpleados.Items.Clear();
                    CargarDatosEmpleadosTiempoCompleto();
                }
                else
                {
                    MessageBox.Show("Falta por ingresar informacion o selecionar un rango de salario para buscar", "Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (cboTipoEmpleado.Text == "Empleado de Tiempo Parcial")
            {
                if (!string.IsNullOrWhiteSpace(txtBuscar.Text) || cboSalarioBruto.SelectedIndex != -1)
                {
                    lvListaBuscarEmpleados.Items.Clear();
                    CargarDatosEmpleadosTiempoParcial();
                }
                else
                {
                    MessageBox.Show("Falta por ingresar informacion o selecionar un rango de salario para buscar", "Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar un tipo de empleado", "Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            string EmpleadoEliminar = txtEliminar.Text;

            if (cboTipoEmpleado.Text == "Empleado de Tiempo Completo")
            {
                if (!string.IsNullOrWhiteSpace(txtEliminar.Text))
                {
                    LN.BorrarEmpleado(ArchivoPath1, EmpleadoEliminar);

                    MessageBox.Show($"La línea con la información '{EmpleadoEliminar}' fue encontrada y eliminada", "Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falta por ingresar el nombre del empleado que desea eliminar", "Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (cboTipoEmpleado.Text == "Empleado de Tiempo Parcial")
            {
                if (!string.IsNullOrWhiteSpace(txtEliminar.Text))
                {
                    LN.BorrarEmpleado(ArchivoPath2, EmpleadoEliminar);

                    MessageBox.Show($"La línea con la información '{EmpleadoEliminar}' fue encontrada y eliminada", "Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falta por ingresar el nombre del empleado que desea eliminar", "Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar un tipo de empleado", "Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboTipoEmpleado.SelectedIndex = -1;
            txtBuscar.Text = string.Empty;
            cboSalarioBruto.SelectedIndex = -1;
            txtEliminar.Text = string.Empty;
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            lvListaBuscarEmpleados.Items.Clear();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //-------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------

        //TIEMPO COMPLETO

        public void CargarDatosEmpleadosTiempoCompleto()
        {
            List<EmpleadoTiempoCompleto> ListaEmpleadosTiempoCompleto = LN.ObtenerListaEmpleadoTiempoCompleto(ArchivoPath1);

            foreach (var EmpleadoTiempoCompleto in ListaEmpleadosTiempoCompleto)
            {
                if (txtBuscar.Text == EmpleadoTiempoCompleto.IdEmpeladoTiempoCompleto.ToString() || txtBuscar.Text == EmpleadoTiempoCompleto.Nombre || txtBuscar.Text == EmpleadoTiempoCompleto.NombreCompleto || txtBuscar.Text == EmpleadoTiempoCompleto.Edad.ToString())
                {
                    ListViewItem Item = new ListViewItem(new string[] { EmpleadoTiempoCompleto.IdEmpeladoTiempoCompleto.ToString(), EmpleadoTiempoCompleto.NombreCompleto, EmpleadoTiempoCompleto.Cedula.ToString(), EmpleadoTiempoCompleto.Edad.ToString(), EmpleadoTiempoCompleto.SalarioBruto.ToString(), EmpleadoTiempoCompleto.SalarioNeto.ToString(), EmpleadoTiempoCompleto.Impuesto.ToString(), EmpleadoTiempoCompleto.SalarioTrimestral.ToString(), EmpleadoTiempoCompleto.SalarioSemestral.ToString(), EmpleadoTiempoCompleto.SalarioAnual.ToString(), EmpleadoTiempoCompleto.Tipo }) ;

                    lvListaBuscarEmpleados.Items.Add(Item);
                }
                else if (cboSalarioBruto.Text == "Menor o igual a 800000")
                {
                    if (EmpleadoTiempoCompleto.SalarioBruto <= 800000)
                    {
                        ListViewItem Item = new ListViewItem(new string[] { EmpleadoTiempoCompleto.IdEmpeladoTiempoCompleto.ToString(), EmpleadoTiempoCompleto.NombreCompleto, EmpleadoTiempoCompleto.Cedula.ToString(), EmpleadoTiempoCompleto.Edad.ToString(), EmpleadoTiempoCompleto.SalarioBruto.ToString(), EmpleadoTiempoCompleto.SalarioNeto.ToString(), EmpleadoTiempoCompleto.Impuesto.ToString(), EmpleadoTiempoCompleto.SalarioTrimestral.ToString(), EmpleadoTiempoCompleto.SalarioSemestral.ToString(), EmpleadoTiempoCompleto.SalarioAnual.ToString(), EmpleadoTiempoCompleto.Tipo });

                        lvListaBuscarEmpleados.Items.Add(Item);
                    }
                }
                else if (cboSalarioBruto.Text == "Mayor a 800000 y menor o igual a 1000000")
                {
                    if (EmpleadoTiempoCompleto.SalarioBruto > 800000 && EmpleadoTiempoCompleto.SalarioBruto <= 1000000)
                    {
                        ListViewItem Item = new ListViewItem(new string[] { EmpleadoTiempoCompleto.IdEmpeladoTiempoCompleto.ToString(), EmpleadoTiempoCompleto.NombreCompleto, EmpleadoTiempoCompleto.Cedula.ToString(), EmpleadoTiempoCompleto.Edad.ToString(), EmpleadoTiempoCompleto.SalarioBruto.ToString(), EmpleadoTiempoCompleto.SalarioNeto.ToString(), EmpleadoTiempoCompleto.Impuesto.ToString(), EmpleadoTiempoCompleto.SalarioTrimestral.ToString(), EmpleadoTiempoCompleto.SalarioSemestral.ToString(), EmpleadoTiempoCompleto.SalarioAnual.ToString(), EmpleadoTiempoCompleto.Tipo });

                        lvListaBuscarEmpleados.Items.Add(Item);
                    }
                }
                else if (cboSalarioBruto.Text == "Mayor a 1000000 y menor o igual a 1500000")
                {
                    if (EmpleadoTiempoCompleto.SalarioBruto > 1000000 && EmpleadoTiempoCompleto.SalarioBruto <= 1500000)
                    {
                        ListViewItem Item = new ListViewItem(new string[] { EmpleadoTiempoCompleto.IdEmpeladoTiempoCompleto.ToString(), EmpleadoTiempoCompleto.NombreCompleto, EmpleadoTiempoCompleto.Cedula.ToString(), EmpleadoTiempoCompleto.Edad.ToString(), EmpleadoTiempoCompleto.SalarioBruto.ToString(), EmpleadoTiempoCompleto.SalarioNeto.ToString(), EmpleadoTiempoCompleto.Impuesto.ToString(), EmpleadoTiempoCompleto.SalarioTrimestral.ToString(), EmpleadoTiempoCompleto.SalarioSemestral.ToString(), EmpleadoTiempoCompleto.SalarioAnual.ToString(), EmpleadoTiempoCompleto.Tipo });

                        lvListaBuscarEmpleados.Items.Add(Item);
                    }
                }
                else if (cboSalarioBruto.Text == "Mayor a 1500000")
                {
                    if (EmpleadoTiempoCompleto.SalarioBruto > 1500000)
                    {
                        ListViewItem Item = new ListViewItem(new string[] { EmpleadoTiempoCompleto.IdEmpeladoTiempoCompleto.ToString(), EmpleadoTiempoCompleto.NombreCompleto, EmpleadoTiempoCompleto.Cedula.ToString(), EmpleadoTiempoCompleto.Edad.ToString(), EmpleadoTiempoCompleto.SalarioBruto.ToString(), EmpleadoTiempoCompleto.SalarioNeto.ToString(), EmpleadoTiempoCompleto.Impuesto.ToString(), EmpleadoTiempoCompleto.SalarioTrimestral.ToString(), EmpleadoTiempoCompleto.SalarioSemestral.ToString(), EmpleadoTiempoCompleto.SalarioAnual.ToString(), EmpleadoTiempoCompleto.Tipo });

                        lvListaBuscarEmpleados.Items.Add(Item);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------

        //TIEMPO PARCIAL

        public void CargarDatosEmpleadosTiempoParcial()
        {
            List<EmpleadoTiempoParcial> ListaEmpleadoTiempoParcial = LN.ObtenerListaEmpleadoTiempoParcial(ArchivoPath2);

            foreach (var EmpleadoTiempoParcial in ListaEmpleadoTiempoParcial)
            {
                if (txtBuscar.Text == EmpleadoTiempoParcial.IdEmpeladoTiempoParcial.ToString() || txtBuscar.Text == EmpleadoTiempoParcial.Nombre || txtBuscar.Text == EmpleadoTiempoParcial.NombreCompleto || txtBuscar.Text == EmpleadoTiempoParcial.Edad.ToString())
                {
                    ListViewItem item = new ListViewItem(new string[] { EmpleadoTiempoParcial.IdEmpeladoTiempoParcial.ToString(), EmpleadoTiempoParcial.NombreCompleto, EmpleadoTiempoParcial.Cedula.ToString(), EmpleadoTiempoParcial.Edad.ToString(), EmpleadoTiempoParcial.SalarioBruto.ToString(), EmpleadoTiempoParcial.SalarioNeto.ToString(), EmpleadoTiempoParcial.Impuesto.ToString(), EmpleadoTiempoParcial.SalarioTrimestral.ToString(), EmpleadoTiempoParcial.SalarioSemestral.ToString(), EmpleadoTiempoParcial.SalarioAnual.ToString(), EmpleadoTiempoParcial.Tipo }) ;

                    lvListaBuscarEmpleados.Items.Add(item);
                }
                else if (cboSalarioBruto.Text == "Menor o igual a 800000")
                {
                    if (EmpleadoTiempoParcial.SalarioBruto <= 800000)
                    {
                        ListViewItem item = new ListViewItem(new string[] { EmpleadoTiempoParcial.IdEmpeladoTiempoParcial.ToString(), EmpleadoTiempoParcial.NombreCompleto, EmpleadoTiempoParcial.Cedula.ToString(), EmpleadoTiempoParcial.Edad.ToString(), EmpleadoTiempoParcial.SalarioBruto.ToString(), EmpleadoTiempoParcial.SalarioNeto.ToString(), EmpleadoTiempoParcial.Impuesto.ToString(), EmpleadoTiempoParcial.SalarioTrimestral.ToString(), EmpleadoTiempoParcial.SalarioSemestral.ToString(), EmpleadoTiempoParcial.SalarioAnual.ToString(), EmpleadoTiempoParcial.Tipo });

                        lvListaBuscarEmpleados.Items.Add(item);
                    }
                }
                else if (cboSalarioBruto.Text == "Mayor a 800000 y menor o igual a 1000000")
                {
                    if (EmpleadoTiempoParcial.SalarioBruto > 800000 && EmpleadoTiempoParcial.SalarioBruto <= 1000000)
                    {
                        ListViewItem item = new ListViewItem(new string[] { EmpleadoTiempoParcial.IdEmpeladoTiempoParcial.ToString(), EmpleadoTiempoParcial.NombreCompleto, EmpleadoTiempoParcial.Cedula.ToString(), EmpleadoTiempoParcial.Edad.ToString(), EmpleadoTiempoParcial.SalarioBruto.ToString(), EmpleadoTiempoParcial.SalarioNeto.ToString(), EmpleadoTiempoParcial.Impuesto.ToString(), EmpleadoTiempoParcial.SalarioTrimestral.ToString(), EmpleadoTiempoParcial.SalarioSemestral.ToString(), EmpleadoTiempoParcial.SalarioAnual.ToString(), EmpleadoTiempoParcial.Tipo });

                        lvListaBuscarEmpleados.Items.Add(item);
                    }
                }
                else if (cboSalarioBruto.Text == "Mayor a 1000000 y menor o igual a 1500000")
                {
                    if (EmpleadoTiempoParcial.SalarioBruto > 1000000 && EmpleadoTiempoParcial.SalarioBruto <= 1500000)
                    {
                        ListViewItem item = new ListViewItem(new string[] { EmpleadoTiempoParcial.IdEmpeladoTiempoParcial.ToString(), EmpleadoTiempoParcial.NombreCompleto, EmpleadoTiempoParcial.Cedula.ToString(), EmpleadoTiempoParcial.Edad.ToString(), EmpleadoTiempoParcial.SalarioBruto.ToString(), EmpleadoTiempoParcial.SalarioNeto.ToString(), EmpleadoTiempoParcial.Impuesto.ToString(), EmpleadoTiempoParcial.SalarioTrimestral.ToString(), EmpleadoTiempoParcial.SalarioSemestral.ToString(), EmpleadoTiempoParcial.SalarioAnual.ToString(), EmpleadoTiempoParcial.Tipo });

                        lvListaBuscarEmpleados.Items.Add(item);
                    }
                }
                else if (cboSalarioBruto.Text == "Mayor a 1500000")
                {
                    if (EmpleadoTiempoParcial.SalarioBruto > 1500000)
                    {
                        ListViewItem item = new ListViewItem(new string[] { EmpleadoTiempoParcial.IdEmpeladoTiempoParcial.ToString(), EmpleadoTiempoParcial.NombreCompleto, EmpleadoTiempoParcial.Cedula.ToString(), EmpleadoTiempoParcial.Edad.ToString(), EmpleadoTiempoParcial.SalarioBruto.ToString(), EmpleadoTiempoParcial.SalarioNeto.ToString(), EmpleadoTiempoParcial.Impuesto.ToString(), EmpleadoTiempoParcial.SalarioTrimestral.ToString(), EmpleadoTiempoParcial.SalarioSemestral.ToString(), EmpleadoTiempoParcial.SalarioAnual.ToString(), EmpleadoTiempoParcial.Tipo });

                        lvListaBuscarEmpleados.Items.Add(item);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                cboSalarioBruto.SelectedIndex = -1;
            }
        }

        private void cboSalarioBruto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSalarioBruto.SelectedIndex != -1)
            {
                txtBuscar.Text = string.Empty;
            }
        }
    }
}