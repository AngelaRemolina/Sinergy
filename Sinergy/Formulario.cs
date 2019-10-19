using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entorno_visual
{
    class Formulario
    {
        private String name;
        private String email;
        private String adress;
        private String keyInfo;
        private String country;
        private String rights;
        private String transfer;
        private String distributor;
        private String genre;
        private String appliedbefore;

        public Formulario() { }
        public Formulario(String name, String email, String adress, 
            String keyInfo, String country, String rights, String transfer,
            String distributor, String genre, String appliedbefore)
        {
            this.name = name;
            this.email = email;
            this.adress = adress;
            this.keyInfo = keyInfo;
            this.country = country;
            this.rights = rights;
            this.transfer = transfer;
            this.distributor = distributor;
            this.genre = genre;
            this.appliedbefore = appliedbefore;
        }

        // public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}", name, email, adress, keyInfo, country, rights, transfer, distributor, genre, appliedbefore);
        }

        //Hello
    }
}