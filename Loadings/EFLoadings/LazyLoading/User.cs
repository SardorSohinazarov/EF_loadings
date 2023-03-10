using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EFLoadings.LazyLoading;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int AddressId { get; set; }
    public virtual Address? Address { get; set; }

    public virtual List<Contact>? Contacts { get; set; }

}