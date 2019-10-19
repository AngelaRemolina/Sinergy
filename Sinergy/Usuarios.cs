using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entorno_visual
{
    class Usuarios
    {

        private String name;
        private String password;

        public Usuarios() { }
        public Usuarios(string name, string password)
        {
            this.name = name;
            this.password = password;

        }

        public String Name { get { return this.name; } set { this.name = value; } }
        public String Password { get { return this.password; } set { this.password = value; } }
        public override string ToString()
        {
            return string.Format("{0};{1}", name, password);
        }
    }
}
