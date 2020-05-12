using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackingERP
{
    public partial class Giris : Form
    {
        public Anasayfa FrmAnasayfa;
        public SistemYonetimi FrmSistemYonetimi;
        public KullanıcıEkleGuncelle FrmKullanıcıEkleGuncelle;
        public GenelKodBilgileri FrmGenelKodBilgileri;
        public UlkeEkleGuncelle FrmUlkeEkleGuncelle;
        public İlEkleGuncelle FrmİlEkleGuncelle;
        public İlceEkleGuncelle FrmİlceEkleGuncelle;
        public MusteriYonetimi FrmMusteriYonetimi;
        public MusteriEkleGuncelle FrmMusteriEkleGuncelle;
        public UrunTipEkleGuncelle FrmUrunTipEkleGuncelle;
        public UrunYonetimi FrmUrunYonetimi;
        public UrunEkleGuncelle FrmUrunEkleGuncelle;
        public DepoYonetimi FrmDepoYonetimi;
        public DepoEkleGuncelle FrmDepoEkleGuncelle;
        public StokYonetimi FrmStokYonetimi;
        public HareketYonetimi FrmHareketYonetimi;
        public HareketEkleGuncelle FrmHareketEkleGuncelle;
        public UrunlerList FrmUrunList;
        public FaturaYonetimi FrmFaturaYonetimi;
        public FaturaOlustur FrmFaturaOlustur;
        public MusterilerList FrmMusterilerList;
        public FaturaUrunEkle FrmFaturaUrunEkle;
        public FaturaUrunList FrmFaturaUrunList;
        public CariHesapYonetimi FrmCariHesapYonetimi;
        public CariHesapFisEkle FrmCariHesapFisEkle;
        public GenelMuhasebeYonetimi FrmGenelMuhasebeYonetimi;
        public MuhasebeFisEkle FrmMuhasebeFisEkle;
   
        public Giris()
        {
            FrmAnasayfa = new Anasayfa();
            FrmSistemYonetimi = new SistemYonetimi();
            FrmKullanıcıEkleGuncelle = new KullanıcıEkleGuncelle();
            FrmGenelKodBilgileri = new GenelKodBilgileri();
            FrmUlkeEkleGuncelle = new UlkeEkleGuncelle();
            FrmİlEkleGuncelle = new İlEkleGuncelle();
            FrmİlceEkleGuncelle = new İlceEkleGuncelle();
            FrmMusteriYonetimi = new MusteriYonetimi();
            FrmMusteriEkleGuncelle = new MusteriEkleGuncelle();
            FrmUrunTipEkleGuncelle = new UrunTipEkleGuncelle();
            FrmUrunYonetimi = new UrunYonetimi();
            FrmUrunEkleGuncelle = new UrunEkleGuncelle();
            FrmDepoYonetimi = new DepoYonetimi();
            FrmDepoEkleGuncelle = new DepoEkleGuncelle();
            FrmStokYonetimi = new StokYonetimi();
            FrmHareketYonetimi = new HareketYonetimi();
            FrmHareketEkleGuncelle = new HareketEkleGuncelle();
            FrmFaturaYonetimi = new FaturaYonetimi();
            FrmUrunList = new UrunlerList();
            FrmFaturaOlustur = new FaturaOlustur();
            FrmMusterilerList = new MusterilerList();
            FrmFaturaUrunEkle = new FaturaUrunEkle();
            FrmFaturaUrunList = new FaturaUrunList();
            FrmCariHesapYonetimi = new CariHesapYonetimi();
            FrmCariHesapFisEkle = new CariHesapFisEkle();
            FrmGenelMuhasebeYonetimi = new GenelMuhasebeYonetimi();
            FrmMuhasebeFisEkle = new MuhasebeFisEkle();
            FrmMuhasebeFisEkle.FrmGiris = this;
            FrmGenelMuhasebeYonetimi.FrmGiris = this;
            FrmCariHesapFisEkle.FrmGiris = this;
            FrmCariHesapYonetimi.FrmGiris = this;
            FrmFaturaUrunList.FrmGiris = this;
            FrmFaturaUrunEkle.FrmGiris = this;
            FrmMusterilerList.FrmGiris = this;
            FrmFaturaOlustur.FrmGiris = this;
            FrmFaturaYonetimi.FrmGiris = this;
            FrmUrunList.FrmGiris = this;
            FrmHareketEkleGuncelle.FrmGiris = this;
            FrmHareketYonetimi.FrmGiris = this;
            FrmStokYonetimi.FrmGiris = this;
            FrmDepoEkleGuncelle.FrmGiris = this;
            FrmDepoYonetimi.FrmGiris = this;
            FrmUrunEkleGuncelle.FrmGiris = this;
            FrmUrunYonetimi.FrmGiris = this;
            FrmUrunTipEkleGuncelle.FrmGiris = this;
            FrmMusteriEkleGuncelle.FrmGiris = this;
            FrmMusteriYonetimi.FrmGiris = this;
            FrmİlceEkleGuncelle.FrmGiris = this;
            FrmİlEkleGuncelle.FrmGiris = this;
            FrmUlkeEkleGuncelle.FrmGiris = this;
            FrmGenelKodBilgileri.FrmGiris = this;
            FrmAnasayfa.FrmGiris = this;
            FrmSistemYonetimi.FrmGiris = this;
            FrmKullanıcıEkleGuncelle.FrmGiris = this;
            InitializeComponent();
        }

        public Classes.System system = new Classes.System();
        public Classes.Customers customer = new Classes.Customers();
        public Classes.Products product = new Classes.Products();
        public Classes.Stores stores = new Classes.Stores();
        public Classes.Stocks stock = new Classes.Stocks();
        public Classes.Invoices invoices = new Classes.Invoices();
        public string vrProductİnformations;
        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult vrResult;
            vrResult = MessageBox.Show("Programdan Çıkış Yapmak İstiyor Musunuz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Programdan Çıkış İşlemi Gerçekleştirilmedi","Çıkış",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtUserCode.Text = "";
                txtUserPassword.Text = "";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            system.m_Login(txtUserCode.Text, txtUserPassword.Text, this, FrmAnasayfa);
            txtUserCode.Text = "";
            txtUserPassword.Text = "";

        }
    }
}
