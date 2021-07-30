using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class noteAppear : MonoBehaviour
{
    [SerializeField]
    private Image _noteImage;
  // Start is called before the first frame update
  void OnTriggerEnter(Collider other){
      if(other.CompareTag("Player")){
          _noteImage.enabled=true;
      }
  }
  void OnTriggerExit(Collider other){
      if(other.CompareTag("Player")){
          _noteImage.enabled=false;
      }
  }
}
