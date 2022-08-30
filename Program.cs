using System;
using System.Collections.Generic;






    List<Guest> guests = GetGuests();

    List<Guest> TableOne = new List<Guest>();
    List<Guest> TableTwo = new List<Guest>();




    foreach (Guest guest in guests) {
       foreach (Guest Table in TableOne)
       {
        if(guest.occupation != Table.occupation) {
          TableOne.Add(guest);
        } else TableTwo.Add(guest);
       }
    }

 

  Console.WriteLine(TableOne);
  Console.WriteLine("---------------------------------");
  Console.WriteLine(TableTwo);
    // A function to make and return list of enemies

    List<Guest> GetGuests()
    {
        // Make a list of Enemy objects
        //  How would you create a collection of enemy objects in JavaScript?
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

 



