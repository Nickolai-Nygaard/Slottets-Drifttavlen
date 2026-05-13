// Copyright (c) 2026 Team6. All rights reserved. 
//  No warranty, explicit or implicit, provided.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.DTOs;

using Domain.Entities;

namespace Core.Interfaces.Managers;

public interface ITaskListManager
{
    Task<IEnumerable<TaskListDto>> GetAvailableTasksByShift(CancellationToken cancellationToken = default);
}
