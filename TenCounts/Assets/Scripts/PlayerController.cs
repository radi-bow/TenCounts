using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public GameManager gameManager;
    public int firstField = 5;
    private int field;

	// Use this for initialization
	void Start () {
        field = firstField;
        this.GetComponent<Transform>().position = CalcualteField(field);
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.LeftArrow) && field > 0){
            field--;
            this.GetComponent<Transform>().position = CalcualteField(field);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) && field < 9){
            field++;
            this.GetComponent<Transform>().position = CalcualteField(field);
        }
	}

    Vector3 CalcualteField(int num){
        return new Vector3(-7.2f + 1.6f * num, -3.0f, -1.0f);
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet"){
            Destroy(collision.gameObject);
            gameManager.GameOver();
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            gameManager.GameOver();
        }
    }
}
