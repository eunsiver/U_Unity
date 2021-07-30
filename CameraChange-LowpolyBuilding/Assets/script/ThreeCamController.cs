using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeCamController : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera[] arrCam;
  public int nCamCount;
  int nNowCam = 0;

  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetButtonUp("Fire3"))
    {
      ++nNowCam;
    }
    if (nNowCam >= nCamCount)
    {
      nNowCam = 0;
    }
    for (int i = 0; i < arrCam.Length; i++)
    {
      arrCam[i].enabled = (i == nNowCam);
    }
  }
}
