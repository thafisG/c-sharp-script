using System;
using System.Data.SqlClient; // Simulando conexão com BD

class Program
{
    // String para conexão
    static string connectionSQL = "simulacao";

    // Classe principal para rodar tudo
    static void Main(string[] args)
    {
        CriarProduto("fusca", 1.8m);
        CriarProduto("rosa", 1.4m);

        LerProduto();

        AtualizarProduto(1, "fusca2", 1.3m);

        DeletarProduto(1);
    }

    // Método para criar produto
    static void CriarProduto(string nome, decimal preco)
    {
        // Simulando conexão
        using (SqlConnection conn = new SqlConnection(connectionSQL))
        {
            conn.Open();

            // Comando SQL correto para inserir
            string query = "INSERT INTO Produtos (Nome, Preco) VALUES (@nome, @preco)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.ExecuteNonQuery(); // Executa o comando

            Console.WriteLine($"Produto {nome} criado com sucesso!");
        }
    }

    // Função para ler os produtos
    static void LerProduto()
    {
        using (SqlConnection conn = new SqlConnection(connectionSQL))
        {
            conn.Open();
            // Comando SQL para buscar os produtos
            string query = "SELECT Id, Nome, Preco FROM Produtos";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader(); // Executa e lê os resultados

            Console.WriteLine("Lista de Produtos:");

            while (reader.Read())
            {
                Console.WriteLine($"ID: {reader["Id"]}, Nome: {reader["Nome"]}, Preço: {reader["Preco"]}");
            }
        }
    }

    // Método para atualizar produto
    static void AtualizarProduto(int id, string novoNome, decimal novoPreco)
    {
        using (SqlConnection conn = new SqlConnection(connectionSQL))
        {
            conn.Open();
            // Comando SQL para atualizar
            string query = "UPDATE Produtos SET Nome = @nome, Preco = @preco WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome", novoNome);
            cmd.Parameters.AddWithValue("@preco", novoPreco);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery(); // Executa o comando

            Console.WriteLine($"Produto {id} atualizado com sucesso!");
        }
    }

    // Método para deletar produto
    static void DeletarProduto(int id)
    {
        using (SqlConnection conn = new SqlConnection(connectionSQL))
        {
            conn.Open();
            // Comando SQL para deletar
            string query = "DELETE FROM Produtos WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            Console.WriteLine($"Produto {id} deletado com sucesso!");
        }
    }
}
