using OOP_TimothyHsu.Models;

namespace OOP_TimothyHsu.Interfaces
{
    public interface ILoggable
    {
        LogMessage LogMessage { get; }//no set, so readonly property
    }
}
