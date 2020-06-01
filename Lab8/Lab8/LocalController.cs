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
            Initialize();
            this.view = view as Form1;
            this.view.SearchLocalButtonClick += OnSearchLocal;
            this.view.NewRecreacionButtonClick += OnCheckRecreacion;
            this.view.NewTiendaButtonClick += OnCheckTienda;
            this.view.NewCineButtonClick += OnCheckCine;
            this.view.NewRestaurantButtonClick += OnCheckRestaurant;
            this.view.ShowLocalsClick += OnShowLocals;
        }


        public List<Local> OnShowLocals(object sender, ShowLocalsEventArgs e)
        {
            if (locals.Count() == 0)
            {
                return null;
            }
            else return locals;
        }

        public Local OnSearchLocal(object sender, SearchLocalEventArgs e)
        {
            int count = 0;
            foreach (Local l in locals)
            {
                if (l.Identifier== e.Identifier)
                {
                    count++;
                    return l;
                }
            }
            if (count == 0)
            {
                return null;
            }
            else
            {
                return null;
            }
  
        }

        public bool OnCheckRecreacion(object sender, AddRecreacionEventArgs e)
        {
            int count = 0;
            foreach (Local l in locals)
            {
                if (l.Identifier== e.Identifier)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Recreacional r = new Recreacional(e.OwnerName, e.Identifier, e.AttentionTime);
                locals.Add(r);
                return true;
            }
            else return false;
        }
        public bool OnCheckTienda(object sender, AddTiendaEventArgs e)
        {
            int count = 0;
            foreach (Local l in locals)
            {
                if (l.Identifier == e.Identifier)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Tienda s = new Tienda(e.OwnerName, e.Identifier, e.AttentionTime, e.Categories);
                locals.Add(s);
                return true;
            }
            else return false;
        }
        public bool OnCheckCine(object sender, AddCineEventsArgs e)
        {
            int count = 0;
            foreach (Local l in locals)
            {
                if (l.Identifier == e.Identifier)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Cine c = new Cine(e.OwnerName, e.Identifier, e.AttentionTime, e.Number);
                locals.Add(c);
                return true;
            }
            else return false;
        }
        public bool OnCheckRestaurant(object sender, AddRestaurantEventArgs e)
        {
            int count = 0;
            foreach (Local l in locals)
            {
                if (l.Identifier == e.Identifier)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Restaurante r = new Restaurante(e.OwnerName, e.Identifier, e.AttentionTime, e.ExclusiveTable);
                locals.Add(r);
                return true;
            }
            else return false;
        }
        public void Initialize()
        {
            Restaurante r1 = new Restaurante("Kika", 1, "12:00-19:00", false);
            locals.Add(r1);
            Restaurante r2 = new Restaurante("Juan", 2, "10:00-22:00", true);
            locals.Add(r2);
            Restaurante r3 = new Restaurante("Isabel", 3, "8:00-13:00", false);
            locals.Add(r3);
            Cine c = new Cine("Francisco", 4, "10:00-24:00", 10);
            locals.Add(c);
            List<string> l = new List<string>() { "Juguetes", "Ropa niño" };
            Tienda t1 = new Tienda("José", 5, "10:00-22:00", l);
            locals.Add(t1);
            List<string> a = new List<string>() { "Mujer", "Accesorios" ,"Cosméticos"};
            Tienda t2 = new Tienda("María", 6, "10:00-22:00", a);
            locals.Add(t2);
            List<string> d = new List<string>() { "Comida sana" };
            Tienda t3 = new Tienda("Diego", 7, "10:00-22:00", d);
            locals.Add(t3);
            Recreacional r = new Recreacional("Antonia", 8, "11:00-20:00");
            locals.Add(r);

        }
    }
}
