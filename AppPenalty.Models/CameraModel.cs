using System;
using System.Collections.Generic;
using System.Text;

namespace AppPenalty.Models
{
    public class CameraModel
    {
        public int LowerSpeed { get; set; }

        public string Id { private set; get; }


        public CameraModel( int lowerSpped)
        {
            Id = Guid.NewGuid().ToString("N");
            LowerSpeed = lowerSpped;
        }
    }
}
