﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class User {

        //La verdad para esto hay que estar viendo el como 
        //esta implementado el usuario en la base de datos

        //Entonces de esto por ahora no puedo hacer nada
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public DateTime fechaRegistro { get; set; }
        public string estado { get; set; }
    }
}
