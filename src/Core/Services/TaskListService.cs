// Copyright (c) 2026 Team6. All rights reserved. 
//  No warranty, explicit or implicit, provided.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Interfaces.Services;

using Domain.Entities;

namespace Core.Services;

public class TaskListService : ITaskListService
{
    private readonly ITaskListService _taskListService;

    public TaskListService(ITaskListService taskListService)
    {
        _taskListService = taskListService;
    }

    public async Task<IEnumerable<TaskList>> GetAvailTasksByShiftAsync(CancellationToken cancellationToken = default)
    {
        return await _taskListService.GetAvailTasksByShiftAsync(cancellationToken);
    }
}
