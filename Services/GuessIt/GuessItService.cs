namespace MC_EightToTen___Endpoints.Services.GuessIt;

public class GuessItService : IGuessItService
{

    public string GetGuessItEasyResult(string easyMode)
    {

        Random diffLevel = new Random();

        int easyLevel = diffLevel.Next(1, 11);
        bool correctFormat1 = int.TryParse(easyMode, out int correctNum1);
        if (correctFormat1)
            if (correctNum1 > easyLevel)
            {
                return $"The number {easyMode} is higher than the number guessed.";
            }
            else if (correctNum1 < easyLevel)
            {
                return $"The number {easyMode} is lower than the number guessed.";
            }
            else if (correctNum1 == easyLevel)
            {
                return $"You, won. Good job!";
            }
            else
            {
                return "Wrong entry. Please re-enter a number from 1-10.";
            }
        else {
            return "Invalid input. Re-enter a number from 1-10.";
        }

    }

    public string GetGuessItMediumResult(string mediumMode)
    {

        Random diffLevel = new Random();

        int mediumLevel = diffLevel.Next(1, 51);
        bool correctFormat2 = int.TryParse(mediumMode, out int correctNum2);
        if (correctFormat2)
            if (correctNum2 > mediumLevel)
            {
                return $"The number {mediumMode} is higher than the number guessed.";
            }
            else if (correctNum2 < mediumLevel)
            {
                return $"The number {mediumMode} is lower than the number guessed.";
            }
            else if (correctNum2 == mediumLevel)
            {
                return $"You, won. Good job!";
            }
            else
            {
                return "Wrong entry. Please re-enter a number from 1-50.";
            }
        else
        {
            return "Invalid input. Re-enter a number from 1-50.";
        }

    }

    public string GetGuessItHardResult(string hardMode)
    {

        Random diffLevel = new Random();

        int hardLevel = diffLevel.Next(1, 101);

        bool correctFormat3 = int.TryParse(hardMode, out int correctNum3);
        if (correctFormat3)
        {
            if (correctNum3 > hardLevel)
            {
                return $"The number {hardMode} is higher than the number guessed.";
            }
            else if (correctNum3 < hardLevel)
            {
                return $"The number {hardMode} is lower than the number guessed.";
            }
            else if (correctNum3 == hardLevel)
            {
                return $"You, won. Good job!";
            }
            else
            {
                return "Wrong entry. Please re-enter a number from 1-100.";
            }
        }
        else
        {
            return "Invalid input. Re-enter a number from 1-100.";
        }
    }

}
