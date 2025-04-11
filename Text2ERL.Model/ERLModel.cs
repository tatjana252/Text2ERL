using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text2ERL.Model.Constraints;
using Text2ERL.Model.Entities;

namespace Text2ERL.Model
{
    public class ERLModel
    {
        public List<Entity> Entities { get; set; }
        public List<Relation> Relationships { get; set; }
        public List<Constraint> Constraints { get; set; }

        public bool IsValid()
        {
            return true;
        }
    }
}
