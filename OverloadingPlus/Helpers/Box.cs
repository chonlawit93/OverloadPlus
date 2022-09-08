using System;
namespace OverloadingPlus.Helpers
{
    class Box
    {
        public double Weight { get; set; }
        public double Value { get; set; }
        public double Volume { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Box box &&
                   Weight == box.Weight &&
                   Value == box.Value &&
                   Volume == box.Volume;
        }

        public static Box operator +(Box lhs, Box rhs)
        {
            return new Box
            {
                Value = lhs.Value + rhs.Value,
                Volume = lhs.Volume + rhs.Volume,
                Weight = lhs.Weight + rhs.Weight
            };
        }



    }
}

