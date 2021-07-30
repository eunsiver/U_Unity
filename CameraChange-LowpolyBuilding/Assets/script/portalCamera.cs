using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalCamera : MonoBehaviour
{
  public Transform playerCamera;
  public Transform portal;
  public Transform otherPortal;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    Vector3 playerOffsetFromProtal = playerCamera.position - otherPortal.position;
    transform.position = portal.position + playerOffsetFromProtal;
    float angularDifferenceBetweenProtalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation);
    Quaternion portalRotationalDifference = Quaternion.AngleAxis(angularDifferenceBetweenProtalRotations, Vector3.up);
    Vector3 newCameraDirection = portalRotationalDifference * playerCamera.forward;
    transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);

  }
}
