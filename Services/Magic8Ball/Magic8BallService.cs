namespace MC_EightToTen___Endpoints.Services.Magic8Ball;

    public class Magic8BallService : IMagic8BallService
    {
         public string GetMagic8BallResult(string magic8BallInput)
         {
            Random magic8BallRandom = new Random();
            string[] magic8Ball = { "It is certain", "It is decidedly so", "Most likely", "Signs point to yes", "Reply hazy, try again", "Ask again later", "My sources say no", "Outlook not so good "};


            int magic8Ball1 = magic8BallRandom.Next(0, magic8Ball.Length);

            return $"The magic 8 ball response you got was {magic8Ball[magic8Ball1]}.";
        

         }
    }
