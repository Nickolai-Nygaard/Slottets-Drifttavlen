// Copyright (c) 2026 Team6. All rights reserved. 
//  No warranty, explicit or implicit, provided.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entities;

namespace Core.Interfaces.Services;
public interface ITaskListService
{
    Task<IEnumerable<TaskList>> GetAvailTasksByShiftAsync(CancellationToken cancellationToken = default);
}
