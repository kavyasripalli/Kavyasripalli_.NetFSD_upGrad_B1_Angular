using System;
using System.Collections.Generic;

class Assignment4
{
    public static void Run()
    {
        Stack<string> actions = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();

        // push actions
        actions.Push("Type A");
        actions.Push("Type B");
        actions.Push("Delete B");
        actions.Push("Type C");
        actions.Push("Save File");

        Console.WriteLine("Undo last 3 actions:");
        for (int i = 0; i < 3; i++)
        {
            if (actions.Count > 0)
            {
                string act = actions.Pop();
                Console.WriteLine("Undo: " + act);
                redoStack.Push(act);
            }
        }

        Console.WriteLine("\nCurrent Top Action:");
        if (actions.Count > 0)
            Console.WriteLine(actions.Peek());

        // bonus - redo
        Console.WriteLine("\nRedo actions:");
        while (redoStack.Count > 0)
        {
            string act = redoStack.Pop();
            Console.WriteLine("Redo: " + act);
            actions.Push(act);
        }
    }
}