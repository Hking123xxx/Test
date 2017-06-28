using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{


    void Update()
    {
        transform.Rotate(Vector3.up);
        Color mColor = new Color(
            Mathf.Lerp(0.5f, 1f, 0.5f),
            Mathf.Lerp(0.2f, 1f, 0.3f),
            Mathf.Lerp(0.1f, 1f, 0.6f));
        gameObject.GetComponent<Renderer>().material.color = mColor;
    }
}
