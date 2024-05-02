using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string EmplyoeeAdded = "Personel eklendi";
        public static string? AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string EmplyoeesListed = "Personeller listelendi";
       
        public static string EmplyoeeNameAlreadyExists = "Bu isimde bir personel var";
        public static string PlantAdded = "Santral Eklendi";
        public static string PlantsListed = "Santraller listelendi";
        internal static string PlantNameAlreadyExists = "Bu isimde bir santral var";
        internal static string TestNameAlreadyExists = "Bu isimde test var";
        internal static string JobAdded = "Görev eklendi";
        internal static string JobsListed = "Görevler listelendi";
        internal static string JobCountOfJobError = "Bir listede en fazla 10 görev olabilir";
        internal static string TestsListed= "Testler listelendi";
        internal static string TestCountOfTestError = "Bir listede en fazla 10 test olabilir";
        internal static string TestAdded = "Test eklendi";
        internal static string EmplyoeeDeleted = "Personel silindi";
        internal static string JobIdAlreadyExists = "Bu İd ye sahip bir görev var";
        internal static string EmplyoeeNotFound = "Personel bulunamadı";
        internal static string EmplyoeeCountOfEmplyoeeError = "En fazla 10 Personel ";
        internal static string EmplyoeeUpdated = "Personel bilgileri güncellendi";
    }
}
