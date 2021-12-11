using System;
using System.Collections;
using System.Collections.Generic;
using FinTOKMAK.EventSystem.Runtime;
using FinTOKMAK.EventSystem.Runtime.GlobalEvent;
using UnityEngine;

public class EventListener : MonoBehaviour
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

    private void Awake()
    {
        // If the GlobalEventManager is already initialized
        // Register the event directly
        if (GlobalEventManager.initialized)
        {
            GlobalEventManager.Instance.RegisterEvent(eventDataName, ResponseEventData);
            GlobalEventManager.Instance.RegisterEvent(eventGenericName, ResponseGenericData);
        }
        // If not initialized, register the operation when GlobalEventManager is initialized
        else
        {
            GlobalEventManager.finishInitializeEvent += () =>
            {
                GlobalEventManager.Instance.RegisterEvent(eventDataName, ResponseEventData);
                GlobalEventManager.Instance.RegisterEvent(eventGenericName, ResponseGenericData);
            };
        }
    }

    private void Start()
    {
        // Register the event when Start
        // GlobalEventManager.Instance.RegisterEvent(eventDataName, ResponseEventData);
        // GlobalEventManager.Instance.RegisterEvent(eventGenericName, ResponseGenericData);
    }

    private void OnDestroy()
    {
        // Unregister the event when Destroy
        GlobalEventManager.Instance.UnRegisterEvent(eventDataName, ResponseEventData);
        GlobalEventManager.Instance.UnRegisterEvent(eventGenericName, ResponseGenericData);
    }

    #region Private Field

    /// <summary>
    /// The listener of the string and int data event.
    /// </summary>
    /// <param name="data">The unconverted IGlobalEventData.</param>
    private void ResponseEventData(IEventData data)
    {
        // Convert data to the DemoGlobalEventData
        DemoGlobalEventData eventData = (DemoGlobalEventData) data;
        Debug.Log($"String message: {eventData.strMsg}; Int message: {eventData.intMsg}.");
    }

    /// <summary>
    /// The listener of the generic data event.
    /// </summary>
    /// <param name="data">The unconverted IGlobalEventData.</param>
    private void ResponseGenericData(IEventData data)
    {
        // Convert the data to DemoGlobalGenericData<float, string>
        DemoGlobalGenericData<float, string> eventData = (DemoGlobalGenericData<float, string>) data;
        Debug.Log($"Float message: {eventData.data1}; String message: {eventData.data2}.");
    }

    #endregion
}
