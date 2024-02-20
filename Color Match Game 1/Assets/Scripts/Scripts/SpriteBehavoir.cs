using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehavoir : MonoBehaviour
{
    private SpriteRenderer rendererObj;

    private void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRenderColor(ColorID obj)
    {
        rendererObj.color = obj.value;
    }

    public void ChangeRenderColor(ColorIDDataList obj)
    {

        rendererObj.color = obj.currentColor.value;

    }
}
