using UnityEngine;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using PackagePersona;

public class UsarPersona
{
    List<Estudiante> ListaE = new List<Estudiante>();
    public void Start()
    {
        Estudiante PEPE = new Estudiante("2025_1", "ing multimedia", "PEPE PINGA", "Pepe_pinga@uao", "bochaplaza");
        ListaE.Add(PEPE);
        Estudiante FLORINDA = new Estudiante("2025_2", "Mercadeo", "FLORINDA MONTES", "florinda_montes@uao", "jardin plaza");
        ListaE.Add(FLORINDA);

        for (int i = 0; i <ListaE.Count; i++)
        {
            Debug.Log
        }
    }
}
