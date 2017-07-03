using System.Data.Entity;

namespace DatabaseClassLibrary
{
    public class DataContext : DbContext
    {
        public DataContext() : base("WindowsNavigator")
        {
            if (!Database.Exists("WindowsNavigator"))
            {
                Database.SetInitializer(new DropCreateDatabaseAlways<DataContext>());
            }
        }
        public DbSet<ButtonInfo> buttonInfo { get; set; }
    }
}
