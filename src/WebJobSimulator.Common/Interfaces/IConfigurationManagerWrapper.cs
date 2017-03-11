using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJobSimulator.Common.Interfaces
{
    public interface IConfigurationManagerWrapper
    {
        IConfigurationManagerWrapper Convert(string key);

        int ToAInt();

        bool ToABool();

        string ToAString();
    }
}
