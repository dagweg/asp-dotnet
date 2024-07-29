
namespace asp_dotnet.Models;

public static class Repository {
    private static List<GuestResponse> _response = new();
    public static IEnumerable<GuestResponse> Response => _response;
    
    public static void AddResponse(GuestResponse response){
        Console.WriteLine(response);
        _response.Add(response);
    }
}