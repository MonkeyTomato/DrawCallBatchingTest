using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSet : MonoBehaviour
{
    public bool isSetShareMaterial;

    void Start()
    {
        var renders = GetComponentsInChildren<Renderer>();
        foreach (var render in renders)
        {
            if (isSetShareMaterial)
            {
                render.sharedMaterial.color = Random.ColorHSV();
            }
            else
            {
                render.material.color = Random.ColorHSV();
            }
        }
    }
}
