// Authored By Kamran Saifullay - The Cyber Frog
// https://linkedin.com/in/KamranSaifullah/
// https://twitter.com/deFr0ggy
// https://github.com/deFr0ggy

using System;
using System.Text;
using System.Windows.Forms;

namespace B64EncoderDecoder
{
    public partial class MainForm : Form
    {

        public string inputData;
        public string outputData;

        public MainForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            inputData = inputForm.Text;
        }

        private void outputForm_TextChanged(object sender, EventArgs e)
        {
            outputData = outputForm.Text;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(inputData) && !string.IsNullOrEmpty(outputData))
            {
                DialogResult emptyForm = MessageBox.Show("Clearing Process", "Data is about to be cleaned?", MessageBoxButtons.YesNo);
                
                if (emptyForm == DialogResult.Yes)
                {
                    inputForm.Clear();
                    outputForm.Clear();
                }
            
            } else if (!string.IsNullOrEmpty(inputData) || !string.IsNullOrEmpty(outputData))
            {

                DialogResult emptyForm = MessageBox.Show("Clearing Process", "Data is about to be cleaned?", MessageBoxButtons.YesNo);

                if (emptyForm == DialogResult.Yes)
                {
                    inputForm.Clear();
                    outputForm.Clear();
                }
            
            } else
            {
                MessageBox.Show("It is already clean!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult exitForm = MessageBox.Show("You surely want to exit?", "Exit the program", MessageBoxButtons.OKCancel);

            if (exitForm == DialogResult.OK)
            {
                Application.Exit();

            }
            else { }
        }

        private void enCoderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputData))
            {
                MessageBox.Show("No data to be encoded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                    try
                {
                    byte[] toBeEncoded = Encoding.UTF8.GetBytes(inputData);
                    string encoded = Convert.ToBase64String(toBeEncoded);
                    outputForm.Text = encoded;
                } catch (FormatException)
                {
                    MessageBox.Show("Data is not valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void deCoderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputData))
            {
                MessageBox.Show("No data to be decoded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    byte[] tobeDecoded = Convert.FromBase64String(inputData);
                    string decoded = Encoding.UTF8.GetString(tobeDecoded);
                    outputForm.Text = decoded;
                } catch (FormatException)
                {
                    MessageBox.Show("Data is not valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
