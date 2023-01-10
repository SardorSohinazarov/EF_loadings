using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EFLoadings.LazyLoading;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int AddressId { get; set; }
    public virtual Address? Address { get; set; }

    public virtual List<Contact>? Contacts { get; set; }

    //public User()
    //{

    //}
    //private ILazyLoader LazyLoader { get; set; }
    //public User(ILazyLoader Loader)
    //{
    //    LazyLoader = Loader;
    //}
    //private Address? _address;
    //public virtual Address? Address
    //{
    //    get => LazyLoader.Load(this, ref _address, "Address");
    //    set => _address = value;
    //}

    //public void LoadRelatedData()
    //{
    //    LazyLoader.Load(this, ref _address, "Address");
    //}
}