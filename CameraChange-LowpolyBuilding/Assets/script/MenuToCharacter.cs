using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToCharacter : MonoBehaviour
{


  // Update is called once per frame
  public void load()
  {
    //if (Input.GetKeyDown(KeyCode.Space))
    // LevelLoader.LoadScene("SimpleNaturePack_Demo");
    SceneManager.LoadScene("characterCreation");
  }
}
