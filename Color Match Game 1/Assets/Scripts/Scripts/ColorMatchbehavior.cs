using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchbehavior : MatchBeahavoir
{

    public ColorIDDataList colorIDDataListobj;

    private void Awake()
    {
        idobj = colorIDDataListobj.currentColor;
    }

    public void ChangeColor(SpriteRenderer renderer)
    {
        var newcolor = idobj as ColorID;
        renderer.color = newcolor.value;


    }
}
