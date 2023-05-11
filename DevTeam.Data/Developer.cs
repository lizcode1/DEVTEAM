
namespace DevTeam.Data

//P.O.C.O -> Plain old cSharp object
//Domain object

{
    public class Developer
    {

      public Developer()
      {
         
      }

      public Developer(string firstName,string lastName, bool hasPluralsight)
      {
         FirstName = firstName;
         LastName = lastName;
         HasPluralsight = hasPluralsight;
      }
      
     //We need a primary key
     public int ID { get; set; }
     public string FirstName { get; set; } = string.Empty;
     public string LastName { get; set; } = string.Empty;
     public string FullName 
     {
         get 
         {
            return $"{FirstName} {LastName}";
         }
      
     }
     public bool HasPluralsight { get; set; }

    // Eveytime I DO Developer.ToString, I WANT TO BE ABLE TO POPULATE THE
    //DEVELOPERS'S ID, F/lName and weather or not they have HasPluralsight
    //This is step is optional though 
     public override String ToString()
     {
        
        var str = $"ID: {ID}\n"+
                  $"Full Name: {FullName}"+
                  $"Has Pluralsight Access: {HasPluralSight}\n" +
                  "==========================================\n";

        return str;
     }


     }        
    
}