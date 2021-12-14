using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Contants
{
    public static class Messages
    {
        public static string CarsListed = "Araçlar Listelendi";
        public static string CarAdded = "Araç Eklendi";
        public static string CarDelete = "Araç Silinidi";
        public static string CarUpdate = "Araç Güncellendi";
        public static string InvalidName = "Geçersiz isim";
        public static string CarNotRented = "Araç Kiralanamadı";
        public static string CarRented = "Araç Kiralandı";

        public static string RentalsListed = "Kiralık Araçlar Listelendi";
        public static string RentalDeleted = "Kiralık Araç Silindi";
        public static string RentalUpdate = "Kiralık Araç Güncellendi";

        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdate = "Kullanıcı Güncellendi";
        public static string UserAdded = "Kullanıcı Eklendi";

        public static string ColorsListed = "Renkler Listelendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdate = "Renk Güncellendi";
        public static string ColorAdded = "Renk Eklendi";

        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdate = "Müşteri Güncellendi";
        public static string CustomerAdded = "Müşteri Eklendi";

        internal static string ImagesListed="Fotoğraflar Listelendi";
        internal static string ImageFound="Fotoğraf Bulundu";

        public static string CarImagesListed = "Arabanin resimleri listelendi";
        public static string CarsImagesListed = "Tum araba resimleri listelendi";
        public static string CarImageListed = "Araba resmi listelendi";
        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageUpdated = "Araba resmi guncellendi";
        public static string ErrorUpdatingImage = "Resim guncellenirken hata olustu";
        public static string ErrorDeletingImage = "Resim silinirken hata olustu";
        public static string CarImageLimitExceeded = "Bu araca daha fazla resim eklenemez";
        public static string CarImageIdNotExist = "Araba resmi mevcut degil";
        public static string UserAlreadyCustomer = "Kullanici zaten bir musteridir";
        public static string GetDefaultImage = "Arabanin bir resmi olmadigi icin varsayilan resim getirildi";
        public static string NoPictureOfTheCar = "Arabanin hic resmi yok";
        internal static string AccessTokenCreated;

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "kayıt olundu.";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Hatalı şifre";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Zaten Var";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
    }
}
