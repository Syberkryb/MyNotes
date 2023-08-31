List<Page>pages = new List<Page>();

Page side1 = new Page(MyNotes.VariablesPageOne);
Page side2 = new Page(MyNotes.VariablesPageTwo);

pages.Add(side1);
pages.Add(side2);


Chapter kap1 = new Chapter("Var");
kap1.Pages = pages;
Chapter kap2 = new Chapter("Var2", pages);

kap1.Read();
kap2.Read();

List<Chapter> chapters = new List<Chapter>();
chapters.Add(kap1);
chapters.Add(kap2);

Book mybook = new Book("Programming notes",chapters);


//pause
Console.ReadLine();