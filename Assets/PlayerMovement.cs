using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

 private Vector2 velocity = Vector2.zero;
 void Update() {
  velocity.y = Input.GetAxis ("Vertical");
  velocity.x = Input.GetAxis ("Horizontal");
  rigidBody.AddRelativeForce (velocity * 30);
 }

 private float rotateFactor;
 void FixedUpdate(){
  Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);
  Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
  float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen) + 90;
  var lerpedRotation = Mathf.MoveTowardsAngle(rigidBody.rotation, angle, 150 * Time.deltaTime);
  rigidBody.MoveRotation(lerpedRotation);
 }

 float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
  return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
 }

// float speed = 0.8f; 
// float turnSpeed = 0.15f;
 Rigidbody2D rigidBody;
//
//
 void Start () {
  rigidBody = GetComponent<Rigidbody2D> ();
 }
//
//
// void FixedUpdate() { 
//  
//  if (Input.GetButton ("Jump")) {
//   //Spacebar by default will make it move forward 
//   rigidBody.AddRelativeForce (Vector3.forward * speed); 
//  } 
//  // W key or the up arrow to turn upwards, S or the down arrow to turn downwards. 
//  rigidBody.AddRelativeTorque ((Input.GetAxis ("Vertical")) * turnSpeed, 0, 0);
//  // A or left arrow to turn left, D or right arrow to turn right.
//  rigidBody.AddRelativeTorque (0, (Input.GetAxis ("Horizontal")) * turnSpeed, 0);
// 
// }

// float rotationSpeed = 1.0f;
// float force = 3.0f;
//
// private Vector3 targetPosition;
// private Vector3 velocity = Vector3.zero;
// private Quaternion targetRotation;
//
// void Update () {
//  if(Input.GetMouseButton(0))
//  {
//   var pos = Input.mousePosition;
//   pos.z = Camera.main.transform.position.y;
//   pos = Camera.main.ScreenToWorldPoint(pos);
//
//   targetRotation = Quaternion.LookRotation(pos - transform.position);
//   velocity += transform.forward * Time.deltaTime * force;
//  }
//  transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
//  transform.position += velocity * Time.deltaTime;
// }
//
}