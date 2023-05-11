
    public class ProgramUI
    {
     //Globally scoped variable container with the DeveloperRepository Data
     private DeveloperRepository _dRepo = new DeveloperRepository();
     private DevTeamRepository _dTRepo;
     
     public ProgramUI()
     {
        _dTRepo = new DevTeamRepository(_dRepo);
     }
     
     public void Run()

     {
        RunApplication(;)
     }

     private void RunApplication()
     {

        bool isRunning = true;
        while (isRunning)
        {

            Console.Clear();
            System.Console.WriteLine("Welcome to Komodo DevTeams\n" +
            "=========Developer Management=======================\n" +
            "1.  View All Developers\n" +
            "2.  View Developer by Id\n" +
            "3.  Add Developer\n"+
            "4.  Update Existing Developer\n" +
            "5.  delete existing Developer\n\n" +
            "6.  View All DevTeams\n" +
            "7.  View DevTeam by Id\n" +
            "8.  Add DevTeam\n" +
            "9.  Update Existing DevTeam\n" +
            "10. Delete existing DevTeam\n\n" +
            "=============Bonus==================\n" +
            "11. Developers with Pluralsight Account\n" +
            "12. Add Multiple Developers to a team\n\n"
            "===============Exit App================\n" +
            "00. Exit Application");

            string userInput = Console.ReadLine()!;

            switch (userInput)
            {
                case "1":
                    ViewAllDevelopers();
                    break;
                case "2":
                    ViewDevelopersById();
                    break;
                case "3":
                    AddDeveloper();
                    break;
                case "4":
                    UpdateExistingDeveloper();
                    break;
                case "5":
                    DeleteExistingDeveloper();
                    break;
                case "6":
                    ViewAllDevTeams();
                    break;
                case "7":
                    viewDevTeamById();
                    break;
                case "8":
                    AddDevTeam();
                    break;
                case "9":
                    UpdateExistingDevTeam();
                    break;
                case "10":
                    DeleteExistingDevTeam();
                    break;
                case "11":
                    DevelopersWithPluralsightAccount();
                    break:
                case "12"
                    AddMultipleDevelopersToATeam();
                    break;
                case "00":
                    isRunning = ExitApplication();
                    break;
                default:
                    System.Console.WriteLine("Invalid Selection");
                    break;
                    
                




            }


        }

     }
     

     private bool ExitApplication()
     {

        Console.Clear();
        System.Console.WriteLine("Thank you for using Komodo DevTeams!");
        PressAnyKey();
        Console.Clear();
        return false;
     }

     private void PressAnyKey()
     {
        System.Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
     }

     private void AddMultipleDevelopersToATeam()
     {
        throw new NotImplementedException();
     }

     private void DevelopersWithPluralsightAccount()
     {
        List<Developer> devsWops = _dRepo.GetDeveloperswithoutPluralsight();
        if (devsWops.Count() > 0)
        {
            foreach (Developer dev in devsWops)
            {
                DisplayDevData(dev)
            }
        }
        else
        {
            System.Console.WriteLine("Every developer has pluralsight!");
        }
     }

     private void DeleteExistingDevTeam();
     {
        throw new NotImplementedException();
     }

     private void UpdateExistingDevTeam();
     {
        Console.Clear();
        ShowEnlistedDevs();
        Console.WriteLine(".........\n");
     }
     private void AddDeveloper();
     {
        Console.Clear();

        try
        {
            Developer dev = InitializeDevCreationSetup()
            if(_dRepo.AddDeveloper(dev))
            {
                System.Console.WriteLine($"Successfully Added (dev.FullName) to the Database")
            }
            else
            {
                Somethingwentwrong();
            }
        }
        catch(Exception ex)
        {
            System.Console.WriteLine(ex.Equals Message);
            Somethingwentwrong
        }
     }

        private Developer InitializeDevCreationSetup()
    {
        Developer dev = new Developer();

        Console.WriteLine("== Add Developer Menu==");

        Console.WriteLine("What is the developers First Name");

        Console.WriteLine("what is the Developers Last Name");
        dev.LastName = Console.ReadLine()!;

        Console.WriteLine("Does this Developer have a Pluralsight Account?\n"+
                         "1. yes\n"+
                         "2. no\n");
                         bool hasMadeselection == false;
                         {
                            switch(userInputPsAcct)
                            {
                                case "1";
                                dev.HasPluralsight = true;
                                hasMadeselection = true;
                                break
                                
                                default:
                                Console.WriteLine("invalid selection");
                                PressAnyKey();
                                break
                            }
                         }

                         return dev;

    }

    private void AddDevTeam()
     {
        throw new NotImplementedException();
     }
     private void viewDevTeamById()
     {
        throw new NotImplementedException();
     }
     private void ViewAllDevTeams()
     {
        throw new NotImplementedException();
     }
     private void DeleteExistingDeveloper
     {
        Console.Clear();
        ShowEnlistedDevs();
        Console.WriteLine(========\n");
        try
        {
            System.Console.WriteLine("select Developer by ID.");
            int userInputDevId = int.Parse(Console.ReadLine()!);
            var isValidated = ValidateDeveloperInDatabase(userInputDevId)
            if (isValidated)
            
            {
                System.Console.WriteLine(Do you want to delete this developer? y/n");
                string userInputDeleteDev = Console.ReadLine()!. ToLower();
                if (userInputDeleDev == "y")
                {
                    if(_dRepo.DeleteDeveloper(userInputDevId))
                    {
                        System.Console.WriteLine("The Developer was Deleted");
                    }

                }
                else  
                {
                    System.Console.WriteLine("The Developer was not Deleted");
                }              
            }
            else
            {
                System.Console.WriteLine($"The Developer with the id: {userInputdevId} Doesnt Exist");
            }

        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex);
            Somethingwentwrong
        }

     }
     private void UpdateExistingDeveloper()
     {
        Console.Clear();
        ShowEnlistedDevs();
        Console.WriteLine("----------\n");
        try
        {
            Console.WriteLine("Select Developer by Id");
            
            int userInputDevId = int.Parse(Console.ReadLine()!);
            
            Developer devInDb = GetDeveloperDataFromDb(userInputDevId); 
            
            bool isValidated = ValidateDeveloperInDatabase(devInDb.ID);
            
            if(isValidated)
            {
                System.Console.WriteLine("Do you want to update this developer y/n");
                string userInputUpdateDev = Console.ReadLine()!. ToLower();
                if(userInputUpdateDev == "y")
                {
                    Developer upDateDevData = InitializeDevCreationSetup();
                    if(_dRepo.UpdateDeveloper(devInDb, ID, upDateDevData))
                    {
                        Console.WriteLine($"The Developer{updateDevData.FullName} has been updated");
                    }

                } 

            }
            else
            {
                 Console.WriteLine($"The Developer{updateDevData.FullName} was not updated");
            }



            {
                System.Console.WriteLine('Developer doesnt exist!');
            }
            
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                Somethingwentwrong();
            }
        }
     
     }


     private void ViewDeveloperById()
     {
        Console.Clear();
        ShowEnlistedDevs();
        Console.WriteLine("--------\n");

            //try/catch -> try something if it doesnt work, swallow the error and continue running the app
            try
            {
                Console.WriteLine("select developer by id.")
                int userInputDevId = int.Parse(Console.ReadLine()!);
                ValidateDeveloperInDatabase(userInputDevId);

            }

            catch (Exception.ex)
            {
                 Somethingwentwrong(); 
                 System.Console.WriteLine(ex. Message);
            
            }

            PressAnyKey();
        }

            private void ValidateDeveloperInDatabase(int userInputDevId)
        {

            Developer dev = GetDeveloperDataFromDb(userInputDevId);
            if(dev != null)
        
            [
                Console.Clear();
                DisplayDevData(dev);

            ]

    }  

        private void Somethingwentwrong()
        {
            Console.WriteLine("somethingwentwrong.\n" +
                              "pls try again. n+"
                              "return it to developer menu.\n"+);
        }

        private void ViewAllDevelopers()
     { 
        Console.Clear();

    //helper menu method
        ShowEnlistedDevs();

        PressAnyKey();
     }

     private void ShowEnlistedDevs()
     {
        Console.Clear();
        Console.WriteLine("== Developer Listing ==");
        List<Developer> devsInDb = _dRepo.GetDevelopers();
        ValidateDeveloperDatabaseData(devsInDb);

     }

     private void ValidateDeveloperDatabaseData(List<Developer> devsInDb)
     {

        if (devsInDb.Count > 0)
        {

            Console.Clear();
             foreach ( Developer dev in devsInDb)

            {
                DisplayDevData(dev);
            }
        }
        else
        {
            Console.WriteLine("There are no Developers in the Database.");
        }

        private void DisplayDevData(Developer dev)
        {
            Console.WriteLine(dev);
        }




        
     }




    

     

    }
