using FinTOKMAK.EventSystem.Runtime;
using NaughtyAttributes;
using UnityEngine;

namespace DefaultNamespace
{
    public class LocalEventCaller : MonoBehaviour
    {
        #region Public Field

        public LocalEventManager manager;

        [LocalEvent]
        public string targetEvent;

        #endregion

        [Button]
        public void InvokeEvent()
        {
            manager.InvokeEvent(targetEvent, new EventData<string>()
            {
                data1 = "Hello World!"
            });
        }
    }
}