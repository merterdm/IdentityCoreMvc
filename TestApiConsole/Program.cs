namespace TestApiConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var jsonToken = WebApiService.GetToken("ali@gmail.com", "123").Result;
            //Token token = JsonConvert.DeserializeObject<Token>(jsonToken);


            Console.WriteLine(jsonToken);

        }
    }
}