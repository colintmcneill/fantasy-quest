using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogScript : MonoBehaviour
{
    public string[] dialog;
    private int dialogLength;
    int curText = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<Canvas>().enabled = false;
        GetComponentInChildren<Text>().text = dialog[0];
        dialogLength = dialog.Length;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponentInChildren<Text>().text = dialog[curText];
    }

    public void AdvanceDialog()
    {
        if (curText < dialogLength - 1)
        {
            curText++;
        }
        else
        {
            GetComponentInChildren<Canvas>().enabled = false;
            curText = 0;

        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponentInChildren<Canvas>().enabled = true;
    }

}
