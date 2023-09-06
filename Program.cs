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


List<Page>FloatPages = new List<Page>();

Page side7 = new Page(MyNotes.float1);
Page side8 = new Page(MyNotes.float2);
Page side9 = new Page(MyNotes.float3);
Page side10 = new Page(MyNotes.float4);
Page side11 = new Page(MyNotes.float5);

FloatPages.Add(side2); FloatPages.Add(side3); 
FloatPages.Add(side4); FloatPages.Add(side5);
FloatPages.Add(side6);

List<Page>BoolPages = new List<Page>();

Page side12 = new Page(MyNotes.bool1);
Page side13 = new Page(MyNotes.bool2);
Page side14 = new Page(MyNotes.bool3);
Page side15 = new Page(MyNotes.bool4);
Page side16 = new Page(MyNotes.bool5);

BoolPages.Add(side12); BoolPages.Add(side13);
BoolPages.Add(side14); BoolPages.Add(side15);
BoolPages.Add(side16);

Chapter kap1 = new Chapter("Variables");
kap1.Pages = VarPages;

Chapter kap2 = new Chapter("Integer");
kap2.Pages = IntPages;

Chapter kap3 = new Chapter("Float");
kap3.Pages = FloatPages;

Chapter kap4 = new Chapter("Bool");
kap4.Pages = BoolPages;

List<Chapter> chapters = new List<Chapter>();
chapters.Add(kap1);
chapters.Add(kap2);
chapters.Add(kap3);
chapters.Add(kap4);


Book mybook = new Book("Programming notes",chapters);
mybook.Start();       
    


