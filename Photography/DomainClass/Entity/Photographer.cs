using DomainClass.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClass.Entity
{
    public class Photographer : BaseEntityClass
    {
        public string? Name { get; set; }

        // Hacer Validaciones de DNI- solo campos numericos y no mas de 8 caracteres 

        
        public string DNI { get; set; }

        public long PhotoId { get; set; }   

        public long ClientsId   { get; set; }   

        public long EnventId { get; set; }

        public long UserSystemId { get; set; }  

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? QualityPhoto { get; set; }

        public string? SizePhoto { get; set; }

        public long UserRol { get; set; }

        

    }
}
