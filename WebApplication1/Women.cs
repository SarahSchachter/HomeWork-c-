namespace WebApplication1
{
    public class Women
    {
        public int Id { get; set; }
        public   string Name { get; set; }
        public int Age { get; set; }
        public   string Cors { get; set; }

        public Women(int id,string name,int age,string cors) { 
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Cors = cors;
        }

    }
}
