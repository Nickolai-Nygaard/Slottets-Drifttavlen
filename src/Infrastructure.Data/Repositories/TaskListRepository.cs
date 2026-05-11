// Copyright (c) 2026 Team6. All rights reserved. 
//  No warranty, explicit or implicit, provided.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entities;
using Domain.Enums;

using Infrastructure.Data.Persistent;

using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories;

public class TaskListRepository(AppDbContext dbContext) : Repository<TaskList>(dbContext)
{
    public async Task<IEnumerable<TaskList>> GetAvailableTasks(CancellationToken cancellationToken = default)
    {
        return await _context.TaskLists
            .AsNoTracking()
            .Where(t => t.DueTime > DateTime.UtcNow && (t.TaskStatus != TaskListStatus.Success))
            .OrderByDescending(t => t.DueTime)
            .ToListAsync(cancellationToken);
    }


}
