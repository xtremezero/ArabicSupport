using UnityEngine;
using System.Collections;
using ArabicSupport;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class FixArabic3DText : MonoBehaviour {

    public bool showTashkeel = true;
    public bool useHinduNumbers = true;

    // Use this for initialization
    void Start () {
        TextMesh textMesh = gameObject.GetComponent<TextMesh>();
        TextMeshPro textMeshPro = gameObject.GetComponent<TextMeshPro>();
        TextMeshProUGUI textMeshProUGUI = gameObject.GetComponent<TextMeshProUGUI>();
        Text text_cmp = gameObject.GetComponent<Text>();

        string oldText = "";
        if(textMesh) oldText= textMesh.text ;
        if(textMeshPro) oldText= textMeshPro.text ;
        if(textMeshProUGUI) oldText= textMeshProUGUI.text ;
        if(text_cmp) oldText= text_cmp.text ;


        string fixedText = ArabicFixer.Fix(oldText, showTashkeel, useHinduNumbers);

        if(textMesh) textMesh.text = fixedText;
        if(textMeshPro) textMeshPro.text = fixedText;
        if(textMeshProUGUI) textMeshProUGUI.text = fixedText;
        if(text_cmp) text_cmp.text = fixedText;

		Debug.Log(fixedText);
    }

}
