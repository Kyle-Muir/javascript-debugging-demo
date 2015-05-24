using System;

namespace JavaScriptDebuggingDemoWebApi.Domain
{
    public static class StringGenerator
    {
        public static string CreateString(int seed, int stringLength)
        {
            const string allowedCharacters = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789!@$?_-";
            char[] characters = new char[stringLength];
            Random random = new Random(seed);

            for (int i = 0; i < stringLength; i++)
            {
                characters[i] = allowedCharacters[random.Next(0, allowedCharacters.Length)];
            }

            return new string(characters);
        } 
    }
}