using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class CorutineBehavoir : MonoBehaviour
{
    public UnityEvent startevent, startCountevent, repeatCountevent, endCountevent, reapeatUntelfalseEvnet;

    public bool canrun;
    public IntData counterNum;
    
    public float seconds = 3.0f;
    
    // only uses one block of memeroy and can be turned of and onn
    private WaitForSeconds wfsOBJ;
    private WaitForFixedUpdate wffoOBJ;

    private void Start()
    {
        wfsOBJ = new WaitForSeconds(seconds);
        wffoOBJ = new WaitForFixedUpdate();
        startevent.Invoke();
        
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    
    IEnumerator Counting()
    {
        startCountevent.Invoke();
        yield return wfsOBJ;
        while (counterNum.value > 0)
        {
            repeatCountevent.Invoke();
            counterNum.value--;
            yield return wfsOBJ;
        }
        endCountevent.Invoke();
    }

    public void StartRepeateUntelFalse()
    {
        canrun = true;
        StartCoroutine(RepeateUntelFalse());
    }
    
    
    private IEnumerator RepeateUntelFalse()
    {

        while (canrun)
        {

            yield return wfsOBJ;
            reapeatUntelfalseEvnet.Invoke();

        }
        
        
    }
    
}
