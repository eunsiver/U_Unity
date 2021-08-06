using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySctipt : MonoBehaviour
{
  protected Joystick joystick;
  public float moveSpeed = 8f;
  // Start is called before the first frame update
  void Start()
  {
    joystick = FindObjectOfType<Joystick>();

  }

  // Update is called once per frame
  void Update()
  {
    var rigidBody = GetComponent<Rigidbody>();
    rigidBody.velocity = new Vector3(joystick.Horizontal * moveSpeed,
    rigidBody.velocity.y, joystick.Vertical * moveSpeed);
  }
}
