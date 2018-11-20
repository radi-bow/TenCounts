using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    public GameManager gameManager;
    public GameObject[] bullets;

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
            interval = 1.0f / gameManager.level * Random.Range(0.8f,1.2f);
            int pos = Random.Range(0, 10);
            int num = Random.Range(0, 3);
            Instantiate(bullets[num], CalcualteBulletPos(pos), Quaternion.identity);
        }
	}

    Vector3 CalcualteBulletPos(int num)
    {
        return new Vector3(-7.2f + 1.6f * num, 3.0f, -1.0f);
    }
}
