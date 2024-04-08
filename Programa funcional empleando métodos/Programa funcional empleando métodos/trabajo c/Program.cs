using System;
namespace inventario
{

   
    class Program

    {  
        static void inicio (){
             Console.WriteLine("Ingrese su nombre");
             string nom = Console.ReadLine();
             Console.WriteLine("Usuario: "+nom);
        } 
        static void saludo()
        {
            Console.WriteLine("Hola, bienvenido al sistema de inventario\n");
        }

        static void productos ()
    {
          Console.WriteLine("Bienvenido al inventario de productos");
          Console.WriteLine("Ingrese la cantidad de productos a ingresar");
            int cantidades = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= cantidades; i++){
            Console.WriteLine("Ingrese el nombre del producto");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad del producto");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto");
            int precio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo del producto");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Los productos ingresados son: ");
            Console.WriteLine("Nombre: " + nombre + "Cantidad: " + cantidad + "Precio: " + precio + "Codigo: " + codigo);
            }
    }
        static void usuarios()
        {
            Console.WriteLine("Bienvenido al inventario de usuarios");
            Console.WriteLine("Ingrese la cantidad de usuarios a ingresar");
            int usuarios = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= usuarios; i++){
            Console.WriteLine("Ingrese el nombre del usuario");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del usuario");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el rol del usuario");
            string rol = Console.ReadLine();
            Console.WriteLine("Ingrese el estado del usuario");
            string estado = Console.ReadLine();
            Console.WriteLine("Los usuarios ingresados son: ");
            Console.WriteLine("Nombre: " + nombre + "Apellido: " + apellido + "Rol: " + rol + "Estado: " + estado);
            }
        }

        static void desarrollador()
        {
             Console.WriteLine("Desarrollador");
            Console.WriteLine("Nombre: Jorge");
            Console.WriteLine("Ficha: 2558684 ");
        }

        static void defaul()
        {
            Console.WriteLine("La opcion no es valida saliendo del sistema ...");
            Console.WriteLine("Gracias por usar el sistema de inventario : ");
            
        }

        static void listaProductos()
        {
            Console.WriteLine("Lista de productos");
            Console.WriteLine("Nombre: Arroz" + "Cantidad: 10" + "Precio: 1000" + "Codigo: 1");
            Console.WriteLine("Nombre: Frijoles" + "Cantidad: 5" + "Precio: 500" + "Codigo: 2");        
            Console.WriteLine("Nombre: Panela" + "Cantidad: 2" + "Precio: 2000" + "Codigo: 3");
            Console.WriteLine("Nombre: Sal" + "Cantidad: 1" + "Precio: 100" + "Codigo: 4");
            Console.WriteLine("Nombre: Azucar" + "Cantidad: 3" + "Precio: 300" + "Codigo: 5");
            Console.WriteLine("Nombre: Cafe" + "Cantidad: 4" + "Precio: 400" + "Codigo: 6");
            Console.WriteLine("Nombre: Chocolate" + "Cantidad: 6" + "Precio: 600" + "Codigo: 7");
            Console.WriteLine("Nombre: Leche" + "Cantidad: 7" + "Precio: 700" + "Codigo: 8");
            Console.WriteLine("Nombre: Huevos" + "Cantidad: 8" + "Precio: 800" + "Codigo: 9");
            Console.WriteLine("Nombre: Queso" + "Cantidad: 9" + "Precio: 900" + "Codigo: 10");

            }

        static void listaUsuarios()
        {
            Console.WriteLine("Lista de usuarios");
            Console.WriteLine("Nombre: Jhors" + "Apellido: Pineda" + "Rol: Administrador" + "Estado: Activo");
            Console.WriteLine("Nombre: Ricardo" + "Apellido: Millos" + "Rol: Administrador" + "Estado: Activo");
            Console.WriteLine("Nombre: Maria" + "Apellido: Rodriguez" + "Rol: Vendedor" + "Estado: Activo");
            Console.WriteLine("Nombre: Pedro" + "Apellido: Gomez" + "Rol: Vendedor" + "Estado: Inactivo");
            Console.WriteLine("Nombre: Luis" + "Apellido: Jimenez" + "Rol: Vendedor" + "Estado: Activo");
            Console.WriteLine("Nombre: Carlos" + "Apellido: Cardona" + "Rol: Vendedor" + "Estado: Inactivo");
            Console.WriteLine("Nombre: Andres" + "Apellido: Suarez" + "Rol: Vendedor" + "Estado: Activo");
            Console.WriteLine("Nombre: Camilo" + "Apellido: Peralta" + "Rol: Vendedor" + "Estado: Activo");
        }

        static void queja()
        {
            Console.WriteLine("Ingrese su queja");
            string queja = Console.ReadLine();
            Console.WriteLine("Su queja es: " + queja);
        }

        static void sujerencia()
        {
            Console.WriteLine("Ingrese su sugerencia");
            string sugerencia = Console.ReadLine();
            Console.WriteLine("Su sugerencia es: " + sugerencia);
        }

        static void reclamo()
        {
            Console.WriteLine("Ingrese su reclamo");
            string reclamo = Console.ReadLine();
            Console.WriteLine("Su reclamo es: " + reclamo);
        }

        static void peticion()
        {
            Console.WriteLine("Ingrese su peticion");
            string peticion = Console.ReadLine();
            Console.WriteLine("Su peticion es: " + peticion);
        }

        static void felicitacion()
        {
            Console.WriteLine("Ingrese su felicitacion");
            string felicitacion = Console.ReadLine();
            Console.WriteLine("Su felicitacion es: " + felicitacion);
        }

        static void areaPeticiones()
        {
         Console.WriteLine("Bienvenido al area de atencion al cliente"); 
        }
        
        static void defaul1()
        {
            Console.WriteLine("La opcion no es valida saliendo del sistema ...");
            Console.WriteLine("Gracias por usar el area de peticiones : ");
            
        }

        static void calculadora()
        {
            Console.WriteLine("Bienvenido a la calculadora");
        }

        static void suma()
        {   
            Console.WriteLine("Ingrese el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int suma = num1 + num2;
            Console.WriteLine("La suma es: " + suma);
          
           }

        static void resta()
        {
            Console.WriteLine("Ingrese el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int resta = num1 - num2;
            Console.WriteLine("La resta es: " + resta);
        }

        static void multiplicacion()
        {
            Console.WriteLine("Ingrese el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int multiplicacion = num1 * num2;
            Console.WriteLine("La multiplicacion es: " + multiplicacion);

        }

        static void division()
        {
            Console.WriteLine("Ingrese el primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int division = num1 / num2;
            Console.WriteLine("La division es: " + division);
        }   

        static void defaul2 ()
        {
            Console.WriteLine("La opcion no es valida saliendo del sistema ...");
            Console.WriteLine("Gracias por usar la calculadora : ");
        }
        static void Main(string[] args)
        {

            inicio();
            saludo();
            
            Console.WriteLine("Por favor ingrese una opcion valida\n");
            Console.WriteLine("[1] Productos");
            Console.WriteLine("[2] Usuarios");
            Console.WriteLine("[3] Lista de productos");
            Console.WriteLine("[4] Lista de usuarios");
            Console.WriteLine("[5] Area de peticiones");
            Console.WriteLine("[6] Calculadora");
            Console.WriteLine("[7] Desarrollador");

            int opcion = Convert.ToInt32(Console.ReadLine());  
            switch (opcion)
            {
                case 1:
                    productos();
                    break;
                case 2:
                    usuarios();
                    break;
                case 3:
                   listaProductos();
                    break;
                case 4:
                    listaUsuarios();
                    break;
                case 5:
                    areaPeticiones();
                        Console.WriteLine("Por favor ingrese una opcion valida\n");
                        Console.WriteLine("[1] Quejas");
                        Console.WriteLine("[2] Sugerencias");
                        Console.WriteLine("[3] Reclamos");
                        Console.WriteLine("[4] Peticiones");
                        Console.WriteLine("[5] Felicitaciones");
                        int opt = Convert.ToInt32(Console.ReadLine());  
                        switch (opt)
                        {
                            case 1:
                                queja();
                                break;
                            case 2:
                                sujerencia();
                                break;
                            case 3:
                                reclamo();
                                break;
                            case 4:
                                peticion();
                                break;
                            case 5:
                                felicitacion();
                                break;
                            default:
                                defaul1();
                                break;
                                
                        }
                    
                    break;
                
                case 6:   
                            calculadora();
                                Console.WriteLine("Por favor ingrese una opcion valida\n");
                                Console.WriteLine("[1] Suma");
                                Console.WriteLine("[2] Resta");
                                Console.WriteLine("[3] Multiplicacion");
                                Console.WriteLine("[4] Division");
                            
                                int op = Convert.ToInt32(Console.ReadLine());  
                            switch (op){
                                case 1:
                                    suma();
                                    break;
                                case 2:
                                    resta();
                                    break;
                                case 3:
                                    multiplicacion();
                                    break;
                                case 4:
                                    division();
                                    break;
                        
                            default:
                                defaul2();
                                break;
                   }
                    break;
                case 7:
                    desarrollador();
                    break;

                default:
                    defaul();
                    break;
            }
        }
    }
}