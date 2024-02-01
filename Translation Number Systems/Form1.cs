using ClassLibrary_Translation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translation_Number_Systems;

namespace Translation_Number_Systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_translate_Click(object sender, EventArgs e)
        {
            int inputSystem = 0;
            int inputSystemTo = 0;

            if (!int.TryParse(input_number_system.Text, out inputSystem))
            {
                MessageBox.Show("В поле \"Его система счисления\" должно быть число", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (!int.TryParse(to_number_system.Text, out inputSystemTo))
            {
                MessageBox.Show("В поле \"Нужная система счисления\" должно быть число", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            NumberTraslate num = new NumberTraslate(int.Parse(input_number_system.Text), input_number.Text);
            num.translateToSystem(int.Parse(to_number_system.Text));
            MessageBox.Show(num.Number);
        }

        private void input_number_system_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
