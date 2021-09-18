using System;
using System.Collections.Generic;

namespace Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ทำไม่ทัน
            Console.Write("Input total Rose: ");
            int totalRose = int.Parse(Console.ReadLine());
            Console.Write("Input total Sunflower: ");
            int totalSunflower = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalRose; i++) {
                int id,amount;string plantname, plantdes,height,circumference;

                id = int.Parse(Console.ReadLine());
                plantname = Console.ReadLine();
                plantdes = Console.ReadLine();
                amount = int.Parse(Console.ReadLine());
                height = Console.ReadLine();
                circumference = Console.ReadLine();
                Rose rose = new Rose(id,plantname,plantdes,amount,height,circumference);
                rose.addRose(rose,i+1);

            }
            for (int i = 0; i < totalSunflower; i++)
            {
                int id, amount; string plantname, plantdes, height, circumference;

                id = int.Parse(Console.ReadLine());
                plantname = Console.ReadLine();
                plantdes = Console.ReadLine();
                amount = int.Parse(Console.ReadLine());
                height = Console.ReadLine();
                circumference = Console.ReadLine();
                Sunflower sunflower = new Sunflower(id, plantname, plantdes, amount, height, circumference);
                sunflower.addSunflower(sunflower,i+1);
            }


        }
        static void InputRose() {
            Console.Write("Input total Rose");
        }
    }
    class Plant {
        public int ID;
        public string PlantName;
        public string PlantDes;
        public int Amount;
        public string Height;
        public string Circumference;

        public Plant(int ID,string plantName,string plantDes,int amount,string height,string circumference) {
            this.ID = ID;
            this.PlantName = plantName;
            this.PlantDes = plantDes;
            this.Amount = amount;
            this.Height = height;
            this.Circumference = circumference;
        }



    }
    class Rose:Plant {

        private List<Rose> RoseInfo;

        public Rose(int ID, string plantName, string plantDes, int amount, string height, string circumference) 
            : base(ID, plantName, plantDes, amount, height, circumference)
        {
            this.ID = ID;
            this.PlantName = plantName;
            this.PlantDes = plantDes;
            this.Amount = amount;
            this.Height = height;
            this.Circumference = circumference;

        }
        public void addRose(Rose rose, int number)
        {
            RoseInfo.Add(rose);
        }
        public void showRoseName()
        {
            Console.WriteLine("Rose Infomation");
            foreach (Rose roses in RoseInfo)
            {
                Console.WriteLine(PlantName);
            }
            
        }

    }
    class Sunflower : Plant
    {
        private List<Sunflower> sunflowerInfo;

        public Sunflower(int ID, string plantName, string plantDes, int amount, string height, string circumference)
            : base(ID, plantName, plantDes, amount, height, circumference)
        {
            this.ID = ID;
            this.PlantName = plantName;
            this.PlantDes = plantDes;
            this.Amount = amount;
            this.Height = height;
            this.Circumference = circumference;

        }
        public void addSunflower(Sunflower sunflower,int number)
        {
            sunflowerInfo.Add(sunflower);
        }
        public void showSunflowerName()
        {
            Console.WriteLine("Sunflower Infomation");
            foreach (Sunflower sunflower in sunflowerInfo)
            {
                Console.WriteLine(PlantName);
            }

        }
    }


}
