using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
    public UnityAction rasise;


    public void RasiseAction()
    {
        
        rasise?.Invoke();
        
    }
}
