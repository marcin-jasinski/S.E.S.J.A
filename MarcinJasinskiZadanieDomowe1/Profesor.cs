using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinJasinskiZadanieDomowe1
{
    public class Profesor
    {
        // pola klasy zawierające imię, współczynnik oblewania na egzaminie i liczbę studentów wysłanych na poprawki
        private string name;
        private double failingRatio;
        private int failedStudentsCount;

        // Property
        public string Name { get => name; }
        public double FailingRatio { get => failingRatio; set => failingRatio = value; }
        public int FailedStudentsCount { get => failedStudentsCount; set => failedStudentsCount = value; }

        // konstruktor, na początku semestru liczba wysłanych na poprawki wynosi 0
        public Profesor(string name, double failingRatio, int failedStudentsCount = 0)
        {
            this.name = name;
            this.failingRatio = failingRatio;
            this.failedStudentsCount = failedStudentsCount;
        }

        // statyczna funkcja zwracająca nowy obiekt klasy Profesor
        public static Profesor newProfesor(string name, double failingRatio, int failedStudentsCount = 0)
        {
            return new Profesor(name, failingRatio, failedStudentsCount);
        }
    }
}
