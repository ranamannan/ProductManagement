using ProductManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ProductManagement.Domain.Entities
{
    public class Category : AuditableEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
