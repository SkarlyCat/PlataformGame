using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int lifes = 3;
    public bool haveKey;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        if (lifes <= 0)
        {
          SceneManager.LoadScene(0);
        }
        
    }
}
