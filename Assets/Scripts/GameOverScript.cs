using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{ 
  Vector3 movement = new Vector3(1, 0, 0);
  void Update()
  {
    transform.Translate(movement * Time.deltaTime);
  }
}
