using UnityEngine;
using System;
using System.Collections.Generic;
using PuntosXY;

public class UsaPunto2D : MonoBehaviour
{
    List<Punto2D> coordenadas2D = new List<Punto2D>();

    public void Start()
    {
        //Punto2D a = new Punto2D(11.7, 22.4);
        //coordenadas2D.Add(a);

        //Punto2D b = new Punto2D(31.8, 19.3);
        //coordenadas2D.Add(b);

        //Punto2D c = new Punto2D(1.9, 0.0);
        //coordenadas2D.Add(c);

        //Punto2D d = new Punto2D(-32.4, 15.8);
        //coordenadas2D.Add(d);

        foreach (var punto in coordenadas2D)
        {
            Debug.Log("Coordenada → X: " + punto.CoordX + " | Y: " + punto.CoordY);
        }

        Utilidades.ExportarCoordenadas(coordenadas2D);
    }

    public void Update()
    {
    
    }
}

