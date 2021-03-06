﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListMaintainer
    {
        public int FilterListId { get; set; }
        public FilterList FilterList { get; private set; } = null!;
        public int MaintainerId { get; set; }
        public Maintainer Maintainer { get; private set; } = null!;
    }

    internal class FilterListMaintainerTypeConfiguration : IEntityTypeConfiguration<FilterListMaintainer>
    {
        public virtual void Configure(EntityTypeBuilder<FilterListMaintainer> builder)
        {
            builder.ToTable(nameof(FilterListMaintainer) + "s");
            builder.HasKey(flm => new {flm.FilterListId, flm.MaintainerId});
            builder.HasDataJsonFile<FilterListMaintainer>();
        }
    }
}
