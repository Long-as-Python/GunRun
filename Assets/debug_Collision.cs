using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug_Collision : MonoBehaviour
{
    void OnCollisionStay(Collision other)
    {
        Debug.LogError(other.gameObject.name);
    }
}
