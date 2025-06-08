using System; 

class URI {

    static void Main(string[] args) {
    
        double total = 0.0;
        bool continua = true;

        while (continua) {
            string entrada1 = Console.ReadLine();

            if (string.IsNullOrEmpty(entrada1)) {
                continua = false;
            }
            else {
                string[] partes = entrada1.Split(' ');

                int codigo = int.Parse(partes[0]);
                int quantidade = int.Parse(partes[1]);
                double valorUnitario = double.Parse(partes[2]);

                total += quantidade * valorUnitario;
            }
        }

        Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");

      
    }

}
