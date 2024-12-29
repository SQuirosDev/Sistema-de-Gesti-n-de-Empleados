using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class F4ListaEmpleados : Form
    {
        private const string ArchivoPath1 = "C:\\Users\\se13q\\OneDrive\\Desktop\\Proyecto\\Proyecto\\Datos\\Lista de Empleados Tiempo Completo.txt";
        private const string ArchivoPath2 = "C:\\Users\\se13q\\OneDrive\\Desktop\\Proyecto\\Proyecto\\Datos\\Lista de Empleados Tiempo Parcial.txt";
        
        LogicaNegocios LN = new LogicaNegocios();

        public F4ListaEmpleados()
        {
            InitializeComponent();
            CargarcboEmpleados();
        }

        private void ListaEmpleados_Load(object sender, EventArgs e)
        {
            lvListaEmpleados.View = View.Details;
            lvListaEmpleados.Columns.Add("Tipo", 160);
            lvListaEmpleados.Columns.Add("Id", 100);
            lvListaEmpleados.Columns.Add("Nombre Completo", 200);
            lvListaEmpleados.Columns.Add("Edad", 100);
            lvListaEmpleados.Columns.Add("Cedula",120);
            lvListaEmpleados.Columns.Add("Salario Bruto", 120);
            lvListaEmpleados.Columns.Add("Salario Neto", 120);
            lvListaEmpleados.Columns.Add("Impuestos", 150);
            lvListaEmpleados.Columns.Add("Salario Trimestral", 150);
            lvListaEmpleados.Columns.Add("Salario Semestral", 150);
            lvListaEmpleados.Columns.Add("Salario Anual", 150);
        }

        public void CargarcboEmpleados()
        {
            string[] Tipos = { "Lista General", "Lista de Empleado de Tiempo Completo", "Lista de Empleado de Tiempo Parcial" };
            cboEmpleado.DataSource = Tipos;
            cboEmpleado.SelectedIndex = -1;
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedIndex == 0)
            {
                lvListaEmpleados.Items.Clear();
                CargarDatosEmpleadosTiempoCompleto();
                CargarDatosEmpleadosTiempoParcial();
            }
            else if (cboEmpleado.SelectedIndex == 1)
            {
                lvListaEmpleados.Items.Clear();
                CargarDatosEmpleadosTiempoCompleto();
            }
            else if (cboEmpleado.SelectedIndex == 2)
            {
                lvListaEmpleados.Items.Clear();
                CargarDatosEmpleadosTiempoParcial();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de Lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboEmpleado.SelectedIndex = -1;
            lvListaEmpleados.Items.Clear();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
     
        //-------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------

        //CARGAR DATOS A LA LISTA

        public void CargarDatosEmpleadosTiempoCompleto()
        {
            List<EmpleadoTiempoCompleto> ListaEmpleadosTiempoCompleto = LN.ObtenerListaEmpleadoTiempoCompleto(ArchivoPath1);

            foreach (var EmpleadoTiempoCompleto in ListaEmpleadosTiempoCompleto)
            {
                ListViewItem Item = new ListViewItem(new string[] { EmpleadoTiempoCompleto.Tipo, EmpleadoTiempoCompleto.IdEmpeladoTiempoCompleto.ToString(), EmpleadoTiempoCompleto.NombreCompleto, EmpleadoTiempoCompleto.Edad.ToString(), EmpleadoTiempoCompleto.Cedula.ToString(), EmpleadoTiempoCompleto.SalarioBruto.ToString(), EmpleadoTiempoCompleto.SalarioNeto.ToString(), EmpleadoTiempoCompleto.Impuesto.ToString(), EmpleadoTiempoCompleto.SalarioTrimestral.ToString(), EmpleadoTiempoCompleto.SalarioSemestral.ToString(), EmpleadoTiempoCompleto.SalarioAnual.ToString()});

                lvListaEmpleados.Items.Add(Item);
            }
        }

        public void CargarDatosEmpleadosTiempoParcial()
        {
            List<EmpleadoTiempoParcial> ListaEmpleadoTiempoParcial = LN.ObtenerListaEmpleadoTiempoParcial(ArchivoPath2);

            foreach (var EmpleadoTiempoParcial in ListaEmpleadoTiempoParcial)
            {
                ListViewItem Item = new ListViewItem(new string[] { EmpleadoTiempoParcial.Tipo, EmpleadoTiempoParcial.IdEmpeladoTiempoParcial.ToString(), EmpleadoTiempoParcial.NombreCompleto, EmpleadoTiempoParcial.Edad.ToString(), EmpleadoTiempoParcial.Cedula.ToString(), EmpleadoTiempoParcial.SalarioBruto.ToString(), EmpleadoTiempoParcial.SalarioNeto.ToString(), EmpleadoTiempoParcial.Impuesto.ToString(), EmpleadoTiempoParcial.SalarioTrimestral.ToString(), EmpleadoTiempoParcial.SalarioSemestral.ToString(), EmpleadoTiempoParcial.SalarioAnual.ToString() });

                lvListaEmpleados.Items.Add(Item);
            }
        }
    }
}