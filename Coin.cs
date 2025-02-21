using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject player;
    public GameObject coin;
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Player>().coins += 1;
        Destroy(coin, 1);
    }
}
