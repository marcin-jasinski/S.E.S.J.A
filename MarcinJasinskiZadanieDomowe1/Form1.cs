using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcinJasinskiZadanieDomowe1
{   
    public partial class FormMain : Form
    {
        byte secondsPassed = 0; // zmienna przechowująca liczbę sekdund od początku uruchomienia programu
        byte daysPassed = 0;    // zmienna przechowująca liczbę dni, które upłynęły w symulacji
        byte daysLeft = 15;     // zmienna przechowująca liczbę dni do końca sesji
        static byte startingDay = 28;  // zmienna określająca dzień początku sesji
        static byte currentDay = startingDay; // zmienna przechowująca obecny dzień;

        int failedStudentsSum = 0; // zmienna przechowująca wartość sumy oblanych studentów
        double avg = 0; // zmienna przechowująca wartość średnią współczynnika uwalania

        // lista profesorów na uczelni
        public List<Profesor> professorsList = new List<Profesor>();

        public FormMain()
        {
            InitializeComponent();
            addInitialListSet();
            timerSessionTimer.Start();
        }

        // funkcja dodająca do listy początkowy zestaw profesorów, z losowym parametrem failingRatio z przedziału 1.00 - 3.00
        public void addInitialListSet()
        {
            Random rand = new Random();
            professorsList.Add(Profesor.newProfesor("Jan Kowalski", rand.Next(1, 300) / 100.0));
            professorsList.Add(Profesor.newProfesor("Tomasz Nowak", rand.Next(1, 300) / 100.0));
            professorsList.Add(Profesor.newProfesor("Jerzy Jerzowski", rand.Next(1, 300) / 100.0));
            professorsList.Add(Profesor.newProfesor("Kajetan Kajetanowicz", rand.Next(1, 300) / 100.0));
            professorsList.Add(Profesor.newProfesor("Krzesimir Dębski", rand.Next(1, 300) / 100.0));
            professorsList.Add(Profesor.newProfesor("Bonifacy Markowski", rand.Next(1, 300) / 100.0));
            professorsList.Add(Profesor.newProfesor("Zbigniew Mietczyński", rand.Next(1, 300) / 100.0));
        }

        // funckcja odświeżająca listę TOP3 profesorów
        public void updateTopList()
        {
            // sortowanie listy profesorów z pomocą klasy ProfessorsComparatorClass
            IComparer<Profesor> comparer = new ProfessorsComparatorClass();
            professorsList.Sort(comparer);

            // wyczyszczenie poprzedniej zawartości listy
            dataGridViewProfessorsRanking.Rows.Clear();
            dataGridViewProfessorsRanking.Refresh();

            // dodanie nowych wierszy z odpowiednimi wartościami
            for (int i = 0; i < 3; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewProfessorsRanking);
                row.Cells[0].Value = professorsList[i].Name;
                row.Cells[1].Value = professorsList[i].FailingRatio;
                row.Cells[2].Value = professorsList[i].FailedStudentsCount;
                dataGridViewProfessorsRanking.Rows.Add(row);
            }
        }

        // funkcja zliczająca sumaryczną wartość wysłanych na poprawki przez wszystkich profesorów
        public int getFailedStudentsSummary()
        {
            foreach(Profesor p in professorsList)
            {
                failedStudentsSum += p.FailedStudentsCount;
            }

            return failedStudentsSum;
        }
        
        // funkcja zliczająca średni współczynnik uwalania dla wszystkich profesorów 
        public double getAverageFailingRatio()
        {
            avg = 0;
            foreach (Profesor p in professorsList)
            {
                avg += p.FailingRatio;
            }

            return avg / professorsList.Count();
        }

        // funkcja obsługująca zdarzenie timera
        private void timerSessionTimer_Tick(object sender, EventArgs e)
        {
            secondsPassed++;

            if (daysPassed <= 14) // dopóki trwa sesja
            {
                if(secondsPassed % 2 == 0) // zmiana dnia w symulacji co 2 rzeczywiste sekundy
                {
                    daysPassed++;
                    currentDay++;
                    
                    // zmiana wyświetlanej daty
                    if (currentDay > 31) currentDay = 1;
                    if (currentDay >= startingDay && currentDay <= 31) labelCurrentDate.Text = currentDay + " stycznia 2018";
                    else labelCurrentDate.Text = currentDay + " lutego 2018";

                    daysLeft--;
                    labelDaysLeft.Text = "do końca sesji pozostało " + daysLeft + " dni.";

                    // codzienny update liczby oblanych studentów dla każdego profesora (wartości losowe)
                    Random rand = new Random();
                    foreach(Profesor p in professorsList)
                    {
                        p.FailedStudentsCount += Convert.ToInt32(p.FailingRatio * rand.Next(1, 5));
                    }

                    // update okna głównego programu
                    updateTopList();
                    textBoxAverageFailingRatio.Text = "" + getAverageFailingRatio();
                    textBoxSummary.Text = "" + getFailedStudentsSummary();
                }
            }
            else
            {
                // zatrzymanie timera i wyświetlenie okna końcowego na koniec sesji
                timerSessionTimer.Stop();
                FormEndingWindow formEndingWindow = new FormEndingWindow();
                formEndingWindow.Show();
            }
        }

        // obsługa przycisku redukcji o 1 ECTS
        private void buttonUse1ECTSReduction_Click(object sender, EventArgs e)
        {
            foreach(Profesor p in professorsList)
            {
                p.FailingRatio += 0.02;
            }

            // zmniejszenie liczby dostępnych użyć zasobu
            int quantityLeft = Convert.ToInt32(label1ECTSReductionLeft.Text);
            quantityLeft--;
            label1ECTSReductionLeft.Text = "" + quantityLeft;

            if (quantityLeft == 0) buttonUse1ECTSReduction.Enabled = false;
        }

        // obsługa przycisku redukcji o 10 ECTS
        private void buttonUse10ECTSReduction_Click(object sender, EventArgs e)
        {
            foreach (Profesor p in professorsList)
            {
                p.FailingRatio += 1.0;
            }

            // zmniejszenie liczby dostępnych użyć zasobu
            int quantityLeft = Convert.ToInt32(label10ECTSReductionLeft.Text);
            quantityLeft--;
            label10ECTSReductionLeft.Text = "" + quantityLeft;

            if (quantityLeft == 0) buttonUse10ECTSReduction.Enabled = false;
        }

        // obsługa przycisku egzaminu u POTĘŻNEGO magistra
        private void buttonUsePowerfulProfesorExam_Click(object sender, EventArgs e)
        {
            failedStudentsSum += 200;

            // zmniejszenie liczby dostępnych użyć zasobu
            int quantityLeft = Convert.ToInt32(labelPowerfulProfesorExamLeft.Text);
            quantityLeft--;
            labelPowerfulProfesorExamLeft.Text = "" + quantityLeft;

            if (quantityLeft == 0) buttonUsePowerfulProfesorExam.Enabled = false;
        }

        // obsługa przycisku dwóch egzaminów jednocześnie
        private void buttonUseTwoParalellExams_Click(object sender, EventArgs e)
        {
            foreach (Profesor p in professorsList)
            {
                p.FailingRatio += 0.15;
            }

            // zmniejszenie liczby dostępnych użyć zasobu
            int quantityLeft = Convert.ToInt32(labelTwoParalellExamsLeft.Text);
            quantityLeft--;
            labelTwoParalellExamsLeft.Text = "" + quantityLeft;

            if (quantityLeft == 0) buttonUseTwoParalellExams.Enabled = false;
        }

        // obsługa przycisku nieoczekiwanej zmiany sali
        private void buttonUseUnexpectedRoomChange_Click(object sender, EventArgs e)
        {
            failedStudentsSum += 15;

            // zmniejszenie liczby dostępnych użyć zasobu
            int quantityLeft = Convert.ToInt32(labelUnexpectedRoomChangeLeft.Text);
            quantityLeft--;
            labelUnexpectedRoomChangeLeft.Text = "" + quantityLeft;

            if (quantityLeft == 0) buttonUseUnexpectedRoomChange.Enabled = false;
        }
    }
}
