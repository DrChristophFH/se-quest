using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

using NSwag.Annotations;

namespace Quest.Api.Controllers;

public static class WebApiConventions {

  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  [ProducesResponseType(StatusCodes.Status404NotFound)]
  [ProducesDefaultResponseType]
  [ApiConventionNameMatch(ApiConventionNameMatchBehavior.Prefix)]
  public static void Get(
    [ApiConventionNameMatch(ApiConventionNameMatchBehavior.Any)]
    [ApiConventionTypeMatch(ApiConventionTypeMatchBehavior.AssignableFrom)]
    Guid id) {

  }

  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesDefaultResponseType]
  [ApiConventionNameMatch(ApiConventionNameMatchBehavior.Prefix)]
  public static void Get(
    [ApiConventionNameMatch(ApiConventionNameMatchBehavior.Any)]
    [ApiConventionTypeMatch(ApiConventionTypeMatchBehavior.Any)]
    object param) {

  }

  [ProducesResponseType(StatusCodes.Status201Created)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  [ProducesResponseType(StatusCodes.Status409Conflict)]
  [ProducesDefaultResponseType]
  [ApiConventionNameMatch(ApiConventionNameMatchBehavior.Prefix)]
  public static void Create(
    [ApiConventionNameMatch(ApiConventionNameMatchBehavior.Any)]
    [ApiConventionTypeMatch(ApiConventionTypeMatchBehavior.Any)]
    object model) {

  }

  [ProducesResponseType(StatusCodes.Status204NoContent)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  [ProducesResponseType(StatusCodes.Status404NotFound)]
  [ProducesDefaultResponseType]
  [ApiConventionNameMatch(ApiConventionNameMatchBehavior.Prefix)]
  public static void Update(
    [ApiConventionNameMatch(ApiConventionNameMatchBehavior.Any)]
    [ApiConventionTypeMatch(ApiConventionTypeMatchBehavior.AssignableFrom)]
    Guid id,
    [ApiConventionNameMatch(ApiConventionNameMatchBehavior.Any)]
    [ApiConventionTypeMatch(ApiConventionTypeMatchBehavior.Any)]
    object model) {

  }

  [ProducesResponseType(StatusCodes.Status204NoContent)]
  [ProducesResponseType(StatusCodes.Status404NotFound)]
  [ProducesDefaultResponseType]
  public static void Delete(
    [ApiConventionNameMatch(ApiConventionNameMatchBehavior.Any)]
    [ApiConventionTypeMatch(ApiConventionTypeMatchBehavior.AssignableFrom)]
    Guid id) {

  }
}
