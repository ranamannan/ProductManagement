using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Domain.Common
{
    public class AuditableEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }
}
