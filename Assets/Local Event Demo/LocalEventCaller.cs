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
        
        [LocalEvent]
        public string specifiedEvent = "root/SUB_DIR_2/EVENT_1";

        [LocalEvent]
        public string specifiedEvent2 = "root/SUB_DIR_2/EVENT_2";
        
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