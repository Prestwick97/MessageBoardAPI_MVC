using Microsoft.EntityFrameworkCore;
using System;

namespace MessageBoard.Models
{
  public class MessageBoardContext : DbContext
  {
    public MessageBoardContext(DbContextOptions<MessageBoardContext> options)
    : base(options)
    {
    }

    public DbSet<Message> Messages { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
  builder.Entity<Message>()
      .HasData(
          new Message { MessageId = 1, Content = "where the tp", Group = "Shopping Boi's", UserName = "Female"},
          new Message{ MessageId = 2, Content = "Pip", Group = "Shark", UserName="leggo"},
          new Message { MessageId = 3, Content = "Bartholomew's fancy hats", Group = "Shark", UserName = "noodle_boi_hat"},
          new Message { MessageId = 4, Content = "Pip", Group = "Shopping Boi's", UserName = "noodle_boi_hat"},
          new Message { MessageId = 5, Content = "doppledonger", Group = "Firework Sales", UserName = "Female"},
          new Message { MessageId = 6, Content = "bart", Group = "Shark", UserName = "Female"},
          new Message { MessageId = 7, Content = "bart", Group = "Firework Sales", UserName = "leggo"}
      );
    }
  }
}

          // new Message { MessageId = 1, Content = "where the tp", Group = "Shopping Boi's", UserName = "Female", PostDate = DateTime.Parse("06-05-2015") },
          // new Message{ MessageId = 2, Content = "Pip", Group = "Shark", UserName="leggo", PostDate = DateTime.Parse("02-03-2020")},
          // new Message { MessageId = 3, Content = "Bartholomew's fancy hats", Group = "Shark", UserName = "noodle_boi_hat", PostDate = DateTime.Parse("12-01-2017") },
          // new Message { MessageId = 4, Content = "Pip", Group = "Shopping Boi's", UserName = "noodle_boi_hat", PostDate = DateTime.Parse("01-15-2019") },
          // new Message { MessageId = 5, Content = "doppledonger", Group = "Firework Sales", UserName = "Female", PostDate = DateTime.Parse("06-15-20") },
          // new Message { MessageId = 6, Content = "bart", Group = "Shark", UserName = "Female", PostDate = DateTime.Parse("06-15-20") },
          // new Message { MessageId = 7, Content = "bart", Group = "Firework Sales", UserName = "leggo", PostDate = DateTime.Parse("05-20-2019") }