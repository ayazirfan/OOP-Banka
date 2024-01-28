using OOP_Workshop1501.Entities;

namespace OOP_Workshop1501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //metodlar mutlaka parantez ile kullan�l�r. Parametre al�r ya da almaz.
            MessageBox.Show("Yeni bir mesaj ekledik.", "Bilgilendirme Mesaj�");

            btnKaydet.Text = "G�ncelle"; //set ettim 

            string butonYazisi = btnKaydet.Text; //get ettim
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string accountNumber = Guid.NewGuid().ToString();
            string nameSurname = "Ahmet Aksakal";
            int balance = 500;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string hesapNo = Guid.NewGuid().ToString();
            string adSoyad = "İrfan AYAZ";
            double acilisBakiye = 500.50;
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            //instance (bir s�n�f�n �rne�ini almak)
            Account hesap = new Account();

            hesap.Balance = 500.54;
            hesap.Owner = "İrfan AYAZ";
            hesap.accountNumber = Guid.NewGuid().ToString();
            lstListe.Items.Add($"Hesap Bilgisi: {hesap.Owner} / {hesap.Balance}");
        }
    }
}
