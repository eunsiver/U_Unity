using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonClickCamChange : MonoBehaviour
{
  // Start is called before the first frame update
  public Button button;
  public Camera[] arrCam;
  public int nCamCount;
  int nNowCam = 1;
  // void Start()
  // {
  //   Button btn = button.GetComponent<Button>();
  //   btn.onClick.AddListener(TaskOnClick);
  // }

  // Update is called once per frame
  public void TaskOnClick()
  {
    ++nNowCam;
    if (nNowCam >= nCamCount)
    {
      nNowCam = 0;
    }
    for (int i = 0; i < arrCam.Length; i++)
    {
      arrCam[i].enabled = (i == nNowCam);
      Debug.Log(nNowCam);
    }
  }

}
