using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string [] cars = {"Volvo", "Mazda","Bentley","Suzuki"};
        cars[0]="Mercedes";
        
        static void MyFactorial(int number){
            
            if (number<0){
                Console.WriteLine("there is no factorial for a negative number");
            
                
            }
            else{
                
            int x=1;
            for (int i =1; i<=number;i++)
            {
                x = i*x;
    
            }
            Console.WriteLine(x);
            }
            
           
            
        }
        MyFactorial(3);
    }
    
}