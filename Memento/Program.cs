using Memento_Pattern;
using System;
namespace Memento.RealWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Ferid";
            s.Phone = "(055) 555-55-55";
            s.Budget = 25000.0;
            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();
            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;
            ProspectMemory k = new ProspectMemory();
            k.Memento = s.SaveMemento();
            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;
            s.RestoreMemento(m.Memento);
            Console.ReadKey();
        }
    }
    
    
}