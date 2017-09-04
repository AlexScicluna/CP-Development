using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour {

    //Varibles
    public float scrollSpeed = 0.5F;
    public Renderer rend;


    // Use this for initialization
    void Start()
    {
        //Set up rend
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Creates an offset variable
        float offset = Time.time * scrollSpeed;

        //Allows for the texture to scroll based on the offset
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
