// Copyright (c) 2026 Team6. All rights reserved. 
//  No warranty, explicit or implicit, provided.

using Core.Interfaces.Services;

using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskListController : ControllerBase
{
    private readonly ITaskListService _taskListService;

    public TaskListController(ITaskListService taskListService)
    {
        _taskListService = taskListService;
    }

    [HttpGet("Dashboard")]
    public async Task<IActionResult> GetAvailableTasksByShift(CancellationToken cancellationToken = default)
    {
        var tasks = await _taskListService.GetAvailTasksByShiftAsync(cancellationToken);
        return Ok(tasks);
    }
}
