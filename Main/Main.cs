using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class Main : MonoBehaviour
{
    public InPos inPos;
    public ProReceiver proReceiver;
    public InRegion inRegion;
    public InView inView;
    public OutView outView;
    public OutPos outPos;
    public OutRegion outRegion;
    public OutImage outImage;
    public ProExport proExport;
    public PythonPptExporter pythonPptExporter;
    public InPdf inPdf;
    public ProImport proImport;
    public InRawAnswer inRawAnswer;
    public PythonPdfConverter pythonPdfConverter;
    public ProSend proSend;
    public ProDisplay proDisplay;
    public OutDisplay outDisplay;
    void Start()
    {
        IInPosToProReceiverSender inPosToProReceiverSender = inPos;
        IInPosToProReceiverReceiver inPosToProReceiverReceiver = proReceiver;
        inPosToProReceiverSender.AddIpiReceiver(inPosToProReceiverReceiver.GetIpiReceiver());
        IInRegionToProReceiverSender inRegionToProReceiverSender = inRegion;
        IInRegionToProReceiverReceiver inRegionToProReceiverReceiver = proReceiver;
        inRegionToProReceiverSender.AddIriReceiver(inRegionToProReceiverReceiver.GetIriReceiver());
        IInViewToOutViewSender inViewToOutViewSender = inView;
        IInViewToOutViewReceiver inViewToOutViewReceiver = outView;
        inViewToOutViewSender.AddViReceiver(inViewToOutViewReceiver.GetViReceiver());
        IProReceiverToOutPosSender proReceiverToOutPosSender = proReceiver;
        IProReceiverToOutPosReceiver proReceiverToOutPosReceiver = outPos;
        proReceiverToOutPosSender.AddOpiReceiver(proReceiverToOutPosReceiver.GetOpiReceiver());
        IProReceiverToOutRegionSender proReceiverToOutRegionSender = proReceiver;
        IProReceiverToOutRegionReceiver proReceiverToOutRegionReceiver = outRegion;
        proReceiverToOutRegionSender.AddOriReceiver(proReceiverToOutRegionReceiver.GetOriReceiver());
        IProReceiverToOutImageSender proReceiverToOutImageSender = proReceiver;
        IProReceiverToOutImageReceiver proReceiverToOutImageReceiver = outImage;
        proReceiverToOutImageSender.AddOiiReceiver(proReceiverToOutImageReceiver.GetOiiReceiver());
        IProReceiverToProExportSender proReceiverToProExportSender = proReceiver;
        IProReceiverToProExportReceiver proReceiverToProExportReceiver = proExport;
        proReceiverToProExportSender.AddPeiReceiver(proReceiverToProExportReceiver.GetPeiReceiver());
        IProExportToPythonPptExporterSender proExportToPythonPptExporterSender = proExport;
        IProExportToPythonPptExporterReceiver proExportToPythonPptExporterReceiver = pythonPptExporter;
        proExportToPythonPptExporterSender.AddPpiReceiver(proExportToPythonPptExporterReceiver.GetPpiReceiver());
        IInPdfToProImportSender inPdfToProImportSender = inPdf;
        IInPdfToProImportReceiver inPdfToProImportReceiver = proImport;
        inPdfToProImportSender.AddPdfReceiver(inPdfToProImportReceiver.GetPdfReceiver());
        IInRawAnswerToProImportSender inRawAnswerToProImportSender = inRawAnswer;
        IInRawAnswerToProImportReceiver inRawAnswerToProImportReceiver = proImport;
        inRawAnswerToProImportSender.AddRawAnswerReceiver(inRawAnswerToProImportReceiver.GetRawAnswerReceiver());
        IProImportToPythonPdfConverterSender proImportToPythonPdfConverterSender = proImport;
        IProImportToPythonPdfConverterReceiver proImportToPythonPdfConverterReceiver = pythonPdfConverter;
        proImportToPythonPdfConverterSender.AddPpiReceiver(proImportToPythonPdfConverterReceiver.GetPpiReceiver());
        IPythonPdfConverterToProSendSender pythonPdfConverterToProSendSender = pythonPdfConverter;
        IPythonPdfConverterToProSendReceiver pythonPdfConverterToProSendReceiver = proSend;
        pythonPdfConverterToProSendSender.AddPprReceiver(pythonPdfConverterToProSendReceiver.GetPprReceiver());
        IProSendToProReceiverSender proSendToProReceiverSender = proSend;
        IProSendToProReceiverReceiver proSendToProReceiverReceiver = proReceiver;
        proSendToProReceiverSender.AddPiReceiver(proSendToProReceiverReceiver.GetPiReceiver());
        IPythonPptExporterToProDisplaySender pythonPptExporterToProDisplaySender = pythonPptExporter;
        IPythonPptExporterToProDisplayReceiver pythonPptExporterToProDisplayReceiver = proDisplay;
        pythonPptExporterToProDisplaySender.AddPptDirReceiver(pythonPptExporterToProDisplayReceiver.GetPptDirReceiver());
        IProDisplayToOutDisplaySender proDisplayToOutDisplaySender = proDisplay;
        IProDisplayToOutDisplayReceiver proDisplayToOutDisplayReceiver = outDisplay;
        proDisplayToOutDisplaySender.AddDirReceiver(proDisplayToOutDisplayReceiver.GetDirReceiver());
    }
}
