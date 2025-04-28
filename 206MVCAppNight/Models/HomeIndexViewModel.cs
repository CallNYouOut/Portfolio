using Packt.Shared;
using System.Net.Http.Headers;

namespace _206MVCAppNight.Models
{
    public record HomeIndexViewModel
    (
        int VisitorCount, IList<Category> Categories, IList<Product> Products
    );
}
