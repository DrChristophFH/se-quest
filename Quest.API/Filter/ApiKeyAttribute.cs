using Microsoft.AspNetCore.Mvc;

namespace Quest.Api.Filter;

public class ApiKeyAttribute : ServiceFilterAttribute {
  public ApiKeyAttribute() : base(typeof(ApiKeyAuthorizationFilter)) {
  }
}