using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaFlow.Core.Requests.Transactions;

public class GetTransactionByIdRequest : Request
{
    public long Id {get; set; }
    
}
