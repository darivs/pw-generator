using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class ePassGen : Form
    {
        public ePassGen()
        {
            InitializeComponent();
        }

        private void bt_gen_Click(object sender, EventArgs e)
        {
            try
            {
                string pw = CreatePassword(Convert.ToInt32(tB_length.Text));
                lB.Items.Add(pw);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a correct length.");
            }
            
        }

        public string CreatePassword(int length)
        {
            string valid = "abcdefghijklmnopqrstuvwxyz";

            if (cB_nums.Checked)
                valid += "1234567890";

            if (cB_cc.Checked)
                valid += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (cB_scs.Checked)
                valid += "!$%&/\\=()[]{}#+*-_.,";

            StringBuilder res = new StringBuilder();

            Random rnd = new Random();

            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void bt_copy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(lB.SelectedItem.ToString());
                MessageBox.Show("Password copied to clipboard.");
            }
            catch (Exception)
            {
                MessageBox.Show("There is no item selected.");
            }                
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            lB.Items.Clear();
        }
    }
}
