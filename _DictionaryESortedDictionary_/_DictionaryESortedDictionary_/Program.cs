using System;
using System.Collections.Generic;

namespace _DictionaryESortedDictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            //DICTIONARY[KEY]
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "maria"; //Cookies na chave "user" recebe "maria" 
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234"; //Esse valor é sobreescrito pelo próximo valor
            cookies["phone"] = "52842158"; //Esse valor sobreescreve encima da key phone
            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]); //Imprime 52842158

            cookies.Remove("email");
            //Console.WriteLine(cookies["email"]); //Erro, Tentando acessar uma chave que não existe
            if (cookies.ContainsKey("email"))//false
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("Nada encontrado no key 'email' ");//Exibe essa mensagem
            }

            //Testando o tamanho do Dictionary
            Console.WriteLine("Size: "+cookies.Count); //2 -> user, phone
            Console.WriteLine("Todos os cookies: ");
            
            //Percorrendo o Dictionary
            foreach (KeyValuePair<string, string> item in cookies)
            { //Para cada item do tipo KeyValuePair, Estou percorrendo cada um dos pares do tipo string, string
                Console.WriteLine(item.Key + ": " +item.Value); //Imprimindo a chave e o valor 
            }
                
        }
    }
}
