using Microsoft.AspNetCore.Http;
using EdifyApp.API.Dtos;
using EdifyApp.API.Models;

namespace EdifyApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        // public static int CalculateNewRemaingLeaveDays(this int theNumber)
        // {
        //     var theThing = new User();
        //     int remainingLeaveDays = theThing.RemainingLeaveDays - theNumber;
        //     return remainingLeaveDays;
        // }
    }
}