using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private int health = 10;
    public GameObject fireballPrefab;
    public Transform ballPoint;
    public Slider hpbar;
    public MANAGERUI ui;
    

    private void Start()
    {
        ui.UPDhpbar(health);
    }

    public void TakeDamage(int damage)
    {
        
         health -= damage;
        ui.ShowOLegsWords("aboba");
        ui.UPDhpbar(health);
        hpbar.value = health;
  
        if (health <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,
      ballPoint.
      position, ballPoint.
      rotation);
        }
    }
}
