namespace Eichenwurz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool boolszenario = false;

        private void textBoxSzenario_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdWeiter_Click(object sender, EventArgs e)
        {
            if(boolszenario == false)
            {

                textBoxSzenario.Text = "Geschichte2";
                CmdWeiter.Hide();
            }
            else
            {
                textBoxSzenario.Text = "Szenario2";
            }

        }

        private void CmdEntscheidung_Click(object sender, EventArgs e)
        {
            if(Auswahl1.Checked)
            {
                textBoxSzenario.Text = "Bla1";
                
            }
            else if (Auswahl2.Checked)
            {
                textBoxSzenario.Text = "Bla2";
            }
            else if(Auswahl3.Checked)
            {
                textBoxSzenario.Text = "Bla3";
            }
            else
            {
                MessageBox.Show("Bitte treffe eine Entscheidung");
            }
            CmdEntscheidung.Hide();
            CmdWeiter.Show();
            boolszenario = true;
        }

        
        
        
        
    }

    
}