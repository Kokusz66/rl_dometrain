public record Customer
{
    public Guid Id { get; set; }
    public string CompanyName { get; set; }
    public string EmailAddress { get; set; }
    public List<Project> Projects { get; set; }

    public Customer(Guid id, string companyName, string emailAddress, List<Project> projects)
    {
        Id = id;
        CompanyName = companyName;
        EmailAddress = emailAddress;
        Projects = projects;
    }

    private Customer() //EF Core constructor
    { 
    }
}
