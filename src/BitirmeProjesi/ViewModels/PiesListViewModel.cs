using BitirmeProjesi.Models;
using System.Collections.Generic;

namespace BitirmeProjesi.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
