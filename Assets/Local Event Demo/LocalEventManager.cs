using FinTOKMAK.EventSystem.Runtime;
using Hextant;

namespace DefaultNamespace
{
    public class LocalEventManager : UniversalEventManager
    {
        public override UniversalEventConfig GetEventConfig()
        {
            return Settings<LocalEventSettings>.instance.universalEventConfig;
        }
    }
}