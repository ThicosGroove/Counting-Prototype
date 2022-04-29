using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereColor : MonoBehaviour
{
    public ScriptableColor color;

    private MeshRenderer texture;

    // Start is called before the first frame update
    void Start()
    {
        texture = GetComponent<MeshRenderer>();

        texture.material.SetColor("_Color", color.color);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
