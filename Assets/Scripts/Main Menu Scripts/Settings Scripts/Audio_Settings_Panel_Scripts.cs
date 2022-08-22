using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio_Settings_Panel_Scripts : MonoBehaviour
{
    //Mixers ------------------------------------------------------------------------------------------
    public AudioMixer dMasterAudioMixer;
    public AudioMixer dSoundEffectsAudioMixer;
    public AudioMixer dMusicAudioMixer;
    
    //Master ------------------------------------------------------------------------------------------
    public void mSetMasterVolume(float xVolume)
    {
        dMasterAudioMixer.SetFloat("Master_Volume", xVolume);
    }
    
    public void mSetMasterPitch(float xPitch)
    {
        dMasterAudioMixer.SetFloat("Master_Pitch", xPitch);
    }
    
    //Sound Effects -----------------------------------------------------------------------------------
    public void mSetSoundEffectsVolume(float xVolume)
    {
        dSoundEffectsAudioMixer.SetFloat("Sound_Effects_Volume", xVolume);
    }
    
    public void mSetSound_EffectsPitch(float xPitch)
    {
        dSoundEffectsAudioMixer.SetFloat("Sound_Effects_Pitch", xPitch);
    }

    //Music -------------------------------------------------------------------------------------------
    public void mSetMusicVolume(float xVolume)
    {
        dMusicAudioMixer.SetFloat("Music_Volume", xVolume);
    }
    
    public void mSetMusicPitch(float xPitch)
    {
        dMusicAudioMixer.SetFloat("Music_Pitch", xPitch);
    }
}
