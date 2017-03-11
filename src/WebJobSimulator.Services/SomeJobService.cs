using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebJobSimulator.Domain;

namespace WebJobSimulator.Services
{
    public class SomeJobService
    {
        public void Save(SomeJob job)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                session.SaveOrUpdate(job);
            }
        }
    }
}
