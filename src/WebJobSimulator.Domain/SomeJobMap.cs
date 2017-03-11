using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJobSimulator.Domain
{
    public class SomeJobMap : ClassMap<SomeJob>
    {
        public SomeJobMap()
        {
            Id(j => j.Id).UnsavedValue(0);
            Map(j => j.Name).Nullable();
        }
    }
}
