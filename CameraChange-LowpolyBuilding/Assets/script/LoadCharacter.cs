using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
  // Start is called before the first frame update
  public GameObject[] characterPrefabs;
  public Transform spawnPoint;

  void Start()
  {
    int selectedCharacter = PlayerPrefs.GetInt("selctionIndex");
    GameObject prefab = characterPrefabs[selectedCharacter];
    GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
  }
}
