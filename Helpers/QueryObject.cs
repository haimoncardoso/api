using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Helpers
{
    public class QueryObject
    {
        public string? Symbol {get; set;} = null; //Data validation
        public string? CompanyName {get; set;} = null; //Data validation
        public string? SortBy {get; set;} = null; //Sorting | crescente e decrescente
        public bool IsDecsending {get; set;} = false; //Sorting | crescente e decrescente
        public int PageNumber {get; set;} = 1; //Pagination
        public int PageSize {get; set;} = 20; //Pagination
    }
}