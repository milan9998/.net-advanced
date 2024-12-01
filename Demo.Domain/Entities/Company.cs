namespace Demo.Domain.Entities;

public class Company
{
    public Company(Guid id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    private Company()
    {
        
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public IList<Product> Products { get; private set; } = new List<Product>();
}