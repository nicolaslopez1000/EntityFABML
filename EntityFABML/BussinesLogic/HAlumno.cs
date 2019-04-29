using ClassLibrary1;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class HAlumno
    {
        public void AddAlumno(string nombre, string apellido, string documento, short? edad)
        {
            using (bddLiceoEntities context = new bddLiceoEntities())
            {

                Alumnos nuevoAlumno = new Alumnos();
                nuevoAlumno.nombre = nombre;
                nuevoAlumno.apellido = apellido;
                nuevoAlumno.edad = edad;
                nuevoAlumno.documento = documento;

                context.Alumnos.Add(nuevoAlumno);
                context.SaveChanges();



            }

        }

        public DTOAlumno getAlumnoByDocument(string documento)
        {
            Alumnos alumnodB = null;
            
            using (bddLiceoEntities context = new bddLiceoEntities())
            {
                alumnodB = context.Alumnos.Include("Materias").FirstOrDefault(f => f.documento == documento);
                DTOAlumno alumno =  new DTOAlumno(alumnodB.idAlumno, alumnodB.nombre, alumnodB.apellido, alumnodB.edad, alumnodB.documento);
                return alumno;
            }



        }
    }
}
