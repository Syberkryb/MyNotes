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


List<Page>StringPages = new List<Page>(){
new Page(MyNotes.string1),
new Page(MyNotes.string2),
new Page(MyNotes.string3),
new Page(MyNotes.string4),
new Page(MyNotes.string5),
};


Chapter kap1 = new Chapter("Variables");
kap1.Pages = VarPages;

Chapter kap2 = new Chapter("Integer");
kap2.Pages = IntPages;

Chapter kap3 = new Chapter("Float");
kap3.Pages = FloatPages;

Chapter kap4 = new Chapter("Bool");
kap4.Pages = BoolPages;

Chapter kap5 = new Chapter("String");
kap5.Pages = StringPages;

List<Chapter> chapters = new List<Chapter>()
{kap1,kap2,kap3,kap4,kap5};



Book mybook = new Book("Programming notes",chapters);
mybook.Start();       
    


