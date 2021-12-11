using FinTOKMAK.EventSystem.Editor;
using FinTOKMAK.EventSystem.Runtime;
using FinTOKMAK.EventSystem.Runtime.GlobalEvent;
using Hextant;
using UnityEditor;

namespace DefaultNamespace.Editor
{
    /// <summary>
    /// The event drawer for the GlobalEventSystem
    /// </summary>
    [CustomPropertyDrawer(typeof(LocalEventAttribute))]
    public class GlobalEventDrawer: UniversalEventDrawer
    {
        public override UniversalEventConfig GetEventConfig()
        {
            return Settings<LocalEventSettings>.instance.universalEventConfig;
        }
    }
}