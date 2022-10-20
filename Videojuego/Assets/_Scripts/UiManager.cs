using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] Image lifeIndicator;
    [SerializeField] Sprite[] lifesprites;

    [SerializeField] GameObject[] panelController;

    [SerializeField] TMP_Text[] dialogs;



    private void Update()
    {
        if(lifeIndicator !=null)
        {
          lifeIndicator.sprite = lifesprites[gameManager.lifes];

        }
    }


    public void Stargame()
    {
        SceneManager.LoadScene(1);

    }
}
