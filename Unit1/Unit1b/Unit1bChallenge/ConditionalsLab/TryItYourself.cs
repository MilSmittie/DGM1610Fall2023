//I was also confused by this part of the challenge so I just put in the code for all 
//the "try it yourself" challenges I did.

//If statement

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      if (20 > 18) 
      {
        Console.WriteLine("20 is greater than 18");
      }    
    }
  }
}

//If statement 2

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 20;
      int y = 18;
      if (x > y)
      {
        Console.WriteLine("x is greater than y");
      }
    }
  }
}

//Else statement

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int time = 20;
      if (time < 18) 
      {
        Console.WriteLine("Good day.");
      } 
      else 
      {
        Console.WriteLine("Good evening.");
      }
    }
  }
}

//Else if statements

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int time = 22;
      if (time < 10) 
      {
        Console.WriteLine("Good morning.");
      } 
      else if (time < 20) 
      {
        Console.WriteLine("Good day.");
      } 
      else 
      {
        Console.WriteLine("Good evening.");
      }
    }
  }
}

//Short-hand if else statements

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int time = 20;
      if (time < 18) 
      {
        Console.WriteLine("Good day.");
      } 
      else 
      {
        Console.WriteLine("Good evening.");
      }
    }
  }
}

//Short-hand if else statements 2

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int time = 20;
      string result = (time < 18) ? "Good day." : "Good evening.";
      Console.WriteLine(result);
    }
  }
}

//Switch statements

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int day = 4;
      switch (day) 
      {
        case 1:
          Console.WriteLine("Monday");
          break;
        case 2:
          Console.WriteLine("Tuesday");
          break;
        case 3:
          Console.WriteLine("Wednesday");
          break;
        case 4:
          Console.WriteLine("Thursday");
          break;
        case 5:
          Console.WriteLine("Friday");
          break;
        case 6:
          Console.WriteLine("Saturday");
          break;
        case 7:
          Console.WriteLine("Sunday");
          break;
      }    
    }
  }
}

//Default statements

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int day = 4;
      switch (day) 
      {
        case 6:
          Console.WriteLine("Today is Saturday.");
          break;
        case 7:
          Console.WriteLine("Today is Sunday.");
          break;
        default:
          Console.WriteLine("Looking forward to the Weekend.");
          break;
      }    
    }
  }
}