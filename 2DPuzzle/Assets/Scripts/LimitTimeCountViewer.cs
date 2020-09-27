using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LimitTimeCountViewer : MonoBehaviour
{
    public float m_limitTime;
    [SerializeField] TextMeshProUGUI m_TimeText;

    // Start is called before the first frame update
    void Start()
    {
        m_limitTime = 60.0f;
    }

    // Update is called once per frame
    void Update()
    {

        if (m_limitTime >= 0)
        {
            m_limitTime -= Time.deltaTime;
        }
        m_TimeText.text = $"Time : {m_limitTime.ToString("f2")}";
    }
}
