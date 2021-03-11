﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APIpersona.Models
{
    public class DataContext: DbContext 
    {
        public DataContext():base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<APIpersona.Models.Person> People { get; set; }
    }
}