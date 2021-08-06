using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class characterCreation : MonoBehaviour
{
  private List<GameObject> models;
  //   public GameObject[] models;
  private int selctionIndex = 0;
  private void Start()
  {

    //     models = new GameObject[transform.childCount];

    //     for (int i = 0; i < transform.childCount; i++)
    //     {
    //       models[i] = transform.GetChild(i).gameObject;
    //     }
    //     foreach (GameObject go in models)
    //       go.SetActive(false);
    //     if (models[0])
    //       models[0].SetActive(true);
    //   }
    selctionIndex = PlayerPrefs.GetInt("characterSelected");
    models = new List<GameObject>();
    foreach (Transform i in transform)
    {
      models.Add(i.gameObject);
      i.gameObject.SetActive(false);
    }
    models[selctionIndex].SetActive(true);
  }
  //   private void Update()
  //   {
  //     if (Input.GetKeyDown(KeyCode.A))
  //       Select(4);
  //   }
  //   public void Select(int index)
  //   {
  //     if (index == selctionIndex)
  //       return;
  //     if (index < 0 || index >= models.Length)
  //       return;
  //     models[selctionIndex].SetActive(false);
  //     selctionIndex = index;
  //     models[selctionIndex].SetActive(true);
  //   }
  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.A))
      Select(4);
  }
  public void Select(int index)
  {
    if (index == selctionIndex)
      return;
    if (index < 0 || index >= models.Count)
      return;
    models[selctionIndex].SetActive(false);
    selctionIndex = index;
    models[selctionIndex].SetActive(true);
  }
  public void SaveBtn()
  {
    PlayerPrefs.SetInt("characterSelected", selctionIndex);
    SceneManager.LoadScene("TestPlayGround 1");
  }

}
