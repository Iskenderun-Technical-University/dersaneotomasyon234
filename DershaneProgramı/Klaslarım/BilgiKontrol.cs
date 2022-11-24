using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klaslarım
{
  public   class BilgiKontrol
    {
        


       
        public static string KullanıcıBilgileriGirilmişMi(object Veriler)
        {
            string Hata = "";

            Kullanıcı kul = new Kullanıcı();
            kul =(Kullanıcı)Veriler;
             
            if(kul.AdıSoyadı=="")
            {
                Hata = "Ad Soyad girmediniz";
            }
            else if(kul.KullanıcıAdı=="")
            {
                Hata = "KullanıcıAdı girmediniz";
            }
            else if(kul.Şifre=="")
            {
                Hata = "Şİfre girmediniz";
            }
            else if(kul.Mail=="")
            {
                Hata = "Mail girmediniz";
            }

     

            return Hata;
        }

        public static bool MailKontrol(string MailAdresi)
        {
            bool DoğruFormat = false;


            if( MailAdresi.Contains("@") && MailAdresi.Contains(".") )
            {
                DoğruFormat = true;
            }


            return DoğruFormat;
        }


    }
}
