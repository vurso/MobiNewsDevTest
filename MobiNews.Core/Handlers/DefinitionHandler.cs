using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MobiNews.Core.Handlers
{
    public class DefinitionHandler : IDefinitionHandler
    {
        public void Process<T>(T definition)
        {
            var _def = definition.GetType();
            var instance = Activator.CreateInstance(_def);
            MethodInfo minfo = _def.GetMethod(
                "Process",
                BindingFlags.Instance | BindingFlags.Public);

            minfo.Invoke(instance, null);
        }

        public void Process<T>(T definition, object paramArray)
        {

        }

        private static bool searchFilter(MemberInfo m, object filterCriteria)
        {
            if (m.Name.ToString() == filterCriteria.ToString())
                return true;
            else
                return false;
        }
    }
}