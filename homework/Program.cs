using System;
public class Program{
    public static void Main(string[] args){
        Shop info = new Shop();
        info.InputName();
        info.InputNumber();
        info.InputOwner();
        info.InputValue();

        PrintInformation(info);
}
    
    public static void PrintInformation(Shop shop){
    Console.WriteLine("—--------- Shop Information —-----");
    Console.WriteLine("Name : {0}",shop.InputName);
    Console.WriteLine("Number : {0}",shop.InputNumber);
    Console.WriteLine("Owner Name : {0} ",shop.InputOwner);
    Console.WriteLine("Registered Value : {0}",shop.InputValue);
    Console.WriteLine("—-----------------------------------------------------");
}
}
