using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022300101
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGeneric<string> nim= new DataGeneric<string>("103022300101");
            nim.PrintData();
        }
    }
    public class DataGeneric<T>
    {
        public T Data { get; set; }

        public DataGeneric(T data)
        {
            Data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {Data}");
        }
    }

}
