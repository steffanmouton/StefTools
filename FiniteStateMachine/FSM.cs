using System;
using System.Diagnostics;

namespace FiniteStateMachine
{
    public interface IPrintable
    {
        void Print();
    }
    public interface ITalkable
    {
        void Talk();
    }
    
    public interface IChangeable
    {
        void Change();
    }
    
    
    public class FSM
    {
        //public IPrintable printable;

        //public void Test()
        //{
        //    printable.Print();
        //}
    }
    

  
/*    public class IMfromthefuture:IPrintable, ITalkable, IChangeable
    {
        public void Print()
        {
            Console.WriteLine("im from the future");
        }

        public void Talk()
        {
            
        }

        public void Change()
        {
            
        }
    }*/
}