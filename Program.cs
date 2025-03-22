using System.Diagnostics;
using System.Diagnostics.Contracts;

class SayaTubeVideo {
    private int id;
    private string title;
    private int playCount;
    
    public SayaTubeVideo( string title)
    {
        
        Debug.Assert(title.Length <= 100, "judul video maksimal 100 karakter") ;
        Debug.Assert(title != null, "judul tidak boleh kosong");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }
    public void IncreasePlayCount(int count)
    {
        try
        {
            if (count <= 0 || count > 10000000)
            {
                throw new ArgumentException("Error: Input play count harus antara 1 hingga 10.000.000.");
            }

            checked
            {
                this.playCount += count;
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount);
    }
}
class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Fadhli Muhammad Dzaki");
        video.IncreasePlayCount(5000000);
        video.IncreasePlayCount(10000000);
        video.IncreasePlayCount(-100);
        video.IncreasePlayCount(15000000);
        video.PrintVideoDetails();
    }

}