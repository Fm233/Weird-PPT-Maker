using System.IO;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
public class InPdf : MonoBehaviour, IInPdfToProImportSender
{
    public Text debug;

    void Start()
    {
        FileDragAndDrop.AddListener(OnPdf);
    }
    void Update()
    {
        // Update here
    }
    Action<Pdf> pdfAction;
    public void AddPdfReceiver(Action<Pdf> action)
    {
        pdfAction += action;
    }

    void OnPdf(List<string> files, Vector2 pos)
    {
        // scan through dropped files and filter out supported image types
        foreach (string f in files)
        {
            FileInfo fi = new FileInfo(f);
            string ext = fi.Extension.ToLower();
            string dest = fi.Name;
            if (ext == ".pdf")
            {
                FileDragAndDrop.RemoveAllListener();
                pdfAction(new Pdf(fi.FullName));
                debug.text = fi.FullName;
                break;
            }
        }
    }
}
