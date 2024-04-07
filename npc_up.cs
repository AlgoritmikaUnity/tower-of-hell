using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public float posx;
    // Start is called before the first frame update
    void Start()
    {
        posx = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        posx += 0.01f;
        transform.position = new Vector3(25, posx, 25);
    }
}
