namespace Actividades{
    class Program{
        static void Main(String[] args){
            CadenasTexto1();
            CadenasTexto2();
            ConversiónMay1();
            ConversiónMay2();
            Concatenar1();
            Concatenar2();
            ConcatenerNum(5, 10);
            ConcatenerNum2();
            InterpolaciónCadenas();
            InterpolaciónCadenas2();
            CadenasAcceso();
            CadenasAcceso2();
            BuscarCadena();
            BuscarCadena2();
            CadenaSubString();
            CadenaSubString2();
            CaracteresEspeciales();
            CaracteresEspeciales2();
            CaracteresEspeciales3();
            CaracteresEspeciales4();
            BoleanNum();
            BoleanNum2();
            If();
            If2();
            IfElseIfElse();
            IfElseIfElse2(); 
            IfUltimate();
            IfUltimate2();
            ActividadSwitch();
            ActividadSwitch2();
        }
        static void CadenasTexto1(){
            string message = "Programando en C#..!";
            Console.WriteLine($"el mensaje tiene {message.Length} de length y dice {message}");
        }
        static void CadenasTexto2(){
            Console.Write("escribe un mensaje: ");
            string message = Console.ReadLine();
            Console.WriteLine($"El length de tu mensaje es : {message.Length}");
        }
        static void ConversiónMay1(){
            string text = "Colombia";
            Console.WriteLine($"{text.ToLower()} es el mejor pais VIVA {text.ToUpper()}");
        }
        static void ConversiónMay2(){
            Console.Write("Escribe algo en minusculas: ");
            string text = Console.ReadLine();
            Console.WriteLine($"aqui tienes el mensaje en mayusculas: {text.ToUpper()}");
        }
        static void Concatenar1(){
            string pj1 = "Nahida";
            string pj2 = "<3";
            Console.WriteLine(pj1 + " " +pj2);
        }
        static void Concatenar2(){
            string pj1 = "Nahida";
            Console.WriteLine("Completa un mensaje con nahida: ");
            string text = Console.ReadLine();
            Console.WriteLine(string.Concat(pj1," " ,text));
        }
        static void ConcatenerNum(int a, int b){
            int result = a + b;
            Console.WriteLine($"Sumaremos el numero {a} y el {b} que da como resultado {result}");
        }
        static void ConcatenerNum2(){
            Console.WriteLine("Escribe un numero: ");
            string a = Console.ReadLine();
            Console.WriteLine("Escribe otro numero: ");
            string b = Console.ReadLine();
            string result = a + b;
            Console.WriteLine($"uniremos los numeros {a} y el {b} que da como resultado {result}");
        } 
        static void InterpolaciónCadenas(){
            string message1 = "Hola";
            string message2 = "esta";
            string message3 = "es";
            string message4 = "una";
            string message5 = "Cadena Interpolada";
            Console.WriteLine($"{message1} {message2} {message3} {message4} {message5}");
        }
        static void InterpolaciónCadenas2(){
            Console.WriteLine("Escribe un mensaje: ");
            string message = Console.ReadLine();
            Console.WriteLine($"Este mensaje esta siendo interpolado: {message}");
        }
        static void CadenasAcceso(){
            string message = "Hola";
            Console.WriteLine(message[0]);
            Console.WriteLine(message[1]);
            Console.WriteLine(message[2]);
            Console.WriteLine(message[3]);
        }
        static void CadenasAcceso2(){
            Console.WriteLine("Escribe un mensaje: ");
            string message = Console.ReadLine();
            Console.WriteLine(message[0]);
            Console.WriteLine(message[1]);
            Console.WriteLine(message[2]);
            Console.WriteLine(message[3]);
        }
        static void BuscarCadena(){
            string message = "Hola";
            Console.WriteLine(message.IndexOf("H"));
        }
        static void BuscarCadena2(){
            Console.WriteLine("Escribe un mensaje que contenga una O: ");
            string message = Console.ReadLine();
            Console.WriteLine(message.IndexOf("O"));
        }
        static void CadenaSubString(){
            string menssage = "Esto es una cadena de texto de prueba para el metodo SubString";
            Console.WriteLine(menssage.Substring(5)); 
        }
        static void CadenaSubString2(){
            string message = "Hola mundo";
            int reach = message.IndexOf(" ");
            Console.WriteLine(message.Substring(0, reach));
        }
        static void CaracteresEspeciales(){
            Console.WriteLine(" Buen Dias \" _ \" ");
        }
        static void CaracteresEspeciales2(){
            Console.WriteLine("Hola \nMundo");
        }
        static void CaracteresEspeciales4(){
            Console.WriteLine("H \n o \n l \n a");
        }
        static void CaracteresEspeciales3(){
            Console.WriteLine("\\_O_//");
        }
        static void BoleanNum(){
            Console.WriteLine("Escribe dos numeros y si el primero es mayor, dara true: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a > b);
        }
        static void BoleanNum2(){
            Console.WriteLine("Escribe dos numeros y si son iguales, dara true: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a == b);
        }
        static void If(){
            string password = "Nahida";
            Console.WriteLine("Escribe la contraseña: ");
            string input = Console.ReadLine();
            if(password.ToLower().Equals(input.ToLower())){
                Console.WriteLine("Contraseña correcta");
            }else{
                Console.WriteLine("Contraseña incorrecta");
            }
        }
        static void If2(){
            Console.WriteLine("Escribe su edad: ");
            int e = int.Parse(Console.ReadLine());
            if(e >= 18){
                Console.WriteLine("Eres mayor de edad");
            }else{
                Console.WriteLine("Eres menor de edad");
            }
        }
        static void IfElseIfElse(){
            Console.WriteLine("ejemplo de if, else if y else");
            int num = 10;
            if(num > 10){
                Console.WriteLine("El numero es mayor a 10");
            }else if(num < 10){
                Console.WriteLine("El numero es menor a 10");
            }else{
                Console.WriteLine("El numero es igual a 10");
            }
        }
        static void IfElseIfElse2(){
            Console.WriteLine("Escribe un numero: ");
            int num = int.Parse(Console.ReadLine());
            if(num > 10){
                Console.WriteLine("El numero es mayor a 10");
            }else if(num < 10){
                Console.WriteLine("El numero es menor a 10");
            }else{
                Console.WriteLine("El numero es igual a 10");
            }
        }
        static void IfUltimate(){
            Console.WriteLine("Escribe tu hora militar: ");
            int tiempo = int.Parse(Console.ReadLine());
            string message = (tiempo < 18 ) ? "Buen dia" : "Buena Noche";
            Console.WriteLine(message);
        }
        static void IfUltimate2(){
            Console.WriteLine("Escribe el rol de estudiante y profesor: ");
            string a = Console.ReadLine();
            string message = (a.Equals("profesor")) ? "Hola profesor": "Hola estudiante";
            Console.WriteLine(message);
        }
        static void ActividadSwitch(){
            int verso = 1;

            switch(verso){
                case 1:
                    Console.WriteLine("una flor para otra flor");
                    break;
                case 2:
                    Console.WriteLine("Cada dia te quiero mas");
                    break;
                case 3:
                    Console.WriteLine("Eres la mejor de todas");
                    break;
                default:
                    Console.WriteLine("No hay mas versos");
                    break;
            }
        }
        static void ActividadSwitch2(){
            Console.WriteLine("Escribe un numero del 1 al 5: ");
            int num = int.Parse(Console.ReadLine());

            switch(num){
                case 1:
                    Console.WriteLine("uno");
                    break;
                case 2:
                    Console.WriteLine("dos");
                    break;
                case 3:
                    Console.WriteLine("tres");
                    break;
                case 4:
                    Console.WriteLine("cuatro");
                    break;
                case 5:
                    Console.WriteLine("cinco");
                    break;
                default:
                    Console.WriteLine("no hay mas numeros");
                    break;
            }
        }
    }
}