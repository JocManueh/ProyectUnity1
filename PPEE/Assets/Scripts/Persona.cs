using UnityEngine;
using System;

namespace PackagePersona
{
    public class Persona
    {
        private string nameP;
        private string mailP;
        private int ageP;
        private string dirP;

        public Persona()
        {
        }

        public Persona(string nameP, string mailP, int ageP, string dirP)
        {
            this.nameP = nameP;
            this.mailP = mailP;
            this.ageP = ageP;
            this.dirP = dirP;
        }

        public string NameP { get => nameP; set => nameP = value; }
        public string MailP { get => mailP; set => mailP = value; }
        public int AgeP { get => ageP; set => ageP = value; }
        public string DirP { get => dirP; set => dirP = value; }
    }
}
