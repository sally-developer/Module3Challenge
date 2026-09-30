using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module3Challenge.Pages
{
    public class IndexModel : PageModel
    {
        public string HungerMessage { get; set; } = string.Empty;
        public string SoundMessage { get; set; } = string.Empty;
        public string DayMessage { get; set; } = string.Empty;

        public void OnGet()
        {
            // This runs when the page first loads. Nothing to do yet.
        }

        public void OnPost(int hungerLevel, int dayOfWeek)
        {
            if (hungerLevel >= 8)
            {
                HungerMessage = "Lion: Roar! I need a big meal!";
            }
            else if (hungerLevel >= 5)
            {
                HungerMessage = "Monkey: Ooh ooh! I'll take some bananas.";
            }
            else
            {
                HungerMessage = "Tortoise: Slow and steady, I'll have some lettuce.";
            }

            SoundMessage = hungerLevel >= 8
                ? "Listen to the Lion: Roar!"
                : "Listen to the Monkey: Ooh ooh!";

            switch (dayOfWeek)
            {
                case 1:
                    DayMessage = "Sunday: It's feeding time for the penguins!";
                    break;
                case 2:
                    DayMessage = "Monday: The giraffes are stretching tall for a morning snack!";
                    break;
                case 3:
                    DayMessage = "Tuesday: The zebras are running across the savanna!";
                    break;
                case 4:
                    DayMessage = "Wednesday: The elephants are splashing in the water!";
                    break;
                case 5:
                    DayMessage = "Thursday: The parrots are putting on a colorful show!";
                    break;
                case 6:
                    DayMessage = "Friday: The monkeys are swinging through the trees!";
                    break;
                case 7:
                    DayMessage = "Saturday: The lions are roaring at the sunset parade!";
                    break;
                default:
                    DayMessage = "Invalid day selected. Please choose a day from 1 to 7.";
                    break;
            }
        }
    }
}