public class Job {
    //instances 
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear; 


    //constructor 
    public Job(){

    }

    //Methods (functions)

    public void displayInfo(){
        Console.WriteLine($"Company:{_company}, Job Title: {_jobTitle}, Start Year: {_startYear}. ");
        
    }
}