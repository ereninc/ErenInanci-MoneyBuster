using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomShaderScreenDivider : MonoBehaviour
{
    [SerializeField] Material mat;
    private Vector2 screenPixel;

    private void Update()
    {
        screenPixel = Camera.main.WorldToScreenPoint(transform.position);
        screenPixel = new Vector2(screenPixel.x / Screen.width, screenPixel.y / Screen.height);

        mat.SetVector("_ObjectScreenPosition", screenPixel);
    }
}