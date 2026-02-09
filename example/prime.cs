using System; 
public class prime
{
    static void Main(string[] args)
    {
        prime(dem, n);
    }
    public void prime(int dem, int n)
    {
        
        int dem = 0;
        int n = 100; 
        for (int i = 0; i<n;i++)
        {
            for (int j = 0; j<n;j++)
            {
                if(i % j == 0)
                {
                    dem++;
                }
            }
        }
        if (dem == 2)
        {
            Console.WriteLine(i);
        }
    }
}