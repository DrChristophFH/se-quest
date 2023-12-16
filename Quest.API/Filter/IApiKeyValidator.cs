namespace Quest.Api.Filter;

public interface IApiKeyValidator {
  bool IsValid(string? apiKey);
}