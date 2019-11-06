using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessManager.Model
{
    public enum Gender : int
    {
        Male = 1,
        Female = 2,
        Unkown = 3
    }

    class Customer
    {
        /*
         nome,cognome, atezza(cm non negativo), peso(non negativo),sesso(),eta(non negativo), data di iscrizione,
         
        2 metodi: calcola BMI(double) - description(string)= scheda cliente

        1)costruttore: completo che prende tutti i campi
        2)costruttore: prende nome, cognome, eta che inizializzi la data di iscrizione ad oggi
         daytime.now
             */

        public string Id { get; }
        private string id;
        private int age;
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public DateTime SigningDate { get; }



        private double hight;
        public double Hight
        {
            get { return hight; }
            set
            {
                if (value >= 0)
                {
                    hight = value;
                }
                else { hight = 0; }
            }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value >= 0)
                {
                    weight = value;
                }
                else { weight = 0; }
            }
        }


        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else { age = 0; }
            }
        }
        public Customer(string name, string surname, double hight, double weight, Gender gender, int age, DateTime signingDate, string id)
        {
            Name = name;
            Surname = surname;
            Hight = hight;
            Weight = weight;
            Gender = gender;
            Age = age;
            SigningDate = signingDate;
            Id = id;
        }
        public Customer(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            SigningDate = DateTime.Now;
            Id = CalculateId();
        }

        public string CalculateId()
        {
            char firstLetter = Name[0];
            char secondLetter = Surname[0];
            string code = SigningDate.ToString("ddMMyyHHmmss");
            id = firstLetter + secondLetter + code;
            return id;
        }
        public double CalculateBmi(double hight, double weight)
        {
            if (Weight != 0 && Hight != 0)
            {

                double bmi = Weight / (Hight * Hight);
                return bmi;
            }
            return -1;
        }

        //public string Description()
        //{
        //    string bMIstring;
        //    double bMI = CalculateBmi(Hight, Weight);
        //    if (bMI > 0)
        //    {
        //        bMIstring = bMI + "";
        //    }

        //    string description = "ID:" + Id + "\n"
        //        + "Nome:" + Name + " " + Surname + "\n"
        //        + "Eta;" + Age + "\n"
        //        + "Sesso:" +GetGenderIta(Gender)+ "\n"
        //        + "BMI:" + CalculateBmi(Hight, Weight) + "\n"
        //        + "Altezza:" + Weight + "\n"
        //        + "Peso:" + Hight + "\n"
        //        + "Data Iscrizione:" + SigningDate.ToString("dd-MM-yyyy") + "\n";
        //    return description;
        //}
        private string GetGenderIta(Gender gender)
        {
            switch (gender)
            {
                case Gender.Male:
                    return "Maschio";
                case Gender.Female:
                    return "Femmina";
                case Gender.Unkown:
                    return "Non Determinato";
                default:
                    return "Non Determinato";
            }
        }

        public override string ToString()        //
        {
            string bMIstring;
            double bMI = CalculateBmi(Hight, Weight);
            if (bMI > 0)
            {
                bMIstring = bMI + "";
            }

            string description = "ID:" + Id + "\n"
                + "Nome:" + Name + " " + Surname + "\n"
                + "Eta;" + Age + "\n"
                + "Sesso:" + GetGenderIta(Gender) + "\n"
                + "BMI:" + CalculateBmi(Hight, Weight) + "\n"
                + "Altezza:" + Weight + "\n"
                + "Peso:" + Hight + "\n"
                + "Data Iscrizione:" + SigningDate.ToString("dd-MM-yyyy") + "\n";
            return description;
        }
    }
   
}