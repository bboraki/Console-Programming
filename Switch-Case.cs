﻿using System;

public class Class5
{
	public Class5()
	{
        int month = DateTime.Now.Month;

        switch(month) // expression
        {
            case 1:
                Console.WriteLine("Ocak ayındasınız.");
                break;
           
            case 2:
                Console.WriteLine("Şubat ayındasınız");
                break;
            
            case 3:
                Console.WriteLine("Nisan ayındasınız.");
                break;
           
            case 4:
                Console.WriteLine("Mart ayındasınız.");
                break;
            
            default:
                Console.WriteLine("Geçerli bir ay değil!"); 
                break;
           
        }

        int monthGroup = DateTime.Now.Month;

        switch(monthGroup)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kış geldi.");
                break;

            case 3:
            case 4:
            case 5:
                Console.WriteLine("İlkbahar geldi.");
                break;

            case 6:
            case 7:
            case 8:
                Console.WriteLine("Yaz geldi.");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sonbahar geldi.");
                break;
        }
	}
}
