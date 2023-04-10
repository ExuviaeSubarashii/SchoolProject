using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTouchpoint : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (name.Contains("Clone") && collision.gameObject.tag == "ObjectTouchpoint")
        {
            transform.gameObject.SetActive(false);
        }
        if (name.Contains("Clone") && collision.gameObject.name == "LaunchOffSet" && collision.contactCount > 2)
        {
            transform.gameObject.SetActive(false);
            ScoreManager.instance.AddTwoPoints();
        }
    }
}
