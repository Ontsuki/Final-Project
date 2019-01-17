using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBomb : MonoBehaviour {
    //這是決定哪個格子放地雷的script
    //public GameController int[,] grid;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int a = Random.Range(0,5);
        int b = Random.Range(0, 5);
        //int[] grid = [a, b];
	}

}
