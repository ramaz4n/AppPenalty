using System;
using System.Collections.Generic;
using AppPenalty.Models;
using AppPenalty.Shared;

namespace AppPenalty
{
    class Program
    {
        //public class OsagoProcess
        //{
        //    public event OsagoSubsriber OsagoEvent;
        //    public void EmitEvent(int x)
        //    {
        //        OsagoEvent(x);
        //    }
        //}

        //public static void Osago(int x)
        //{
        //    Console.WriteLine("Все путем {0}", x);
        //}
        //public delegate void OsagoSubsriber(int x);

        public static void DPSS(CarModel car, int carSpeed, CameraModel camera)
        {
            Console.WriteLine("Автомобиль нарушителя - " + car.Model + "\n Номер авто - " + car.Number);
            Console.WriteLine("Разрешенная скорость - " + camera.LowerSpeed);
            Console.WriteLine("Cкорость нарушителя - " + carSpeed);
        }

        public static void DetectPenalty(CarModel car, int carSpeed, CameraModel camera)
        {
            //var osagoProcess = new OsagoProcess();
            //osagoProcess.OsagoEvent += Osago;
            //if(x > y)
            //{
            //    osagoProcess.EmitEvent(x);
            //}

            if(carSpeed > camera.LowerSpeed + 20)
            {
                DPSS(car, carSpeed, camera);
            }
        }

        static void Main(string[] args)
        {
            //CarModel audi = new CarModel("23", "e245ар", "Audi");
            //CameraModel cam1 = new CameraModel(60);
            //DetectPenalty(audi, 100, cam1);



            var osagos = new List<OsagoModel>()
            {
                new OsagoModel("2345"),
                new OsagoModel("0020"),
                new OsagoModel("4300"),
                new OsagoModel("1020"),
                new OsagoModel("5120"),
                new OsagoModel("5070")
            };

            foreach (var i in osagos) { SeedData.OsagoRepo.Create(i); }

        }


    }
}
