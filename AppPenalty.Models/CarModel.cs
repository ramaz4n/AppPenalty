using System;
using System.Collections.Generic;
using System.Text;

namespace AppPenalty.Models
{
    public class CarModel
    {

        public string Number { get; set; }
        public string Model { get; set; }

        public string OwnerId { private set; get; }

        public CarModel(string ownerid, string number, string model)
        {
            OwnerId = ownerid;
            Number = number;
            Model = model;
        }

    }
}
