namespace MC_EightToTen___Endpoints.Services.Magic8Ball;

    public interface IMagic8BallService
    {
        string GetMagic8BallResult(string firstUniqueResp, string secondUniqueResp, string thirdUniqueResp, string fourthUniqueResp, string fifthUniqueResp, string sixthUniqueResp, string seventhUniqueResp, string eighthUniqueResp, string ninthUniqueResp, string tenthUniqueResp);
    }
