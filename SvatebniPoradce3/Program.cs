﻿using System;

class MainClass {
    public static void Main (string[] args) {
    
        // Nastavte si proměnné
        bool jeStary = true;
        bool jeHezky = false;
        bool jeChudy = true;
    
        // tuto podmínku je třeba doplnit
        if (jeHezky || jeStary && !jeChudy )
            // zde končí úpravy
        {
            Console.WriteLine("Vezmi si ho!");
        }
        else
        {
            Console.WriteLine("Toho si neber!");
        }
    

    }
}