using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Locals : Form
    {
        List<Local> locales = new List<Local>();

        public List<Local> Locales { get => locales; set => locales = value; }

        public Locals(List<Local> locales)
        {
            InitializeComponent();
            this.locales = locales;
            AllPanel.Visible = true;
            AllPanel.Dock = System.Windows.Forms.DockStyle.Fill;

        }

        private void Locals_Load(object sender, EventArgs e)
        {
            if (locales == null)
            {
                AllTextBox.AppendText("No existen locales en la base de datos" + Environment.NewLine);
            }
            else
            {
                foreach (Local l in locales)
                {
                    string k = "";
                    k += "IDENTIFICADOR: " + l.Identifier.ToString() + ". TIPO: " + l.Type +". DUEÑO: "+ l.OwnerName;
                    AllTextBox.AppendText(k+Environment.NewLine);
                }

            }

        }
    }
}
