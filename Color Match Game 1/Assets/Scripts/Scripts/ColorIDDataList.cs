using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIdList;

    public ColorID currentColor;

    private int num;

    public void SetCurrentColorRandomly()
    {
        num = colorIdList.Count - 1;
        currentColor = colorIdList[num];
    }

}
