using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityAbstractions;

public class AuditableEntity : TrackableEntity
{
    public DateTime? Created { get; init; }
    public Guid? CreatedBy { get; init; }
    public DateTime? Modified { get; private set; }
    public Guid? ModifiedBy { get; private set; }

    protected AuditableEntity() : base()
    {
    }

    protected AuditableEntity(Guid? id) : base(id)
    {
    }

    protected void Updated(Guid id)
    {
        ModifiedBy = id;
        Modified = DateTime.UtcNow;
    }
}