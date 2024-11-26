using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsLibrary
{
    public partial class SWCodi : UserControl
    { 
        public enum NivellEnum
        {
            GM,
            GS
        }

        public NivellEnum Nivell { get; set; }
        public bool Requerit { get; set; }

        public SWCodi()
        {
            InitializeComponent();
        }

        public void ValidaCodi()
        {
            if (Requerit && string.IsNullOrWhiteSpace(txtCodi.Text))
            {
                txtCodi.Focus();
            }
            else
            {
                if (Nivell == NivellEnum.GS)
                {
                    if (txtCodi.Text == "S2AM")
                    {
                        txtDesc.Text = "Desenvolupament aplicacions multiplataforma";
                    }
                    else if (txtCodi.Text == "S2SX")
                    {
                        txtDesc.Text = "Administració de sistemes Informàtics en xarxa";
                    }
                    else
                    {
                        MostrarErrorCodi();
                    }
                }
                else if (Nivell == NivellEnum.GM)
                {
                    if (txtCodi.Text == "M2SX")
                    {
                        txtDesc.Text = "Sistemes MicroInformàtics i Xarxes";
                    }
                    else
                    {
                        MostrarErrorCodi();
                    }
                }
            }            
        }

        private void MostrarErrorCodi()
        {
            txtDesc.Text = "Unknown data";
            txtCodi.Clear();
        }

        private void txtCodi_Leave(object sender, EventArgs e)
        {
            ValidaCodi();
        }
    }
}
