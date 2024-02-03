using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IdContanorBehavoir : MonoBehaviour
{
    public ID idobj;
    public UnityEvent startEvent;
    
    public void Start()
    {
        startEvent.Invoke();
    }
}
