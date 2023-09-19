using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float moveSpeed;

    GameController m_gc;

    // Start is called before the first frame update
    void Start()
    {
        m_gc = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3.left = (-1, 0, 0)
        //(-1, 0, 0) * 5 = (-5, 0, 0)

        transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.CompareTag("SceneLimit"))
        {   
            m_gc.ScoreIncrement();

            Debug.Log("Nguoi choi da duoc 1 diem");

            Destroy(gameObject);
        } 
    }
}
