using EFLoadings;
using Microsoft.EntityFrameworkCore;
#region EagerLoading 

//using EFLoadings.EagerLoading;

//var context = new UserDbContext();

//var user = context.Users
//    .Include(user => user.Address)
//    .Include(user=> user.Contacts)
//    .First();

//var contacts = user.Contacts;

//Console.WriteLine(user.Name);
//Console.WriteLine(user.Address.AddressName);
//foreach (var contact in contacts)
//    Console.WriteLine(contact.Phone);

#endregion


#region LazyLoading
//using EFLoadings.LazyLoading;

//var context =new UserLazyDbContext();

//var user = context.Users.First();

//Console.WriteLine(user.Name);
//Console.WriteLine(user.Address.AddressName);
#endregion


#region ExplicitLoading

//using EFLoadings.ExplicitLoading;

//var context = new UserExplicitDbContext();

//var user = context.Users.First();

//Console.WriteLine(user.Name);

//context.Entry(user).Reference(user => user.Address).Load();

//Console.WriteLine(user.Address.AddressName);

#endregion
