﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battlefield.Infrastructure.Commands.BattleUnit
{
    public class DeleteUnit : ICommand
    {
        public Guid UnitId { get; set; }
    }
}
