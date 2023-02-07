using ShopProjectAsp_PhamVanLinh.Models;
using System.Linq.Dynamic.Core;
using static System.Reflection.Metadata.BlobBuilder;

namespace ShopProjectAsp_PhamVanLinh.Data
{
    public class Services
    {
        public HashSet<Product> Products { get; set; }

        public Product[] Get() => Products.ToArray();

        public Product[] Get(string search)
        {
            var s = search.ToLower();
            return Products.Where(b =>
                b.Name.ToLower().Contains(s) ||
                b.img.ToLower().Contains(s) ||
                b.Price.ToString().Contains(s) ||
                b.Quantity.ToString().Contains(s) ||
                (b.Description != null
                && b.Description.ToLower().Contains(s)) ||
                b.Category_id.ToString() == s).ToArray();
        }

        public (Product[] products, int pages, int page) Paging(int page, string orderBy = "Name", bool dsc = false)
        {
            int size = 2;
            int pages = (int)Math.Ceiling((double)Products.Count / size);
            var products = Products.Skip((page - 1) * size).Take(size).AsQueryable().OrderBy($"{orderBy} {(dsc ? "descending" : "")}").ToArray();
            return (products, pages, page);
        }
    }
}
