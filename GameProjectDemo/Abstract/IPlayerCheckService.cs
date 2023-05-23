﻿using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    internal interface IPlayerCheckService
    {
       bool CheckIfRealPerson(Player player);
    }
}
