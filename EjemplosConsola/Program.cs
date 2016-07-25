using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            UsoPOOMEtodos();
        }

        static void UsoPOOMEtodos()
        {
            /*
             * MEtodos:
             *  -Acciones que puede realizar el objeto, generalmentre sobre las propiedades
             *  
             * Variantes:
             *      -Valor de regreso
             *          *En la declaracion del metodo se indica el tipo de dato del valor a regresar.
             *          *En caso de que el metodo no regrese ningun valor se debe calificar con la palabra reservada void.
             *          *El hecho que metodo genere un valor de regreso no obliga al objeto a usar dicho valor.
             *          
             *      -Parametros
             *          *Son datos que requiere de manera particular el metodo.
             *          *Funcionan como variables locales al metodo.
             *          *No se soporta la inferencia de tipos (Var).
             *          
             *      -Argumentos Nombrados
             *          * Ventajas: Legibilidad y Flexibilidad
             *         
             *      -Parametros opcionales
             *          *Permiten definir un valor por defecto al parametro.
             *          *Se pueden usar combinados con parametros requeridos; siempre y cuando los opcionales sean los ultimos en la lista de parametros.
             *          
             *      -Polimorfismo de estado
             *          *Estado (Propiedades)
             *              Condicion de un objeto en un momento determinado.
             *              Cuando las propiedades modifican el estado de un objeto.
             *          *El comportamiento de un metodo se ve alterado por los valores de las propiedades del objeto.
             *          
             *      -Paso de parametros
             *          *Por valor
             *              Tipo de paso por defecto.
             *              El parametro tiene un espacio de memoria propio.
             *         *Por referencia
             *              Se debe calificar tanto el parametro como el argumento con el operador ref.
             *              El parametro comparte el espacio de memoria del argumento.
             *         *De salida
             *              Se debe calificar tanto el parametro como el argumento con el operador out.
             *              El valor se genera despues de la llamada al metodo.
             * 
             *      -Tipo de firma
             *          Se constituye por:
             *              Nombre metodo
             *              Numero parametros
             *              Tipo de datos de parametros
             *              Orden de parametros 
             *              Tipo de paso de parametros (valor,referencia o salida)
             *              
             *      -Poliformismo de Métodos (Sobre carga)
             *          
             *          Operacion                   Metodo
             *           ¿Qué?                      ¿Cómo?
             *           
             *          Sobre carga: Poliformismo en base una operacion implementada en metodos con firmas diferentes.
             *          
             *          C# aplica conversiones implicitas para asociar las formas; si hay una firma explicita, esta toma precedencia.
             *          
             *      -Parametros de Longitud Variable
             *         *Permiten que el metodo reciba un numero variable de argumentos del tipo dado.
             *         *En la declaracion del parametro se debe usar el operador (params) y la notacion de arreglos. P.ej. (Params string[] temas)
             *         *Internamente, en el metodo la variable es un arreglo.
             *         *se puede combinar con sobre carga; esta ultima toma precedencia.
             *         
             *
             *          
             */

            Curso objCurso = new Curso();
            //Console.WriteLine("Introduce el nombre de curso a registrar");
            //objCurso.Nombre = Console.ReadLine();
            //Console.WriteLine("Indica la duracion del curso en hrs");
            //objCurso.Duracion = int.Parse(Console.ReadLine());
            //string separador = new string('=', 50);
            //Console.WriteLine(separador);

            //objCurso.Mostrar();
            //DateTime vigencia = objCurso.Publicar();
            //Console.WriteLine("Vigencia de la publicacion: " + vigencia);
            //Console.WriteLine(separador);

            //Console.WriteLine("Escribe el motivo de cancelacion");
            //objCurso.Cancelar(Console.ReadLine());

            //Console.WriteLine(separador);
            //Console.WriteLine("Escribe la ciudad sede asignada");
            //string val1 = Console.ReadLine();
            //Console.WriteLine("Proporciona el n° de alumnos");
            //int val2 = int.Parse(Console.ReadLine());
            //objCurso.Asignar(val1,val2);

            //objCurso.AplicarDescuento();
            //objCurso.AplicarDescuento("Por la cantidad de alumnos");
            //objCurso.Duracion = 120;
            //objCurso.AsignarDescansos();

            //int v1 = 50, v2 = 25, s1;

            //objCurso.TipoPasoParametros(v1, ref v2,out s1);
            //Console.WriteLine("Paso por valor: {0}",v1);
            //Console.WriteLine("Paso por referencia: {0}",v2);
            //Console.WriteLine("Parametro de salida: {0}",s1);

            objCurso.Pagar(123.50);

            //objCurso.AgregarNuevoTema("Cap1");
            //objCurso.AgregarNuevoTema("CSS Hojas de estilo en XML", "HTML5");
            Console.ReadKey();

        }

        class Curso
        {
            public string Nombre { get; set; }
            public int Duracion { get; set; }
            public string Motivo { get; set; }

            public void Mostrar()
            {
                Console.WriteLine("Datos del curso");
                Console.WriteLine("Nombre: {0}", Nombre);
                Console.WriteLine("Duracion: {0} horas.", Duracion);
            }

            public DateTime Publicar()
            {
                Console.WriteLine("El curso {0} ha sido publicado", Nombre);
                return DateTime.Now.AddMonths(3);
            }

            public void Cancelar(string Motivo)
            {
                Console.WriteLine("El curso {0} ha sido cancelado", Nombre);
                Console.WriteLine("Motivo: {0}", Motivo);
            }

            public void Asignar(string Sede, int NoAlumnos)
            {
                Console.WriteLine("El curso {0} ha sido asignado", Nombre);
                Console.WriteLine("Sede: {0}", Sede);
                Console.WriteLine("Numero de alumnos: {0}", NoAlumnos);
                Console.ReadKey();
            }

            public void AplicarDescuento(string TipoDescuento = "Por ser exalumno")
            {
                Console.WriteLine("El curso {0} tiene un descuento {1}", Nombre,TipoDescuento);
                Console.ReadLine();
            }

            public void AsignarDescansos()
            {
                if (Duracion < 30)
                {
                    Console.WriteLine("Tomar un descanso al dia...");
                }
                if (Duracion > 60)
                {
                    Console.WriteLine("Tomar varios descansos...");
                }
                Console.ReadLine();
            }

            public void TipoPasoParametros(int valor1, ref int valor2, out int salida1)
            {
                valor1 = 300;
                valor2 = 500;
                salida1 = 750;
            }

            public void Pagar(string NoTDC)
            {
                Console.WriteLine("El curso {0} ha sido pagado.", Nombre);
                Console.WriteLine("Forma de pago: Tarjeta de crédito.");
                Console.WriteLine("Promocion: Pago a meses sin intereses");
            }

            public void Pagar(double Importe)
            {
                Console.WriteLine("El curso {0} ha sido pagado.", Nombre);
                Console.WriteLine("Forma de pago: En efectivo.");
                Console.WriteLine("Promocion: 10% desc en la siguiente compra.");
            }

            public void AgregarNuevoTema(string NvoTema)
            {
                Console.WriteLine("Recursos ocupados por la BD..");
                Console.WriteLine("El contenido del curso ha mejorado: ");
                Console.WriteLine("Nuevo temas: {0}", NvoTema);
                Console.WriteLine();
            }

            public void AgregarNuevoTema(params string[] temas)
            {
                Console.WriteLine("Recursos en la BD");
                Console.WriteLine("Se agregaron los siguientes temas");
                foreach (string tema in temas)
                {
                    Console.WriteLine("\tTema: {0}", tema);
                }
                Console.WriteLine();
            }
        }
    }
}
