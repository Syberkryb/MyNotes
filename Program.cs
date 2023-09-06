List<Page>VarPages = new List<Page>();

Page side1 = new Page(MyNotes.Variables);

VarPages.Add(side1);

List<Page>IntPages = new List<Page>();

Page side2 = new Page(MyNotes.integer1);
Page side3 = new Page(MyNotes.integer2);
Page side4 = new Page(MyNotes.integer3);
Page side5 = new Page(MyNotes.integer4);
Page side6 = new Page(MyNotes.integer5);

IntPages.Add(side2); IntPages.Add(side3); 
IntPages.Add(side4); IntPages.Add(side5);
IntPages.Add(side6);

Chapter kap1 = new Chapter("Variables");
kap1.Pages = VarPages;

Chapter kap2 = new Chapter("Integers");
kap2.Pages = IntPages;

List<Chapter> chapters = new List<Chapter>();
chapters.Add(kap1);
chapters.Add(kap2);

Book mybook = new Book("Programming notes",chapters);


mybook.Start();       
    


