




namespace array_collections
{

    class Program { 

        static void Main(string[] args)
        {

            // string[] s = new String[4];
            //    s[0] = "sss";


            //   List<string> s2 = new List<string>();

            // s[0] = "Danilo";
            //  s[1] = "Sheila";
            //  s[2] = "Lana";

            //   Array.Sort(s);


            // foreach(string nome in s)
            //  {
            //     Console.WriteLine(nome);
            // }






             string[] s2 = new String[4];

             s2[0] = "Marcelo1";
             s2[1] = "Marcelo2";
             s2[2] = "Marcelo3";


            if(Array.Exists(s2, e => e == "Marcelo1"))
            {
                Console.WriteLine("Existe o Marcelo 1 no meu Array");
            }


            int size = s2.Length;

            List<string> s = new List<string>();
            
            s.Add("Marcelo");
            s.Add("Sheila");
            s.Add("Lana");

      //      Console.WriteLine(s[0]);

            foreach(string nome in s)
            {
                Console.WriteLine(nome);
            }

            if (s.Exists(e => e == "Marcelo"))
            {
                Console.WriteLine("Existe o Marcelo no meu Collection");
            }

            s.ToArray();

            int size_list = s.Count;

            Console.Read();
        }

    }

}