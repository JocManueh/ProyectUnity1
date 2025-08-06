using UnityEngine;
using System;
using System.Xml.Linq;

namespace PackagePersona
{
    [Serializable]
    public class Estudiante : Persona
    {
        [SerializeField]private string codigo;
        [SerializeField]private string carrera;

        public Estudiante()
        {
        }

        public Estudiante(string codigo, string carrera)
        {
            this.codigo = codigo;
            this.carrera = carrera;
        }

        public Estudiante(string nameP, string mailP, string codigo, string dirP, string carrera) : base(nameP, mailP,dirP)
        {
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Carrera { get => carrera; set => carrera = value; }
    }



}