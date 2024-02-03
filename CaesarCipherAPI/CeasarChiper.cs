namespace MyApp
{
    public static class CaesarCipher
    {
        public static string Encrypt(string plainText, int shift)
        {
            char[] result = plainText.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsLetter(result[i]))
                {
                    char offset = char.IsUpper(result[i]) ? 'A' : 'a';
                    result[i] = (char)(((result[i] + shift - offset) % 26 + 26) % 26 + offset);
                }
            }

            return new string(result);
        }

        public static string Decrypt(string cipherText, int shift)
        {
            char[] result = cipherText.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsLetter(result[i]))
                {
                    char offset = char.IsUpper(result[i]) ? 'A' : 'a';
                    result[i] = (char)(((result[i] - shift - offset + 26) % 26 + 26) % 26 + offset);
                }
            }

            return new string(result);
        }
    }
}
