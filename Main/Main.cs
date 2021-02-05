using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class Main : MonoBehaviour
{
    public InPdf inPdf;
    public ProImport proImport;
    public InRawAnswer inRawAnswer;
    public PythonPdfConverter pythonPdfConverter;
    public ProReceiver proReceiver;
    public InPos inPos;
    public InRegion inRegion;
    public InView inView;
    public OutView outView;
    public OutPos outPos;
    public OutRegion outRegion;
    public OutImage outImage;
    public ProExport proExport;
    public PythonPptExporter pythonPptExporter;
    void Start()
    {
        IInPdfToProImportSender inPdfToProImportSender = inPdf;
        IInPdfToProImportReceiver inPdfToProImportReceiver = proImport;
        inPdfToProImportSender.AddPdfReceiver(inPdfToProImportReceiver.GetPdfReceiver());
        IInRawAnswerToProImportSender inRawAnswerToProImportSender = inRawAnswer;
        IInRawAnswerToProImportReceiver inRawAnswerToProImportReceiver = proImport;
        inRawAnswerToProImportSender.AddRawAnswerReceiver(inRawAnswerToProImportReceiver.GetRawAnswerReceiver());
        IProImportToPythonPdfConverterSender proImportToPythonPdfConverterSender = proImport;
        IProImportToPythonPdfConverterReceiver proImportToPythonPdfConverterReceiver = pythonPdfConverter;
        proImportToPythonPdfConverterSender.AddPpiReceiver(proImportToPythonPdfConverterReceiver.GetPpiReceiver());
        IProImportToProReceiverSender proImportToProReceiverSender = proImport;
        IProImportToProReceiverReceiver proImportToProReceiverReceiver = proReceiver;
        proImportToProReceiverSender.AddPiReceiver(proImportToProReceiverReceiver.GetPiReceiver());
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
    }
}
