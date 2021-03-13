using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi en az iki karakterden oluşmalıdır";
        public static string CarPriceInvalid = "Araba fiyatı sıfırdan büyük olmalıdır";
        public static string MaintenanceTime = "Sistem bakımda...";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string RentalAdded = "Kiralama eklendi";
        public static string CarImageLimitExceeded = "Bir araba için en fazla 5 fotoğraf eklenebilir";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş yapıldı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı kaydı yapıldı";
        public static string AccessTokenCreated = "Access token oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
