using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIdBehavoir : IdContanorBehavoir
{
    public ColorIDDataList colorIDDataListobj;

    private void Awake()
    {
        idobj = colorIDDataListobj.currentColor;
    }
}
