using System;

namespace ATV_GeometricShape.Circle
{
    internal class Circle : GeometricShape
    {
        public float Pi = 3.1415f;
        public float Ray;

        public override float Area()
        {
            return (Pi * Ray);
        }
        public override float Perimeter()
        {
            return (2 * Pi * Ray);
        }

    }
}