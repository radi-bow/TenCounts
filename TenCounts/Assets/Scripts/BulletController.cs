using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    public GameManager gameManager;
    public GameObject bullet;

    private float bulletTime;
    private float interval;
	// Use this for initialization
	void Start () {
        bulletTime = 0.0f;
        interval = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if(!gameManager.inGame){
            bulletTime = 0.0f;
            return;
        }
        bulletTime += Time.deltaTime;
        if(bulletTime > interval){
            bulletTime = 0.0f;
            interval = 1.0f / gameManager.level * Random.Range(0.9f,1.1f);
            int pos = Random.Range(0, 10);
            Instantiate(bullet, CalcualteBulletPos(pos), Quaternion.identity);
        }
	}

    Vector3 CalcualteBulletPos(int num)
    {
        return new Vector3(-7.2f + 1.6f * num, 3.0f, -1.0f);
    }
}
