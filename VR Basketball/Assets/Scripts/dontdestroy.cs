using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Start called");
	}

    private void Awake()
    {
        Debug.Log("awake called");
        DontDestroyOnLoad(gameObject);
        Time.timeScale = 1;
    }
}
