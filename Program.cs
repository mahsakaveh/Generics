namespace MyApp
{ 
    enum month{
        jan,
        feb,
        march,
        apr,
        may
    }

    class Program{
        static public void Main(string[] args){

      BookStore<string, string> b1= new BookStore<string, string>();
      b1.AddOrUpdate(1,"Harry","JK");
      b1.getBooks(1);


            exam exam1= new exam();
            exam1.function();
        

        
            exam ex1=new exam();
            ex1.show();

            // Person p1 = new Person("jafar")

            // DataStore<string> store = new DataStore<string>();
            // DataStore<int> store2 = new DataStore<int>();

            // store.Data = "my name is csharp";

            // Console.WriteLine(store.Data);

            KeyValues<string,int> obj1 = new KeyValues<string, int>();
            obj1.klid="k";
            obj1.etebar=2;
            

            //Console.WriteLine((int)month.apr);
            DataStore<string> _name=new DataStore<string>();
            for(int i=0; i<2; i++)
            {
                string temp= Console.ReadLine();
                _name.AddOrUpdate(i,temp);
            }

            _name.AddOrUpdate(1,"ali");
            _name.GetData(1);

           System.Console.WriteLine(_name.GetData(1)); 


           var ann_obj = new {s_id = 123, s_name = "max", language = "python"}; //anonymous Type
           var ann_obj1= new {s_id=456, s_name="sara", language= new {lang1="C#", lang2="HTML", lang3="Java"}};

           //mymethod(ann_obj);
           //mymethod(ann_obj1);
        }
    }
}

