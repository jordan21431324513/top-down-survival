using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI text;

    // Update is called once per frame
    void Update()
    {
        text.text = "Health: " + GameObject.FindGameObjectWithTag("player").GetComponent<PlayerMovement>().health;
        if(GameObject.FindGameObjectWithTag("player").GetComponent<PlayerMovement>().health <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
