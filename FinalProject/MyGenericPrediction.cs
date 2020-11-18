using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class MyGenericPredicition<T>
    {
        //יצירת שדה במחלקה מסוג גנרי
        public T genericMinutesVariable;

        //יצירת פרופרטי גנרי
        public T genericProperty { get; set; }

        //בנאי המחלקה מקבל גם הוא פרמטר גנרי
        public MyGenericPredicition(T value)
        {
            genericMinutesVariable = value;
        }

        public string Predict(string status)
        {
            
            double prediction = 1;
            if (status == "Rookie")
            {
                prediction = prediction * 0.7 * double.Parse(genericMinutesVariable.ToString());
            }
            else
            {
                prediction = prediction * 1.7 * double.Parse(genericMinutesVariable.ToString());
            }
            

            return string.Format("{0:0.0}", prediction);
        }
    }

}
