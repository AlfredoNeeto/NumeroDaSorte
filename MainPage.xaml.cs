namespace NumeroDaSorte;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnGenerateLuckNumbers(object sender, EventArgs e)
    {
        var set = GenerateLuckNumbers();

        NameApp.IsVisible = false;
        ContainerLuckNumbers.IsVisible = true;

        FillLuckyNumbers(set);
    }

    private SortedSet<int> GenerateLuckNumbers()
    {
        var set = new SortedSet<int>();

        while (set.Count < 6)
        {
            var random = new Random();
            var luckyNumber = random.Next(1, 60);

            set.Add(luckyNumber);
        }

        return set;
    }

    private void FillLuckyNumbers(SortedSet<int> set)
    {
        if (set.Count == 6)
        {
            LuckNumberOne.Text = set.ElementAt(0).ToString("D2");
            LuckNumberTwo.Text = set.ElementAt(1).ToString("D2");
            LuckNumberThree.Text = set.ElementAt(2).ToString("D2");
            LuckNumberFour.Text = set.ElementAt(3).ToString("D2");
            LuckNumberFive.Text = set.ElementAt(4).ToString("D2");
            LuckNumberSix.Text = set.ElementAt(5).ToString("D2");
        }
    }
}