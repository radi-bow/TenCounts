using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleButtonController : MonoBehaviour
{
    public GameManager gameManager;
    [SerializeField] Canvas startCanvas;
    [SerializeField] Canvas endCanvas;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        gameManager.inTitle = true;
        gameManager.inGameOver = false;
        gameManager.inGame = false;

        startCanvas.gameObject.SetActive(true);
        endCanvas.gameObject.SetActive(false);
        gameManager.time = 0.0f;
        gameManager.level = 1;
    }
}
