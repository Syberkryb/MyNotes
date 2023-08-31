List<Page>VarPages = new List<Page>();

Page side1 = new Page(MyNotes.Variables);
Page side2 = new Page(MyNotes.integer);

VarPages.Add(side1);



Chapter kap1 = new Chapter("Var");
kap1.Pages = VarPages;

Chapter kap2 = new Chapter("Var2");


List<Chapter> chapters = new List<Chapter>();
chapters.Add(kap1);
chapters.Add(kap2);

Book mybook = new Book("Programming notes",chapters);


Console.Clear();
        Console.WriteLine("I denne bog kommer du til at lære om nogle af de forskellige varibler i C#");
        Console.WriteLine(chapters);
        Console.WriteLine("Her er en liste over kapitlerne:");
       
    


Console.ReadLine();