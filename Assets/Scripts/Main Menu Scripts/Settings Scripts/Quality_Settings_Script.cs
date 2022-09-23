using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quality_Settings_Script : MonoBehaviour
{
    public void mSetQuality(int xQualityIndex)
    {
        QualitySettings.SetQualityLevel(xQualityIndex);
    }
}
