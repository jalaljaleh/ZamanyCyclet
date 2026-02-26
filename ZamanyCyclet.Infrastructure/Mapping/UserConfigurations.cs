using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZamanyCyclet.Domain;

namespace ZamanyCyclet.Infrastructure
{
    public class UserConfigurations : EntityTypeConfiguration<User>
    {
        public UserConfigurations()
        {
            ToTable("Users");

            Property(a => a.Id)
                   .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.DisplayName)
                .HasMaxLength(40)
                .IsOptional();

            Property(a => a.Username)
                .HasMaxLength(40)
                .IsRequired();

            Property(a => a.Password)
            .HasMaxLength(40)
            .IsRequired();
        }
    }
}
