using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class DTOAlumno
    {
        public int idAlumno { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Nullable<short> edad { get; set; }
        public string documento { get; set; }

        public DTOAlumno(int idAlumno, string nombre, string apellido, short? edad, string documento)
        {
            this.idAlumno = idAlumno;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.documento = documento;
        }
    }
}
