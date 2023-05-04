using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VimeNotifier {
    public partial class Form2: Form {
        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            
        }

        private void ПомощьToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Псевдонимы необходимы, если в чате вас называют не по нику, " +
                "а как-то иначе. И да, регистр не важен...", 
                "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
