using Microsoft.EntityFrameworkCore;



namespace INvasjonNorge.API.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Active Wear - Men" },
                new Category { Id = 2, Name = "Active Wear - Women" },
                new Category { Id = 3, Name = "Mineral Water" },
                new Category { Id = 4, Name = "Publications" },
                new Category { Id = 5, Name = "Supplements" });

            Microsoft.EntityFrameworkCore.Metadata.Builders.DataBuilder<Company> dataBuilder = modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1000, CategoryId = 1, Name = "Google", Advisor = "Adam Smith", Gender = "Male", MeetingDate = "2021-10-01", Subscriber = "1200", IsAvailable = true },
                new Company { Id = 1500, CategoryId = 2, Name = "Hulu", Advisor = "Andy Benji", Gender = "Male", MeetingDate = "2021-10-10", Subscriber = "3200", IsAvailable = true },
                new Company { Id = 2500, CategoryId = 3, Name = "Disney", Advisor = "Adam Smith", Gender = "Male", MeetingDate = "2021-10-13", Subscriber = "5000", IsAvailable = true },
                new Company { Id = 3234, CategoryId = 4, Name = "Amazone", Advisor = "Gro Harlem", Gender = "Female", MeetingDate = "2021-10-16", Subscriber = "7000", IsAvailable = true },
                new Company { Id = 5235, CategoryId = 5, Name = "Apple", Advisor = "Stevie Jobsy", Gender = "Female", MeetingDate = "2021-10-24", Subscriber = "2000", IsAvailable = true },
                new Company { Id = 6533, CategoryId = 6, Name = "Wired", Advisor = "Ines Awsome", Gender = "Female", MeetingDate = "2021-10-31", Subscriber = "3000", IsAvailable = true });


            Microsoft.EntityFrameworkCore.Metadata.Builders.DataBuilder<User> dataBuilder1 = modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Email = "adam@example.com" },
                new User { Id = 2, Email = "barbara@example.com" });

        }
    }
}
