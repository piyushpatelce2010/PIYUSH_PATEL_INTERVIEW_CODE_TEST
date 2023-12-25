using System;

namespace DeveloperSample.ClassRefactoring
{
    public enum SwallowType
    {
        African, European
    }

    public enum SwallowLoad
    {
        None, Coconut
    }

    public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType, SwallowLoad swallowLoad) => new Swallow(swallowType, swallowLoad);
    }

    public class Swallow
    {
        public SwallowType Type { get; }
        public SwallowLoad Load { get; }

        public Swallow(SwallowType swallowType, SwallowLoad load)
        {
            Type = swallowType;
            Load = load;
        }

        public double GetAirspeedVelocity()
        {
            int intVal = 0;
            if (Type == SwallowType.African && Load == SwallowLoad.None)
                    intVal = 22;
            else if (Type == SwallowType.African && Load == SwallowLoad.Coconut)
                    intVal = 18;
            else if (Type == SwallowType.European && Load == SwallowLoad.None)
                    intVal= 20;
            else if (Type == SwallowType.European && Load == SwallowLoad.Coconut)
                     intVal = 16;
            return intVal;
        }
    }
}