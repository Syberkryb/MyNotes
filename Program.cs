List<Page>VarPages = new List<Page>();

Page side1 = new Page(MyNotes.Variables);
Page side2 = new Page(MyNotes.integer1);
Page side3 = new Page(MyNotes.integer2);

VarPages.Add(side1);



Chapter kap1 = new Chapter("Variables");
kap1.Pages = VarPages;

Chapter kap2 = new Chapter("Var2");


List<Chapter> chapters = new List<Chapter>();
chapters.Add(kap1);
chapters.Add(kap2);

Book mybook = new Book("Programming notes",chapters);


mybook.Start();       
    


