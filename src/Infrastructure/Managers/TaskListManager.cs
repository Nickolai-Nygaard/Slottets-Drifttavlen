// Copyright (c) 2026 Team6. All rights reserved. 
//  No warranty, explicit or implicit, provided.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

using Core.DTOs;
using Core.Interfaces.Managers;

namespace Infrastructure.Managers;

public class TaskListManager(IHttpClientFactory httpClientFactory) : HttpApiManagerBase(httpClientFactory, "SlottetApi"), ITaskListManager
{


    public async Task<IEnumerable<TaskListDto>> GetAvailableTasksByShift(CancellationToken cancellationToken = default)
    {
        IEnumerable<TaskListDto>? response = await HttpClient.GetFromJsonAsync<IEnumerable<TaskListDto>>("tasklist/Dashboard", cancellationToken);

        return response ?? [];
    }
}
