class SayaTubeVideo {
    private int id;
    private string title;
    private int playCount;
    
    public SayaTubeVideo( string title)
    {
        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }
    public void IncreasePlayCount(int count)
    {
        if (count < 0)
        {
            Console.WriteLine("jumlah tidak boleh negatif");
        }
        this.playCount += count;
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
        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design by Contract - Fadhli Muhammad Dzaki");
        video1.IncreasePlayCount(10);
        video1.PrintVideoDetails();
    }
}