using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

//using UnityEngine.SceneManagement;
public class CollisionDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public int collisionDamage = 1;
    public string collisionTag;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == collisionTag /*&& other.gameObject.tag == "Respawn"*/ )
        {
            HealthSystem health = other.gameObject.GetComponent<HealthSystem>();
            health.TakeHit(collisionDamage);
            //SceneManager.LoadScene(0);
        }
    }
}
