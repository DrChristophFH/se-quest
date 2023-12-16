namespace Quest.Api.Filter;

public class ApiKeyValidator : IApiKeyValidator {
  public bool IsValid(string? apiKey) {
    if (apiKey == null) {
      return false;
    }
    return true; // TODO: Implement API key validation
  }
}