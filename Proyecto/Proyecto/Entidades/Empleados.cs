using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Persona
    {
        public string Nombre { get; set; } //1
        public string Apellido1 { get; set; } //2
        public string Apellido2 { get; set; } //3
        public int Cedula { get; set; } //4
        public int Edad { get; set; } //5
        public string NombreCompleto { get; set; } // NO CUENTA
    }
    public class Empleado : Persona
    {
        public string Tipo { get; set; } //6
        public double SalarioBruto { get; set; } //7
        public double SalarioNeto { get; set; } //8
        public string Impuesto { get; set; } //9
        public double SalarioTrimestral { get; set; } //10 
        public double SalarioSemestral { get; set; } //11
        public double SalarioAnual { get; set; } //12


        public string ImpuestoCCSSRenta()
        {
            if (SalarioBruto > 800000 && SalarioBruto <= 1000000)
            {
                string ImpuestoRenta10 = "10.75%, 10%";

                return ImpuestoRenta10;
            }
            else if (SalarioBruto > 1000000 && SalarioBruto <= 1500000)
            {
                string ImpuestoRenta15 = "10.75%, 10%, 15%";

                return ImpuestoRenta15;
            }
            else if (SalarioBruto > 1500000)
            {
                string ImpuestoRenta20 = "10.75%, 10%, 15%, 20%";

                return ImpuestoRenta20;
            }
            else if (SalarioBruto <= 800000)
            {
                string ImpuestoCcss = "10.75%";

                return ImpuestoCcss;
            }
            else
            {
                string ImpuestoNulo = "0%";

                return ImpuestoNulo;
            }
        }

        public double CalcularSalarioTrimestral()
        {
            double salarioTrimestral = SalarioNeto * 3;
            return salarioTrimestral;
        }

        public double CalcularSalarioSemestral()
        {
            double SalarioSemestral = SalarioNeto * 6;
            return SalarioSemestral;
        }

        public double CalcularSalarioAnual()
        {
            double SalarioAnual = SalarioNeto * 12;
            return SalarioAnual;
        }

        public double CalcularSalarioNeto()
        {
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------

            // Impuesto de la CCSS

            double ImpuestoCCSS = SalarioBruto * 0.1075; // 10.75% = 0.1075

            // Impuesto de Renta

            if (SalarioBruto > 800000 && SalarioBruto <= 1000000)
            {
                double salarioLR = SalarioBruto - 800000; //800.000 Libres de Renta

                double ImpuestoRenta = salarioLR * 0.1; // 10% = 0.1

                double salarioNeto1 = SalarioBruto - ImpuestoCCSS - ImpuestoRenta;

                return salarioNeto1;
            }
            else if(SalarioBruto > 1000000 && SalarioBruto <= 1500000)
            {
                double salarioLR = SalarioBruto - 800000; //800.000 Libres de Renta

                double intervalo1 = 1000000 - 800000;
                double renta10 = intervalo1 * 0.1; // 10% = 0.1

                double intervalo2 = salarioLR - intervalo1;
                double renta15 = intervalo2 * 0.15; // 15% = 0.15

                double ImpuestoRenta = renta10 + renta15;

                double salarioNeto2 = SalarioBruto - ImpuestoCCSS - ImpuestoRenta;

                return salarioNeto2;
            }
            else if (SalarioBruto > 1500000)
            {
                double salarioLR = SalarioBruto - 800000; //800.000 Libres de Renta

                double intervalo1 = 1000000 - 800000;
                double renta10 = intervalo1 * 0.1; // 10% = 0.1

                double intervalo2 = 1500000 - 1000000;
                double renta15 = intervalo2 * 0.15; // 15% = 0.15

                double intervalo3 = salarioLR - (intervalo1 + intervalo2);
                double renta20 = intervalo3 * 0.2; // 20% = 0.2

                double ImpuestoRenta = renta10 + renta15 + renta20;

                double salarioNeto3 = SalarioBruto - ImpuestoCCSS - ImpuestoRenta;

                return salarioNeto3;
            }
            else
            {
                double salarioNeto4 = SalarioBruto - ImpuestoCCSS;

                return salarioNeto4;
            }

            //------------------------------------------------------------------------
            //------------------------------------------------------------------------
        }
    }

    public class EmpleadoTiempoCompleto : Empleado
    {
        public int IdEmpeladoTiempoCompleto { get; set; } //13
    }

    public class EmpleadoTiempoParcial : Empleado
    {
        public int IdEmpeladoTiempoParcial { get; set; } //13
    }
}