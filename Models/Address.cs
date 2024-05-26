using System.ComponentModel.DataAnnotations;

namespace RunGroopWebApp.Models
{
   public class Address
   {
      [Key]
      public int Id { get; set; }
      public string Street { get; set; }
      public string City { get; set; }
      public string State { get; set; }


      public override string ToString()
      {
         return $"""Street:{Street}, City:{City}, State: {State}""";
      }
   }
}