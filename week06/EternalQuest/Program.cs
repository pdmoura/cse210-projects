using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
         // Creates a new "GoalManager" object to control everything
        GoalManager manager = new GoalManager();
        // Starts the main loop (menu and actions)
        manager.Start();
    }
}
