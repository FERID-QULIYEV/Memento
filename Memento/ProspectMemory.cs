using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    public class ProspectMemory
    {
        Memento memento;
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
