using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    public Image redbox;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < 7; i++)
        {
            float x;
            x = i * 45.6f;
            Instantiate(redbox, new Vector3(-134f + x, -164, 0), Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
