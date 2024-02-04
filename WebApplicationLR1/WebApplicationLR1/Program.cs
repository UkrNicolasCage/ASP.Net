namespace WebApplicationLR1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            Company company = new Company
            {
                CompanyName = "TechInnovators",
                CompanyAddress = "123 Some Street, Kyiv, Ukraine",
                CompanyIndustry = "Information Technology",
                CompanyProductsOrServices = new List<string>
            {
                "Software Development",
                "Web Design",
                "IT Consulting"
            }
            };

            Random random = new Random();
            int randomInRange = random.Next(101);

            app.MapGet("/", () => $"{company.CompanyName}\n{company.CompanyAddress}\n{company.CompanyIndustry}\n{string.Join(", ", company.CompanyProductsOrServices)}\n{"Random number: " + randomInRange.ToString()}");

            app.Run();
        }
    }
}