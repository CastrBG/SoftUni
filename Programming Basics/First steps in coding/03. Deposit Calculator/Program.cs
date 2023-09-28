namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int timePeriod = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine()) / 100;
            double returnSum = deposit + timePeriod * ((deposit * rate) / 12);
            Console.WriteLine(returnSum);
        }
    }
}