using System;
using System.Collections.Generic;
using System.Linq;

List<Guest> allguests = GetGuests();
List<Guest> TableOne = new List<Guest>();
List<Guest> TableTwo = new List<Guest>();

foreach (Guest guest in allguests)
{
    List<string?> table1Occs = TableOne.Select(g => g.occupation).ToList();
  if(table1Occs.Contains(guest.occupation))
  {
    TableTwo.Add(guest);
  } else TableOne.Add(guest);
}

foreach (Guest guest in TableOne)
{
    Console.WriteLine("table1");
    Console.WriteLine(guest.name);
}
foreach (Guest guest in TableTwo)
{
    Console.WriteLine("table2");
    Console.WriteLine(guest.name);
}


// Console.WriteLine($"{TableOne}");
Console.WriteLine("---------------------------------");


// A function to make and return list of guests
List<Guest> GetGuests()
{
    // Make a list of guest objects
    //  How would you create a collection of guest objects in JavaScript?
    List<Guest> guestList = new List<Guest> {
        new Guest {
       name = "Marilyn Monroe",
      occupation = "entertainer",
      bio = "(1926 - 1962) American actress, singer, model"
        },
        new Guest {
        name =  "Abraham Lincoln",
      occupation = "politician",
      bio = "(1809 - 1865) US President during American civil war"
        },
        new Guest {
      name = "Martin Luther King",
      occupation = "activist",
      bio = "(1929 - 1968)  American civil rights campaigner"
        },
        new Guest {
        name = "Rosa Parks",
      occupation = "activist",
      bio = "(1913 - 2005)  American civil rights activist"
        },
        new Guest {
        name = "Peter Sellers",
      occupation = "entertainer",
      bio = "(1925 - 1980) British actor and comedian"
        },
        new Guest {
  name = "Alan Turing",
      occupation = "computer scientist",
      bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
        },
        new Guest {
            name ="Admiral Grace Hopper",
      occupation = "computer scientist",
      bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
        },
        new Guest {
      name = "Indira Gandhi",
      occupation = "politician",
      bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
        }
    };

    return guestList;
}


public class Guest
{
    public string? name { get; set; }
    public string? occupation { get; set; }
    public string? bio { get; set; }
}





