using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coppel.funciones;
using System.Collections;
using System.Collections.Specialized;
using System.Data.SqlClient;

namespace ClienteConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntroNET();
            //UsoLPComentarios();
            //UsoLPVariables();
            //UsoLPSinonimos();
            //UsoLPInferenciaTipos();
            //UsoLPAusenciaValor();
            //UsoLPAlcances();
            //UsoLPEnumeraciones();

            //UsoLPOperadores();
            //UsoLPOperadoresCategorias();
            //UsoLPIEEE754();
            //UsoLPOperadoresSobreFlujo();
            //UsoBloqueIf();
            //UsoBloqueIfElse();
            //UsoBloqueSwitch();
            //UsoCicloWhile();
            //UsoCicloDoWhile();
            //UsoCicloFor();
            //UsoCicloForEach();
            //UsoInterrupcionMEtodo();
            //UsoInterrupcionCiclo();
            //UsoInterrupcionInteracion();
            //UsoActividadProcuderal();

            //UsoParadigmaProcedural();
            //UsoPOOConceptos();
            //UsoPOOClasesYObjetos();
            //UsoPOOPropiedades();
            //UsoPOOParadigmaOrientadoOjetos();
            //UsoPOOMEtodos();
            //UsoPooEnsamblados();
            //UsoPOOConstructores();
            //UsoElementosInstanciaEstatico();
            //UsoPOORelacionesAsociacion();
            //UsoPOORelacionesEspecializacion();
            //UsoPOOHerenciaLaClaseRaiz();
            //UsoPOOHerenciaPErsonalizada();
            //UsoPOOHerenciaSobreEscritura();
            //UsoPOOHerenciaConstructores();
            //UsosPOOClasesAbstactas();
            //UsoActividadRelaciones();
            //UsoPOORealizaciones();

            //UsoAPIExcepcionCOndicionError();
            //UsoAPIExcepcionMAnejoError();
            //UsoAPIExcepcionUsoExcepcion();
            //UsoAPIExcepcionCatchMultiples();
            //UsoAPIExcepcionClausulaFinally();
            //UsoAPIExcepcionLiberacionRecursos();
            //UsoAPIExcepcionLiberacionAutomaticaDeRecursos();
            //UsoAPIExcepcionActivacion();
            //UsoAPIExcepcionPersonalizada();

            //UsoAPICadenasCreacion();
            //UsoAPICadenasComparacion();
            //UsoAPICadenasEntidadInmutable();
            //UsoAPICadenasElementos();
            //UsoAPICadenasCaracteresEscape();

            //UsoAPIArreglosJagged();
            //UsoAPIArreglosRectangulares();
            //UsoAPIArreglosElementos();
            //UsoAPIArreglosYCadenas();

            //UsoAPIColeccionesGenerales();
            //UsoAPIColeccionesEspecializadas();
            //UsoAPIColeccionesGenericas();
            //UsoAPIColeccionesElementos();
            //UsoAPIActividad();

            //UsoFRMADDONETIntro();
            //UsoFRAMEWORKADONETActionQuery();
        }

        #region "C# - Lenguaje Procedural"

        #region "Introduccion"

        static void IntroNET()
        {
            Console.WriteLine("Curso de c# - Coppel Culiacan");
            Console.ReadLine();
            Console.ReadKey();
        }

        /// <summary>
        /// Ejemplo del uso de comentarios en c#.
        /// </summary>
        static void UsoLPComentarios()
        {
            // Autor: Diego Zazueta

            /*
                Curso: C#
                Objetivo: Mostrar los diferentes tipos de comentarios de C#.
             */

            // TODO: En espera de lo que resuelvan los usuarios en la proxima reunion. 
        }

        #endregion

        #region "Tipos datos y variables"

        static void UsoLPVariables()
        {
            /* Def.:
             * 
             * Declaración: <Tipo_dato> + <Nombre_variable> [ = Valor_inicial]
             * 
             * 
             * Tipos basicos:
             *      string      Nombre
             *      integer     Edad
             *      char        Sexo
             *      double      Importe
             *      boolean     Pagado
             *      
             *  Notas:
             *      C# no inicializa valores por defecto.
             *      C# permite declaraciones e inicializaciones multiples
             *      
             * 
             */

            string nombre = "No asignado";
            int entero1 = 10, entero2 = 20;

            Console.WriteLine(nombre);
            Console.WriteLine(entero1);
            Console.WriteLine(entero2);
            Console.ReadKey();
        }

        static void UsoLPSinonimos()
        {
            /*
             Def.: Representacion especifica (c#) de un tipo de dato base en el MSIL.
             * 
             * Int32 -> int
             * Int64 -> long
             * Boolean -> bool
             * string -> string
             * 
             * Nota:
             *     -Para realizar un codigo fuente comptatible en su mayor medida con los demas codigos de .NET 
             *      se aconseja usar la definicion de datos en modo MSLI.
             *      
             *     -El metodo GetType(), disponible en todos los tipos de .NET, permite conocer el tipo de una variable.
             */
            Int32 valor1 = 0;  //   MSIL
            int valor2 = 0;    //   C#

            Console.WriteLine(valor1.GetType().Name);
            Console.WriteLine(valor2.GetType().Name);
            Console.ReadKey();
        }

        static void UsoLPInferenciaTipos()
        {
            /*
             * Def.: La capacidad de reconocer el tipo de variable
             *       Soportada a partir de la version 3 del lenguaje.
             */

            int capacidad1 = 0;
            Int32 capacidad2 = 0;
            var capacidad3 = "diez";

            //Sentencia no valida

            //var capacidad3 = 10;

            Console.WriteLine(capacidad1.GetType().Name);
            Console.WriteLine(capacidad2.GetType().Name);
            Console.WriteLine(capacidad3.GetType().Name);
            Console.ReadKey();
        }

        static void UsoLPAusenciaValor()
        {
            /*
             * Tipos nulables: Son tipos basados en los tipos base que representan ausencia de valor. 
             * 
             * Nota:
             *  -Hacen uso de los tipos genericos.
             *  -c# soporta la sintaxis abreviada: <tipo_base> + ?
             *  -Los tipos nulables son soportados a partir de la version 3 del lenguaje.
             * 
             */

            //int añosExperiencia = 3;
            Nullable<int> añosExperiencia2 = 4;
            int? añosExperiencia3 = null;

            if (añosExperiencia2.HasValue)
            {
                Console.WriteLine("Datos del candidato: ");
                Console.WriteLine("Años de experiencia: {0} años", añosExperiencia2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Se desconoce los años de experiencia de la persona");
                Console.ReadKey();
            }
        }

        static int valor3 = 3;

        static void UsoLPAlcances()
        {
            /*
             * Def.:
             * 
             * Niveles:
             *  -Local
             *  -Bloque
             *  -Global
             */

            int valor1 = 0;

            if (true)
            {
                int valor2 = 0;
            }
            else
            {

            }
        }

        enum NivelesSocio : byte
        {
            NoAsignado,
            Plata = 15,
            Silver = 15,
            Oro,
            Platino
        }
        static void UsoLPEnumeraciones()
        {
            // RN: Se desea almacenar el nivel de un cliente en base a las comprar que esre a realizado.
            //Los unicos niveles permisibles son: Platino, Oro y Plata.

            /*
             * String
             *  -Demaciados recursos para el conjunto de valores de negocio.
             *  -Validacion de integridad requerida. 
             * 
             * Char
             *  -Se requiere logica para resolver nivel.
             *  -Validacion de integridad requerida.
             *  -Falta de legibilidad.
             *  
             * Def.: Es un nuevo tipo de datos que se define apartir de un entero o conjunto de enteros.
             * 
             * Ventajas:
             *  -Legibilidad
             *  -Integridad de datos
             *  -Optimización
             * 
             * Notas:
             *  -Por defecto las enumeraciones de basan en Int32.
             *  -Se puede acotar el tipo entero base de la enumeracion.
             *  -Los valores de la enumeracion son posicionales. Iniciando en cero.
             *  -Se pueden asignar valores explicitos en las enumeraciones
             *  -El valor de una enumeracion depende del inmediato anterior.
             *  -El valor se puede asignar en diferentes ocaciones.
             * 
             */

            NivelesSocio nivel = NivelesSocio.Platino;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(nivel);
            Console.WriteLine((int)nivel);
            Console.WriteLine(nivel.GetType().Name);
            Console.ReadKey();
        }

        #endregion

        #region "Operadores"

        static void UsoLPOperadores()
        {
            /*
             * Operadores y Metodos
             *
             *  -Los metodos pertenecen a las APIs por lo tanto son accesibles desde cualquier lenguaje.
             * 
             *  -Los datos se conocen como parametros.
             * 
             *  -Los operadores son especificos del lenguaje.
             *  -En los operadores los datos se conocen como operandos.
             *  -Cardinalidad: Numero de operandos requeridos por el operador.
             *      Unarios
             *      Binarios
             *      Ternarios
             *
             */

            string cad1 = "Promocion del mes: ";
            string cad2 = "20% de descuento en electronica.";

            Console.WriteLine(String.Concat(cad1, cad2));
            Console.WriteLine(cad1 + cad2);
            Console.WriteLine("{0}{1}", cad1, cad2);
            Console.ReadKey();
        }

        static void UsoLPOperadoresCategorias()
        {
            /*
             * Aritmeticos: +,-,*,/,%,++,--
             *  Notas:
             *      -Los operadores ++ y -- soportan notacion de prefijo y postfijo.
             *      -Si es un prefijo primero hace la operacion, luego la asignacion. (Antes)
             *      -Si es un postfijo primero hace la asignacion y luego la operacion. (Despues)
             *      -El operador / se apega al estandar IEEE754 de ECMA.
             *      
             * Compraracion: ==, !=, >, >=, <, <=
             * 
             * Logicos: !, &, &&, |, ||, ^
             *  Notas:
             *      Tabla de verdad (Y logico)
             *      
             *      EXP1    EXP2    Resultado
             *      v       v          v
             *      v       f          f
             *      f       v          f
             *      f       f          f
             *      
             *      Tabla de verdad (O Logico)
             *      
             *      EXP1    EXP2    Resultado
             *      v       v       v
             *      v       f       v
             *      f       v       v
             *      f       f       f
             *      
             *      Tabla de verdad (O logico exclusivo)
             *      EXP1    EXP2    Resultado
             *      v       v       F
             *      v       f       v
             *      f       v       v
             *      f       f       f
             * 
             * Concatenacion: +
             *  Notas:
             *      -Si uno de los operandos es numerico; las cadenas tienen precedencia.
             *      
             *
             * Asignacion: =
             * 
             * Asignacion Compuesta: +=, -=, *=, /=, %=
             * 
             * Manejo de objetos: new, =>, ~
             * 
             * Sobre flujo:
             * 
             * Condicionales: ?, :
             */

            int calificacion = 8;

            Console.ForegroundColor =
                (calificacion > 7) ? ConsoleColor.Green : ConsoleColor.Red;

            Console.WriteLine(
                (calificacion > 7) ? "Aprobado!" : "Solicita una feha nueva"
                );

            Console.ReadKey();
        }

        static void ObtenerPromedio(double cantidad)
        {
            double promedio = -0 / cantidad;
            Console.WriteLine("El promedio es: {0}", promedio);
        }

        static void UsoLPIEEE754()
        {
            /*
             * ECMA: Es un estandar al que aplica varios lenguajes de programacion (.NET, Java, PHP, Javascript entre otros).
             * 
             * IEEE754: Es una norma de ECMA que indica que en operaciones de punto flotante entre cero no se generan excepciones.
             *          Solo valores especiales.
             *          
             *          Infinito
             *          Neum
             *          -Infinito
             */

            ObtenerPromedio(0);
            Console.ReadKey();
        }

        static void UsoLPOperadoresSobreFlujo()
        {
            /*Sobre flujo o desbordamiento
             * Notas:
             *  Por defecto c# no hace revisiones de sobreflujo; ni genera excepciones.
             *  
             *  Es responsabilidad del programador aplicar revisiones de sobre flujo.
             *  
             *  El checked se puede aplicar por expresion o por bloque.
             */

            int valor = 0;

            Console.WriteLine("Adicional: ");
            int adicional = int.Parse(Console.ReadLine());

            valor = checked(int.MaxValue + adicional);

            //checked
            //{
            //    valor = int.MaxValue + adicional;
            //    valor = int.MaxValue + adicional;
            //    valor = int.MaxValue + adicional;
            //    valor = int.MaxValue + adicional;
            //}

            Console.WriteLine("Valor: {0}", valor);
            Console.ReadLine();

        }

        #endregion

        #region "Estructuras de control"

        static void UsoBloqueIf()
        {
            /*
             * Notas:
             *  -Condiciona un conjunto de instrucciones a una expresion verdadera.
             *  -La expresion siempre se delimita entre parentesis.
             *  -Por defecto solo la siguiente expresion es parte del bloque.
             *  
             */

            int puntos = 500;

            if (puntos >= 500)
            {
                Console.WriteLine("Aprobado!");
                Console.WriteLine("Felicidades...");
                Console.ReadKey();
            }
        }

        static void UsoBloqueIfElse()
        {
            /*
             * Notas:
             *  -Se usa para tomar acciones si no se satisface la exprecion o condicional.
             *  -Por defecto solo la siguiente expresion es parte de bloque else.
             *  
             */

            int puntos = 500;

            if (puntos > 500)
            {
                Console.WriteLine("Aprobado!");
                Console.WriteLine("Felicidades...");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Solicita una nueva fecha...");
                Console.ReadKey();
            }
        }

        static void UsoBloqueSwitch()
        {
            /*
             * Se usa para tomar acciones diferentes a valores diferentes generados por una misma expresiones.
             * 
             * se condidera una buena practica su uso en lugar de los ifs anidados por cuestiones de legibilidad.
             * 
             * La expresion evaluada por el bloque switch puede ser
             */

            Console.WriteLine("Clave de la ciudad: ");
            string ciudad = Console.ReadLine().ToUpper();
            string mensaje = "Temperatura: ";

            switch (ciudad)
            {
                case "CL":
                    Console.WriteLine(mensaje += "Min 30 - Max 45");
                    break;
                case "AC":
                    Console.WriteLine(mensaje += "Min 25 - Max 35");
                    break;
                case "MX":
                    Console.WriteLine(mensaje += "Min 18 - Maz 27");
                    break;
                default:
                    Console.WriteLine(mensaje = "Ciudad no registrada");
                    break;
            }
            Console.ReadKey();
        }

        static void UsoCicloWhile()
        {
            /*
             *  Notas:
             *      - Categoria: Ciclos indefinidos (Condición).
             *      - Preevaluacion: 
             *          Existe la posibilidad que el cuerpo del ciclo jamas se ejecute.
             */

            string pass = "";

            while (pass != "123")
            {
                Console.WriteLine("Pasword: ");
                pass = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bienvenido al sistema...");
        }

        static void UsoCicloDoWhile()
        {
            /*
             *  Notas:
             *      - Categoria: Ciclos indefinidos (Condición).
             *      - Preevaluacion: 
             *          Garantizan que almenos una vez se ejecute el cuerpo del ciclo.
             */

            string pass = "";

            do
            {
                Console.WriteLine("Pasword: ");
                pass = Console.ReadLine();
            } while (pass != "123");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bienvenido al sistema...");
        }

        static void UsoCicloFor()
        {
            string secuencia = "";

            for (int indice = 1; indice < 25; indice++)
            {
                secuencia += indice + " ";
            }

            //Modificacion del incremento.
            secuencia = "";

            for (int indice = 25; indice >= 1; indice--)
            {
                secuencia += indice + " ";
            }
            Console.WriteLine(secuencia);
            Console.ReadKey();
        }

        static void UsoCicloForEach()
        {
            /*
              Notas:
             *  -Se considera una estructura mas eficiente que su equivalente tradicional.
             *  -No requiere la declaracion de una variable de bloque para recorrer cada elemento.
             *  -No requiere una condicion en cada iteracion.
             *  -Aplica exclusivamente a contenedor.
             */
            string cadena = "Coppel";

            foreach (char item in cadena)
            {
                Console.WriteLine(item.ToString().ToUpper());
                Console.ReadKey();
            }
        }

        static void UsoInterrupcionMEtodo()
        /*
         * -return provoca la iterrupcion de todo el metodo.
        * -si el metodo declara que debe regresar un valor; la clausula return se debe completar con un valor correspondiente.
        */
        {
            string secuencia = "";

            for (int indice = 0; indice <= 25; indice++)
            {
                if (indice == 15)
                {
                    return;
                }
                secuencia += indice + " a";
            }
            Console.WriteLine(secuencia);
            Console.ReadKey();
        }

        static void UsoInterrupcionCiclo()

        {
            string secuencia = "";

            for (int indice = 0; indice <= 25; indice++)
            {
                if (indice == 15)
                {
                    break;
                }
                secuencia += indice + " ";
            }
            Console.WriteLine(secuencia);
            Console.ReadLine();
        }

        static void UsoInterrupcionInteracion()

        {
            string secuencia = "";

            for (int indice = 0; indice <= 25; indice++)
            {
                if (indice == 15)
                {
                    continue;
                }
                secuencia += indice + " ";
            }
            Console.WriteLine(secuencia);
            Console.ReadKey();
        }

        #endregion

        #region "Actividad"

        static void UsoActividadProcuderal()
        {
            /*
             * RN: Encontrar una secuencia de pares.
             * 
             * Consideraciones:
             *  -El programa va a necesitar 3 enteros al usuario.
             *      (Inicio,fin y cantidad).
             *      
             *  -Inicio: Representa el inicio de la secuencia.
             *  -Fin: representa el fin de la secuencia
             *  -Cantidad: el numero de pares a mostrar en la secuencia.
             *  -Los valores de inicio y fin determinaran el sentido de la secuencia.
             *  -Manejar valores positivos(no se requiere que el programa valide) 
             * 
             * Pruebas de escritorio
             *  Inicio      Fin     Cantidad        Resultado
             *  25          10          5               24,22,20,18,16
             *  3           9           8               4,6,8
             *  63          63          10              No hay pares
             *  
             */

            Console.WriteLine("Introduce valor de inicio");
            int inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce valor de fin");
            int fin = int.Parse(Console.ReadLine());

            try
            {
                int cadena = 0;
                string separador = new string('=', 70);

                if (inicio == fin)
                {
                    Console.WriteLine("No hay pares a mostrar");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Introduce la cantidad de pares a mostrar");
                    int cantidad = int.Parse(Console.ReadLine());

                    if (inicio < fin)
                    {
                        Console.WriteLine(separador);

                        for (int i = inicio; i <= fin && cadena < cantidad; i++)
                        {
                            if ((i % 2) == 0)
                            {
                                Console.WriteLine(i);
                                cadena++;
                            }
                        }
                        Console.WriteLine(separador);
                    }
                    else
                    {
                        Console.WriteLine(separador);

                        for (int i = inicio; i >= fin; i--)
                        {
                            if ((i % 2) == 0 && cadena < cantidad)
                            {
                                Console.WriteLine(i);
                                cadena++;
                            }
                        }
                        Console.WriteLine(separador);
                    }
                    Console.WriteLine(separador);
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error {0}", ex.Message);
                Console.ReadKey();
            }
        }

        #endregion

        #endregion

        #region "C# - lenguaje Orientado a objetos"

        #region "Conceptos"

        static void UsoParadigmaProcedural()
        {
            //Encontrar el mayor de 3 numeros.

            /*
             *  Inconvenientes de la programacion procedural
             *      -El codigo funcional esta fuertemente acoplado a la aplicacion.
             *      -Se dificulta el mantenimiento al hacer ajustes directamente en la aplicacion.
             *      -No hay reutilizacion de código en distintos ensamblados.
             */

            Console.WriteLine("Escribe el 1er numero");
            int ent1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el segundo numero");
            int ent2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el tercer numero");
            int ent3 = int.Parse(Console.ReadLine());
            int resultado = 0;

            if (ent1 > ent2)
            {
                if (ent1 > ent3)
                {
                    resultado = ent1;
                }
            }

            if (ent2 > ent1)
            {
                if (ent2 > ent3)
                {
                    resultado = ent2;
                }
            }

            if (ent3 > ent1)
            {
                if (ent3 > ent2)
                {
                    resultado = ent3;
                }
            }

            Console.WriteLine("El mayor valor es: {0}",resultado);
            Console.ReadLine();

        }

        static void UsoPOOConceptos()
        {
            /*
             * Programa (general)           POO
             *  -Datos                  -Propiedades (Datos)
             *  -Procesos               -Métodos    (Procesos)
             *  -Salidas                
             *  
             * Filosofía de POO
             *  -Entidad Real           -Entidad Lógica
             *      *carta                  *email
             *      *bancos                 *banca electronica
             *      *libros                 *Libros digitales
             *      
             * Fases de POO
             *  -Análisis               Qué(s)                Analistas de negocio
             *  -Diseño                 Qué(s)/Cómo(s)        Arquitectos de software
             *  -Programación           Cómo(s)               Desarrolladores/Programadores
             *  
             * Elementos orientados a objetos
             *                       Abstracción
             *      Entidad Real                    Entidad Logica
             *         Libro
             *          Editorial                   Editorial
             *          Titulo                      Titulo
             *          N° de paginas               N° paginas
             *          Peso
             *          Tipo de papel
             *          Acabado
             *          ----------------            ---------------
             *          Leer                        Almacenar
             *          Hojear                      Dar de baja
             *          Vender                      Actualizar
             *          Deshojarlo                  
             *  
             * Clasificación de elementos (Clase)
             * Espacios de nombres (NameSpace)
             * Ensamblados
             * 
             * Jerarquia de Elementos .NET
             *  Framework
             *      Ensamblado
             *          Espacio de nombres
             *              Clases
             *                  -Propiedades
             *                  -Métodos
             *  
             * 
             * 
             */
        }

        class Pelicula
        {
        }

        static void UsoPOOClasesYObjetos()
        {
            /*
             * Clase: Es la especificacion del objeto.
             * Objeto: Representacion de la memoria de la clase.
             */
            Pelicula pel1 = new Pelicula(); // Objeto.
            Pelicula pel2 = new Pelicula(); // Objeto.
            Pelicula pel3 = null; // Declaracion.

            Console.WriteLine(pel1);
            Console.ReadKey();
        }

        #endregion

        #region "Propiedades"
        
        class Alumno
        {
            //Variables publicas.
            public string Nombre;

            //Procedimientos de propiedades.
            private string _Apellido;
            public string Apellido 
            {
                get
                {
                    return _Apellido.ToUpper();
                }
                set
                {
                    _Apellido = value;
                }
            }

            //Procedimiento de propiedad solo lectura
            public string Matricula 
            { 
                get
                {
                    return "ALU00001";
                }
            }

            //Propiedades autoimplementadas
            public string Direccion { get; set; }

        }
        static void UsoPOOPropiedades()
        {
            /*
             * Propiedades:
             *  Variables publicas
             *  Procedimientos de propiedad - Lectura / Escritura
             *  Procedimientos de propiedad - Solo lectura
             *  propiedades autoimplementadas
             */

            Alumno objAlumno = new Alumno();
            Alumno objAlumno2 = new Alumno();

            //Asignacion o escritura
            objAlumno.Nombre = "Ana";
            objAlumno.Apellido = "Zazueta";
            objAlumno.Direccion = "Av. libertad centro 1321";

            objAlumno2.Nombre = "Luis";

            //Consulta o lectura
            Console.WriteLine("Datos del alumno");
            Console.WriteLine("Nombre: {0} {1}",objAlumno.Nombre,objAlumno.Apellido);
            Console.WriteLine("Matricula: {0}",objAlumno.Matricula);
            Console.WriteLine("Direccion: {0}",objAlumno.Direccion);

            Console.ReadKey();
           
        }

        static void UsoPOOParadigmaOrientadoOjetos()
        {
            MisMatematicas objMisMatematicas = new MisMatematicas();
            objMisMatematicas.entero1 = 80;
            objMisMatematicas.entero2 = 45;

            Console.WriteLine("El mayor: {0}",objMisMatematicas.mayor);
            Console.ReadKey();
        }

        class MisMatematicas
        {
            public int entero1 { get; set; }
            public int entero2 { get; set; }

            public int mayor 
            {
                get
                {
                    int resultado = 0;

                    if (entero1 > entero2)
                    {
                        resultado = entero1;
                    }
                    else
                    {
                        resultado = entero2;
                    }
                    return resultado;
                }
            }
        }

        #endregion

        #region "Metodos"

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
            objCurso.Nombre = "Fundamentos de XML";
            objCurso.Duracion = 20;

            //objCurso.Mostrar();
            //DateTime vigencia = objCurso.Publicar();
            //Console.WriteLine("Vigencia de la publicacion: " + vigencia);
            //objCurso.Cancelar("Falta de pago");
            //objCurso.Asignar("Culiacan", 25);
            //objCurso.Asignar(Sede: "Culiacan", NoAlumnos: 25);

            //objCurso.AplicarDescuento();
            //objCurso.AplicarDescuento("Por la cantidad de alumnos");
            //objCurso.Duracion = 120;
            //objCurso.AsignarDescansos();

            //int v1 = 50, v2 = 25, s1;

            //objCurso.TipoPasoParametros(v1, ref v2,out s1);
            //Console.WriteLine("Paso por valor: {0}",v1);
            //Console.WriteLine("Paso por referencia: {0}",v2);
            //Console.WriteLine("Parametro de salida: {0}",s1);
            //Console.ReadLine();

            //objCurso.Pagar(123);
            objCurso.AgregarNuevoTema("Cap1");
            objCurso.AgregarNuevoTema("CSS Hojas de estilo en XML","HTML5");
            Console.ReadKey();

        }

        class Curso
        {
            public string Nombre { get; set; }
            public int Duracion { get; set; }
            public string Motivo { get; set; }

            public void Mostrar()
            {
                Console.WriteLine("Datos del curso: ");
                Console.WriteLine("Nombre: {0}",Nombre);
                Console.WriteLine("Duracion: {0} horas.",Duracion);
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
                Console.WriteLine("El curso {0} ha sido asignado", Nombre);
                Console.WriteLine("Sede: {0}",Sede);
                Console.WriteLine("Numero de alumnos: {0}",NoAlumnos);
                Console.ReadKey();
            }

            public void AplicarDescuento(string TipoDescuento = "Por ser exalumno")
            {
                Console.WriteLine("El curso {0} tiene un descuento",Nombre);
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

            public void TipoPasoParametros(int valor1,ref int valor2, out int salida1)
            {
                valor1 = 300;
                valor2 = 500;
                salida1 = 750;
            }

            public void Pagar(string NoTDC)
            {
                Console.WriteLine("El curso {0} ha sido pagado.",Nombre);
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
                Console.WriteLine("Nuevo temas: {0}",NvoTema);
                Console.WriteLine();
            }

            public void AgregarNuevoTema(params string[] temas)
            {
                Console.WriteLine("Recursos en la BD");
                Console.WriteLine("Se agregaron los siguientes temas");
                foreach (string tema in temas)
                {
                    Console.WriteLine("\tTema: {0}",tema);
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region "Ensamblados"
        //RN: Hacer un programa orientado a objetos que permita convertir de grados C° a grados F° y viceversa.

        static void UsoPooEnsamblados()
        {
            // A cuanto equivale 46° en F?

           Coppel.funciones.ConvertidorTemperatura obj = new ConvertidorTemperatura();

            Console.Write("Grados C°: ");
            obj.GradosC = double.Parse(Console.ReadLine());
            obj.Conversion = ConvertidorTemperatura.TipoConversion.DeCaF;

            Console.WriteLine("{0}°C equivalen a {1}° F",obj.GradosC,obj.Convertir());
            Console.ReadLine();


        }
        #endregion

        #region "Constructores"
        class Empresa
        {
            public string RazonSocial { get; set; }
            public int NoEmpleados { get; set; }
            public string Direccion { get; set; }

            public Empresa()
            {
                RazonSocial = "No Asignada";
            }

            public Empresa(string RazonSocial, int NoEmpleados,string Direccion)
            {
                this.RazonSocial = RazonSocial;
                this.NoEmpleados = NoEmpleados;
                this.Direccion = Direccion;
            }
        }
        
        static void RegistroEmpresa(Empresa objEmpresa)
        {
            Console.WriteLine("Datos de la empresa");
            Console.WriteLine("Razon social: {0}",objEmpresa.RazonSocial);
            Console.WriteLine("NoEmpleados: {0}",objEmpresa.NoEmpleados);
            Console.WriteLine("Direccion: {0}",objEmpresa.Direccion);
            Console.ReadLine();
        }


        static void UsoPOOConstructores()
        {
            /*
             * Constructor
             *  Def.:
             *      Inicializa los valores de las propiedades:
             *          En base al tipo de dato.
             *              Numericos -> 0
             *              Cadenas -> Cadenas vacias
             *              Boleano -> False
             *              Caracter -> Espacio
             *              Objeto -> null
             * 
             *      Tipos:
             *          -Constructor por defecto.
             *              No re sequiere codigo especial.
             *              Se incluye por parte de la plataforma .NET
             *              
             *          -Constructor sin parametros
             *              Sirve para personalizar el proceso de inicializacion.
             *              
             *          -Constructores personalizados
             *              Se usan para asignar valores a las propiedades desde que se crea el objeto.
             *              
             *          -Inicializadores de Objetos
             *              Sintaxis de C# que permite asociar valores a las propiedades sin depender del diseño de constructores de la clase.
             *              No soportada en las primeras versiones del lenguaje.
             *              
             *          -Validacion de estado
             *              Recnica de diseño basada en constructores que asegura que un objeto secree con valores de negocio
             *              Consiste en incluir constructores personalizados con parametros para asi evitar el constructor por defecto (de fabrica).
             */

            //Empresa objEmpresa = new Empresa();

            Empresa objEmpresa = new Empresa();
            objEmpresa.RazonSocial = "Mi EMpresa SA de CV";
            objEmpresa.NoEmpleados = 12345;
            objEmpresa.Direccion = "En algun lugar";
            RegistroEmpresa(objEmpresa);

            Empresa objEmpresa1 = new Empresa("Mi Empresa SA de CV", 12345, "En algun lugar");
            RegistroEmpresa(objEmpresa1);

            RegistroEmpresa(new Empresa("Mi EMpresa SA de CV", 12345, "En algun lugar"));

            //Inicializador de objetos
            RegistroEmpresa(new Empresa() {RazonSocial = "Mi EMpresa SA de CV",
                                            NoEmpleados = 12345,
                                            Direccion = "En algun lugar"});
            Console.ReadLine();


        }
        #endregion

        #region "Elementos de Instancia y Estaticos"
        
        static void UsoElementosInstanciaEstatico()
        {
            /*
             * Los elementos pueden ser de instancia (particulares) o estaticos (generales).
             * Si son de instancia se invocan a partir de un objeto.
             * Si son estaticos se invocan a partir de la clase.
             * 
             * Un elemento de instancia puede referirse a elementos de instanca y estaticos.
             * 
             * Un elemento estatico solo puede referirse a elementos estaticos.
             * 
             * El operador this hace referencia a elementos de la instancia.
             * 
             * Los valores constantes por definicion son elementos estaticos.
             * 
             * A los elementos estaticos tambien se les suelen llamar de clase o compartidos.
             * 
             * Constructores estaticos:
             *  Soportados por las ultimas versiones del lenguaje.
             *  Permiten inicializar propiedades estaticas.
             *  No llevan calificador de alcance; por definicion son publicos.
             *  No soportan parametros. (No soportan el concepto de sobrecarga)
             * 
             */
            Salon.Escuela = "San Sebastian";

            Salon objSalon = new Salon();
            objSalon.Capacidad = 30;
            objSalon.Registrar();


            Salon.BorrarTodo();

            Console.WriteLine(Salon.CAPACIDAD_LIMITE);
            Console.WriteLine("OK - UsoElementosInstanciaEstatico");
            Console.ReadKey();
        }

        class Salon
        {
            public const int CAPACIDAD_LIMITE = 40;


            public int Capacidad { get; set; }
            public static string Escuela { get; set; }

            public void Registrar()
            {
                
            }

            public static void BorrarTodo()
            {
                   
            }

            static Salon()
            {

            }

        }
        #endregion

        #region "Relaciones"
        /*
         *          Sentencia                   Ejemplo                         Nombre              Implementacion
         *          Tiene un           Poliza TIENE UN Asegurado              Asociacion             Tipo de dato 
         *          Es un                Taxi ES UN Automovil               Especializacion            Herencia
         *          Actua como un     Un cuadro ACTUA COMO UN decorador      Realizaciones            Interfaces
         */
        
       #endregion

        #region "Relaciones - Asociacion"
        
        class Asegurado
        {
            public string Nombre { get; set; }
            public bool EsFumador { get; set; }
        }

        class Poliza
        {
            // Antipatron de Diseño "El todo poderoso" que le carguen a una clase mas responsabilidades de las que debe.
            public int Folio { get; set; }
            public double SumaAgregada { get; set; }
            public Asegurado Asegurado { get; set; } //Asociacion
        }

        static void UsoPOORelacionesAsociacion()
        {
            Poliza objPoliza = new Poliza();

            objPoliza.Asegurado = new Asegurado() { Nombre = "Luis Silva", EsFumador = true };
            objPoliza.Folio = 123;
            objPoliza.SumaAgregada = 50000000.00;

            Console.WriteLine("Asegurado {0}, es fumador? {1}",objPoliza.Asegurado.Nombre,objPoliza.Asegurado.EsFumador);
            Console.ReadKey();
        }

        #endregion

        #region "Relaciones - Herencia"

        static void UsoPOORelacionesEspecializacion()
        {
            /*
             * Sentencia: ES UN
             * Nombre Especializacion
             * Clase Base / Anteprecesora / Padre / Super Clase
             * Clase Derivada / Desendente / Hija / Sub Clase
             * Herencia Multiple
             *      Una clase derivada tiene mas de una clase.
             *      C# no soporta la herencia multiple
             * Herencia de niveles Multiples
             *      Una derivada se convierte en base de otra.
             *      Soportado en c#
             *      P.ej:
             *          Telefono
             *              Celular
             *                  Smartphone
             *                  
             * La clase Raiz
             *      System.Object
             *      Es la clase base de todas las clases de .NET
             *      Es una relacion hecha por definicion.
             *      
             * Polimorfismo de jerarquis de objetos - Sobre Escritura
             *      Sobre Escritura - Flexible
             *      Sobre Escitura - Rigida
             */
        }

        class Tienda
        {
            public string Nombre { get; set; }
        }

        static void UsoPOOHerenciaLaClaseRaiz()
        {
            /*
             * Equals:
             *      Permite la comparacion entre objetos (en base a las referencias de memoria).
             * 
             * HashCode:
             *      Representacion numerica del area de memoria.
             *      
             * ToString:
             *      Devuelve el nombre completo de la clase a la que pertenece el objeto.
             *      
             * GetType:
             *      Devuelve informacion especifica del tipo del objeto.
             */

            Tienda objTienda1 = new Tienda() { Nombre = "Plaza Fiesta" };
            Tienda objTienda2 = new Tienda() { Nombre = "Elektra" };

            objTienda1 = objTienda2; //Referencias

            Console.WriteLine(objTienda1.Equals(objTienda2));
            Console.WriteLine(objTienda1.GetHashCode());
            Console.WriteLine(objTienda2.GetHashCode());
            Console.WriteLine(objTienda1.ToString());
            Console.WriteLine(objTienda1.GetType().Assembly.FullName);
            Console.ReadKey();
        }


        class Libro
        {
            public string Titulo { get; set; }
            public int NoPaginas { get; set; }

            public void Leer()
            {

            }

            public virtual void Abrir()
            {
                Console.WriteLine("Levantar la portada - Movimiento manual");
                Console.ReadKey();
            }

            public void Cerrar()
            {
                Console.WriteLine("El libro se ha cerrado");
            }
        }

        class EBook : Libro
        {
            public string SelloDigital { get; set; }

            public override void Abrir()
            {
                Console.WriteLine("Click sobre la aplicacion");
                Console.ReadKey();
            } 

            new public void Cerrar()
            {
                Console.WriteLine("El libro se ha cerrado correctamente");
            }

            public EBook()
            {
                Console.WriteLine("Constructor de EBook - (Derivada)");
            }
        }

        static void UsoPOOHerenciaPErsonalizada()
        {
            EBook objEBook = new EBook();

            //Clase base
            objEBook.Titulo = "El titulo";
            objEBook.NoPaginas = 100;
            //Clase derivada
            objEBook.SelloDigital = "adjlahjkdsfhdskfl";
            objEBook.Leer();
        }

        static void AdministracionBiblioteca(Libro obj)
        {
            //obj.Abrir();
            obj.Cerrar();
            Console.ReadKey();
        }

        static void UsoPOOHerenciaSobreEscritura()
        {
            //EBook objEBook = new EBook();
            //objEBook.Abrir();
            AdministracionBiblioteca(new Libro());
            AdministracionBiblioteca(new EBook());
        }

        class Automovil
        {
            public Automovil(string NoPlacas)
            {

            }
        }

        class Taxi : Automovil
        {
            public Taxi():base("") //Llamar un contructor de la clase base desde una clase derivada
            {

            }
        }

        static void UsoPOOHerenciaConstructores()
        {
            new EBook();
            new Automovil("123-ABC");
            new Taxi();
            Console.ReadKey();
        }

        static void UsosPOOClasesAbstactas()
        {
            //EditorTexto obj = new EditorTexto();
            RedactarDocumento(new Notepad());
            RedactarDocumento(new Winword());
            RedactarDocumento(new NotepadPlus());
        }

        static void RedactarDocumento(EditorTexto obj)
        {
            obj.Escribir();
            Console.ReadLine();
        }

        abstract class EditorTexto
        {
            //
            public abstract void Escribir();
            public abstract void Copiar();
            public abstract void Pegar();
        }

        class Notepad : EditorTexto
        {

            public override void Escribir()
            {
                Console.WriteLine("Escribe con formato basico - Notepad");
            }

            public override void Copiar()
            {
                
            }

            public override void Pegar()
            {
                
            }
        }

        sealed class Winword : EditorTexto
        {

            public override void Escribir()
            {
                Console.WriteLine("Escribe con formato basico - Winwird");
            }

            public override void Copiar()
            {
                
            }

            public override void Pegar()
            {
                
            }
        }

        class NotepadPlus : Notepad
        {
            public override void Escribir()
            {
                base.Escribir();
                Console.WriteLine("Con correccion de ortografia");
            }
        }

        #endregion

        #region "Actividad"
        
        static void UsoActividadRelaciones()
        {
            /*
             * RN: Hacer un programa orientado a objetos que muestre al comensal lo que debe pagar de su consumo, considerado que:
             *      Hasta la fecha el restaurante maneja diferentes tipos de platillos (Posteriormente se piensa expandir la oferta)
             *      
             *     Los platillos que se manejan actualmente son:
             *          Cortes
             *          Mariscos
             *          Ensalada
             *     
             *      Todos los platillos tienen un nombre y un precio
             *      
             *      El programa debe mostrar los platillos consumidos y el total a pagar.
             *      
             *      Los platillos tienen caracteristicas especiales:
             *          cortes: un termino de coccion.
             *          Mariscos: Fecha de veda.
             *          Ensaladas: Aderezo.
             */

            cortes objCortes = new cortes() {Nombre = "Filete",precio = 100 };
            Ensaladas objEnsalada = new Ensaladas() {Nombre = "Ensalada cesar", precio = 50 };

            Comanda objComanda = new Comanda();
            objComanda.calcularTotal(objCortes, objEnsalada);
            Console.ReadKey();
            

        }

        abstract class platillo
        {
            public string Nombre { get; set; }
            public double precio { get; set; }

        }

        class cortes : platillo
        {
            public double Termino { get; set; }

        }

        class Mariscos : platillo
        {
            public DateTime FechaVeda { get; set; }
        }

        class Ensaladas : platillo
        {
            public string Aderezo { get; set; }
        }

        class Comanda 
        {
            public void calcularTotal(params platillo[] platillos)
            {
                double resultado = 0.0;

                foreach (platillo item in platillos)
                {
                    Console.WriteLine("{0} {1}",item.Nombre,item.precio.ToString("c"))
                        ;
                    resultado += item.precio;
                }
                Console.WriteLine("==========================================");
                Console.WriteLine("Total: {0}",resultado.ToString("c"));
            }
        }
        #endregion

        interface IEMpleadoPiso
        {
           void AtenderClientes();
        }

        interface IrecursosHumanos
        {
            void EntrevistarCandidato();
        }

        class Empleado
        {
            public string Puesto { get; set; }
        }

        class Programador : Empleado,IEMpleadoPiso,IrecursosHumanos
        {
            public double Sueldo { get; set; }

            public void programar(){}

            public void AtenderClientes()
            {
                Console.WriteLine("Atiende a los clientes sin mucho animo.");
                Console.ReadKey();
            }

            public void EntrevistarCandidato()
            {
                Console.WriteLine("El programador enrevista candidatos");
            }
        }

        class Secretaria : Empleado,IEMpleadoPiso
        {
            public void Contestar() {}

            public void AtenderClientes()
            {
                Console.WriteLine("Atiende cliente con coordialidad");
                Console.WriteLine();
            }
        }

        class Intendente : Empleado
        {
            
        }

        static void Recepcion(IEMpleadoPiso obj)
        {
            obj.AtenderClientes();
            Console.WriteLine();
        }

        static void ComprobacionInterfaces(object obj)
        {
            IEMpleadoPiso iObj = (IEMpleadoPiso)obj;
            iObj.AtenderClientes();
            Console.WriteLine();
        }

        static void ComprobacionInterfacesIs(object obj)
        {
            if (obj is IEMpleadoPiso)
            {
                IEMpleadoPiso iObj = (IEMpleadoPiso)obj;
                iObj.AtenderClientes();
            }
            else
            {
                Console.WriteLine("El objeto no puede atender a los clientes");
            }
            Console.WriteLine();
        }

        static void ComprobacionInterfacesAs(object obj) //Es mas eficiente pues no verifica dos veces el objeto
        {
            IEMpleadoPiso iObj = obj as IEMpleadoPiso;
 
            if (iObj != null)
            {
                iObj.AtenderClientes();
            }
            else
            {
                Console.WriteLine("El objeto no puede atender a los clientes");
            }
            Console.WriteLine();
        }

        static void UsoPOORealizaciones()
        {
            /*
             * Interfaz Nativa / Por defecto / Primaria
             * Alta cohesion
             * Interfaz secundarias / multiples
             * -Bajo acoplamiento (programar con Interfaces)
             * -Alto acoplamiento (programar con una Clase en especifico)
             * Programacion por contrato
             * Se puede complementar con la herencia.
             *      Se debe priorizzar la herencia.
             * Una clase puede implmentar varias interfaces.
             * Una interfaz no puede tener implementaciones.
             * Una interfaz puede heredar de varias interfaces (Herencia multiple)
             * 
             * Comprobacion de Interfaces y/o Clases
             *      Cast
             *          En caso que no se pueda hacer la conversion gennerica excepciones.
             *          Usado cuando sequiere manejar la excempcion.
             *          Requiere mas recursos, justamente para manejar la excepcion.
             *      Operadot Is
             *          Permite comprobar que un objeto implementa la interfaz antes de convertir.
             *          Es menos "pesado" que el cast por no requerir excepciones.
             *          Requiere una doble revision del objeto.
             *      Operador As
             *          En caso de no poder convertir genera una referencia nula.
             *          No maneja excepciones ni requiere una doble comprobacion; por lo cual es mas eficiente.
             *          Soportado en versiones recientes del lenguaje.
             * 
             */

            //Recepcion(new Programador());
            //Recepcion(new Secretaria());
            ComprobacionInterfacesIs(new Intendente());
            ComprobacionInterfacesIs(new Programador());
        }

        #endregion

        #region "Excepciones"

        static void RecuperaValor()
        {
            Console.WriteLine("Escribe un numero entero");
            int entero = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor capturado: {0}",entero);
            Console.ReadKey();
        }

        static void UsoAPIExcepcionCOndicionError()
        {
            /*
             * Tipos de errores
             *      -Sintaxis
             *          Violaciones a las reglas de lenguaje
             *          Ejemplos:
             *              Omitir punto y coma
             *              Referirse a una palabra en mayusculas cuando era en minusculas.
             *              Falta de alguna llave en un bloque de codigo.
             *              Usar el operador virtual en un constructor.  
             *              Aplicar un modificador de visivilidad a un contructor estatico.
             *          Solucion: Se evitan conociendo el lenguaje
             *          
             *      -Tiempo de ejecucion
             *          Condiciones de error en la ejeccion del programa
             *          Tiempo: Ejecucion
             *          Ejemplos:
             *              Una base de datos desconectada.
             *              Permisos insuficientes para realizar una accion.
             *              Acceso a un puerto restringido.
             *              Conversion a un tipo de dato no valido.
             *              Division por cero. (entre valores enteros)
             *         Solucion: Estrategia de manejo de errores y conocimiento de la operacion de los componentes.
             *      -Logicos
             *          Operaciones no deseadas en el comportamiento de la aplicacion.
             *          Tiempo: Ejecucion
             *          Ejemplos:
             *              Redondeos no deseados.
             *              Calculos no realizados o realizados de mas.
             *              El 2YK
             *          Solucion: Conociendo la regla de negocio.
             */

            RecuperaValor();
        }

        static void UsoAPIExcepcionMAnejoError()
        {
            Console.WriteLine("Escribe un numero: ");

            try
            {
                int entero = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor capturado {0}",entero);
            }
            catch
            {

                Console.WriteLine("Introduce un valor soportado");
                Console.ReadKey();
            }
        }

        static void UsoAPIExcepcionUsoExcepcion()
        {
            Console.WriteLine("Escribe un numero: ");

            try
            {
                int entero = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor capturado {0}", entero);
            }
            catch (Exception ex) // Objeto creado por el CLR.
            {

                Console.WriteLine("Error {0}",ex.Message);
                Console.ReadKey();
            }
        }

        static void UsoAPIExcepcionCatchMultiples()
        {
            Console.WriteLine("Escribe un numero: ");

            try
            {
                int entero = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor capturado {0}", entero);
            }
            catch (OverflowException ex)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Error de sobre Flujo: {0}", ex.Message);
                Console.ReadKey();
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Error de sobre Formato: {0}", ex.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: {0}", ex.Message);
                Console.ReadKey();
            }
        }

        static void UsoAPIExcepcionClausulaFinally()
        {
            Console.WriteLine("Escribe un numero: ");

            try
            {
                int entero = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor capturado {0}", entero);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: {0}", ex.Message);
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Proceso terminado!");
                Console.ReadKey();
            }
        }

        class Reporteador
        {
            public void GenerarReporte()
            {
                Console.WriteLine("Reporte generado con exito.");
            }

            public void LiberarRecursos()
            {
                Console.WriteLine("Se liberan todos lo recursos usados por el reporteador");
            }
        }

        static void UsoAPIExcepcionLiberacionRecursos()
        {
            Reporteador objReporteador = new Reporteador();


            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                objReporteador.GenerarReporte();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: {0}",ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                objReporteador.LiberarRecursos();
                Console.ReadKey();
            }   
            
        }

        class ReporteadorPlus : Reporteador,IDisposable
        {
            public void Dispose()
            {
                LiberarRecursos();
            }
        }

        static void UsoAPIExcepcionLiberacionAutomaticaDeRecursos()
        {
            try
            {
                using (ReporteadorPlus objReporteador = new ReporteadorPlus())
                {
                    objReporteador.GenerarReporte();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}",ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Proceso terminado!!");
            }

            Console.ReadKey();
        }

        static void UsoAPIExcepcionActivacion()
        {
            Console.WriteLine("Escribe un entero: ");

            try
            {
                int entero = int.Parse(Console.ReadLine());

                if (entero >= 100)
                {
                    throw new ApplicationException("Valor no valido");
                }
                    Console.WriteLine("Valor capturado: {0}",entero);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error General: {0}", ex.Message);
            }

            Console.ReadLine();
        }


        //============================================


        class VentasException : Exception
        {
            public string Responsable 
            {
                get 
                { 
                    return "Luis Silva"; 
                }
            }

            public VentasException(string mensaje): base(mensaje)
            {

            }

        }

        class Ventas
        {
            private const int UNIDADES_INVENTARIO = 10;

            public void vender(int cantidad)
            {
                if (cantidad > UNIDADES_INVENTARIO)
                {
                    throw new VentasException("No hay unidades suficientes en inventario");
                }
            }
        }

        static void UsoAPIExcepcionPersonalizada()
        {

            Ventas objVentas = new Ventas();

            try
            {
                objVentas.vender(11);
                Console.WriteLine("Venta exitosa");
            }
            catch (VentasException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error en ventas");
                Console.WriteLine("Responsable: {0}",ex.Responsable);
                Console.WriteLine("Error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Error general: {0}",ex.Message);
            }
            Console.ReadLine();
        }

        #endregion

        #region "Strings"
        
        static void UsoAPICadenasCreacion()
        {
            //Por valores literales
            string cad1 = "Curso de C# Culiacan";
            // A traves de constructores
            string cad2 = new string('=', 50);

            Console.WriteLine(cad1);
            Console.WriteLine(cad2);
            Console.ReadLine();
        }

        static void UsoAPICadenasComparacion()
        {
            /*
             *Comparaciones:
             *      La comparacion entre objetos implica comparar referencias.
             *      Las cadenas aun siendo objetos su comparacion es con valores.
             *      Los valores se una cadena son Unicode.
             *          -Ocupan 2bytes por caracter.
             *          -Permiten la representacion de alfabetos con mas caracteres.
             *          -Son sensitivas
             *      Las cadenas se pueden comparar con:
             *          Método Equals de la clase Object.
             *          Con el operador == (C#)
             *          Metodo Compare de la clase String.
             *              Valores de regreso:
             *                  1 La primera cadena es mayor
             *                  0 Iguales
             *                 -1 La primera cadena es menor
             *              Permite con considerar mayusculas y minusculas.
             * 
             */

            Curso obj1 = new Curso() { Nombre = "XML" };
            Curso obj2 = new Curso() { Nombre = "XML" };

            Console.WriteLine(obj1.Equals(obj2));
            Console.WriteLine(obj1 == obj2);
            Console.WriteLine(obj1.Nombre.Equals(obj2.Nombre));
            Console.WriteLine(obj1.Nombre == obj2.Nombre);
            Console.WriteLine(String.Compare(obj1.Nombre,obj2.Nombre));
            Console.ReadLine();
        }

        static void UsoAPICadenasEntidadInmutable()
        {
            Console.WriteLine("Limite: ");
            string separador = new string('=', 50);
            int limite = int.Parse(Console.ReadLine());
            //string secuencia = "";
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= limite; i++)
			{
			    //secuencia += i + " ";
                sb.Append(i);
                sb.Append(" ");
                Console.WriteLine(sb.GetHashCode());
			}
            Console.WriteLine(separador);
            Console.WriteLine("OK- Secuencia terminada");
            Console.ReadLine();
        }

        static void UsoAPICadenasElementos()
        {
            string cadena = "Curso de programacon Avanzada con c# y Windows Communication Foundation";

            Console.WriteLine("Elementos de la clase string");
            Console.WriteLine("Cadena en matusculas: {0}",cadena.ToUpper());
            Console.WriteLine("Cadena en minusculas: {0}",cadena.ToLower());
            Console.WriteLine("Longitud de la cadena: {0}",cadena.Length);
            //Las cadenas inician en cero
            //      Si el caracter no es encontrado; regresa -1
            Console.WriteLine("Posicion del caracter '#': {0}", cadena.IndexOf("#"));
            Console.WriteLine("Posicion del caracter '#': {0}", cadena.IndexOf("x"));
            //Reemplazo
            Console.WriteLine("Posicion del caracter '#': {0}", cadena.Replace("Windows Communication Foundation","WCF"));
            //Subcadenas
            //  Ver1.: A partir de un caracter hasta el final.
            //  Ver2.: En un rango de caracteres.
            Console.WriteLine("SubCadena ver1,: {0}",cadena.Substring(30));
            Console.WriteLine("SubCadena ver1,: {0}", cadena.Substring(21,35));
            //Rellenar caracteres
            Console.WriteLine(cadena.PadRight(100,'.'));
            Console.ReadLine();
        }

        static void UsoAPICadenasCaracteresEscape()
        {
            string mensaje = "Promocion del dia: \n2x1 en todos los productos.";
            string rutaArchivo1 = "C:\\Users\\210\\Desktop\\Notas y archivos curso c#\\Proyectos c#\\PlataformaNET\\ClienteConsola\\Program.cs";
            string rutaArchivo2 = @"C:\Users\210\Desktop\Notas y archivos curso c#\Proyectos c#\PlataformaNET\ClienteConsola\Program.cs";
            Console.WriteLine(mensaje);
            Console.WriteLine(rutaArchivo1);
            Console.WriteLine(rutaArchivo2);
            Console.ReadLine();
        }

        #endregion

        #region "Areglos"
        
        static void UsoAPIArreglosJagged()
        {
            /*
             * Jagged = Arreglo de arreglos.
             * Cada elemento de un arreglo; es otro arreglo
             * pero este segundo arreglo tiene un numero de elementos diferentes con respecto a los demas.
             */

            int[][] calificaciones = new int[3][];

            // Calificaciones del primer alumno.
            calificaciones[0] = new int[3];
            calificaciones[0][0] = 8;
            calificaciones[0][0] = 6;
            calificaciones[0][0] = 7;

            //Calificacion del segundo alumno.
            calificaciones[1] = new int[] { 8, 6, 9, 7, 8, 6 };

            //Calificaciones del tercer alumno.
            calificaciones[2] = new int[2];
            calificaciones[2][0] = 9;
            calificaciones[2][1] = 10;

            Console.WriteLine("Ok - UsoAPIArreglosJagged");

            double resultado = calificaciones[1].Average();

            if ( resultado >= 7.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Acredita");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No acredita");
            }
            Console.WriteLine("Calificacion final: {0}",resultado);
            Console.ReadLine();
        }

        static void UsoAPIArreglosRectangulares()
        {
            string[,] agenda = new string[4, 3];

            agenda[0, 0] = "Ana torres";
            agenda[0, 1] = "ana@dci.com.mx";
            agenda[0, 2] = "02994 - 93848";

            agenda[1, 0] = "Luis silva";
            agenda[1, 1] = "luis@dci.com.mx";
            agenda[1, 2] = "4324 - 65465";

            agenda[2, 0] = "Rafael valle";
            agenda[2, 1] = "rafa@dci.com.mx";
            agenda[2, 2] = "43242 - 43432";

            agenda[3, 0] = "Veronica lopez";
            agenda[3, 1] = "vero@dci.com.mx";
            agenda[3, 2] = "54233 - 43444";

            Console.WriteLine("OK - UsoAPIArreglosRectangulares");
        }

        static void UsoAPIArreglosElementos()
        {
            string[] colores = { "verde", "amarillo", "rojo", "azul", "morado" };

            Console.WriteLine("Numero de elementos (int32): {0}", colores.Length);
            Console.WriteLine("Numero de elementos (int64): {0}", colores.LongLength);
            Console.WriteLine("Numero de elementos (int64): {0}", colores.GetLongLength(0));
            Console.WriteLine("Indice menor: {0}", colores.GetLowerBound(0));
            Console.WriteLine("Indice mayor: {0}", colores.GetUpperBound(0));
            Console.WriteLine("Valor x indice: [original] {0}", colores.GetValue(0));
            Array.Reverse(colores);
            Console.WriteLine("Valor x indice: [inverso] {0}", colores.GetValue(0));
            Console.ReadLine();
        }

        static void UsoAPIArreglosYCadenas()
        {
            string ciudades = "Culiacan,villahermosa,puebla,san luis potosi,uruapan,acapulco";
            string[] arrCiudades = ciudades.Split(',');
            Array.Sort(arrCiudades);
            Console.WriteLine(String.Join(",",arrCiudades));
            Console.ReadLine();
        }

        #endregion

        #region "APIs" 
      
        static void UsoAPIColeccionesGenerales()
        {
            /*
             * Pueden contener objetos.
             * permiten valores duplicados.
             * Y son ordenados.
             */
            ArrayList objArrayList = new ArrayList();

            objArrayList.Add(123);
            objArrayList.Add("Coppel");
            objArrayList.Add(new Curso());

            foreach (object item in objArrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static void UsoAPIColeccionesEspecializadas()
        {
          
            StringCollection objStringCollection = new StringCollection();

            objStringCollection.Add("Cad 1");
            objStringCollection.Add("Cad 2");
            objStringCollection.Add("Cad 3");
            objStringCollection.Add("Cad 4");

            foreach (string item in objStringCollection)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static void UsoAPIColeccionesGenericas()
        {
            List<Libro> objList = new List<Libro>();

            objList.Add(new Libro() { Titulo = "Libro 1" });
            objList.Add(new Libro() { Titulo = "Libro 2" });
            objList.Add(new Libro() { Titulo = "Libro 3" });
            objList.Add(new Libro() { Titulo = "Libro 4" });

            foreach (Libro item in objList)
            {
                Console.WriteLine(item.Titulo);
            }
            Console.ReadLine();
        }

        static void UsoAPIColeccionesElementos()
        {
            StringCollection valores = new StringCollection();

            valores.Add("Valor 1");
            valores.Add("Valor 2");
            valores.Add("Valor 3");
            valores.Add("Valor 4");
            valores.Add("Valor 5");
            valores.Insert(5,"Valor 6");
            valores.AddRange(new string[]{"Valor 9","Valor 10", "Valor 11"});

            Console.WriteLine("Numero de elementos: {0}",valores.Count);
            Console.WriteLine("Indice de un valor: {0}", valores.IndexOf("Valor 3"));
            Console.WriteLine("¿Existe el valor 13?: {0}", ((valores.Contains("13")) ? "SI" : "NO"));
            valores.RemoveAt(1); // Por indice.
            valores.Remove("Valor 1"); //Por valor.
            valores.Clear();

            foreach (string item in valores)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        } 

        static void UsoAPIActividad()
        {
            /*
             * Hacer un despertador orientado a objetos considerando que:
             *  -Puede tener varias alarmas.
             *  -Cada alarma tendra:
             *      Un nombre (mensaje)
             *      Un hora de activacion.
             *  -El despertador no puede tener mas de tres alarmas registradas.
             *  -El despertador debe tener una hora de activacion que determine hasta que momento esta en operacion.
             *  
             * -Incluir un codigo que muestre el uso del despertador. Es decir que cuando se cumpla la hora se muestre el aviso en la aplicacion.
             * 
             * Tip:
             *  DateTime.toString("mmhhss");
             * 
             */
            Despertador objDespertador = new Despertador();
            objDespertador.Nombre = "Despierta";
            objDespertador.AgregarAlarma(new Alarma());
            objDespertador.FechaDeActivacion = DateTime.Now.AddSeconds(10);
            objDespertador.Activar();
        }

        class Alarma
        {
            public string Nombre { get; set; }
            public DateTime FechaDeActivacion { get; set; }
        }

        class Despertador: Alarma
        {
            private const int LIMITEALARMAS = 3;
            private List<Alarma> _Alarmas;
            public DateTime Activacion { get; set; }

            public Despertador()
            {
                _Alarmas = new List<Alarma>();
            }

            public void AgregarAlarma(Alarma Alarma)
            {
                if (_Alarmas.Count < LIMITEALARMAS)
                {
                    _Alarmas.Add(Alarma);
                }
                else
                {
                    throw new ApplicationException("Se ha llegado al limite de alarmas");
                }
                
            }

            public void Activar()
            {
                while (DateTime.Now < Activacion)
                {
                    foreach (Alarma item in _Alarmas)
                    {
                        if (DateTime.Now.ToString("mmhhss") == item.FechaDeActivacion.ToString("mmhhss"))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine(item.Nombre);
                            return;
                        }
                    }
                    Console.ReadLine();
                }
            }
        }

        #endregion

        #region "Frameworks"
        
        static void UsoFRMADDONETIntro()
        {
            /*
             * ADO.NET
             *      -Framework para conetividad con fuentes de datos.
             *      -Fuentes de datos es un termino usado or la plataforma para indicar que los datos pueden provenir de varios lugares (BDs, Archivos de texto, documentos xml, estructuras de memoria, etc)
             *      -Ambiente conectado
             *          Requiere una conexion con la base de datos.
             *      -Ambiente 
             *      
             * ADO.NET (Ambiente - Conectado)
             *      
             *      Arquitectura
             *                           (System.Data.dll)
             *          App.NET <------------>ADO.NET<-----------------> Drivers <---------------------> DMBS
             *                           Data .Net Provider            ODBC/OLEDB
             *                             xyzConnection            (MS integrados)
             *                              xyzCommand
             */
        }

        static void UsoFRAMEWORKADONETActionQuery()
        {
            try
            {
                using(SqlConnection cnn = new SqlConnection())
                {
                    cnn.ConnectionString = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=Educacional;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    cmd.CommandText = "INSERT INTO Cursos VALUES ('Fundamentos XML',10)";
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("Curso registrado con exito");
            }
            catch (SqlException ex)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Error de SQL server: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Error general: {0}", ex.Message);
            }
            Console.ReadLine();
        }

        #endregion
    }
}
