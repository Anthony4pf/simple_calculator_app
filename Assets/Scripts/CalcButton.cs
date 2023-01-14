using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcButton : MonoBehaviour
{
    public Text label;
    RectTransform _rectTransform;
    static CalcManager _calcManager;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public RectTransform rectTransform
    {
        get
        {
            if (_rectTransform == null)
                _rectTransform = GetComponent<RectTransform>();
            return _rectTransform;
        }
    }
    public CalcManager calcManager
    {
        get
        {
            if (_calcManager == null)
                _calcManager = GetComponentInParent<CalcManager>();
            return _calcManager;
        }
    }
    public void OnTapped()
    {
        calcManager.buttonTapped(label.text[0]);
    }
}
