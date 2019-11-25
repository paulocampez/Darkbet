using System;
using System.Collections.Generic;
using System.Text;

namespace Darkbet.Application.ViewModels
{
    public class DiceViewModel
    {
        public DiceViewModel()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
    }
}
