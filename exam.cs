namespace MyApp
{
    public class Student{
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int age { get; set; }
    }
    class exam
    {
        //anonymous type
        IList<Student> studentsList = new List<Student>(){
            new Student() { StudentID = 1, StudentName = "mahdi", age = 12},
            new Student() { StudentID = 2, StudentName = "Sara",  age=13}
        };
        
        public void show(){
            var students = from s in studentsList select new {Id = s.StudentID, Name = s.StudentName};
            foreach (var stu in students)
            {
                Console.WriteLine(stu.Id + " - " + stu.Name);
            }
        }

        // 1-mahdi
        // 2-Sara
        
        string[] names = {"ali", "mahsa", "sara"}; 
        // ali liked your post
        // ali and mahsa liked your post
        // ali, mahsa and sara liked your post
        // ali, mahsa and 9 others liked your post
        
        public void function()
        {
            int l = this.names.Length;

            // if (l == 1){
            //     Console.WriteLine($"{this.names[0]} liked your post");
            // } 
            // else if(l==2){
            //     System.Console.WriteLine($"{this.names[0]} and {this.names[1]} liked your post ");
            // }
            // else if(l==3){
            //     System.Console.WriteLine($"{this.names[0]} and {this.names[1]} and {this.names[2]} liked your post ");
            // }
            //  else {
            //     System.Console.WriteLine($"{this.names[0]} and {this.names[1]} and {l-2} liked your post ");
            // }

            var res = new[] {
                new { ans = $"{this.names[0]} liked your post"}, 
                new { ans = $"{this.names[0]} and {this.names[1]} liked your post "}, 
                new { ans = $"{this.names[0]} and {this.names[1]} and {this.names[2]} liked your post "}, 
                new { ans = $"{this.names[0]} and {this.names[1]} and {l-2} liked your post"}
                }; 



                if (l < 4){
                    Console.WriteLine(res[l-1].ans);
                } else if (l>=4){
                    Console.WriteLine(res[3].ans);
                }

                // if(l == 1)
                // {
                //     Console.WriteLine(res.l_1);
                // }


            // var students = new[] {
            //     new {Id = 1, FirstName = "ali", LastName = "ahmadi"},
            //     new {Id=2, FirstName="sara", LastName="akbari"},
            //     new {Id=3, FirstName="reza", LastName="asghari"},
            // };

            // Console.WriteLine(students[2].FirstName);
        }

       
    }
    
}



