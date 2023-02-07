class Program
{
   static void Main(string[] args)
   {
      // Registrar la calificacion de n alumnos e imprimir en pantalla el alumno con peor promedio y el mejor promedio
      int numAlumnos;
      double promedioMin = 10, promedioMax = 0;
      string alumTonto = "", alumGenio = "";

      Console.Write("Ingresa la cantidad de alumnos: ");
      numAlumnos = Convert.ToInt32(Console.ReadLine());

      string[,] calificacionesYNombres = new string[numAlumnos, 2];
      string pedirNombreCalif = "  Nombre: ";

      for (int i = 0; i < numAlumnos; i++)
      {
         Console.WriteLine("Estudiante {0}:", i + 1);

         for (int j = 0; j < 2; j++) // Pedir nombres y calificaciones
         {
            if (j == 1) pedirNombreCalif = "  Calificacion: ";
            Console.Write(pedirNombreCalif);
            calificacionesYNombres[i, j] = Console.ReadLine();
         }

         double calificaciones = Convert.ToDouble(calificacionesYNombres[i, 1]); // Acceder, convertir y trabajar solo con las calificaciones para obtener promedio peor y mejor

         if (calificaciones < promedioMin) // Obtener la calificacion menor
         {
            promedioMin = calificaciones;
            alumTonto = calificacionesYNombres[i, 0];
         }
         if (calificaciones > promedioMax)
         {
            promedioMax = calificaciones;
            alumGenio = calificacionesYNombres[i, 0];
         }

         pedirNombreCalif = "  Nombre: ";
         Console.WriteLine("\n");
      } // Fin  For


      // ********  ==> Codigo mejor en linea 27 ********* ==>
      //for (int i = 0; i < numAlumnos; i++) // Acceder a las calificaciones
      //{
      //   for (int j = 1; j < 2; j++)
      //   {
      //      double calificaciones = Convert.ToDouble(calificacionesYNombres[i, j]);

      //      if (calificaciones < promedioMin) // Obtener la calificacion menor
      //      {
      //         promedioMin = calificaciones;
      //      }
      //      if (calificaciones > promedioMax)
      //         promedioMax = calificaciones;
      //   }
      //}
      //Console.WriteLine("\nPromedio minino: " + promedioMin + "\nPromedio mejor: " + promedioMax);
      Console.WriteLine($"\nEl alumno con peor promedio es: {alumTonto}");
      Console.WriteLine($"El alumno con mejor promedio es: {alumGenio}");
   }
}
