using UnityEngine;
using System;

namespace PuntosXY
{
    [Serializable]
    public class Punto2D
    {
        [SerializeField] private float coordX;
        [SerializeField] private float coordY;

        public float CoordX { get => coordX; set => coordX = value; }
        public float CoordY { get => coordY; set => coordY = value; }

        public Punto2D() { }

        public Punto2D(float valorX, float valorY)
        {
            CoordX = valorX;
            CoordY = valorY;
        }



    }


}
