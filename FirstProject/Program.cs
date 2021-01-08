using System;

namespace FirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OnlineStore onlineStore = new OnlineStore();
            onlineStore.MainMenu();
            Console.ReadLine();
        }
    }
}