using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLNotas
{
    public class EstudiantesBL 
    {
        public BindingList<Estudiante> ListaEstudiantes { get; set; }

        public EstudiantesBL()
        {
            ListaEstudiantes = new BindingList<Estudiante>();
            var estudiante1 = new Estudiante();
            estudiante1.Id = 1;
            estudiante1.Nombre = "Robert Downey Jr";
            estudiante1.Genero = "masculino";
            estudiante1.Edad = 16;
            estudiante1.Identificacion = 2020 | 2002 | 234;
            estudiante1.Activo = true;

            ListaEstudiantes.Add(estudiante1);


            ListaEstudiantes = new BindingList<Estudiante>();
            var estudiante2 = new Estudiante();
            estudiante2.Id = 2;
            estudiante2.Nombre = "Keanu Reeves";
            estudiante2.Genero = "masculino";
            estudiante2.Edad = 18;
            estudiante2.Identificacion = 2020 | 2001|234;
            estudiante2.Activo = true;

            ListaEstudiantes.Add(estudiante2);
        }

        public BindingList<Estudiante> ObtenerEstudiantes ()
        {
            return ListaEstudiantes;

        }
    }
    public class Estudiante 
    {
        public int Id  { get; set; }
        public string Nombre { get; set; }
        public string Genero      { get; set; }
        public double Edad { get; set; }
        public double  Identificacion { get; set; }
        public bool Activo { get; set; }
      
    } 

    }    

