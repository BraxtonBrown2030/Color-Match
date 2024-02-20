using System.Collections;
using UnityEngine;

public class DestroyBehavoir : MonoBehaviour
{
    public float seconds = 1f;
    private WaitForSeconds wfsobj;
    
    
    IEnumerator Start()
    {
        wfsobj = new WaitForSeconds(seconds);
        
        yield return wfsobj;
        Destroy(gameObject);

    }

}
