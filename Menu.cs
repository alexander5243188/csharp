using ControlIngresoSistema;

namespace MenuSistema
{
    public class Menu
    {
        public void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al sistema de autenticación.");
            Console.WriteLine("1. Ingresar al sistema");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opción: ");
            var opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                //MenuSistema.Menu menuInicio = new MenuSistema.Menu();
                //menuInicio.MostrarMenu();
                case 1:
                    ControlIngresoSistema.IngresarAlSistema ingresarAlSistema = new ControlIngresoSistema.IngresarAlSistema();
                    Console.Clear();
                    ingresarAlSistema.Main();                    
                    break;
                case 2:
                    Console.WriteLine("Saliendo del sistema. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    MostrarMenu();
                    break;
            }
        }
    }
}