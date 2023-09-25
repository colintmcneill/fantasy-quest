using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BattleScript : MonoBehaviour
{
    public bool success = false;
    public GameObject WinText;
    public GameObject LoseText;
    public GameObject BattleMusic;
    public GameObject WinMusic;
    public GameObject LoseMusic;
    public GameObject GameMusic;
    public int speed;
    public GameObject player;
    public GameObject outerSquare;
    public GameObject innerSquare;
    public GameObject resetButton;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        resetButton.SetActive(false);
        player.GetComponent<PlayerScript>().enabled = false;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, rb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.x < (player.transform.position.x - 20)) {
            rb.position = new Vector2(player.transform.position.x + 20, rb.position.y);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Hit();
        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Title");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        success = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        success = false;
    }

    public void Hit()
    {
        resetButton.SetActive(true);
        GameMusic.SetActive(false);
        BattleMusic.SetActive(false);
        

        if (success)
        {
            WinText.SetActive(true);
            WinMusic.SetActive(true);
        }
        else
        {
            LoseText.SetActive(true);
            LoseMusic.SetActive(true);
        }
        outerSquare.SetActive(false);
        innerSquare.SetActive(false);


    }

    public void Reset()
    {
        SceneManager.LoadScene("Title");
    }

}
