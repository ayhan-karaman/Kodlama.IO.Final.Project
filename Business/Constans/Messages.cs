using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
   public static class Messages
    {
        internal static string AuthorizationDenied = "AuthorizationDenied Hatası";
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProcuctNameInvalid = "Ürün İsmis Geçersizdir";
        public static string ProductDelete = "Ürün Başarıyla Silindi";
        public static string ProductList = "Ürünler Başarıyla Listeledi";
        public static string ProductNotList = "Sistem Bakımda Olduğu için Listelenmedi";
        public static string UserAdded = "Kullanıcı Kaydı Oluşturuldu";
        public static string AccessTokenCreated = "Access Token Oluşturuldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Hatalı Şifre";

        public static string SuccessLogin = "Giriş Başarılı";

        public static string UserRegistered = "Kaydınız Oluşturuldu";

        public static string UserAlreadyExists = "Kullanıcı Bulunamadı";
    }
}
