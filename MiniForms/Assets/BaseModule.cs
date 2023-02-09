using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniForms.Assets
{
    public abstract class BaseModule
    {
        // Propperties
        public string Name;
        public Form Form;

        public abstract bool Execute();

        public abstract void EditForm();

        
    }
}
