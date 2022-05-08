using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyun Ornekleri Olusturuldu.
            Game game1 = new Game()
            {
                Id = 1,
                GameName = "Metro",
                Price = 138.50
            };

            Game game2 = new Game()
            {
                Id = 1,
                GameName = "Call Of Duty",
                Price = 238.50
            };


            //Oyuncu ornekleri olusturuldu.
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                Username = "prosonar",
                Name = "Sukru",
                Surname = "Sonar",
                DateOfBirth = "1999",
                Balance = 1000.00
            };

            Gamer gamer2 = new Gamer()
            {
                Id = 2,
                Username = "kenanismayilov",
                Name = "Kenan",
                Surname = "Ismayil",
                DateOfBirth = "2000",
                Balance = 500.00
            };

            Gamer gamer3 = new Gamer()
            {
                Id = 3,
                Username = "slipknot",
                Name = "Tofiq",
                Surname = "Mammadov",
                DateOfBirth = "2004",
                Balance = 2000.00
            };

            Gamer gamer4 = new Gamer()
            {
                Id = 4,
                Username = "engin431",
                Name = "Engin",
                Surname = "Demirog",
                DateOfBirth = "1985",
                Balance = 438.68
            };


            //Oyun kampanya yoneticilerinin ornegi olusturuldu.
            ICampaignManager campaignManager1 = new AnnualCampaignManager();
            ICampaignManager campaignManager2 = new MonthlyCampaignManager();


            IVerificationService verification1 = new EdevletService()
            {
                Id = 2,
                TcNo = "424242424",
                Name = "Kenan",
                Surname = "Ismayil",
                DateOfBirth = "2000",
            };

            IVerificationService verification2 = new EdevletService()
            {
                Id = 3,
                TcNo = "54546698",
                Name = "Tofiq",
                Surname = "Mammadov",
                DateOfBirth = "2004",
            };

            IVerificationService verification3 = new EdevletService()
            {
                Id = 4,
                TcNo = "54546698",
                Name = "Engin",
                Surname = "Demirog",
                DateOfBirth = "1985",
            };

            //Oyun Yoneticisi Ornegi olusturuldu:
            GameManager gameManager = new GameManager();

            //Registr Gamer
            Console.WriteLine("----------------------OYUNCU KAYIT YONETIMI SISTEMI-----------------------");
            Console.WriteLine("  *******************************************************************  ");
            gameManager.RegistrateGamer(gamer2, verification1);
            gameManager.RegistrateGamer(gamer1, verification2);
            gameManager.RegistrateGamer(gamer3, verification2);
            gameManager.RegistrateGamer(gamer4, verification3);


            Console.WriteLine("------------------------------------------------------------------------");

            //Update Info
            List<Gamer> gamers = new List<Gamer>
            {
                gamer2,
                gamer3,
                gamer4
            };


            gameManager.UpdateInformation(gamers);

            Console.WriteLine("------------------------------------------------------------------------");

            //Delete Gamer
            gameManager.DeleteRegInfoGamer(gamer3);

            Console.WriteLine("------------------------------------------------------------------------");
            
            //Oyun Satis Yonetimi Ornegi:
            GameSaleManager gameSaleManager = new GameSaleManager();

            //Oyunu Alma
            Console.WriteLine("----------------------OYUN SATIS YONETIMI SISTEMI-----------------------");
            Console.WriteLine("  *******************************************************************  ");
            gameSaleManager.BuyGame(gamer2, game1, campaignManager1);
            gameSaleManager.BuyGame(gamer3, game2, campaignManager2);

            Console.WriteLine("------------------------------------------------------------------------");

            //Oyunu Iade Etme
            gameSaleManager.PayBack(gamer3, game2);

            Console.ReadKey();
        }
    }
}
