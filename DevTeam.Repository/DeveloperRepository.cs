
    public class DeveloperRepository 
    {
        public DeveloperRepository()
        {
            Seed ();
        }

     // we need a variable container that will hold the collection of Developers 
     private List<Developer>  _developerDb = new List<Developer>();
     // we need to autoincreament the developer Id
     private int _count = 0;

     //C.R.U.D

     //create
     public bool AddDeveloper(Developer developer)
     {

        if(developer is null)
        {
             return false; 
        }
     else
        {
            // increment the _count
              _count++;
        
             //assign the developerId to _count
            developer.ID = _count;

            //save to the database
            _developerDb.Add(developer);

            return true;

        }
     }

     //Read All
     public List<Developer> GetDevelopers() 
     {
        return _developerDb;
     }
     
     //Read by Id

     public Developer GetDeveloperById(int developerId)
     {
        //look thru the whole database
        foreach (var developer in _developerDb)
        {
            //check if developer have a matching id
            if(developer.ID == developer)
            {
                return developer;
            }

        }
     }

     //Update
     public bool UpdateDeveloper(int developerId, Developer )
     {
        //lets check if the dev exist
        Developer oldDevData = GetDeveloperById(developerId);
        
        //so if we actually have data
        if(oldDevData != null)
        {
            //this is where update our values....
            oldDevData.FirstName = newDevData.FirstName;
            oldDevData.LastName = newDevData.LastName;
            oldDevData.HasPluralsight = newDevData.HasPluralsight;
            //after values have been updated....
            return true;
        }
        //if old devdata retruns null....
        return false;
     }

    


     //Delete

     public bool DeleteDeveloper(int developerId)

        //developers w/o pluralsight license

        public List<Developer> GetDeveloperswithoutPluralsight()
        {
            //1. we need an empty list
            List<Developer> devsWithoutPS = new List<Developer>();
            //2. need to loop thru the database
            foreach (Developer developer in _developerDb)
            {
                //3. check tosee if the developer dont have pluralsight
                if(developer.HasPluralsight == false)
                {
                    //4. if true we will add the dev to the database
                    devsWithoutPS.Add(developer)
                }
            }
            
            //5 when all is done we will return.....
            return devsWithoutPS;
        }


     {
        //lets check if the dev exist
        Developer oldDevData = GetDeveloperById(developerId);
        //so if we actually have data
        if(oldDevData != null)
        {
            // remove the developer
           return _developerDb.Remove(oldDevData);
        }

        //otherwise 
        return false;

     }



     //Seed Developers

     private void Seed()
     {
        // create developers to add to the database 

        Developer george = new Developer
        {
            FirstName = "George";
            LastName = "Carlin";
            HasPluralsight = true;

        }

        Developer richard = new Developer
        {
            FirstName = "Richard";
            LastName = "Pryor";
            HasPluralsight = false;
        }

        Developer damon = new Developer
        {
            FirstName = "Damon";
            LastName = "Wayans";
            HasPluralsight = true;

        }

        //add developers to database

        AddDeveloper (George);
        AddDeveloper (Richard);
        AddDeveloper (damon);
     
     }

    }
