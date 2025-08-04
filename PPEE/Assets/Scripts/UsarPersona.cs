using UnityEngine;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using PackagePersona;

public class UsarPersona : MonoBehaviour 
{
    List<Estudiante> ListaE = new List<Estudiante>();
    public void Start()
    {
        Estudiante PEPE = new Estudiante("FLORINDA MONTES","florinda_montes@uao","2025","AGUABLANCA","ing multimedia");
        ListaE.Add(PEPE);
        Estudiante FLORINDA = new Estudiante("PEPE PINGA","pepe_pinga@uao","2025-2","Bochaplaza","ing ambiental");
        ListaE.Add(FLORINDA);

        for (int i = 0; i <ListaE.Count; i++)
        {
            Debug.Log("" + ListaE[i].NameP + "Carrera" + ListaE[i].Carrera);
        }
    }
}
