using UnityEngine;
using System;
using System.Collections.Generic;
using PackagePersona;
using TMPro;
using UnityEditor.Experimental.GraphView;

public class UsarPersona : MonoBehaviour
{
    List<Estudiante> registroAlumnos = new List<Estudiante>();
    public TMP_InputField nameStudent;
    public TMP_InputField mailStudent;
    public TMP_InputField dirStudent;
    public TMP_InputField codeStudent;
    public TMP_InputField carreraStudent;

    //public void Start()
    // {
    //   Estudiante estudiante1 = new Estudiante("Florinda Montes", "florinda_montes@uao", "2025", "Aguablanca", "Ing. Multimedia");
    // registroAlumnos.Add(estudiante1);

    //  Estudiante estudiante2 = new Estudiante("Pepe Pino", "pepe_pino@uao", "2025-2", "Bochaplaza", "Ing. Ambiental");
    // registroAlumnos.Add(estudiante2);

    //  for (int i = 0; i < registroAlumnos.Count; i++)
    // {
    //     Debug.Log("Nombre: " + registroAlumnos[i].NameP + " | Carrera: " + registroAlumnos[i].Carrera);
    // }

    // Utilidades.ExportarAlumnos(registroAlumnos);
    // 
    public void Update()
    {
        
    }
    public void AddStudentList()
    {
        string nameStudent01 = nameStudent.text;
        string mailStudent01 = mailStudent.text;
        string dirStudent01 = dirStudent.text;
        string codeStudent01 = codeStudent.text;
        string carreraStudent01 = carreraStudent.text;
        Estudiante E1 = new Estudiante(codeStudent01, carreraStudent01, nameStudent01, mailStudent01, dirStudent01);

        registroAlumnos.Add(E1);
    }

    public void showStudentList()
    {
        for (int i = 0; i < registroAlumnos.Count; i++)
        {

            Debug.Log("Nombre: " + registroAlumnos[i].NameP + " | Carrera: " + registroAlumnos[i].Carrera);
        }
    }
}