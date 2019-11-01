using System;
using System.Collections.Generic;
using System.Text;


namespace com.huaqian
{
    class TheadLink
    {





        public static void Run(Action<Object> action,Object parm1)
        {
            UnityThreadHelper.Dispatcher.Dispatch(() => { action(parm1); });
        }

        public static void Run(Action action)
        {
            UnityThreadHelper.Dispatcher.Dispatch(() => { action(); });
        }

        public static void Run(Action<Object, Object> action, Object parm1, Object parm2)
        {
            UnityThreadHelper.Dispatcher.Dispatch(() => { action(parm1,parm2); });
        }
    }
}
