using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject player;

    // OnCollision is setting the player back to the spawn
    void OnCollision(Collider other)
    {
      player.transform.position = spawnPoint.transform.position;
    }
}


//reference from https://scholarslab.lib.virginia.edu/blog/teleporting-in-Unity3D/
