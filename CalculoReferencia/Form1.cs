using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoReferencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            lb_res.Text = $"Referencia Completa: {Calculate.CompleteReference(tb_reference.Text)}";
            if (!lb_res.Visible)
                lb_res.Visible = true;
        }

        private void tb_reference_TextChanged(object sender, EventArgs e)
        {
            //Validar que el campo solo contenga digitos
            Regex regex = new Regex(@"\D");
            string prev = tb_reference.Text;
            tb_reference.Text = regex.Replace(tb_reference.Text, "");
            if (prev != tb_reference.Text)
                tb_reference.Select(tb_reference.Text.Length, 0);
        }
    }
}
