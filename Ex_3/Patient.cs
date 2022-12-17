using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    class Patient : TherpyPlan
    {
        private bool _isIll;

        public Patient(bool isIll)
        {
            _isIll = isIll;
        }

        public void GetSimptoms()
        {
            if (_isIll == false)
            {
                Console.WriteLine("You are not ill!");
            }

            else
            {
                Console.WriteLine("If you have a problem with heart press 1 \n" +
               "If you have a problem with teeth press 2 \n" +
               "If you have another problems press 3 \n" +
               "Please, make a choise!");

                GetPlan(simptomps = Convert.ToInt32(Console.ReadLine()));
            }

        }
    }
}
