﻿using System;

namespace DoFactory.GangOfFour.Singleton.Structural
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Singleton Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Constructor is protected -- cannot use new
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    class Singleton
    {
        private static Singleton _instance;
        
        protected Singleton()
        {
        }

        //public static Singleton Instance
        //{
        //    get { return _instance ?? (_instance = new Singleton()); }
        //}

        public static Singleton Instance()
        {
            // Uses lazy initialization.
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}