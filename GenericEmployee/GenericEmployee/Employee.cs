using System;
using System.Collections.Generic;
using System.Text;

namespace GenericEmployee
{
    public class GenericEmployee<T> : Person
    {
        public T things;


        //public T stuff 
        //{
        //    get // Abfrage des Werts ggf. mittels "="
        //    {
        //        return this.things;
        //    }

        //    set // Zuweisung mittels "="
        //    {
        //        this.things = stuff;
        //    }
    }
        //private int Id;
        //public void setEmployeeId(int eID)
        //{
        //    Id = eID;
        //    Console.WriteLine(eID);
        //}
}
