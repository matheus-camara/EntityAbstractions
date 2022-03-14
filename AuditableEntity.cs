using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityAbstractions;

public class AuditableEntity : TrackableEntity
{
    public DateTime? Created { get; }
    public Guid? CreatedBy { get; }
    public DateTime? Modified { get; }
    public Guid? ModifiedBy { get; }

    protected AuditableEntity() : base()
    {
    }

    protected AuditableEntity(Guid? id) : base(id)
    {
    }
}