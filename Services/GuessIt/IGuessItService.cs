namespace MC_EightToTen___Endpoints.Services.GuessIt;

    public interface IGuessItService
    {
        string GetGuessItEasyResult(string easyMode);
        string GetGuessItMediumResult(string mediumMode);
        string GetGuessItHardResult(string hardMode);
        
    }
