﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreViewer : MonoBehaviour
{
    ComboCounter m_comboCounter => GetComponent<ComboCounter>();
    [SerializeField] TextMeshProUGUI m_scoreText;
    // Update is called once per frame
    void Update()
    {
        m_scoreText.text = $"{m_comboCounter.CurrentComboCount}";
    }
}
