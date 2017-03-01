using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReadTagsSync
{
    public partial class FormLeitura : Form
    {
        public FormLeitura()
        {
            InitializeComponent();
        }

        private void FormLeitura_Load(object sender, EventArgs e)
        {
            Program program = new Program();

            program.teste();
        }

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
