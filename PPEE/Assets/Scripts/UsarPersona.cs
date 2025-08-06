using UnityEngine;
using System;
using System.Collections.Generic;
using PackagePersona;

public class UsarPersona : MonoBehaviour
{
    List<Estudiante> registroAlumnos = new List<Estudiante>();

    public void Start()
    {
        Estudiante estudiante1 = new Estudiante("Florinda Montes", "florinda_montes@uao", "2025", "Aguablanca", "Ing. Multimedia");
        registroAlumnos.Add(estudiante1);

        Estudiante estudiante2 = new Estudiante("Pepe Pinga", "pepe_pinga@uao", "2025-2", "Bochaplaza", "Ing. Ambiental");
        registroAlumnos.Add(estudiante2);

        for (int i = 0; i < registroAlumnos.Count; i++)
        {
            Debug.Log("Nombre: " + registroAlumnos[i].NameP + " | Carrera: " + registroAlumnos[i].Carrera);
        }

        Utilidades.ExportarAlumnos(registroAlumnos);
    }
}
