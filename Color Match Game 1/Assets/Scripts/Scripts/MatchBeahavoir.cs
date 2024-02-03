using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBeahavoir : MonoBehaviour
{
    public ID idobj;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IdContanorBehavoir>();
        if(tempObj == null)
            yield break;
        var otherID = tempObj.idobj;
        if (otherID == idobj)
        {
  
            matchEvent.Invoke();
            
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }
    }
}
