namespace ClassLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Human human1 = new("Veli", "Memmedov", 15, "Baku");
            Human human2 = new("Pirveli", "Memmedov", 20, "Xizi");
            Human human3 = new("Eli", "Memmedov", 25, "Lerik");
            Human human4 = new("Gunay", "Memmedova", 32, "Baku");
            Human human5 = new("Sehran", "Memmedova", 18, "Xizi");

            //Console.WriteLine(human1.IsStudent());
            //Console.WriteLine(human2.IsStudent());
            //Console.WriteLine(human3.IsStudent());
            //Console.WriteLine(human4.IsStudent());

            string[] cities = { human1.City, human2.City, human3.City, human4.City, human5.City };

            Human[] humans = { human1, human2, human3, human4, human5 };

            //human1.CheckCity(human2.City);

            //human1.CheckCity2(humans);


            human1.GetCount(humans);
        }
    }
}
