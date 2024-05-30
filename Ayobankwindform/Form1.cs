namespace Ayobankwindform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "Ayomide")
            {
                tbFirstName.Text = string.Empty;
            }
            else
            {
                tbFirstName.Text = "Ayomide";

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void avgbutton_Click(object sender, EventArgs e)
        {
            TextBox[] B = { TbChemistry, Tbcivic, Tbmath, Tbenglish, Tbphysics, Tbfrench };
            int count = 0, CurrSum = 0;

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i].Text != string.Empty)
                {
                    count++;
                    CurrSum = CurrSum + Convert.ToInt32(B[i].Text);
                }
            }

            Avgtext.Text = (CurrSum / count).ToString();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TbChemistry.Text))
            {

                int val = Convert.ToInt32(TbChemistry.Text);
                TbChemistry.Text = (Convert.ToInt32(TbChemistry.Text) + 1).ToString();
            }
        }

        private void TbChemistry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
