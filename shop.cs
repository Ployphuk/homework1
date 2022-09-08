using System;
public class Shop{
    public string InputName(){
        Console.Write("Please input Name: ");
        return Console.ReadLine();
    }

    public long InputNumber(){
        Console.Write("Please input Number: ");
        return long.Parse(Console.ReadLine());
    }

    public string InputOwner(){
        Console.Write("Please input Owner Name : ");
        return Console.ReadLine();
    }

    public long InputValue(){
        Console.Write("Pleas input Registered Value : ");   
        return long.Parse(Console.ReadLine());
    }
}