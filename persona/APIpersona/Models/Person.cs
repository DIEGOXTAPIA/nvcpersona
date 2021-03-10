using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIpersona.Models
{

    public enum SexType
    {
        Femenino=0,
        Masculino=1
    }
    public class Person
    {
        [Key] 
    public int PersonID { get; set; }
        [Required]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "ingresar nombres entre 5 a 250 caracteres")]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        public SexType Sex { get; set; }
    }
}