﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blackground : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float animationSpeed = 1f;
    // Start is called before the first frame update
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
