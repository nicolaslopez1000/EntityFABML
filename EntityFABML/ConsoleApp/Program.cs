using BusinessLogic;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            DTOAlumno alumno = null;

            HAlumno ha = new HAlumno();

            ha.AddAlumno("Pedro", "Vazques", "78978", 22);

            alumno = ha.getAlumnoByDocument("28947541");




        }
    }
}
