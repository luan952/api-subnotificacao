using api_subnotificacao.Infra.Data;

namespace api_subnotificacao.EndPoints.User
{
  public class UserPost
  {
    public static string Template => "/user";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action(UserRequest request, ApplicationDbContext context)
    {
      var user = new Domain.User
      {
        Name = request.Name,
        Email = request.Email,
        Password = request.Password
      };

      context.Users.Add(user);
      context.SaveChanges();
      return Results.Created($"/categories/{user.Id}", user.Id);

    }

  }
}