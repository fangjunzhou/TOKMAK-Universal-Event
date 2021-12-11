using FinTOKMAK.EventSystem.Runtime;
using Hextant;
#if UNITY_EDITOR
using Hextant.Editor;
using UnityEditor;
#endif
using UnityEngine;

namespace DefaultNamespace
{
    [Settings( SettingsUsage.RuntimeProject, "Sample Local Event" )]
    public sealed class LocalEventSettings : Settings<LocalEventSettings>
    {
        public UniversalEventConfig universalEventConfig;
        
#if UNITY_EDITOR
        [SettingsProvider]
        static SettingsProvider GetSettingsProvider() =>
            instance.GetSettingsProvider();
#endif
    }
}