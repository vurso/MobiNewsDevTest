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
        public void Process<T>(T definition, object[] paramArray)
        {
            var _def = definition.GetType();
            var _param = paramArray.GetType();
            //var instance = Activator.CreateInstance(_def, _param);
            var instance = CreateInstance(_def, paramArray);
            MethodInfo minfo = _def.GetMethod(
                "Process",
                BindingFlags.Instance | BindingFlags.Public);

            minfo.Invoke(instance, null);
        }

        public static object CreateInstance(Type context, params object[] Params) // params keyword for array
        {
            List<Type> argTypes = new List<Type>();

            //used .GetType() method to get the appropriate type
            //Param can be null so handle accordingly
            foreach (object Param in Params)
                argTypes.Add((Param ?? new object()).GetType());
            ConstructorInfo[] Types = context.GetConstructors();
            foreach (ConstructorInfo node in Types)
            {
                ParameterInfo[] Args = node.GetParameters();
                if (Params.Length == Args.Length)
                {
                    bool[] cond = new bool[Params.Length];
                    //handle derived types
                    for (int i = 0; i < Params.Length; i++)
                        if (Args[i].ParameterType.IsAssignableFrom(argTypes[i])) cond[i] = true;
                    if (cond[0])
                        return node.Invoke(Params);
                }
            }
            return null;
        }
    }
}