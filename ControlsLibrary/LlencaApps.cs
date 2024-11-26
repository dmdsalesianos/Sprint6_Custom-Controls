using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsLibrary
{
    public partial class LlencaApps : UserControl
    {
        public LlencaApps()
        {
            InitializeComponent();
            this.Click += new EventHandler(OnControlClick);
            this.panelMain.Click += new EventHandler(OnControlClick);
            this.labelTitle.Click += new EventHandler(OnControlClick);
            this.pictureBoxIcon.Click += new EventHandler(OnControlClick);
        }

        public string Classe { get; set; }
        public string Form { get; set; }
        public string Descripcio
        {
            get => labelTitle.Text;
            set => labelTitle.Text = value;
        }

        private void OnControlClick(object sender, EventArgs e)
        {
            OpenForm();
        }

        private void OpenForm()
        {
            try
            { 
                Assembly ensamblat = Assembly.LoadFrom($@"{Classe}.dll");
                Object dllBD;
                Type tipus;

                tipus = ensamblat.GetType($"{Classe}.{Form}");

                dllBD = Activator.CreateInstance(tipus);
                if (dllBD is Form form)
                {
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None; 
                    form.Dock = DockStyle.Fill;

                    panelMain.Controls.Clear();
                    panelMain.Controls.Add(form);

                    form.Show();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
