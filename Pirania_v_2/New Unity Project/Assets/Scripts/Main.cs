using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Stats_ns;


public class Main : MonoBehaviour
{
    public Stats stats;
    //public PlayerController player;
    public Text coordinates;
    public GameObject PauseScreen;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //    coordinates.text = stats.GetCoordinates().ToString();
    }

    public void PauseOn()
    {
        Time.timeScale = 0f;
        //player.enabled = false;
        PauseScreen.SetActive(true);
    }

    public void PauseOff()
    {
        Time.timeScale = 1f;
        //player.enabled = true;
        PauseScreen.SetActive(false);
    }


    public void OpenScene(int index)
    {
        SceneManager.LoadScene(index);
    }

}
