using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text textComponent;

    private int coinCount;

    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void changeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    public void AddCoinCount()
    {
        coinCount++;
        Debug.Log("CoinCount : " + coinCount.ToString());
        textComponent.text = "CoinCount : " + coinCount.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
        coinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
