using System;

namespace TestForUP01.Model
{
    class EstimationModel
    {
        public int Estimation { get; private set; }

        public EstimationModel(int estimation)
        {
            Estimation = estimation;
        }

        public override string ToString()
        {
            switch (Estimation)
            {
                case 0: return "Очень плохо";
                case 1: return "Очень плохо";
                case 2: return "Плохо";
                case 3: return "Удовлетворительно";
                case 4: return "Хорошо";
                case 5: return "Отлично";
            }

            throw new Exception("Error parsing estimation to string");
        }
    }
}
