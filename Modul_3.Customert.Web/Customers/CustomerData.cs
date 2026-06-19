public class CustomerData
{
    private readonly Guid _customer1Id = Guid.Parse("a1d82285-cf45-4e2f-839e-7ffcf971b36a");
    private readonly Guid _customer2Id = Guid.Parse("5e1d51c0-882d-48b7-8055-55df857632f5");
    private readonly List<Customer> _customers;

    public CustomerData()
    {
        _customers = new List<Customer>
        {
            new Customer(_customer1Id, "Acme", new List<Project>
            {
                new Project(Guid.NewGuid(), "Porject 1", Guid.NewGuid()),
                new Project(Guid.NewGuid(), "Porject 2", Guid.NewGuid())
            }),
            new Customer(_customer2Id, "NimblePros", new List<Project>
            {
                new Project(Guid.NewGuid(), "Porject 3", Guid.NewGuid()),
                new Project(Guid.NewGuid(), "Porject 4", Guid.NewGuid())
            })
        };
    }

    public async Task<List<Customer>> ListAsync()
    {
        return _customers;
    }

    
    //most nincs warning, a trükk a Tast-volt
    public Task<Customer?> GetByIdAsync(Guid id)
    {
        return Task.FromResult(_customers.FirstOrDefault(c => c.Id == id));
    }


    public Task AddAsync(Customer newCustomer)
    {
        _customers.Add(newCustomer);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(Guid id, Customer customer)
    {
        if (_customers.Any(c => c.Id == customer.Id))
        {
            var index = _customers.FindIndex(c => c.Id == customer.Id);
            _customers[index] = customer;
        }
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Guid id)
    {
        if (_customers.Any(c => c.Id == id))
        {
            var index = _customers.FindIndex(c => c.Id == id);
            _customers.RemoveAt(index);
        }
        return Task.CompletedTask;
    }

    
}

