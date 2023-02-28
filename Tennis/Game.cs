namespace Tennis;

public class Game
{
    private static readonly Dictionary<int, string> CountNameLookup = new Dictionary<int, string>
    {
        { 0, "Love" },
        { 1, "Fifteen" },
        { 2, "Thirty" },
        { 3, "Forty" },
    };

    public string ShowResult(Player player1, Player player2)
    {
        var comparerResult = player1.Value - player2.Value;
        string showResult = null;

        if (comparerResult == 0)
        {
            showResult = player1.Value > 3
                ? "Deuce"
                : $"{CountNameLookup[player1.Value]} All";
        }
        else
        {
            if (comparerResult == 1 && player1.Value > 3)
            {
                showResult = $"{player1.Name} Adv";
            }
            else if (comparerResult == -1 && player2.Value > 3)
            {
                showResult = $"{player2.Name} Adv";
            }
            else if (comparerResult == 2 && player1.Value > 3)
            {
                showResult = $"{player1.Name} Win";
            }
            else if (comparerResult == -2 && player2.Value > 3)
            {

                showResult = $"{player2.Name} Win";
            }
            else
            {
                showResult = $"{CountNameLookup[player1.Value]} {CountNameLookup[player2.Value]}";
            }
        }

        return showResult;
    }
}