using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSONAS
{
    public class Contacto : Personas
    {
        private string telefono;
        private string email;

        public string Telefono {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Email {
            get { return email; }
            set { email = value; }
        }
        public Contacto() {
            telefono = "";
            email = "";
            ApPaterno = "";
            ApMaterno = "";
            nombre = "";
            Nacimiento = DateTime.Now;
        }
        public Contacto(string telefono, string email, string nombre, string ApellidoPaterno, string ApellidoMaterno, DateTime FechaNacimiento)
        {
            this.telefono = telefono;
            this.email = email;
            this.nombre = nombre;
            this.ApMaterno = ApellidoMaterno;
            this.ApPaterno = ApellidoPaterno;
            this.Nacimiento = FechaNacimiento;
        }
        public string toString(){
            return nombre + " "+ApPaterno+" "+ApMaterno+" "+Nacimiento+","+telefono+", "+email;
}
    }
}
