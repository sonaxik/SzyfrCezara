namespace SzyfrCezara
{
    public partial class Form1 : Form
    {

        private const string Alfabet = "a¹bcædeêfghijkl³mnñoóprsœtuwyzŸ¿";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZaszyfruj_Click(object sender, EventArgs e)
        {
            string tekst = txtWejscie.Text.ToLower();
            if (int.TryParse(txtKlucz.Text, out int klucz))
            {
                if (klucz < 1 || klucz > 31)
                {
                    MessageBox.Show("Klucz musi znajdowaæ siê w przedziale od 1 do 31.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtWynik.Text = SzyfrCezara(tekst, klucz);
                txtWynik.Visible = true;
            }
            else
            {
                MessageBox.Show("Podaj poprawny klucz (liczba ca³kowita).", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdszyfruj_Click(object sender, EventArgs e)
        {
            string tekst = txtWejscie.Text.ToLower();
            if (int.TryParse(txtKlucz.Text, out int klucz))
            {
                if (klucz < 1 || klucz > 31)
                {
                    MessageBox.Show("Klucz musi znajdowaæ siê w przedziale od 1 do 31.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtWynik.Text = SzyfrCezara(tekst, -klucz);
                txtWynik.Visible = true;
            }
            else
            {
                MessageBox.Show("Podaj poprawny klucz (liczba ca³kowita).", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string SzyfrCezara(string tekst, int klucz)
        {
            return new string(tekst.Select(c =>
            {
                int indeks = Alfabet.IndexOf(c);
                if (indeks >= 0)
                {
                    int nowyIndeks = (indeks + klucz) % Alfabet.Length;
                    if (nowyIndeks < 0)
                        nowyIndeks += Alfabet.Length;
                    return Alfabet[nowyIndeks];
                }
                return c;
            }).ToArray());
        }
    }
}
