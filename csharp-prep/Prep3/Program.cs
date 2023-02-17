namespace HelloWorld
{
    public class Resume

    {
    public string CompanyName{ get; set; }
    public String JobTitle{get; set;} 
    public int StartYear{get; set;}
    public int EndYear{get; set;}

    public Resume(string companyname, String jobtitle, int startyear, int endyear) 
    {
      CompanyName = companyname;
      JobTitle = jobtitle;
      StartYear = startyear;
      EndYear = endyear;
    }
}


  class Program
  {
    static void Main()
    {
      Resume newcompany1 = new Resume("Touchcore LTD", "Developer", 2000, 2030 );
      Console.WriteLine("CompanyName = {0} JobTitle = {1} StartYear ={2} EndYear{3}", newcompany1.CompanyName, newcompany1.JobTitle, newcompany1.StartYear, newcompany1.EndYear);
        
      Resume createresume = newcompany1;
    }
  }
}