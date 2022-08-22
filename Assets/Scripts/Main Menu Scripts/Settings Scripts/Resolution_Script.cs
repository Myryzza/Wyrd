using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resolution_Script : MonoBehaviour
{

    Resolution[] dResolutions;

    public Dropdown dResolutionDropdown;

    void Start()
    {
        //Gets the resolutions which are specific for specific devices
        dResolutions = Screen.resolutions;

        int lCurrentResolutionIndex = 0;
        //Converts into string so we can add them into the dropdown
        List<string> lResolutionOptions = new List<string>();
        for(int iii = 0; iii < dResolutions.Length; iii++)
        {
            string lOption = dResolutions[iii].width + " x " + dResolutions[iii].height;
            lResolutionOptions.Add(lOption);

            if(dResolutions[iii].width == Screen.currentResolution.width &&
               dResolutions[iii].height == Screen.currentResolution.height)
            {
                lCurrentResolutionIndex = iii;
            }
        }

        //Updating dropdown
        dResolutionDropdown.ClearOptions();
        dResolutionDropdown.AddOptions(lResolutionOptions);
        dResolutionDropdown.value = lCurrentResolutionIndex;
        dResolutionDropdown.RefreshShownValue();

    }

    public void mSetResolution(int xResolutionIndex)
    {
        Resolution lResolution = dResolutions[xResolutionIndex];
        Screen.SetResolution(lResolution.width,lResolution.height,Screen.fullScreen);
    }

    public void mSetFullscren(bool xIsFullscreen)
    {
        Screen.fullScreen = xIsFullscreen;
    }
}
