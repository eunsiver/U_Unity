using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoadTester : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  public void load()
  {
    //if (Input.GetKeyDown(KeyCode.Space))
    // LevelLoader.LoadScene("SimpleNaturePack_Demo");
    LevelLoader.LoadScene("SampleScene");
  }
}
