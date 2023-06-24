namespace MyApp
{
    enum month{
        jan,
        feb,
        march,
        apr,
        may
    }

    class Person {
        public string name;
        public Person(string _name){
            name = _name;
        }
    }
    class DataStore<W>{
        // public T Data { get; set; }  //prop
        private W[] _data1 = new W[10];  //Attribute  W jense araaye _data1 e

        public void AddOrUpdate(int index, W item)
        {
            if (index >= 0 && index < 10)
                _data1[index]=item;
        }
        public W GetData(int index)  //be dast avordane data
        {
            return _data1[index];
        }
    }

    class KeyValues<TKey, TValue>
    {
        public TKey klid { get; set; }
        public TValue etebar { get; set; }
    }

    class Program{
        static void Main(string[] args){
            
            // Person p1 = new Person("jafar")

            // DataStore<string> store = new DataStore<string>();
            // DataStore<int> store2 = new DataStore<int>();

            // store.Data = "my name is csharp";

            // Console.WriteLine(store.Data);

            KeyValues<string,int> obj1 = new KeyValues<string, int>();
            obj1.klid="k";
            obj1.etebar=2;
            

            Console.WriteLine((int)month.apr);
            DataStore<string> _name=new DataStore<string>();
            for(int i=0; i<10; i++)
            {
                string temp= Console.ReadLine();
                _name.AddOrUpdate(i,temp);
            }

            _name.AddOrUpdate(1,"ali");
            _name.GetData(1);

           System.Console.WriteLine(_name.GetData(1)); 

        
        }
    }
}

