List<Page>VarPages = new List<Page>();

Page side1 = new Page(MyNotes.Variables);

VarPages.Add(side1);

List<Page>IntPages = new List<Page>();

Page side2 = new Page(MyNotes.integer1);
Page side3 = new Page(MyNotes.integer2);

IntPages.Add(side2); IntPages.Add(side3);



Chapter kap1 = new Chapter("Variables");
kap1.Pages = VarPages;

Chapter kap2 = new Chapter("Integers");
kap2.Pages = IntPages;

List<Chapter> chapters = new List<Chapter>();
chapters.Add(kap1);
chapters.Add(kap2);

Book mybook = new Book("Programming notes",chapters);


mybook.Start();       
    


