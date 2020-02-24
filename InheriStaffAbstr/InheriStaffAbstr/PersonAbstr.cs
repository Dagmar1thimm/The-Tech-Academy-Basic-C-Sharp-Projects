using System;
using System.Collections.Generic;
using System.Text;

namespace InheriStaffAbstr
{
   public abstract class PersonAbstr
    {
        public string firstName;
        public string lastName;

        public abstract void sayName();
        public abstract void setFirstName(string FN);
        public abstract void setLastName(string LN);

    }
}
