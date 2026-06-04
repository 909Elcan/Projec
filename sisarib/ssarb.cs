namespace HelloVord
{
  class Test
  {
    static void Main()
    {

    ////1
      int number4 =Convert.ToInt32(Console.ReadLine());

      if (number4 >1 && number4 < 100)
      {
        if(number4 % 3==0 && number4 % 5 == 0)
        {
          Console.WriteLine("FizzBuzz");
          return; 
        }
        if (number4 %3==0)
        {
            Console.WriteLine("Fizz");
             return;
        }
        if(number4 % 5 == 0)
        {
          Console.WriteLine("Buzz");
           return;
        }
        else
        {
          Console.WriteLine(number4);
        }
        
      }
      else{
         Console.WriteLine("Eded boyuktur! ");
      }




     ////2
      Console.Write("Birinci ededi daxil et: ");
      int number1 = Convert.ToInt32(Console.ReadLine());

      if(number1 !=0){
         Console.WriteLine("Sef daxil etiniz ");
         return;
      }
      Console.Write("ikinci  ededi daxil et: ");
      int number2 = Convert.ToInt32(Console.ReadLine());
      if(number2  !=0){
         Console.Write("Sef daxil etiniz ");
         return;
      }
    
        number2 = number1 %10;
        Console.WriteLine(number2);




     ////3
        Console.WriteLine("1. Farenheyt -> Selsi");
        Console.WriteLine("2. Selsi -> Farenheyt");
        Console.Write("Seçim edin 1 və 2: ");
        string secim = Console.ReadLine();


        Console.Write("Tenpurator daxil edin: ");
        double Tenpurator= Convert.ToDouble();
      

      if (secim.Equals("1")){
       double celsius = (temp - 32) * 5 / 9;
       Console.WriteLine("Nəticə: " + celsius + " °C"); 
      }
      else if (secim.Equals("2"))
      {
          double fahrenheit = (temp * 9 / 5) + 32;
          Console.WriteLine("Nəticə: " + fahrenheit + " °F");
        
      }
      else
      {
        Console.WriteLine("Sef daxil etdin");
      }

     

    }

  }
}