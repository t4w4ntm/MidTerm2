class Program {
    static void Main(string[] args) {
        string menu;
        int BS = 6;
        int WS = 3;
        int C = 4;

        Console.Write("Enter day : ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter time : ");
        int t = int.Parse(Console.ReadLine());
        
        while (true){
            Console.Write("Enter menu or End to exit : ");
            menu = Console.ReadLine();

            if(menu == "End"){
                break; } 
            else if(menu == "Breakfast Set" && t > 11){Console.WriteLine("Sorry your order is not available"); 
                 }
            else if(menu == "Weekend Set" && d > 5){Console.WriteLine("Sorry your order is not available"); 
                 } 
            else if(menu == "Breakfast Set"){ BS -= 1;
                if(BS <= 0){Console.WriteLine("Sorry your order is out of stock");}}
            else if(menu == "Weekend Set"){WS -= 1;
                if(WS <= 0){Console.WriteLine("Sorry your order is out of stock");}}
            else if(menu == "Coffee"){C -= 1;
                if(C <= 0){Console.WriteLine("Sorry your order is out of stock");}}
               
            else { Console.WriteLine("Please enter a valid menu");
            }
        
        }
    }
}
   
        