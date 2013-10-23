using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOPConPostsharp.Aspects
{
    [Serializable] 
    public sealed class TimeTraceAspect : OnMethodBoundaryAspect
    {
        private readonly string _name;

        [NonSerialized]
        System.Diagnostics.Stopwatch watch;

        public TimeTraceAspect(string name)
        {
            _name = name;
        }

        public TimeTraceAspect()
        {
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Console.WriteLine(string.Format("Inicio Metodo {0}", _name ?? args.Method.Name));
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            watch.Stop();
            Console.WriteLine(string.Format("Fin Metodo {0}. Tiempo {1}", _name ?? args.Method.Name, watch.ElapsedMilliseconds));
        } 
    } 
}
