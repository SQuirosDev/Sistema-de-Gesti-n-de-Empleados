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
    public partial class F2AgregarEmpleado : Form
    {
        private const string ArchivoPath1 = "C:\\Users\\se13q\\OneDrive\\Desktop\\Proyecto\\Proyecto\\Datos\\Lista de Empleados Tiempo Completo.txt";
        private const string ArchivoPath2 = "C:\\Users\\se13q\\OneDrive\\Desktop\\Proyecto\\Proyecto\\Datos\\Lista de Empleados Tiempo Parcial.txt";
        
        LogicaNegocios LN = new LogicaNegocios();

        private Random IdRandom = new Random();

        public F2AgregarEmpleado()
        {
            InitializeComponent();
            CargarcboTipoEmpleado();
            txtId.Enabled = false;
        }

        public void CargarcboTipoEmpleado()
        {
            string[] Tipos = {"Empleado de Tiempo Completo", "Empleado de Tiempo Parcial" };
            cboTipoEmpleado.DataSource = Tipos;
            cboTipoEmpleado.SelectedIndex = -1;
            cboTipoEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (cboTipoEmpleado.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtApellido1.Text) && !string.IsNullOrWhiteSpace(txtApellido2.Text) && !string.IsNullOrWhiteSpace(txtEdad.Text) && !string.IsNullOrWhiteSpace(txtCedula.Text) && !string.IsNullOrWhiteSpace(txtId.Text) && !string.IsNullOrWhiteSpace(txtSalarioBruto.Text))
            { 
                if (cboTipoEmpleado.Text == "Empleado de Tiempo Completo")
                {
                    EmpleadoTiempoCompleto EmpleadoTiempoCompleto = new EmpleadoTiempoCompleto();

                    EmpleadoTiempoCompleto.Tipo = cboTipoEmpleado.Text; //1
                    EmpleadoTiempoCompleto.Nombre = txtNombre.Text; //2
                    EmpleadoTiempoCompleto.Apellido1 = txtApellido1.Text; //3
                    EmpleadoTiempoCompleto.Apellido2 = txtApellido2.Text; //4
                    EmpleadoTiempoCompleto.Cedula = Convert.ToInt32(txtCedula.Text); //5
                    EmpleadoTiempoCompleto.Edad = Convert.ToInt32(txtEdad.Text); //6
                    EmpleadoTiempoCompleto.SalarioBruto = Convert.ToDouble(txtSalarioBruto.Text); //7
                    EmpleadoTiempoCompleto.SalarioNeto = EmpleadoTiempoCompleto.CalcularSalarioNeto(); //8
                    EmpleadoTiempoCompleto.Impuesto = EmpleadoTiempoCompleto.ImpuestoCCSSRenta(); //9
                    EmpleadoTiempoCompleto.SalarioTrimestral = EmpleadoTiempoCompleto.CalcularSalarioTrimestral(); //10
                    EmpleadoTiempoCompleto.SalarioSemestral = EmpleadoTiempoCompleto.CalcularSalarioSemestral(); //11
                    EmpleadoTiempoCompleto.SalarioAnual = EmpleadoTiempoCompleto.CalcularSalarioAnual(); // 12
                    EmpleadoTiempoCompleto.IdEmpeladoTiempoCompleto = Convert.ToInt32(txtId.Text); //13

                    LN.ObtenerINFOEmpleadoTiempoCompleto(EmpleadoTiempoCompleto, ArchivoPath1);

                    MessageBox.Show("El empleado fue agregado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cboTipoEmpleado.Text == "Empleado de Tiempo Parcial")
                {
                    EmpleadoTiempoParcial EmpleadoTiempoParcial = new EmpleadoTiempoParcial();

                    EmpleadoTiempoParcial.Tipo = cboTipoEmpleado.Text; //1
                    EmpleadoTiempoParcial.Nombre = txtNombre.Text; //2
                    EmpleadoTiempoParcial.Apellido1 = txtApellido1.Text; //3
                    EmpleadoTiempoParcial.Apellido2 = txtApellido2.Text; //4
                    EmpleadoTiempoParcial.Cedula = Convert.ToInt32(txtCedula.Text); //5
                    EmpleadoTiempoParcial.Edad = Convert.ToInt32(txtEdad.Text); //6
                    EmpleadoTiempoParcial.SalarioBruto = Convert.ToDouble(txtSalarioBruto.Text); //7
                    EmpleadoTiempoParcial.SalarioNeto = EmpleadoTiempoParcial.CalcularSalarioNeto(); //8
                    EmpleadoTiempoParcial.Impuesto = EmpleadoTiempoParcial.ImpuestoCCSSRenta(); //9
                    EmpleadoTiempoParcial.SalarioTrimestral = EmpleadoTiempoParcial.CalcularSalarioTrimestral(); //10
                    EmpleadoTiempoParcial.SalarioSemestral = EmpleadoTiempoParcial.CalcularSalarioSemestral(); //11
                    EmpleadoTiempoParcial.SalarioAnual = EmpleadoTiempoParcial.CalcularSalarioAnual(); //12
                    EmpleadoTiempoParcial.IdEmpeladoTiempoParcial = Convert.ToInt32(txtId.Text); //13

                    LN.ObtenerINFOEmpleadoTiempoParcial(EmpleadoTiempoParcial, ArchivoPath2);

                    MessageBox.Show("El empleado fue agregado Correctamente", "Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un tipo de empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Falta informacion por ingresar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnGenerarId_Click(object sender, EventArgs e)
        {
            int RandomId = IdRandom.Next(100, 1000);
            txtId.Text = RandomId.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboTipoEmpleado.SelectedIndex = -1;
            txtNombre.Text = string.Empty;
            txtApellido1.Text = string.Empty;
            txtApellido2.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtSalarioBruto.Text = string.Empty;
            txtId.Text = string.Empty;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}