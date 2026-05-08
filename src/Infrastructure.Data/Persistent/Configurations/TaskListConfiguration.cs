// Copyright (c) 2026 Team6. All rights reserved. 
//  No warranty, explicit or implicit, provided.

using Domain.Entities;
using Domain.Enums;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Persistent.Configurations;

public class TaskListConfiguration : IEntityTypeConfiguration<TaskList>
{
        public void Configure(EntityTypeBuilder<TaskList> builder)
        {
            SeedingData(builder);
        }

    public void SeedingData(EntityTypeBuilder<TaskList> builder)
    {
        _ = builder.HasData(
            new TaskList
            {
                Id = Guid.Parse("12345678-1234-5678-1234-567812345678"),
                Title = "indkøb",
                Description = "Tasks to be completed in the morning.",
                TaskStatus = TaskListStatus.InProgress,
                DueTime = DateTime.Now.AddHours(2)
            },
            new TaskList
            {
                Id = Guid.Parse("87654321-4321-8765-4321-876543218765"),
                Title = "rengøring",
                Description = "Tasks to be completed in the afternoon.",
                TaskStatus = TaskListStatus.InProgress,
                DueTime = DateTime.Now.AddHours(4)
            },
            new TaskList
            {
                Id = Guid.Parse("11223344-5566-7788-99AA-BBCCDDEEFF00"),
                Title = "lave aftensmad",
                Description = "Tasks to be completed in the evening.",
                TaskStatus = TaskListStatus.InProgress,
                DueTime = DateTime.Now.AddHours(6)
            }
        );

    }
}