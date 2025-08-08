using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using PackagePersona;
using PuntosXY;

public class Utilidades
{
 
    [Serializable]
    private class RegistroDeAlumnos
    {
        public List<Estudiante> contenido;
    }

    [Serializable]
    private class RegistroDePuntos
    {
        public List<Punto2D> datos;
    }

    public static void ExportarAlumnos(List<Estudiante> entrada, string archivoSalida = "datos_alumnos.json")
    {
        RegistroDeAlumnos paquete = new RegistroDeAlumnos();
        paquete.contenido = entrada;

        string jsonFinal = JsonUtility.ToJson(paquete, true);
        string destino = Application.persistentDataPath + "/" + archivoSalida;

        File.WriteAllText(destino, jsonFinal);
        Debug.Log(destino);
    }

    public static void ExportarCoordenadas(List<Punto2D> entrada, string archivoSalida = "datos_puntos.json")
    {
        RegistroDePuntos paquete = new RegistroDePuntos();
        paquete.datos = entrada;

        string jsonFinal = JsonUtility.ToJson(paquete, true);
        string destino = Application.persistentDataPath + "/" + archivoSalida;

        File.WriteAllText(destino, jsonFinal);
        Debug.Log(destino);
    }
    //public static bool SaveDataStudent(List<Estudiante> listaE)
    //{
    //    bool SaveDataStudent = false;
    //    string jsonString = JsonUtility.ToJson(listaE, true);
    //    Debug.Log("Lista"+jsonString);
    //    //EstudianteListaWrapper wrapper =  new EstudianteListaWrapper();
    //    //wrapper.listaE = listaE;
    //    string path = Path.Combine(Application.streamingAssetsPath,"estudiantes.json");
    //   // return resultado;


    //}
}

