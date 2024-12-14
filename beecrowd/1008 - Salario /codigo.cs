using System; 

class URI {

    static void Main(string[] args) { 
        int numero = int.Parse(Console.ReadLine());
        int salarioDoFuncionario = int.Parse(Console.ReadLine());
        double horasTrabalhadas = double.Parse(Console.ReadLine());
        
        double salarioTotalFuncionario = salarioDoFuncionario * horasTrabalhadas;
        
        Console.WriteLine($"NUMBER = {numero}\nSALARY = U$ {salarioTotalFuncionario}");
        
        

    }

}
