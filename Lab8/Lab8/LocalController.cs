using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab8
{
    class LocalController
    {
        List<Local> locals = new List<Local>();
        

        Form1 view;

        public LocalController(Form view)
        {
            initialize();
            this.view = view as Form1;
        }

        public void initialize()
        {
        }
    }
}
