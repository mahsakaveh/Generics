namespace MyApp{
     public class DataStore<W>{
        // public T Data { get; set; }  //prop
        private W[] _data1 = new W[10];  //Attribute W jense araaye _data1 e

        public void AddOrUpdate(int index, W item)
        {
            if (index >= 0 && index < 10)
                _data1[index]=item;
        }
        public W GetData(int index)  //Be dast avordane data
        {
            return _data1[index];
        }
    }

    public class KeyValues<TKey, TValue>
    {
        public TKey klid { get; set; }
        public TValue etebar { get; set; }
    }
}