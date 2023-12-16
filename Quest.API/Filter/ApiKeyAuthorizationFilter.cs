using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

using Quest.Api.Controllers;

namespace Quest.Api.Filter;

public class ApiKeyAuthorizationFilter : IAuthorizationFilter {
  private const string ApiKeyHeaderName = "snacks-api-key";

  private readonly IApiKeyValidator _apiKeyValidator;

  public ApiKeyAuthorizationFilter(IApiKeyValidator apiKeyValidator) {
    _apiKeyValidator = apiKeyValidator;
  }

  public void OnAuthorization(AuthorizationFilterContext context) {
    string? apiKey = context.HttpContext.Request.Headers[ApiKeyHeaderName];

    if (!_apiKeyValidator.IsValid(apiKey)) {
      context.Result = new UnauthorizedObjectResult(StatusInfo.InvalidApiKey());
    }
  }
}