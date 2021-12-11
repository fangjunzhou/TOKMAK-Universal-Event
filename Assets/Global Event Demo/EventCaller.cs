using System.Collections;
using System.Collections.Generic;
using FinTOKMAK.EventSystem.Runtime;
using FinTOKMAK.EventSystem.Runtime.GlobalEvent;
using NaughtyAttributes;
using UnityEngine;

/// <summary>
/// The sample global event data with a string message and a int message.
/// </summary>
public struct DemoGlobalEventData : IEventData
{
    public string strMsg;
    public int intMsg;
}

/// <summary>
/// The sample global event data with two generic type.
/// </summary>
/// <typeparam name="T1">The generic type 1.</typeparam>
/// <typeparam name="T2">The generic type 2.</typeparam>
public struct DemoGlobalGenericData<T1, T2> : IEventData
{
    public T1 data1;
    public T2 data2;
}

public class EventCaller : MonoBehaviour
{
    #region Public Field

    /// <summary>
    /// The name of event with string and int data.
    /// </summary>
    [GlobalEvent]
    public string eventDataName;

    /// <summary>
    /// The name of event with generic data.
    /// </summary>
    [GlobalEvent]
    public string eventGenericName;

    #endregion
    
    /// <summary>
    /// The sample method to call a Global Event with string and int data.
    /// </summary>
    [Button()]
    public void CallDataEvent()
    {
        GlobalEventManager.Instance.InvokeEvent(eventDataName, new DemoGlobalEventData()
        {
            strMsg = "Nana7mi",
            intMsg = 010
        });
    }

    /// <summary>
    /// The sample method to call a Global Event with generic type data.
    /// </summary>
    [Button()]
    public void CallGenericEvent()
    {
        GlobalEventManager.Instance.InvokeEvent(eventGenericName, new DemoGlobalGenericData<float, string>()
        {
            data1 = 0.10f,
            data2 = "ybb"
        });
    }
}
