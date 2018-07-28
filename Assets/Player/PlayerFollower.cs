using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour {

    [SerializeField] public Transform toFollow;
    [SerializeField] public BoxCollider2D _collider;

	
	void Update () {
        Vector3 newPosition = toFollow.position;
        newPosition = _collider.bounds.ClosestPoint(newPosition);
        newPosition.z = transform.position.z;
        transform.position = newPosition;
	}


}
