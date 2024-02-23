using System;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHanlder : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent onRaiseEvent;

    private void Start()
    {
        gameActionObj.rasise += Raise;
    }

    private void Raise()
    {
        onRaiseEvent.Invoke();
        
    }
}
