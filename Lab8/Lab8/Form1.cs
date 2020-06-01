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
        public delegate Local SearchLocalEventHandler(object source, SearchLocalEventArgs args);
        public event SearchLocalEventHandler SearchLocalButtonClick;

        private void OnSearchLocal(int identifier)
        {
            if (SearchLocalButtonClick != null)
            {
                Local result = SearchLocalButtonClick(this, new SearchLocalEventArgs() { Identifier = identifier });
                if (result==null)
                {
                    NoLocalLabel.Visible = true;
                }
                else
                {
                    textBox7.Text = result.OwnerName;
                    textBox7.BackColor = System.Drawing.Color.White;
                    textBox5.Text = result.AttentionTime;
                    textBox5.BackColor = System.Drawing.Color.White;
                    textBox11.Visible = true;
                    textBox11.Text = result.Type;
                    if (result.Type == "Tienda")
                    {
                        textBox1.BackColor = System.Drawing.Color.White;
                        textBox1.Visible = true;
                        textBox3.Text = "CATEGORIAS";
                        textBox3.Visible = true;
                        string otro="";
                        int count = 1;
                        foreach (string s in result.Other)
                        {
                            otro +=count.ToString()+": "+ s + ". ";
                            count++;
                        }

                        textBox1.Text = otro;
                    }
                    else if (result.Type == "Cine")
                    {
                        textBox1.BackColor = System.Drawing.Color.White;
                        textBox3.Text = "NÚMERO SALAS";
                        textBox1.Visible = true;
                        textBox3.Visible = true;
                        textBox1.Text = result.Other.ToString();
                    }
                    else if (result.Type == "Restaurante")
                    {
                        textBox1.BackColor = System.Drawing.Color.White;
                        textBox3.Text = "MESAS EXCLUSIVAS";
                        textBox3.Visible = true;
                        textBox1.Visible = true;
                        if (result.Other == true)
                        {
                            textBox1.Text = "SI";
                        }
                        else
                        {
                            textBox1.Text = "NO";
                        }
                        
                    }
                }
            }
        }


        public delegate bool AddRecreacionEventHandler(object source, AddRecreacionEventArgs args);
        public event AddRecreacionEventHandler NewRecreacionButtonClick;

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
                    AddPanel.Visible = false;
                    InitialPanel.Visible = true;
                }
            }
        }

        public delegate bool AddTiendaEventHandler(object source, AddTiendaEventArgs args);
        public event AddTiendaEventHandler NewTiendaButtonClick;

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
                    AddPanel.Visible = false;
                    InitialPanel.Visible = true;
                }
            }
        }

        public delegate bool AddCineEventHandler(object source, AddCineEventsArgs args);
        public event AddCineEventHandler NewCineButtonClick;

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
                    AddPanel.Visible = false;
                    InitialPanel.Visible = true;
                }
            }
        }

        public delegate bool AddRestaurantEventHandler(object source, AddRestaurantEventArgs args);
        public event AddRestaurantEventHandler NewRestaurantButtonClick;

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
            TiendaButton.Tag = "no";
            RecreacionalButton.Tag = "no";
            CineButton.Tag = "no";
            RestaurantButton.Tag = "no";
            OtroTextBoxTitle.Visible = false;
            CAddTextBox.Visible = false;
            AddPanel.Visible = true;
            AlreadyLabel.Visible = false;
            WrongFormatLabel.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }


        private void ViewInformationButton_Click(object sender, EventArgs e)
        {
            NoLocalLabel.Visible = false;
            WFL2.Visible = false;
            textBox11.Visible = false;
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
            AlreadyLabel.Visible = false;
            WrongFormatLabel.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
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
            AlreadyLabel.Visible = false;
            WrongFormatLabel.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
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
            AlreadyLabel.Visible = false;
            WrongFormatLabel.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
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
                OtroTextBoxTitle.Text = "NÚMERO SALAS";
                OtroTextBoxTitle.Visible = true;
                CAddTextBox.Text = "N°";
                CAddTextBox.Visible = true;
            }
        }

        private void OptionResButton_Click(object sender, EventArgs e)
        {
            AlreadyLabel.Visible = false;
            WrongFormatLabel.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
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

        public delegate List<Local> ShowLocalsEventHandler(object source, ShowLocalsEventArgs args);
        public event ShowLocalsEventHandler ShowLocalsClick;
        private List<Local>  OnShowLocals()
        {
            if (ShowLocalsClick != null)
            {
                List<Local> result = ShowLocalsClick(this, new ShowLocalsEventArgs() { });
                return result;
            }
            else
            {
                return null;
            }

        }
        private void AllLocalsButton_Click(object sender, EventArgs e)
        {
            List<Local> locals = OnShowLocals();
            Locals f2 = new Locals(locals);
            f2.ShowDialog();            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            string name = NAddTextBox.Text;
            bool numcheck;
            numcheck = int.TryParse(IAddTextBox.Text, out int identificaction);
            string horario = HAddTextBox.Text;
            AlreadyLabel.Visible = false;
            WrongFormatLabel.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            if (TiendaButton.Tag.ToString() == "si")
            {
                List<string> otros = CAddTextBox.Text.Split(',').ToList();
                if ((!numcheck || identificaction<1) && IAddTextBox.Text!="")
                {
                    WrongFormatLabel.Visible = true;
                }
                if (String.IsNullOrEmpty(name) || IAddTextBox.Text == "" || String.IsNullOrEmpty(horario) || String.IsNullOrEmpty(otros.ToString())||CAddTextBox.Text== "Categoría 1, categoría 2, etc." || HAddTextBox.Text== "Ej. 12.00-19.00")
                {
                    label1.Visible = true;
                }
                else if (numcheck && identificaction >=1) 
                {
                    OnCheckTienda(name, horario, identificaction, otros);
                    
                }

            }
            else if(CineButton.Tag.ToString() == "si")
            {
                bool numcheck2 = int.TryParse(CAddTextBox.Text, out int otros);
                if ((!numcheck2 || !numcheck || identificaction < 1  || otros <1) && IAddTextBox.Text != "" &&  CAddTextBox.Text != "")
                {
                    WrongFormatLabel.Visible = true;
                }
                if (String.IsNullOrEmpty(name) ||   IAddTextBox.Text == "" || String.IsNullOrEmpty(horario) || CAddTextBox.Text == "" || CAddTextBox.Text == "N°" || HAddTextBox.Text == "Ej. 12.00-19.00")
                {
                    label1.Visible = true;
                }
                else if (numcheck && numcheck2 &&identificaction>=1 && otros>=1) 
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
                else if (CAddTextBox.Text != "" && CAddTextBox.Text != "NO / SI")
                {
                    WrongFormatLabel.Visible = true;
                }
                if ((!numcheck || identificaction < 1) && IAddTextBox.Text != "")
                {
                    WrongFormatLabel.Visible = true;
                }
                if (String.IsNullOrEmpty(name) ||  IAddTextBox.Text == "" || String.IsNullOrEmpty(horario) || CAddTextBox.Text == "" ||CAddTextBox.Text == "NO / SI" || HAddTextBox.Text == "Ej. 12.00-19.00")
                {
                    label1.Visible = true;
                }
                else if (numcheck &&identificaction>=1 &&(CAddTextBox.Text == "SI" || CAddTextBox.Text == "NO"))
                {
                    OnCheckRestaurant(name, horario, identificaction, eleccion);
                }

            }
            else if (RecreacionalButton.Tag.ToString() == "si")
            {
                if ((!numcheck || identificaction < 1) && IAddTextBox.Text != "")
                {
                    WrongFormatLabel.Visible = true;
                }
                if (String.IsNullOrEmpty(name) ||  IAddTextBox.Text == "" || String.IsNullOrEmpty(horario) ||HAddTextBox.Text == "Ej. 12.00-19.00")
                {
                    label1.Visible = true;
                }
                else if (numcheck&&identificaction>=1)
                {
                    OnCheckRecreacion(name, horario, identificaction);
                }
            }
            else
            {
                label2.Visible = true;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool numcheck;
            numcheck = int.TryParse(textBox9.Text, out int identificaction);
            if (!numcheck || identificaction < 1)
            {
                WFL2.Visible = true;
            }
            else if (numcheck &&identificaction>=1)
            {
                OnSearchLocal(identificaction);
            }

        }


    }
}
