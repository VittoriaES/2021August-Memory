using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public void Change (string sceneName) {

        SceneManager.LoadScene(sceneName);
    }

    public void LoadGameScene(int level){
        int row, column;
        switch(level) {
            case 1:
                row = 2;
                column = 3;
                break;
            case 2: 
                row = 3;
                column = 4;
                break;
            default: 
                row = 4;
                column = 5;
                break;
        }
        PlayerPrefs.SetInt("row", row);
        PlayerPrefs.SetInt("column", column);
        SceneManager.LoadScene("GameScene");
    }

    public void Exit() {
        Application.Quit();
    }


}
