using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Activity.ValueObject
{
    public sealed class ActivityId
    {
        public Guid Value{get;}
        private ActivityId(Guid value)
        {
            Value = value;
        }

        public static ActivityId Create()
        {
            return new ActivityId(Guid.NewGuid());
        }
    };
}