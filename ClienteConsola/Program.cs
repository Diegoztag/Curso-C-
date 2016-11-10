using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coppel.funciones;

namespace ClienteConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //InicializarProp();
            ejemplo();
        }

        class Empresa
        {
            public string RazonSocial { get; set; }
            public int NoEmpleados { get; set; }
            public string Direccion { get; set; }

            public Empresa(string RazonSocial, int NoEmpleados, string Direccion)
            {
                this.RazonSocial = RazonSocial;
                this.NoEmpleados = NoEmpleados;
                this.Direccion = Direccion;
            }
        }

        static void RegistroEmpresa(Empresa objEmpresa)
        {
            Console.WriteLine("Datos de la empresa");
            string cadena = new string('=', 50);
            Console.WriteLine(cadena);
            Console.WriteLine("Razon social: {0}",objEmpresa.RazonSocial);
            Console.WriteLine("N° empleados: {0}", objEmpresa.NoEmpleados);
            Console.WriteLine("Direccion: {0}", objEmpresa.Direccion);
            Console.ReadLine();
        }

        static void InicializarProp()
        {
            Empresa objEmp = new Empresa("sad",90,"dsa");
            RegistroEmpresa(objEmp);
            Console.ReadLine();
        }

        class Curso
        {
            public string Nombre { get; set; }
            public int Duracion { get; set; }
            public string Motivo { get; set; }

            public void Mostrar()
            {
                Console.WriteLine("Datos del curso");
                Console.WriteLine("Nombre: {0}",Nombre);
                Console.WriteLine("Duracion: {0} horas",Duracion);
            }

            public DateTime Publicar()
            {
                Console.WriteLine("El curso {0} ha sido publicado",Nombre);
                return DateTime.Now.AddMonths(3);
            }

            public void Cancelar(string Motivo)
            {
                Console.WriteLine("El curso {0} ha sido cancelado",Nombre);
                Console.WriteLine("Motivo: {0}",Motivo);
            }

            public void Asignar (string Sede, int NoAlumnos)
            {
                Console.WriteLine("El curso {0} ha sido asignado",Nombre);
                Console.WriteLine("Sede: {0}",Sede);
                Console.WriteLine("Numero de alumnos: {0}",NoAlumnos);
                Console.ReadKey();
            }

            public void AplicarDescuento(string TipoDescuento = "Por ser exalumno")
            {
                Console.WriteLine("El curso {0} tiene un descuento",Nombre);
                Console.ReadKey();
            }

            public void AsignarDescanso()
            {
                if (Duracion < 30)
                {
                    Console.WriteLine("Tomar un descanso al dia..");
                }
                if (Duracion > 60)
                {
                    Console.WriteLine("Tomar muchos descansos...");
                }
                Console.ReadKey();
            }

            public void TipoParametros(int valor1,ref int valor2,out int salida)
            {
                valor1 = 300;
                valor2 = 500;
                salida = 700;
            }

            public void Pagar(string TDC)
            {
                Console.WriteLine("El curso {0} ha sido pagado",Nombre);
                Console.WriteLine("Forma de pago: Targeta de credito");
                Console.WriteLine("Promocion: Meses sin intereses");
            }

            public void Pagar(double Importe)
            {
                Console.WriteLine("El curso {0} ha sido pagado", Nombre);
                Console.WriteLine("Forma de pago: Efectivo");
                Console.WriteLine("Promocion: !0% descuento la siguiente compra");
            }

            public void AgregarNuevoTema(string NvoTema)
            {
                Console.WriteLine("Recursos en la BD");
                Console.WriteLine("El contenido del curso ha mejorado");
                Console.WriteLine("Nuevos temas: {0}",NvoTema);
            }

            public void AgregarNuevoTema(params string[] temas)
            {
                Console.WriteLine("Recursos en la BD");
                Console.WriteLine("Se agregaron los siguientes temas:");

                foreach (string item in temas)
                {
                    Console.WriteLine("Tema: {0}",item);
                }
            }
        }

        static void ejemplo()
        {
            Curso objCurso = new Curso();
            objCurso.Nombre = "Ajax";
            objCurso.Duracion = 20;

            //objCurso.Mostrar();
            // DateTime vigencia = objCurso.Publicar();
            // Console.WriteLine("Vigencia de la publicacion {0}",vigencia);
            // objCurso.Cancelar("Falta de pago");
            // objCurso.Asignar("Culiacan",50);
            // objCurso.AplicarDescuento();
            // objCurso.AplicarDescuento("Por cantida de alumnos");
            // objCurso.AsignarDescanso();

            //int v1 = 50, v2 = 25, s1;
            //objCurso.TipoParametros(v1, ref v2, out s1);
            //Console.WriteLine("Paso por valor {0}",v1);
            //Console.WriteLine("Paso por referencia {0}", v2);
            //Console.WriteLine("Paso por salida {0}", s1);

            //objCurso.Pagar("Hola");

            Console.ReadKey();
        }

    }
}
