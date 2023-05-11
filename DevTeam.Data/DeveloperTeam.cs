//ctrl + b -> hide explorer

    public class DeveloperTeam
    {
        // start with empty constructor

        public DeveloperTeam() {  }

        // make partial constructor
        public DeveloperTeam(string teamName)
        {
            TeamName = teamName;
        }

        //full Constructor

        public DeveloperTeam(string teamName, List<Developer> developers)
        {
            TeamName = teamName;
            Developers = developers;
        }
        //[Key]
       public int ID { get; set; }
       public string TeamName { get; set; } = string.Empty;

        //obt type is always singular e.g Developer while 
        //variable container can be plural e.g Developers
       public List<Developer> Developers { get; set; } = new List<Developer>();

       public override string ToString()
       {
        var str = $"TeamId: {ID}\n" +
                  $"TeamName: {TeamName}\n" +
                  $"-------   Team Members --------\n";
                  foreach (Developer dev in Developers)
                  {
                    str += dev + "\n";
                  }

                  return str;
       }

       
    }
