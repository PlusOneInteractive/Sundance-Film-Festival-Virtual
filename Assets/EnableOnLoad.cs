using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnableOnLoad : MonoBehaviour {

   public GameObject[] gameObjectsToEnable;
	// Use this for initialization
	void Start () {
        foreach (GameObject gameObject in gameObjectsToEnable) {
            gameObject.SetActive(true);
        }
	}
}
