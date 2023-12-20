﻿using YoutubeApi.Domain.Common;

namespace YoutubeApi.Domain.Entities;

public class Category : EntityBase
{
    public Category()
    {

    }
    public Category(int parentId, string name, int priority)
    {
        ParentId = parentId;
        Name1 = name;
        Priority = priority;
    }
    public required int ParentId { get; set; }
    public string Name1 { get; }
    public required int Name { get; set; }
    public required int Priority { get; set; }
    public ICollection<Detail> Details { get; set; }
    public ICollection<Product> products { get; set; }
}

