using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightmapCopy : MonoBehaviour
{
    public MeshRenderer meshRenderer;

    void Start()
    {
    }


    public void OnValidate()
    {
        if (meshRenderer == null)
            return;
        var myRenderer = GetComponent<MeshRenderer>();
        myRenderer.lightmapIndex = meshRenderer.lightmapIndex;
        myRenderer.lightmapScaleOffset = meshRenderer.lightmapScaleOffset;
    }
}
