using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW4.Entity;

namespace Module4HW4.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<ClientEntity>
    {
        public void Configure(EntityTypeBuilder<ClientEntity> builder)
        {
            builder.ToTable("Client").HasKey(p => p.ClientId);
            builder.Property(p => p.ClientId).ValueGeneratedOnAdd();
            builder.HasData(new ClientEntity[]
            {
                new ClientEntity { ClientId = 1, FirstName = "Vadim", SecondName = "Bilyi", Birthday = new DateTime(2001,12,2), Language = "UA" },
                new ClientEntity { ClientId = 2, FirstName = "Dima", SecondName = "Yampolskiy", Birthday = new DateTime(2001,12,12), Language = "UA" },
                new ClientEntity { ClientId = 3, FirstName = "Dima", SecondName = "Menshakov", Birthday = new DateTime(2000,11,24), Language = "UA" },
                new ClientEntity { ClientId = 4, FirstName = "Roma", SecondName = "Momot", Birthday = new DateTime(2001,6,22), Language = "RU" },
                new ClientEntity { ClientId = 5, FirstName = "Sergay", SecondName = "Naimutenko", Birthday = new DateTime(2001,8,2), Language = "UA" }
            }
            );
        }
    }
}