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
    public partial class Form1 : Form
    {
        public delegate bool SearchLocalEventHandler(object source, SearchLocalEventArgs args);
        public event SearchLocalEventHandler SearchLocalButtonClick;
        public event EventHandler<SearchLocalEventArgs> SearchLocal;

        private void OnSearchLocal(int identifier)
        {
            if (SearchLocalButtonClick != null)
            {
                bool result = SearchLocalButtonClick(this, new SearchLocalEventArgs() { Identifier = identifier });
                if (!result)
                {
                    NoLocalLabel.Visible = true;
                }
                else
                {
                    //Muestro cosas encontradas
                }
            }
        }


        public delegate bool AddRecreacionEventHandler(object source, AddRecreacionEventArgs args);
        public event AddRecreacionEventHandler NewRecreacionButtonClick;
        public event EventHandler<AddRecreacionEventArgs> AddRecreacion;

        private void OnCheckRecreacion(string ownerName, string attentionTime, int identifier)
        {
            if (NewRecreacionButtonClick != null)
            {
                bool result = NewRecreacionButtonClick(this, new AddRecreacionEventArgs() { OwnerName = ownerName, AttentionTime = attentionTime, Identifier = identifier });
                if (!result)
                {
                    AlreadyLabel.Visible = true;
                }
                else
                {
                    //Agregar recreación a la lista de locales
                    AddPanel.Visible = false;
                    InitialPanel.Visible = true;
                }
            }
        }

        public delegate bool AddTiendaEventHandler(object source, AddTiendaEventArgs args);
        public event AddTiendaEventHandler NewTiendaButtonClick;
        public event EventHandler<AddTiendaEventArgs> AddTienda;

        private void OnCheckTienda(string ownerName, string attentionTime, int identifier, List<string> categories)
        {
            if (NewTiendaButtonClick != null)
            {
                bool result = NewTiendaButtonClick(this, new AddTiendaEventArgs() { OwnerName = ownerName, AttentionTime = attentionTime, Identifier = identifier, Categories = categories });
                if (!result)
                {
                    AlreadyLabel.Visible = true;
                }
                else
                {
                    //Agregar tienda a la lista de locales
                    AddPanel.Visible = false;
                    InitialPanel.Visible = true;
                }
            }
        }

        public delegate bool AddCineEventHandler(object source, AddCineEventsArgs args);
        public event AddCineEventHandler NewCineButtonClick;
        public event EventHandler<AddCineEventsArgs> AddCine;

        private void OnCheckCine(string ownerName, string attentionTime, int identifier, int number)
        {
            if (NewCineButtonClick != null)
            {
                bool result = NewCineButtonClick(this, new AddCineEventsArgs() { OwnerName = ownerName, AttentionTime = attentionTime, Identifier = identifier, Number = number });
                if (!result)
                {
                    AlreadyLabel.Visible = true;
                }
                else
                {
                    //Agregar cine a la lista de locales
                    AddPanel.Visible = false;
                    InitialPanel.Visible = true;
                }
            }
        }

        public delegate bool AddRestaurantEventHandler(object source, AddRestaurantEventArgs args);
        public event AddRestaurantEventHandler NewRestaurantButtonClick;
        public event EventHandler<AddRestaurantEventArgs> AddRestaurant;

        private void OnCheckRestaurant(string ownerName, string attentionTime, int identifier, bool exclusiveTable)
        {
            if (NewRestaurantButtonClick != null)
            {
                bool result = NewRestaurantButtonClick(this, new AddRestaurantEventArgs() { OwnerName = ownerName, AttentionTime = attentionTime, Identifier = identifier, ExclusiveTable = exclusiveTable });
                if (!result)
                {
                    AlreadyLabel.Visible = true;
                }
                else
                {
                    //Agregar cine a la lista de locales
                    AddPanel.Visible = false;
                    InitialPanel.Visible = true;
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
            InitialPanel.Dock= System.Windows.Forms.DockStyle.Fill;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            SearchPanel.Visible = false;
            InitialPanel.Visible = true;

        }

        private void ChangeTextBox_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textbox = (System.Windows.Forms.TextBox)sender;
            textbox.BackColor = System.Drawing.Color.White;

            if (textbox.Text == "Ej. 12.00-19.00" || textbox.Text == "Categoría 1, categoría 2, etc." || textbox.Text=="N°" || textbox.Text== "NO / SI")
            {
                textbox.Clear();
            }
        }

        public void NewLocalButton_Click(object sender, EventArgs e)
        {
            InitialPanel.Visible = false;
            AddPanel.Dock= System.Windows.Forms.DockStyle.Fill;
            NAddTextBox.BackColor= System.Drawing.Color.Silver;
            NAddTextBox.Text = "";
            IAddTextBox.BackColor = System.Drawing.Color.Silver;
            IAddTextBox.Text = "";
            HAddTextBox.BackColor = System.Drawing.Color.Silver;
            HAddTextBox.Text = "Ej. 12.00-19.00";
            CAddTextBox.BackColor = System.Drawing.Color.Silver;
            AddPanel.Visible = true;
        }


        private void ViewInformationButton_Click(object sender, EventArgs e)
        {
            InitialPanel.Visible = false;
            SearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox1.BackColor = System.Drawing.Color.Silver;
            textBox1.Text = "";
            textBox5.BackColor = System.Drawing.Color.Silver;
            textBox5.Text = "";
            textBox7.BackColor = System.Drawing.Color.Silver;
            textBox7.Text = "";
            textBox9.BackColor = System.Drawing.Color.Silver;
            textBox9.Text = "";
            SearchPanel.Visible = true;
        }

        private void OptionTButton_Click(object sender, EventArgs e)
        {
            if (TiendaButton.Tag.ToString() == "no")
            {
                NAddTextBox.BackColor = System.Drawing.Color.Silver;
                NAddTextBox.Text = "";
                IAddTextBox.BackColor = System.Drawing.Color.Silver;
                IAddTextBox.Text = "";
                HAddTextBox.BackColor = System.Drawing.Color.Silver;
                HAddTextBox.Text = "Ej. 12.00-19.00";
                CAddTextBox.BackColor = System.Drawing.Color.Silver;
                TiendaButton.Tag = "si";
                RecreacionalButton.Tag = "no";
                CineButton.Tag = "no";
                RestaurantButton.Tag = "no";
                OtroTextBoxTitle.Text = "CATEGORIAS";
                OtroTextBoxTitle.Visible = true;
                CAddTextBox.Text = "Categoría 1, categoría 2, etc.";
                CAddTextBox.Visible = true;
            }
        }

        private void OptionRButton_Click(object sender, EventArgs e)
        {
            if (RecreacionalButton.Tag.ToString() == "no")
            {
                NAddTextBox.BackColor = System.Drawing.Color.Silver;
                NAddTextBox.Text = "";
                IAddTextBox.BackColor = System.Drawing.Color.Silver;
                IAddTextBox.Text = "";
                HAddTextBox.BackColor = System.Drawing.Color.Silver;
                HAddTextBox.Text = "Ej. 12.00-19.00";
                CAddTextBox.BackColor = System.Drawing.Color.Silver;
                TiendaButton.Tag = "no";
                RecreacionalButton.Tag = "si";
                CineButton.Tag = "no";
                RestaurantButton.Tag = "no";
                OtroTextBoxTitle.Visible = false;
                CAddTextBox.Visible = false;
            }
        }

        private void OptionCButton_Click(object sender, EventArgs e)
        {
            if (CineButton.Tag.ToString() == "no")
            {
                NAddTextBox.BackColor = System.Drawing.Color.Silver;
                NAddTextBox.Text = "";
                IAddTextBox.BackColor = System.Drawing.Color.Silver;
                IAddTextBox.Text = "";
                HAddTextBox.BackColor = System.Drawing.Color.Silver;
                HAddTextBox.Text = "Ej. 12.00-19.00";
                CAddTextBox.BackColor = System.Drawing.Color.Silver;
                TiendaButton.Tag = "no";
                RecreacionalButton.Tag = "no";
                CineButton.Tag = "si";
                RestaurantButton.Tag = "no";
                OtroTextBoxTitle.Text = "SALAS";
                OtroTextBoxTitle.Visible = true;
                CAddTextBox.Text = "N°";
                CAddTextBox.Visible = true;
            }
        }

        private void OptionResButton_Click(object sender, EventArgs e)
        {
            if (RestaurantButton.Tag.ToString() == "no")
            {
                NAddTextBox.BackColor = System.Drawing.Color.Silver;
                NAddTextBox.Text = "";
                IAddTextBox.BackColor = System.Drawing.Color.Silver;
                IAddTextBox.Text = "";
                HAddTextBox.BackColor = System.Drawing.Color.Silver;
                HAddTextBox.Text = "Ej. 12.00-19.00";
                CAddTextBox.BackColor = System.Drawing.Color.Silver;
                TiendaButton.Tag = "no";
                RecreacionalButton.Tag = "no";
                CineButton.Tag = "no";
                RestaurantButton.Tag = "si";
                OtroTextBoxTitle.Text = "MESAS EXCLUSIVAS";
                OtroTextBoxTitle.Visible = true;
                CAddTextBox.Text = "NO / SI";
                CAddTextBox.Visible = true;
            }
        }

        private void AllLocalsButton_Click(object sender, EventArgs e)
        {
            Locals f2 = new Locals();
            f2.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = NAddTextBox.Text;
            bool numcheck;
            int identificaction;
            numcheck = int.TryParse(IAddTextBox.Text, out identificaction);
            string horario = HAddTextBox.Text;
            AlreadyLabel.Visible = false;
            WrongFormatLabel.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            if (TiendaButton.Tag.ToString() == "si")
            {
                List<string> otros = CAddTextBox.Text.Split(',').ToList();
                
                if (!numcheck)
                {
                    WrongFormatLabel.Visible = true;
                }
                if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(identificaction.ToString()) || String.IsNullOrEmpty(horario) || String.IsNullOrEmpty(otros.ToString())||CAddTextBox.Text== "Categoría 1, categoría 2, etc." || HAddTextBox.Text== "Ej. 12.00-19.00")
                {
                    label1.Visible = true;
                }
                else if (numcheck) 
                {
                    OnCheckTienda(name, horario, identificaction, otros);
                    
                }

            }
            else if(CineButton.Tag.ToString() == "si")
            {
                int otros;
                bool numcheck2 = int.TryParse(CAddTextBox.Text, out otros);
                if (!numcheck2 || !numcheck)
                {
                    WrongFormatLabel.Visible = true;
                }
                if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(identificaction.ToString()) || String.IsNullOrEmpty(horario) || String.IsNullOrEmpty(otros.ToString()) || CAddTextBox.Text == "N°" || HAddTextBox.Text == "Ej. 12.00-19.00")
                {
                    label1.Visible = true;
                }
                else if (numcheck && numcheck2) 
                {
                    OnCheckCine(name, horario, identificaction, otros);
                }

            }
            else if (RestaurantButton.Tag.ToString() == "si")
            {
                bool eleccion = false;
                if (CAddTextBox.Text == "SI")
                {
                    eleccion = true;
                }
                else if (CAddTextBox.Text == "NO")
                {
                    eleccion = false;
                }
                else
                {
                    WrongFormatLabel.Visible = true;
                }
                if (!numcheck)
                {
                    WrongFormatLabel.Visible = true;
                }
                if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(identificaction.ToString()) || String.IsNullOrEmpty(horario) ||(CAddTextBox.Text != "SI" && CAddTextBox.Text != "NO") || CAddTextBox.Text == "NO / SI" || HAddTextBox.Text == "Ej. 12.00-19.00")
                {
                    label1.Visible = true;
                }
                else if (numcheck) //AGregar que revise que no exista
                {
                    OnCheckRestaurant(name, horario, identificaction, eleccion);
                }

            }
            else if (RecreacionalButton.Tag.ToString() == "si")
            {
                if (!numcheck)
                {
                    WrongFormatLabel.Visible = true;
                }
                if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(identificaction.ToString()) || String.IsNullOrEmpty(horario) ||HAddTextBox.Text == "Ej. 12.00-19.00")
                {
                    label1.Visible = true;
                }
                else if (numcheck) //AGregar que revise que no exista
                {
                    OnCheckRecreacion(name, horario, identificaction);
                }
            }
            else
            {
                label2.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int identificaction;
            bool numcheck;
            numcheck = int.TryParse(IAddTextBox.Text, out identificaction);
            if (!numcheck)
            {
                WFL2.Visible = true;
            }
            else if (numcheck)
            {
                OnSearchLocal(identificaction);
            }

        }
    }
}
