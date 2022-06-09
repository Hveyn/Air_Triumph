using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
    public static IEnumerator MoveToTarget(Transform obj, Vector3 target, float speed)
    {
        if(obj == null) yield break;

        while(obj.position != target  )
        {
            obj.position=Vector3.MoveTowards(obj.position, target, speed*Time.deltaTime);
            yield return null;
        }
    }
}
