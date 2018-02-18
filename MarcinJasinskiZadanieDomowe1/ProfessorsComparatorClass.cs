using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinJasinskiZadanieDomowe1
{
    // klasa dostarczająca mechanizm sortowania listy profesorów
    class ProfessorsComparatorClass : IComparer<Profesor>
    {
        // funkcja sortująca
        // sortowanie odbywa się najpierw wg. liczby wysłanych na poprawki, w przypadku remisu - wg. współczynnika uwalania (W.U)
        public int Compare(Profesor x, Profesor y)
        {
            // zmienna przechowująca wynik porównania
            int compareFailedStudents = y.FailedStudentsCount.CompareTo(x.FailedStudentsCount);
            if (compareFailedStudents == 0)
            {
                return y.FailingRatio.CompareTo(x.FailingRatio);
            }
            return compareFailedStudents;
        }
    }
}
