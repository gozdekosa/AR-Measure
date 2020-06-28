using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonhandler : MonoBehaviour {

	public void RestartGame()
    {
        SceneManager.LoadScene("E_ARCore_Base");
    }
}
