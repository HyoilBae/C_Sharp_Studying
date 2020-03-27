using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");
            //tdl.Add("Snowboarding");
            //tdl.Add("Pow Wow");
            //tdl.Add("Going home");
            tdl.Display();

            PasswordManager pm = new PasswordManager("iluvpie", true);
            pm.Display();

            //tdl.Reset();
            //tdl.Display();

            //pm.Reset();
            //pm.Display();
        }
    }
}


/*
 * Add a get-only property to IDisplayable called HeaderSymbol. This should be used in Display() as a header. For example, if the header symbol is -, then the apps should be displayed as:

Todos
--------
Eat
Sleep
Code

Password
-----------
***
If you add more than five to-dos to the TodoList, it throws an error! Extend the Add() method so that it doesn’t add any more than five items to the Todos array.

Currently a blank line is printed for each empty index in Todos. Change Display() in TodoList so that it prints [] instead of a blank line. You’ll need to use the static method String.IsNullOrEmpty().

Add a method ChangePassword() to PasswordManager. It should:

have two string parameters
if the first argument matches the existing Password, reset the Password to the second argument
return true if the password change was a success (the first argument matched the old password), and false otherwise
Extend the Password property in PasswordManager:

Change the set method so that it requires the password to be at least eight characters in length
*
* 
* 
* 
* Adding HeaderSymbol to IDisplayable: Here’s what a get-only Sound property looks like in an interface:

interface ISoundable
{
  string Sound { get; }
}
Extending TodoList.Add(): To extend the Add() method, use an if-else statement that checks if the Todos.Length is less than 5.

Extending TodoList.Display(): Within the foreach loop, check is each string is null or empty by using String.IsNullOrEmpty(). If this returns true, print []. Otherwise print the string.

Adding PasswordManager.ChangePassword(): Here’s the signature for ChangePassword():

public bool ChangePassword(string oldPass, string newPass)
Extending the setter for Password: remember that you can add a backing field for a property and define your own set method. Here’s an example of a legs field and Legs property that must be at least 6.

class CreepyCrawler
{
  int legs;

  public int Legs
  {
    get
    { 
      return legs;
    }
    set
    {
      if (value >= 6) { legs = value; }
      else { legs = 6; }
    }
  }
}

    */