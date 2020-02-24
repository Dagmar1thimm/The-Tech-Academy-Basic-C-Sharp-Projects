using System;
using System.Collections.Generic;
using System.Text;

namespace InheriInterface
{
    class Employee : Person, IQuittable
    {

        private int Id;
        public void setEmployeeId(int eID)
        {
            Id = eID;
            Console.WriteLine(eID);
        }

        public void Quit()
        {
            throw new NotImplementedException();

        }

    }
}
