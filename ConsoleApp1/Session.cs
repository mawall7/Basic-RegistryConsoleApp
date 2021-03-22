using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Session
    {
       private PersonHandler Handler { get; set; }
        //private bool SessionIsActive => true;

        //public bool SessionIsActive { get; set; } = true;
       
       
        internal void start()
        {
            Handler = new PersonHandler();
            Displayinfo();
            /*while (SessionIsActive) {
                MakeOption();
            }*/
            
            do
            {
                MakeOption();
            } while (true);
        }
            
        private void MakeOption()
        {
            Console.WriteLine("1) Save new Person\n2)Display All (Return)\n3)Quit\n\n--------------------------------");
            string input = null;
            string fname = "";
            string lname = "";
            //PersonHandler handler;
            while (string.IsNullOrWhiteSpace(input)) {
                input = Console.ReadLine();
            }

            switch (input)
            {
               
                case "1":
                    Console.WriteLine("Write the Name of a New Person to register:\n\n");
                    
                    while (string.IsNullOrWhiteSpace(fname)) 
                    {
                        Console.WriteLine("FirstName?:\n");
                        fname = Console.ReadLine();
                    }
                    while (string.IsNullOrWhiteSpace(fname))
                    {
                        Console.WriteLine("Lastname?:\n");
                        fname = Console.ReadLine();
                    }
                    Handler.CreatePerson(fname, lname);
                        Console.WriteLine("New Person Created!");
                        Console.ReadLine();
                        break;
                
                case "2":
                    Handler.DisplayAll(); 
                    break;
                
                case "3":
                    //SessionIsActive = false;
                    Environment.Exit(0);
                    break;
            }
        }

        public void Displayinfo()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\matte\Downloads\Demotext.txt");

            Console.WriteLine($"This program was created for demo purpose!\n{text}" +
                "");
        }
    }
}
