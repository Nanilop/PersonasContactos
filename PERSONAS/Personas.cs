using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSONAS
{
    public class Personas
    {
        protected string nombre;
        protected string ApPaterno;
        protected string ApMaterno;
        protected DateTime Nacimiento;

        public string Nombre {

            get { return nombre; }
            set { nombre = value; }
        }
        public string ApellidoPaterno{
    get { return ApPaterno; }
    set{ ApPaterno = value; }}
        public string ApellidoMaterno
        {
            get { return ApMaterno; }
            set { ApMaterno = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return Nacimiento; }
            set { Nacimiento = value;}
        }
        public Personas() {
            nombre = "";
            ApPaterno = "";
            ApMaterno = "";
            Nacimiento= DateTime.Now;
        }
        public Personas(string nombre,string ApPaterno, string ApMaterno)
        {
            this.nombre = nombre;
            this.ApPaterno = ApPaterno;
            this.ApMaterno = ApMaterno; 
            Nacimiento = DateTime.Now;
        }

        public override string ToString()
        {
            return nombre+" "+ApPaterno+" "+ApMaterno+" "+Nacimiento;
        }
        public string RFC() {
            string resultado = "";
            resultado=ApPaterno.Substring(0,1);
            for (int i=1; i<ApPaterno.Length;i++) {
                string vocal= ApPaterno.Substring(i, 1);
                if (vocal == "a" | vocal == "á") {
                    resultado += "A";
                    i = ApPaterno.Length+1;
                } else if (vocal=="e"| vocal == "é") {
                    resultado += "E";
                    i = ApPaterno.Length + 1;
                }
                else if (vocal == "i" | vocal == "í")
                {resultado += "I";
                    i = ApPaterno.Length + 1;
                }
                else if (vocal == "o" | vocal == "ó")
                {resultado += "O";
                    i = ApPaterno.Length + 1;
                }
                else if (vocal == "ú" | vocal == "u"| vocal == "ü")
                {resultado += "U";
                    i = ApPaterno.Length + 1;
                }
            }
            if (String.IsNullOrWhiteSpace(ApMaterno) | String.IsNullOrEmpty(ApMaterno))
            {
                resultado += "X";
            }
            else
            {
                resultado += ApMaterno.Substring(0, 1);
            }
            
            resultado += nombre.Substring(0, 1);
            resultado+= Nacimiento.Year.ToString().Substring(2,2);
            if (Nacimiento.Month<10) {
                resultado += "0";
                resultado += Nacimiento.Month.ToString();
            } else {
                resultado += Nacimiento.Month.ToString();
            }
            if (Nacimiento.Day<10) {
                resultado += "0";
                resultado += Nacimiento.Day.ToString();
            } 
            else { resultado += Nacimiento.Day.ToString(); }
            
            
            return resultado;

        }
    }
}
