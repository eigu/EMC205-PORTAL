using UnityEngine;

public class Enemy : MonoBehaviour
{
  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("Object"))
    {
      Destroy(gameObject);
    }
  }
}
