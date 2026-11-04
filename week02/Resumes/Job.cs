
    public class Job
    {
        public string _jobTitle = "Programmer";
        public string _company = "Republic Bank"; 
        public int _startYear = 2025;
        public int _endYear = 2026;
         
        
    public void JobInfo()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
        }
    
    public void Display()
    {
       Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
    }


