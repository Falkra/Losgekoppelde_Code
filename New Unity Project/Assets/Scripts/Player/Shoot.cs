using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    [SerializeField]
    private Enemy enemy;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && enemy != null)
        {
            // Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            enemy.GetComponent<Enemy>().Die();
        }
    }
}
