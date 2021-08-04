using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomToNote : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene()
    {
        SceneManager.LoadScene("Book");
    }
}
