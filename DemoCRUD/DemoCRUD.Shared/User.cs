﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCRUD.Shared
{
    public class User
    {
        public int Id { get; set; }
        public string Nombre{ get; set; } = string.Empty;
        public string Correo{ get; set; } = string.Empty;
    }
}
