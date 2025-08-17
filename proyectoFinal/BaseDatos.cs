using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class BaseDatos : Form
    {
        public BaseDatos()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            if (this.Controls.Count > 0)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Panel || control is GroupBox)
                    {
                        control.BackColor = Color.White;
                    }
                }
            }
        }
    }
}
