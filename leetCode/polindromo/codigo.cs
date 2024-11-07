public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) {
            return false; // caso base
        }

        string numero = x.ToString();
        
        char[] charArray = numero.ToCharArray();
        Array.Reverse(charArray);
        string numero_invertido = new string(charArray);

        // Compara o número original com o número invertido
        return numero == numero_invertido;
    }
}
