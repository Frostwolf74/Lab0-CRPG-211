namespace Lab0_CRPG211;

class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the low number: ");
        double lowNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the high number: ");
        double highNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Difference: " + (highNum - lowNum));

        double num = highNum;
        while (ValidateInput(num, highNum)){
            Console.WriteLine("Enter low number: ");
            num = double.Parse(Console.ReadLine());
        }

        double num1 = lowNum;
        while (ValidateInput(num1, lowNum, highNum)){
            Console.WriteLine("Enter high number: ");
            num1 = double.Parse(Console.ReadLine());
        }

        // int[] a = new int[highNum - lowNum + 1];
        List<double> l = new List<double>(); // list implementation
        
        for (double i = lowNum; i <= highNum; ++i){
            // a[i - lowNum] = i;
            l.Add(i);
        }

        using (StreamWriter sw = File.CreateText("./numbers.txt")){
            // for (int i = a[a.Length - 1]; i >= a[0]; --i){
            //     sw.WriteLine(i);
            // }

            for (double i = l[l.Count - 1]; i >= l[0]; --i){
                sw.WriteLine(i);
            }
        
            sw.Close();
        }
        
        List<double> primeNumbers = findPrimeNumbers(lowNum, highNum);
        
        Console.WriteLine("Prime numbers: ");
        foreach(double i in primeNumbers){
            Console.Write(i + ", ");   
        }
        
        Console.WriteLine("\nEnter any number: ");
        if (verifyPrimeNumber(double.Parse(Console.ReadLine()))){
            Console.WriteLine("Number is prime");
        }
        else{
            Console.WriteLine("Number is not prime");
        }
    }

    public static List<double> findPrimeNumbers(double lowNum, double highNum){
        List<double> primeNumbers = new List<double>();
        
        for(double i = lowNum; i < highNum; ++i) {
            if (verifyPrimeNumber(i)){
                primeNumbers.Add(i);
            }
        }
        
        return primeNumbers;
    }

    public static Boolean verifyPrimeNumber(double num){
        if (num < 2) return false;
        if (num % 2 == 0) return false; // weed out even numbers, guaranteed not prime
        
        for (int i = 2; i <= 101; ++i){ // this range accounts for all prime numbers
            if (num % i != 0){
                return true;
            }
        }
        
        return false;
    }

    public static Boolean ValidateInput(double num, double highNum){
        return !(num >= highNum || num < 0);
    }

    public static Boolean ValidateInput(double num, double lowNum, double highNum){ // overload for different uses
        return !(num <= lowNum || num > highNum);
    }
}
    