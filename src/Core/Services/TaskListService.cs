// Copyright (c) 2026 Team6. All rights reserved. 
//  No warranty, explicit or implicit, provided.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.DTOs;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Mappers;

using Domain.Entities;

namespace Core.Services;

public class TaskListService : ITaskListService
{
    private readonly ITaskListRepository _taskListRepository;

    public TaskListService(ITaskListRepository taskListRepository)
    {
        _taskListRepository = taskListRepository;
    }

    public async Task<IEnumerable<TaskListDto>> GetAvailTasksByShiftAsync(CancellationToken cancellationToken = default)
    {
        var tasks = await _taskListRepository.GetAvailTasksByShiftAsync(cancellationToken);
        return tasks.Select(t => t.ToTaskListDto());
    }
}
