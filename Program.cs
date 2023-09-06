List<Page>VarPages = new List<Page>(){
    new Page(MyNotes.Variables)
    };





List<Page>IntPages = new List<Page>(){
new Page(MyNotes.integer1),
new Page(MyNotes.integer2),
new Page(MyNotes.integer3),
new Page(MyNotes.integer4),
new Page(MyNotes.integer5)
};


List<Page>FloatPages = new List<Page>(){
new Page(MyNotes.float1),
new Page(MyNotes.float2),
new Page(MyNotes.float3),
new Page(MyNotes.float4),
new Page(MyNotes.float5)
};


List<Page>BoolPages = new List<Page>(){
new Page(MyNotes.bool1),
new Page(MyNotes.bool2),
new Page(MyNotes.bool3),
new Page(MyNotes.bool4),
new Page(MyNotes.bool5),
};


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
    


