using Kros.KORM;
using Kros.KORM.Metadata;
using Sample.KormAutoincrement.Domains;

namespace Sample.KormAutoincrement.Infrastructure
{
    public class DatabaseConfiguration: DatabaseConfigurationBase
    {
        public override void OnModelCreating(ModelConfigurationBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasTableName("Users")
                .HasPrimaryKey(f => f.Id)
                .AutoIncrement(autoIncrementType: AutoIncrementMethodType.Identity);
        }
    }
}
