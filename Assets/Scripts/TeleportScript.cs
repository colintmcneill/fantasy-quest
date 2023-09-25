using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    private Vector2 teleportLocation;
    public float teleport_x;
    public float teleport_y;

    private void Start()
    {
        teleportLocation = new Vector2(teleport_x, teleport_y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = teleportLocation;
    }
}
