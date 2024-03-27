using Gesition_Commercial;

class Program
{
    static void Main(string[] args)
    {
        Categorie cat1 = new Categorie("chef", "1");
        Categorie cat2 = new Categorie("adjoint", "2");
        Categorie cat3 = new Categorie("employé", "3");

        Service s1 = new Service("international");
        Service s2 = new Service("National");

        Commercial c1 = new Commercial("Dupont", "Jean", 1990,cat3,s1);
        Commercial c2 = new Commercial("Dupont", "Marie", 1985,cat3,s2);
        Commercial c3 = new Commercial("Portgas","ace",2000,cat2,s2);
        Commercial c4 = new Commercial("hhhhh", "Victor", 1999, cat3,s1);
        Commercial c5 = new Commercial("KLM", "JOE", 2010, cat1,s2);



        Console.WriteLine("=======================================");
        Console.WriteLine(" voici les infos du " + s1);
        Console.WriteLine("=======================================");
        Console.WriteLine(" voici les infos du " + s2);
        Console.WriteLine("=======================================");
        


        c1.Compare(c2);

        Console.ReadLine();
    }
}