using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public int numberOfLives;
    public Image[] lives;
    public int maxHealth;
    public Sprite fullLive;
    public Sprite emptyLive;
    private bool hasEntered;
    Vector2 startPosition;
    
    public void TakeHit(int damage)
    {
        health -= damage;
    }


    // Start is called before the first frame update
    void Start()
    {
        
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(health> numberOfLives)
        {
            health = numberOfLives;
        }


        for (int i = 0; i < lives.Length; i++)
        {
            if(i < health)
            {
                lives[i].sprite = fullLive;
            }
            else
            {
                lives[i].sprite = emptyLive;
            }



            if(i< numberOfLives)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }
        }

        if(health == 0)
        {
            SceneManager.LoadScene(0);
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Respawn" && !hasEntered)
        {
            Reset();
            //Destroy(gameObject);
            //LevelManager.instance.Respawn();

        }
    }

    private void Reset()
    {
        transform.position = startPosition;
    }
}
