namespace MC_EightToTen___Endpoints.Services.RestaurantPicker;

public class RestaurantPickerService : IRestaurantPickerService
{
    public string GetRestaurantPickerResult(string userInput)
    {
        
            Random fastFoodCategory = new Random();
            string[] fastFood = { "Taco Bell", "McDonalds", "Burger King", "Jack In The Box", "Wendys", "Carls Jr", "KFC", "In N Out", "Arbys", "A&W" };
            int fastFood1 = fastFoodCategory.Next(0, fastFood.Length);



            Random pizzaCategory = new Random();
            string[] pizza = { "Pizza Hut", "Dominoes", "Round Table", "Mountain Mikes", "Eddies Pizza", "Little Ceasars", "Papa John's Pizza", "Papa Murphy's", "Marco's Pizza", "Prime Pizza" };
            int pizza1 = pizzaCategory.Next(0, pizza.Length);
            
  
            Random diningCategory = new Random();
            string[] casualDining = { "IHOP", "Applebees", "Chilis", "Dennys", "The Cheesecake Factory", "Red Lobster", "Olive Garden", "TGI Fridays", "Outback Steakhouse", "BJ's Restaurant & Brewhouse" };
            int casualDining1 = diningCategory.Next(0, casualDining.Length);
            
        

            if(userInput == "fast food"){
                    return $"The fast food restaurant picked is {fastFood[fastFood1]}.";
            }else if (userInput == "pizza"){
                    return $"The pizza restaurant picked is {pizza[pizza1]}. ";
            }else if (userInput == "casual dining"){
                return $"The casual dining restaurant picked is {casualDining[casualDining1]}.";
            }
            else {
                return "Enter the correct retaurant category.";
            }

    }

}


