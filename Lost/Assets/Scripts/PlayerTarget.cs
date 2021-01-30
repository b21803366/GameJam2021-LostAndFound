using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTarget : MonoBehaviour
{
    public float hitPoint = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void TakeDamage(float amount)
    {
        hitPoint -= amount;
        if (hitPoint <= 0f)
        {
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(scene.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
