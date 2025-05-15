using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCajeroporConsola 
{
    internal class Program
    {
        public enum Menu 
        {
            ConsultarSalido=1,DepositarDinero,RetirarDinero,ConsultarHistorialdeDeposito,ConsultarHistorialdeRetiros 
        }
        static Dictionary<int,string>CajeroConsola = new Dictionary<int,string>();
        static void Main(string[] args)
        {
            DateTime fechaactual = DateTime.Now;
                Console.WriteLine("Ingresa el usuario:");
                string usuario = Console.ReadLine();
                Console.WriteLine("Ingresa el pasword:");
                string pasword = Console.ReadLine();
                Console.WriteLine("Ingresa tu fecha de nacimiento:");
                DateTime fechadenacimiento = Convert.ToDateTime(Console.ReadLine());
                int edad = fechaactual.Year - fechadenacimiento.Year;
            int intentos = 3;
            while (intentos <= 3)
            {
                if (usuario == "diego" && pasword == "1234" && edad >= 18) 
                {
                    Console.WriteLine("Ingreso exitoso");
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                }
            }
            
        }
        static  Menu Men() 
        {
            
            Console.WriteLine("1)Consultar saldo actual");
            Console.WriteLine("2)Depositar dinero");
            Console.WriteLine("3)Retirar dinero");
            Console.WriteLine("4)Consultar historial de deposito");
            Console.WriteLine("5)Consultar historial de retiros");
            Console.WriteLine("6)Salir");
            Menu opc =(Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
