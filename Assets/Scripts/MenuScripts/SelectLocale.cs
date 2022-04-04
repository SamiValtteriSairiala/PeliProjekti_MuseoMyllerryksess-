using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class SelectLocale : MonoBehaviour
{
    [SerializeField]

    private Locale locale;

    public void SetLocale()
    {
        LocalizationSettings.SelectedLocale = locale;
    }
 
}
