class program {
    static void Main(string[] arge) {
        Console.Write("password :" );
        int x = int.Parse(Console.ReadLine());

        Console.Write("agency :");
        string a = (Console.ReadLine());

        if(x <= 999999 && x >= 0) {
            int b = x / 100000 % 10;
            int s = x / 10000 % 10;
            int m = x / 1000 % 10;
            int e = x / 100 % 10;
            int q = x / 10 % 10;
            int i = x % 10;
        
        if(a == "CIA") {
            if(m >= 6 && m != 8 && q != 1 && q != 3 && q != 5 && m >= 6 && m != 8) {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("false");
            }
          }

        if(a == "FBI") {
            if(b >= 4 && b <= 7 && e % 2 == 0 && e != 6 && s % 2 == 1) {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }
          }
          if(a == "NSA") {
            if(i % 30 != 0 && e % 3 == 0 && e % 2 != 0 && b == 7 ||s == 7 || m == 7 || e == 7 || q == 7 || i == 7) {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("false");
            }
          }
          }
            else {
                Console.WriteLine("false");
            }
        
            }
          }
        
