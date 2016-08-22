﻿/// <summary>
/// Calculator panel.
/// Provides functionalty for calculating material needed to cover a wall area.
///
/// Created by Jorge L. Chavez Herrera.
/// </summary>
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class CalculatorPanel : Panel 
{
	#region Class members
	public InputField height;
    public InputField width;
    public InputField windowCount;
	public GameObject resultPanel;
    public Text resultText;
	#endregion

	#region MonoBehaviour overrides
	#endregion

	#region Panel overrides
	#endregion

	#region Class implementation
	public void GetTotal()
    {
        float h = 0;
        float.TryParse(height.text, out h);

        float w = 0;
        float.TryParse(width.text, out w);

        int wc = 0;
        int.TryParse(windowCount.text, out wc);

        resultText.text = string.Format("Necesitarás {0:0.00} lts", ((h * w * .0909f) - (wc * .02f)).ToString());

        resultPanel.SetActive(true);
    }
	#endregion
}