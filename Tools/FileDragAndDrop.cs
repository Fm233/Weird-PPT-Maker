using System.Numerics;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using B83.Win32;
using System;


public class FileDragAndDrop
{
    Action<List<string>, UnityEngine.Vector2> onFiles;
    static FileDragAndDrop instance;
    bool enabled = false;
    void OnEnable()
    {
        // must be installed on the main thread to get the right thread id.
        UnityDragAndDropHook.InstallHook();
        UnityDragAndDropHook.OnDroppedFiles += OnFiles;
        enabled = true;
    }
    void OnDisable()
    {
        UnityDragAndDropHook.UninstallHook();
        enabled = false;
    }

    void OnFiles(List<string> aFiles, POINT aPos)
    {
        onFiles(aFiles, new UnityEngine.Vector2(aPos.x, aPos.y));
    }

    public static void AddListener(Action<List<string>, UnityEngine.Vector2> action)
    {
        TryCreateInstance();
        if (!instance.enabled)
        {
            instance.OnEnable();
        }
        instance.onFiles += action;
    }
    public static void RemoveAllListener()
    {
        TryCreateInstance();
        if (instance.enabled)
        {
            instance.OnDisable();
        }
        instance.onFiles = null;
    }

    static void TryCreateInstance()
    {
        if (instance == null)
        {
            instance = new FileDragAndDrop();
        }
    }
}
