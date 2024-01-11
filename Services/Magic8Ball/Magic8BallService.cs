namespace MC_EightToTen___Endpoints.Services.Magic8Ball;

    public class Magic8BallService : IMagic8BallService
    {
         public string GetMagic8BallResult(string firstUniqueResp, string secondUniqueResp, string thirdUniqueResp, string fourthUniqueResp, string fifthUniqueResp, string sixthUniqueResp, string seventhUniqueResp, string eighthUniqueResp, string ninthUniqueResp, string tenthUniqueResp)
         {
            return $"{firstUniqueResp}. {secondUniqueResp}. {thirdUniqueResp}. {fourthUniqueResp}.{fifthUniqueResp}. {sixthUniqueResp}. {seventhUniqueResp}. {eighthUniqueResp}.{ninthUniqueResp}. {tenthUniqueResp}.";
         }
    }
