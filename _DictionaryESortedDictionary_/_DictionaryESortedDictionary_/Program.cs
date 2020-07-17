using System;
using System.Collections.Generic;

namespace _DictionaryESortedDictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "maria"; //Cookies na chave "user" recebe "maria"
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234"; //Esse valor é sobreescrito pelo próximo valor
            cookies["phone"] = "52842158"; //Esse valor sobreescreve encima da key phone

            Console.WriteLine(cookies["phone"]);
        }
    }
}
