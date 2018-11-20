using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class YellowBulletDrop : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Transform>().DOMoveY(-5.0f, 3.0f)
            .SetEase(Ease.InElastic);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
