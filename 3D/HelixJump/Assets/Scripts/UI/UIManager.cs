using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text txtCurrentScore;
    public Text txtBestScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        txtCurrentScore.text = "Score: " + GameManager.singleton.currentScore;
        
        txtBestScore.text = "Best: " + GameManager.singleton.bestScore;
    }
}
