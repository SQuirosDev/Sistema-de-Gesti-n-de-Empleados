using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class AccesoDatos
    {
        //---------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------

        // GUARDAR DATOS

        public bool GuardarEmpleadoTiempoCompleto(EmpleadoTiempoCompleto EmpleadoTiempoCompleto, string ArchivoPath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(ArchivoPath, true))
                {
                    string EmployeeFullTime = $"{EmpleadoTiempoCompleto.Tipo}/{EmpleadoTiempoCompleto.Nombre}/{EmpleadoTiempoCompleto.Apellido1}/{EmpleadoTiempoCompleto.Apellido2}/{EmpleadoTiempoCompleto.Cedula}/{EmpleadoTiempoCompleto.Edad}/{EmpleadoTiempoCompleto.SalarioBruto}/{EmpleadoTiempoCompleto.SalarioNeto}/{EmpleadoTiempoCompleto.Impuesto}/{EmpleadoTiempoCompleto.SalarioTrimestral}/{EmpleadoTiempoCompleto.SalarioSemestral}/{EmpleadoTiempoCompleto.SalarioAnual}/{EmpleadoTiempoCompleto.IdEmpeladoTiempoCompleto}";
                    writer.WriteLine(EmployeeFullTime);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar la empleado: {ex.Message}");
                return false;
            }
        }

        public bool GuardarEmpleadoTiempoParcial(EmpleadoTiempoParcial EmpleadoTiempoParcial, string ArchivoPath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(ArchivoPath, true))
                {
                    string EmployeePartTime = $"{EmpleadoTiempoParcial.Tipo}/{EmpleadoTiempoParcial.Nombre}/{EmpleadoTiempoParcial.Apellido1}/{EmpleadoTiempoParcial.Apellido2}/{EmpleadoTiempoParcial.Cedula}/{EmpleadoTiempoParcial.Edad}/{EmpleadoTiempoParcial.SalarioBruto}/{EmpleadoTiempoParcial.SalarioNeto}/{EmpleadoTiempoParcial.Impuesto}/{EmpleadoTiempoParcial.SalarioTrimestral}/{EmpleadoTiempoParcial.SalarioSemestral}/{EmpleadoTiempoParcial.SalarioAnual}/{EmpleadoTiempoParcial.IdEmpeladoTiempoParcial}";
                    writer.WriteLine(EmployeePartTime);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar la empleado: {ex.Message}");
                return false;
            }
        }

        //---------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------

        // OBTENER DATOS

        public List<EmpleadoTiempoCompleto> LeerRegistrosEmpleadosTiempoCompleto(string ArchivoPath)
        {
            List<EmpleadoTiempoCompleto> ListaEmpleadoTiempoCompleto = new List<EmpleadoTiempoCompleto>();

            try
            {
                using (StreamReader reader = new StreamReader(ArchivoPath))
                {
                    while (!reader.EndOfStream)
                    {
                        string linea = reader.ReadLine();
                        string[] campos = linea.Split('/');

                        if (campos.Length == 13)
                        {
                            EmpleadoTiempoCompleto EmpleadoTiempoCompleto = new EmpleadoTiempoCompleto();
                            EmpleadoTiempoCompleto.Tipo = campos[0];
                            EmpleadoTiempoCompleto.Nombre = campos[1];
                            EmpleadoTiempoCompleto.Apellido1 = campos[2];
                            EmpleadoTiempoCompleto.Apellido2 = campos[3];
                            EmpleadoTiempoCompleto.NombreCompleto = campos[1] + " " + campos[2] + " " + campos[3];
                            EmpleadoTiempoCompleto.Cedula = Convert.ToInt32(campos[4]);
                            EmpleadoTiempoCompleto.Edad = Convert.ToInt32(campos[5]);
                            EmpleadoTiempoCompleto.SalarioBruto = Convert.ToDouble(campos[6]);
                            EmpleadoTiempoCompleto.SalarioNeto = Convert.ToDouble(campos[7]);
                            EmpleadoTiempoCompleto.Impuesto = campos[8];
                            EmpleadoTiempoCompleto.SalarioTrimestral = Convert.ToDouble(campos[9]);
                            EmpleadoTiempoCompleto.SalarioSemestral = Convert.ToDouble(campos[10]);
                            EmpleadoTiempoCompleto.SalarioAnual = Convert.ToDouble(campos[11]);
                            EmpleadoTiempoCompleto.IdEmpeladoTiempoCompleto = Convert.ToInt32(campos[12]);

                            ListaEmpleadoTiempoCompleto.Add(EmpleadoTiempoCompleto);
                        }
                        else
                        {
                            Console.WriteLine($"Formato incorrecto en la línea: {linea}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }

            return ListaEmpleadoTiempoCompleto;
        }

        public List<EmpleadoTiempoParcial> LeerRegistrosEmpleadoTiempoParcial(string ArchivoPath)
        {
            List<EmpleadoTiempoParcial> ListaEmpleadoTiempoParcial = new List<EmpleadoTiempoParcial>();

            try
            {
                using (StreamReader reader = new StreamReader(ArchivoPath))
                {
                    while (!reader.EndOfStream)
                    {
                        string linea = reader.ReadLine();
                        string[] campos = linea.Split('/');

                        if (campos.Length == 13)
                        {
                            EmpleadoTiempoParcial EmpleadoTiempoParcial = new EmpleadoTiempoParcial();
                            EmpleadoTiempoParcial.Tipo = campos[0];
                            EmpleadoTiempoParcial.Nombre = campos[1];
                            EmpleadoTiempoParcial.Apellido1 = campos[2];
                            EmpleadoTiempoParcial.Apellido2 = campos[3];
                            EmpleadoTiempoParcial.NombreCompleto = campos[1] + " " + campos[2] + " " + campos[3];
                            EmpleadoTiempoParcial.Cedula = Convert.ToInt32(campos[4]);
                            EmpleadoTiempoParcial.Edad = Convert.ToInt32(campos[5]);
                            EmpleadoTiempoParcial.SalarioBruto = Convert.ToDouble(campos[6]);
                            EmpleadoTiempoParcial.SalarioNeto = Convert.ToDouble(campos[7]);
                            EmpleadoTiempoParcial.Impuesto = campos[8];
                            EmpleadoTiempoParcial.SalarioTrimestral = Convert.ToDouble(campos[9]);
                            EmpleadoTiempoParcial.SalarioSemestral = Convert.ToDouble(campos[10]);
                            EmpleadoTiempoParcial.SalarioAnual = Convert.ToDouble(campos[11]);
                            EmpleadoTiempoParcial.IdEmpeladoTiempoParcial = Convert.ToInt32(campos[12]);

                            ListaEmpleadoTiempoParcial.Add(EmpleadoTiempoParcial);
                        }
                        else
                        {
                            Console.WriteLine($"Formato incorrecto en la línea: {linea}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }

            return ListaEmpleadoTiempoParcial;
        }
    }
}