using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FauxFaux.Domain.Repositories
{
    public class Actions
    {
        protected List<Action> _actions;

        public Action[] All
        {
            get { return _actions.ToArray(); }
        }
    }
}
