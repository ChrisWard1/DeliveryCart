// using System;
// using System.Linq;
// using System.Collections.Generic;
// using Microsoft.EntityFrameworkCore;
// using System.ComponentModel.DataAnnotations;


// namespace Deliverycart2.Models
// {
//     public static class SeedData
//     {
//         public static void Initialize(IServiceProvider serviceProvider)
//         {
//             using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
//             {
//                 // if (context.Addresses.Any())
//                 // {
//                 //     return;
//                 // }
         
//                 List<Customer> customer = new List<Customer> {
//                     new Customer {FirstName="Laurie", LastName="Cornfoot", Age= 22, gender='f', bDate="1999-12-02"},
//                     new Customer {FirstName="Conni", LastName="Spriggen",Age= 15, gender='f',bDate="1999-12-02"},
//                     new Customer {FirstName="Darsey", LastName="Pervoe", Age= 33, gender='f',bDate="1999-12-02"},
//                     new Customer {FirstName="Ninetta", LastName="Seccombe",Age= 88, gender='f',bDate="1999-12-02"},
//                     new Customer {FirstName="Sibilla", LastName="Louisot", Age= 44, gender='f',bDate="1999-12-02"},
//                     new Customer {FirstName="Harli", LastName="Jencken", Age= 55, gender='f',bDate="1999-12-02"},
//                     new Customer {FirstName="Lisa", LastName="Dorrian",Age= 38, gender='f',bDate="1999-12-02"},
//                     new Customer {FirstName="Cary", LastName="Witt", Age= 56, gender='m',bDate="1999-12-02"},
//                     new Customer {FirstName="Hallsy", LastName="Choppen",Age= 21, gender='f',bDate="1999-12-02"},
//                     new Customer {FirstName="Sanson", LastName="Feyer",Age= 23, gender='m',bDate="1999-12-02"},
//                     new Customer {FirstName="Stearn", LastName="Hutchason",Age= 47, gender='m',bDate="1999-12-02"},
//                     new Customer {FirstName="Hewet", LastName="Gamlen",Age= 66, gender='m',bDate="1999-12-02"},
//                     new Customer {FirstName="Sheffie", LastName="Dicte",Age= 13, gender='m',bDate="1999-12-02"},
//                     new Customer {FirstName="Dot", LastName="Ralton",Age= 15, gender='f',bDate="1999-12-02"},
//                     new Customer {FirstName="Drusi", LastName="MacGovern", Age= 77, gender='m',bDate="1999-12-02"},
//                     new Customer {FirstName="Izak", LastName="Rosenkranc", Age= 69, gender='m',bDate="1999-12-02"},
//                     new Customer {FirstName="Clarinda", LastName="Rolling", Age= 14, gender='f',bDate="1999-12-02"},
//                     new Customer {FirstName="Coleen", LastName="Forcade", Age= 33, gender='f',bDate="1999-12-02"},
//                     new Customer {FirstName="Gray", LastName="Madner", Age= 22, gender='f',bDate="1999-12-02"},
//                     new Customer {FirstName="Rowan", LastName="Bursnell",Age= 29, gender='m',bDate="1999-12-02"},
//                     new Customer {FirstName="Kipp", LastName="Kiddell", Age= 27, gender='m',bDate="1999-12-02"},
//                     new Customer {FirstName="Iosep", LastName="Morville", Age= 25, gender='m',bDate="1999-12-02"},
//                     new Customer {FirstName="Martyn", LastName="Bhar", Age= 41, gender='m',bDate="1999-12-02"},
//                     new Customer {FirstName="Antoinette", LastName="Hanhardt", Age= 44, gender='f',bDate="1999-12-02"},
//                     new Customer {FirstName="Thor", LastName="Candy", Age= 52, gender='m',bDate="1999-12-02"},
//                     new Customer {FirstName="Beryl", LastName="Spikings", Age= 54, gender='m',bDate="1999-12-02"},
//                     new Customer {FirstName="Margeaux", LastName="Sturzaker", Age= 37, gender='f',bDate="1999-12-02"},
//                     new Customer {FirstName="Horatio", LastName="Chessel", Age= 40, gender='m',bDate="1999-12-02"},
//                     new Customer {FirstName="Vasili", LastName="Dore", Age= 66, gender='m',bDate="1999-12-02"},
//                     new Customer {FirstName="Flemming", LastName="Magnay", Age= 99, gender='m',bDate="1999-12-02"}
                
//                 };
//                 context.AddRange(person);
//                 context.SaveChanges();
                
                    
//                 List<Address> address = new List<Address> {
//                     new Address {street = "6114 Leopard Rd", city="Ropesville", state="Tx",zipCode=79358},
//                     new Address {street = "6116 Leopard Rd",city="Ropesville", state="Tx",zipCode=79358},
//                     new Address {street = "3575 Mallard Rd",city="Ropesville", state="Tx",zipCode=79358},
//                     new Address {street = "6112 Leopard Rd",city="Ropesville", state="Tx",zipCode=79358},
//                     new Address {street = "6116 Leopard Rd",city="Ropesville", state="Tx",zipCode=79358},
//                     new Address {street = "5223 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5123 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5923 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5823 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5723 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5221 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5228 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5224 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5229 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5222 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5224 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5228 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5225 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5293 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5283 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5273 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5263 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5213 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5253 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5243 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5233 109th St",city="Lubbock", state="Tx",zipCode=79423},
//                     new Address {street = "5226 109th St",city="Lubbock", state="Tx",zipCode=793423}
//                 };
//                      context.AddRange(address);
//                      context.SaveChanges();

//                   List<PersonAddress> personaddress = new List<PersonAddress> {
//                     new PersonAddress {AddressID = 1, PersonID = 1},
//                     new PersonAddress {AddressID = 2, PersonID = 26},
//                     new PersonAddress {AddressID = 3, PersonID = 5},
//                     new PersonAddress {AddressID = 4, PersonID = 18},
//                     new PersonAddress {AddressID = 5, PersonID = 2},
//                     new PersonAddress {AddressID = 6, PersonID = 20},
//                     new PersonAddress {AddressID = 7, PersonID = 25},
//                     new PersonAddress {AddressID = 7, PersonID = 6},
//                     new PersonAddress {AddressID = 9, PersonID = 27},
//                     new PersonAddress {AddressID = 10, PersonID = 4},
//                     new PersonAddress {AddressID = 11, PersonID = 2},
//                     new PersonAddress {AddressID = 12, PersonID = 13},
//                     new PersonAddress {AddressID = 13, PersonID = 11},
//                     new PersonAddress {AddressID = 14, PersonID = 14},
//                     new PersonAddress {AddressID = 15, PersonID = 10},
//                     new PersonAddress {AddressID = 11, PersonID = 28},
//                     new PersonAddress {AddressID = 12, PersonID = 7},
//                     new PersonAddress {AddressID = 13, PersonID = 24}
//                   };
//                   context.AddRange(personaddress);
                

//                 context.SaveChanges();
//             }
//         }
//     }
// }