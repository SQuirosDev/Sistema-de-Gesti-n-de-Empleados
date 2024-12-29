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
    public partial class F5SalarioEmpresa : Form
    {
        private const string ArchivoPath1 = "C:\\Users\\se13q\\OneDrive\\Desktop\\Proyecto\\Proyecto\\Datos\\Lista de Empleados Tiempo Completo.txt";
        private const string ArchivoPath2 = "C:\\Users\\se13q\\OneDrive\\Desktop\\Proyecto\\Proyecto\\Datos\\Lista de Empleados Tiempo Parcial.txt";
        
        LogicaNegocios LN = new LogicaNegocios();

        public F5SalarioEmpresa()
        {
            InitializeComponent();
        }

        private void SalarioEmpresa_Load(object sender, EventArgs e)
        {
            lvSalarioEmpresa.View = View.Details;
            lvSalarioEmpresa.Columns.Add("Salario Bruto", 120);
            lvSalarioEmpresa.Columns.Add("Salario Neto", 120);
            lvSalarioEmpresa.Columns.Add("Nombre Completo", 200);
            lvSalarioEmpresa.Columns.Add("Tipo", 200);
        }

        private void btnCalcularSalarioEmpresa_Click(object sender, EventArgs e)
        {
            CargarDatosEmpleadosTiempoCompleto();
            CargarDatosEmpleadosTiempoParcial();
            CalcularSalarioBrutoEmpresa();
            CalcularSalarioNetoEmpresa();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //-----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------

        public void CalcularSalarioBrutoEmpresa()
        {
            List<EmpleadoTiempoCompleto> ListaEmpleadoTiempoCompleta = LN.ObtenerListaEmpleadoTiempoCompleto(ArchivoPath1);
            List<EmpleadoTiempoParcial> ListaEmpleadoTiempoParcial = LN.ObtenerListaEmpleadoTiempoParcial(ArchivoPath2);

            double salarioEmpresa = 0;

            foreach (var EmpleadoTiempoCompleto in ListaEmpleadoTiempoCompleta)
            {
                salarioEmpresa += EmpleadoTiempoCompleto.SalarioBruto;
            }

            foreach (var EmpleadoTiempoParcial in ListaEmpleadoTiempoParcial)
            {
                salarioEmpresa += EmpleadoTiempoParcial.SalarioBruto;
            }


            txtTotalSalarioBruto.Text = salarioEmpresa.ToString();
        }

        public void CalcularSalarioNetoEmpresa()
        {
            List<EmpleadoTiempoCompleto> ListaEmpleadoTiempoCompleta = LN.ObtenerListaEmpleadoTiempoCompleto(ArchivoPath1);
            List<EmpleadoTiempoParcial> ListaEmpleadoTiempoParcial = LN.ObtenerListaEmpleadoTiempoParcial(ArchivoPath2);

            double salarioEmpresa = 0;

            foreach (var EmpleadoTiempoCompleto in ListaEmpleadoTiempoCompleta)
            {
                salarioEmpresa += EmpleadoTiempoCompleto.SalarioNeto;
            }

            foreach (var EmpleadoTiempoParcial in ListaEmpleadoTiempoParcial)
            {
                salarioEmpresa += EmpleadoTiempoParcial.SalarioNeto;
            }


            txtTotalSalarioNeto.Text = salarioEmpresa.ToString();
        }

        //-----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------

        //CARGAR DATOS A LA LISTA

        public void CargarDatosEmpleadosTiempoCompleto()
        {
            List<EmpleadoTiempoCompleto> ListaEmpleadoTiempoCompleta = LN.ObtenerListaEmpleadoTiempoCompleto(ArchivoPath1);

            foreach (var EmpleadoTiempoCompleto in ListaEmpleadoTiempoCompleta)
            {
                ListViewItem Item = new ListViewItem(new string[] { EmpleadoTiempoCompleto.SalarioBruto.ToString(), EmpleadoTiempoCompleto.SalarioNeto.ToString(), EmpleadoTiempoCompleto.NombreCompleto, EmpleadoTiempoCompleto.Tipo });

                lvSalarioEmpresa.Items.Add(Item);
            }
        }

        public void CargarDatosEmpleadosTiempoParcial()
        {
            List<EmpleadoTiempoParcial> ListaEmpleadoTiempoParcial = LN.ObtenerListaEmpleadoTiempoParcial(ArchivoPath2);

            foreach (var EmpleadoTiempoParcial in ListaEmpleadoTiempoParcial)
            {
                ListViewItem Item = new ListViewItem(new string[] { EmpleadoTiempoParcial.SalarioBruto.ToString(), EmpleadoTiempoParcial.SalarioNeto.ToString(), EmpleadoTiempoParcial.NombreCompleto, EmpleadoTiempoParcial.Tipo});

                lvSalarioEmpresa.Items.Add(Item);
            }
        }
    }
}