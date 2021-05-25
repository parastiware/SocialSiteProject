namespace DataStore.Models{

public class Profile: ApplicationUser
{
 public string Images { get; set; }
 public string ProfileImage { get; set;}
 public string CoverImage {get;set;}
 public string Bio {get;set;}
    
}

}