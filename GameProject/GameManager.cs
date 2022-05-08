using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GameManager
    {
        //Oyuncunun Oyun Yoneticisine Kayit Operasyonu:
        public void RegistrateGamer(Gamer gamer, IVerificationService verification)
        {
            if (gamer.Name == verification.Name && gamer.Surname == verification.Surname && gamer.Id == verification.Id)
            {
                Console.WriteLine("-> Kimlik Dogrulandi!!!");
                Console.WriteLine($"<{gamer.Username}> adli kullanici oyun yoneticisine kayit oldu!");
            }
            else
            {
                Console.WriteLine("-> Kimlik Dogrulama Basarisiz!!!");
                Console.WriteLine($"<{gamer.Username}> adli kullanici oyun yoneticisine kayit olamadi!");
            }
            
        }

        //Oyunculularin Bilgilerinin Guncellenmesi:
        public void UpdateInformation(List<Gamer> gamers)
        {
            foreach (var gamer in gamers)
            {
                Console.WriteLine($"<{gamer.Username}> adli kullanicilarin bilgileri guncellendi!");
            }
            
        }

        //Oyuncunun Oyun Yoneticisinden Silinmesi:
        public void DeleteRegInfoGamer(Gamer gamer)
        {
            Console.WriteLine(gamer.Username + " adli kullanici oyun yoneticisinden silindi!");
        }

        
    }
}
