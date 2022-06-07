using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject prefabHpBar;
    public GameObject canvas;

    RectTransform hpBar;

    public float enemyHeight = 1.7f;

    // Start is called before the first frame update
    void Start()
    {
        hpBar = Instantiate(prefabHpBar, canvas.transform).GetComponent<RectTransform>();    
    }

    // Update is called once per frame
    void Update()
    {
        hpBar.position = Camera.main.WorldToScreenPoint(new Vector3(transform.position.x, transform.position.y + enemyHeight, 0));
    }
}
