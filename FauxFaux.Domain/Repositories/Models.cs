using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FauxFaux.Domain.Repositories
{
    public class Models
    {
        protected List<Model> _models;

        public Model[] All
        {
            get { return _models.ToArray(); }
        }

        public Models()
        {
        }
        
        public void Save(Model model)
        {
            throw new NotImplementedException();
        }
    }
}
