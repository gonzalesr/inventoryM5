﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Transactions;

public enum TransactionStatus
{
    Created,
    Completed,
    Canceled
}
