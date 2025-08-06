using UnityEngine;
using System;

namespace PuntosXY
{
    [Serializable]
    public class Punto2D
    {
        [SerializeField] private double coordX;
        [SerializeField] private double coordY;

        public Punto2D() { }

        public Punto2D(double valorX, double valorY)
        {
            coordX = valorX;
            coordY = valorY;
        }

        public double X
        {
            get { return coordX; }
            set { coordX = value; }
        }

        public double Y
        {
            get { return coordY; }
            set { coordY = value; }
        }
    }
}
