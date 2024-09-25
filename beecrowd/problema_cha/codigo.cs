using System; 

class URI {

    static void Main(string[] args) { 
        
        int tipoCha = int.Parse(Console.ReadLine());

        // respostas
        string[] entradas = Console.ReadLine().Split(' ');
        int[] respostas = Array.ConvertAll(entradas, int.Parse);

        int acertos = 0;
        foreach (int resposta in respostas)
        {
            if (resposta == tipoCha)
            {
                acertos++;
            }
        }

        Console.WriteLine(acertos);

    }

}
