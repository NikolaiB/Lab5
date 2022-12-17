using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    class TherpyPlan : Doctors
    {
        public int simptomps;

        public void GetPlan(int simptomps)
        {
            switch (simptomps)
            {
                case 1:
                    Console.WriteLine("Your doctor is surgeon Victoria");
                    Doctors.Surgeon();
                    break;

                case 2:
                    Console.WriteLine("Your doctor is dantist Mary");
                    Doctors.Dantist();
                    break;

                default:
                    Console.WriteLine("Your doctor is therapist Oleg");
                    Doctors.Therapist();
                    break;
            }


        }

    }
}
