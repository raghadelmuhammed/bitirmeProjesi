using BitirmeProjesi.Models;
using System.Collections.Generic;

namespace BitirmeProjesi.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
