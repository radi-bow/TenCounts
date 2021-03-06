﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour {
    public GameManager gameManager;
    public int firstField = 5;
    private int field;

    public AudioSource audioSource;
    public AudioClip destroySound;

    public Sequence sequence;

	// Use this for initialization
	void Start () {
        field = firstField;
        this.GetComponent<Transform>().position = CalcualteField(field);
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.LeftArrow) && field > 0){
            field--;
            //this.GetComponent<Transform>().position = CalcualteField(field);
            this.GetComponent<Transform>().DOMove(CalcualteField(field), 0.2f)
                .SetEase(Ease.InOutElastic)
                .OnKill(End);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) && field < 9){
            field++;
            this.GetComponent<Transform>().DOMove(CalcualteField(field), 0.2f)
                .SetEase(Ease.InOutElastic)
                .OnKill(End);
        }
	}

    Vector3 CalcualteField(int num)
    {
        return new Vector3(-7.2f + 1.6f * num, -3.0f, -1.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            sequence = DOTween.Sequence()
                                       .Append(this.GetComponent<Transform>().DOScale(0.6f, 1.0f).SetEase(Ease.InExpo))
                                       .Join(this.GetComponent<Rigidbody2D>().DORotate(360.0f, 1.0f).SetEase(Ease.OutExpo))
                                       .OnKill(End);
            sequence.Play();
            audioSource.PlayOneShot(destroySound);
            Destroy(collision.gameObject);
            gameManager.GameOver();
        }
    }

    void End(){
        // not implemented
    }

}
