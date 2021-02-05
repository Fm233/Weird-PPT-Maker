#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;
public class InitMan : Editor
{
    [MenuItem("InitMan/Init")]
    public static void Init()
    {
        GameObject mainObject = new GameObject();
        mainObject.name = "Main";
        Main main = mainObject.AddComponent<Main>();
        GameObject inPdf = new GameObject();
        inPdf.name = "InPdf Instance";
        main.inPdf = inPdf.AddComponent<InPdf>();
        GameObject inRawAnswer = new GameObject();
        inRawAnswer.name = "InRawAnswer Instance";
        main.inRawAnswer = inRawAnswer.AddComponent<InRawAnswer>();
        GameObject proImport = new GameObject();
        proImport.name = "ProImport Instance";
        main.proImport = proImport.AddComponent<ProImport>();
        GameObject pythonPdfConverter = new GameObject();
        pythonPdfConverter.name = "PythonPdfConverter Instance";
        main.pythonPdfConverter = pythonPdfConverter.AddComponent<PythonPdfConverter>();
        GameObject proReceiver = new GameObject();
        proReceiver.name = "ProReceiver Instance";
        main.proReceiver = proReceiver.AddComponent<ProReceiver>();
        GameObject inPos = new GameObject();
        inPos.name = "InPos Instance";
        main.inPos = inPos.AddComponent<InPos>();
        GameObject inRegion = new GameObject();
        inRegion.name = "InRegion Instance";
        main.inRegion = inRegion.AddComponent<InRegion>();
        GameObject inView = new GameObject();
        inView.name = "InView Instance";
        main.inView = inView.AddComponent<InView>();
        GameObject outView = new GameObject();
        outView.name = "OutView Instance";
        main.outView = outView.AddComponent<OutView>();
        GameObject outPos = new GameObject();
        outPos.name = "OutPos Instance";
        main.outPos = outPos.AddComponent<OutPos>();
        GameObject outRegion = new GameObject();
        outRegion.name = "OutRegion Instance";
        main.outRegion = outRegion.AddComponent<OutRegion>();
        GameObject proExport = new GameObject();
        proExport.name = "ProExport Instance";
        main.proExport = proExport.AddComponent<ProExport>();
        GameObject outImage = new GameObject();
        outImage.name = "OutImage Instance";
        main.outImage = outImage.AddComponent<OutImage>();
        GameObject pythonPptExporter = new GameObject();
        pythonPptExporter.name = "PythonPptExporter Instance";
        main.pythonPptExporter = pythonPptExporter.AddComponent<PythonPptExporter>();
    }
}
#endif
