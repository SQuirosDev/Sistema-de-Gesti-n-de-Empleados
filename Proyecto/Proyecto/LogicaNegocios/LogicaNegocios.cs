using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class LogicaNegocios
    {
        private const string ArchivoPath1 = "C:\\Users\\se13q\\OneDrive\\Desktop\\Proyecto\\Proyecto\\Datos\\Lista de Empleados Tiempo Completo.txt";
        private const string ArchivoPath2 = "C:\\Users\\se13q\\OneDrive\\Desktop\\Proyecto\\Proyecto\\Datos\\Lista de Empleados Tiempo Parcial.txt";

        AccesoDatos AD = new AccesoDatos();

        // GUARDAR INFO EN ARCHIVOS TXT

        public bool ObtenerINFOEmpleadoTiempoCompleto(EmpleadoTiempoCompleto EmpleadoTiempoCompleto, string ArchivoPath)
        {
            AD.GuardarEmpleadoTiempoCompleto(EmpleadoTiempoCompleto, ArchivoPath);
            return true;
        }

        public bool ObtenerINFOEmpleadoTiempoParcial(EmpleadoTiempoParcial EmpleadoTiempoParcial, string ArchivoPath)
        {
            AD.GuardarEmpleadoTiempoParcial(EmpleadoTiempoParcial, ArchivoPath);
            return true;
        }

        //------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------

        // OBTENER INFO DE LOS ARCHIVOS TXT

        public List<EmpleadoTiempoCompleto> ObtenerListaEmpleadoTiempoCompleto(string ArchivoPath)
        {
            List<EmpleadoTiempoCompleto> ListaEmpleadoTiempoCompleto = AD.LeerRegistrosEmpleadosTiempoCompleto(ArchivoPath);

            return ListaEmpleadoTiempoCompleto;
        }

        public List<EmpleadoTiempoParcial> ObtenerListaEmpleadoTiempoParcial(string ArchivoPath)
        {
            List<EmpleadoTiempoParcial> ListaEmpleadoTiempoParcial = AD.LeerRegistrosEmpleadoTiempoParcial(ArchivoPath);

            return ListaEmpleadoTiempoParcial;
        }

        //------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------

        // Metodo de eliminar empleado

        public void BorrarEmpleado(string ArchivoPath, string NombreEliminar)
        {
            try
            {
                string[] lineas = File.ReadAllLines(ArchivoPath);

                for (int i = 0; i < lineas.Length; i++)
                {
                    if (lineas[i].Contains(NombreEliminar))
                    {
                        lineas[i] = "";
                        
                        break;
                    }
                }

                File.WriteAllLines(ArchivoPath, lineas);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
        }
    }
}