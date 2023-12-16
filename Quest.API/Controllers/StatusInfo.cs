using Microsoft.AspNetCore.Mvc;

namespace Quest.Api.Controllers;

public static class StatusInfo {

  public static ProblemDetails NoMenuForRestaurant(int restaurantId) {
    return new ProblemDetails {
      Title = "No menu for restaurant",
      Detail = $"Restaurant with ID {restaurantId} does not exist or has no menu."
    };
  }

  public static ProblemDetails InvalidApiKey() {
    return new ProblemDetails {
      Title = "Invalid API key",
      Detail = "The API key provided is invalid."
    };
  }
}