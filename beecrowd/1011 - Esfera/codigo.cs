using System; 

class URI {

    static void Main(string[] args) { 
        
    double pi = 3.14159;

    double num = double.Parse(Console.ReadLine());

    double resultado = (4.0 / 3) * pi * Math.Pow(num, 3);
    
    Console.WriteLine($"VOLUME = {resultado:F3}");
    
    }
}
