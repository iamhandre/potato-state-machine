namespace PsmTestsConsole
{
    using Entities;
    using Helpers;
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Testing();

            Console.WriteLine();
        }

        public enum WasherStates
        {
            Wait, Start, Running, Clean, End
        }

        public enum CarStates
        {
            Wait, Start, Shampoo, Water, End
        }

        public static async void Testing()
        {
            var washer1 = new Washer();
            MongoHelper mongo = new MongoHelper();

            await washer1.NextAsync("WasherStart");
            mongo.InsertOrUpdateWasher(washer1);

            await washer1.NextAsync("WasherWait");
            mongo.InsertOrUpdateWasher(washer1);
        }

    }
}