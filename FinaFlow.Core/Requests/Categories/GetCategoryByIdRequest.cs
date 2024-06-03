using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaFlow.Core.Requests.Categories;

public class GetCategoryByIdRequest : Request
{
    public long Id { get; set; }
}
