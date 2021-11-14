using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Company<T> where T : Employee
    {
        private T[] Entities;

        public Company(T[] list)
        {
            Entities = list;
        }

        public T GetEntity(int pos)
        {
            try
            {
                return Entities[pos];
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void SetEntity(int pos, T entity)
        {
           
            try
            {
                Entities[pos] = entity; 
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void SwapPosition(int pos1, int pos2)
        {
            try
            {
                T x = Entities[pos1];
                Entities[pos1] = Entities[pos2];
                Entities[pos2] = x;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public bool Equals(Company<T> company)
        {
            for (int i = 0; i < Entities.Length; i++)
            {
                return Entities[i].Name != company.GetEntity(i).Name;
            }
            return false;
        }
    }
}
