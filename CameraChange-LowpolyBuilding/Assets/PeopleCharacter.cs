using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleCharacter : MonoBehaviour
{
  private static PeopleCharacter Instance = null;
  // Start is called before the first frame update
  private void Awake()
  {

    // if (Instance != null)
    // {
    //   Destroy(this.gameObject);
    //   return;
    // }
    // Instance = this;
    //DontDestroyOnLoad(gameObject);

    // if (Instance == null)
    //   Instance = this;
    // else
    // {
    //   Destroy(gameObject);

    // }
    DontDestroyOnLoad(gameObject);


  }

}

