/*
 * JDFTypes.cs
 * JDFLib4Net
 * Created By Bob Babb (RBabb@kmbs.konicaminolta.us)
 * Last Modified 2016/06/16
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JDFLib4Net
{
    public class JDFTypes
    {
        public static string ID(string value) { return value.Substring(0, 62); }
        public static string NMTOKEN(string value) { return value.Substring(0, 62); }
        public static string NMTOKENS(string value) { return value.Substring(0, 2047); }
        public static string SHORTSTRING(string value) { return value.Substring(0, 65); }
        public static string LONGSTRING(string value) { return value.Substring(0, 255); }
        public static string TEXT(string value) { return value.Substring(0, 20480); }
        public static string URL(string value) { return value.Substring(0, 4095); }
        public static bool BOOL(string value) { return Tools.SetBool(value);}
        public static string CMYKColor = "CMYK";
        public static string[] JDFJMFVersion = new string[] {"1.1", "1.2", "1.3", "1.4", "1.5" };
        public string PDFPATH(string value) {return Tools.ValidatePDFPath(value);}

        public enum ePartUsage { Explicit, Implicit, Sparse };
        public enum eSpawnStatus { NotSpawned, SpawnedRO, SpawnedRW };
        public enum eResourceStatus { Incomplete, Rejected, Unavailable, InUse, Draft, Complete, Available };
        public enum eNodeStatus
        { 
            Waiting, TestRunInProgress, Ready, FailedTestRun, Setup, InProgress, Cleanup, 
            Spawned, Suspended, Stopped, Completed, Aborted, Part, Pool
        };
        public enum eNodePhaseTimeStatus { TestRunInProgress, Setup, InProgress, Cleanup, Spawned, Suspended, Stopped };
        public enum eMounting { Unfixed, Fixed, Wet, Registered };
        public enum eModification { Create, Delete, Modify };
        public enum eMirrorMargins { Vertical, Horizontal };
        public enum eMirrorAround { None, FeedDirection, MediaWidth, Both };
        public enum eMessageFamily { Acknowledge, Response, Signal, All };
        public enum eMethod { BlowIn, BindIn };
        public enum XYRelation { gt, ge, eq, le, lt, ne };
        public enum All { All };
        public enum eAcknowledgeType { Received, Applied, Completed };
        public enum eAction 
        { 
            LongFoldLeftToRight, LongFoldRightToLeft, LongPreFoldLeftToRight, LongPreFoldRightToLeft,
            FrontFoldComplete, FrontFoldDiagonal, FrontFoldCompleteDiagonal, BackFoldComplete, BackFoldDiagonal,
            BackFoldCompleteDiagonal, ReverseFold, Milling, Rotate90, Rotate180, Rotate270
        };
        public enum eActivation { Inactive, Informative, Held, Active, TestRun, TestRunAndGo };
        public enum eActivation1 { Held, Active, TestRun, TestRunAndGo };
        public enum eAllowedRotate { None, Grain, MinorGrain, CrossGrain };
        public enum eAllowedTransforms { Rotate0, Rotate90, Rotate180, Rotate270, Flip0, Flip90, Flip180, Flip270 };
        public enum eAlternateColorSpace
        {
            CalGray, CalRGB, CIEBasedA, CIEBasedABC, CIEBasedDEFG, DeviceCMYK,
            DeviceGray, DeviceN, DeviceRGB, ICCBased, Lab
        };
        public enum eAnchor
        {
            TopLeft, TopCenter, TopRight, CenterLeft, Center, CenterRight, BottomLeft, BottomCenter, BottomRight
        };
        public enum eAnchorType { Parent, Sibling };
        public enum eApprovalRole { Approvinator, Group, Informative, Obligated };
        public enum eApprovalState { Approved, ApprovedWithComment, Rejected };
        public enum eArtificialTextEffect { Bold, Italic, Outline, Shadow, Underline };
        public enum eAspectRatio { Ignore, CenterMax, CenterMin, Crop, Expand };
        public enum eAuthenticationReason
        {
            InitiateConnection, ClientCertificateExpired, ServerCertificateExpired, ClientHostnameMismatch,
            ServerHostnameMismatch, ClientCertificateRevoked, ServerCertificateRevoked, Other
        };
        public enum eAuthenticationType { AsClient, AsServer };
        public enum eAutoRotatePages { None, All, PageByPage };
        public enum eAvailability { Installed, Module, NotInstalled, NotLicensed, Disabled };
        public enum eBandOrdering { BandMajor, ColorMajor };
        public enum eBaseOrdReset { PagePool, PagePoolList };
        public enum eBearerBars { None, TopBottom, Box, BoxHMarks };
        public enum eBinderySignatureType { Die, Fold, Grid };
        public enum eBindingEdge { Left, Right, Top, Bottom, None };
        public enum eBindingOrder { Collecting, Gathering, List };
        public enum eBinding { Left, Right };
        public enum eBlackGeneration { Identity, Custom };
        public enum eBlockElementType { CutElement, PunchElement };
        public enum eBlockType { CutBlock, SaveBlock, TempBlock, MarkBlock };
        public enum eBottleAxis { SpineHead, SpineFoot, FaceHead, FaceFoot };
        public enum eBox { ArtBox, BleedBox, CropBox, MarginsBox, MediaBox, SlugBox, TrimBox };
        public enum eBoxFoldingType
        {
            Type00, Type01, Type02, Type03, Type04, Type10, Type11, Type12, Type13, Type15, Type20
        };
        public enum eBundleType
        {
            BoundSet, Box, Carton, CollectedStack, CompensatedStack, Pallet, Roll,
            Sheet, Stack, StrappedStack, StrappedCompensatedStack, WrappedBundle
        };
        public enum eByteOrder { II, MM };
        public enum eCannotEmbedFontPolicy { Warning, Error, OK };
        public enum eCenterAcross { None, FeedDirection, MediaWidth, Both };
        public enum eCenterReference { TrailingEdge, RegistrationMark };
        public enum eChannelMode { FireAndForget, Reliable };
        public enum eChannelType { Phone, Email, Fax, WWW, JMF, PrivateDirectory, InstantMessaging };
        public enum eCharacterProblem { Corrupted, IncorrectEncoding, Missing, Others };
        public enum eCoatings { None, Coated, Glossy, HighGloss, InkJet, Matte, Polymer, Silver, Satin, Semigloss };
        public enum eColorSpace
        {
            CalGray, CalRGB, CIEBasedA, CIEBasedABC, CIEBasedDEFG, DeviceCMYK,
            DeviceGray, DeviceN, DeviceRGB, ICCBased, Lab, Separation
        };
        public enum eColorType { DieLine, Normal, Transparent, Opaque, OpaqueIgnore };
        public enum eColorType1 { Monochrome, BasicColor, MatchedColor };
        public enum eColorTransform { YUV, None, Automatic };
        public enum eCombinedMethod { None, Combined, CombinedProcessGroup, GrayBox, ProcessGroup };
        public enum eCommandResult { Rejected, Removed, New, Merged, Replaced };
        public enum eCommentAction { Add, Concat, Replace, Remove };
        public enum eCompensation { None, Unknown, Film, Plate, Press };
        public enum eCompensation1 { None, Film, Plate, Press };
        public enum eCompensationProcess { Printing, Platemaking };
        public enum eComponentGranularity { Page, Document, Set, All, BundleItem };
        public enum eComponentType { Block, Other, Ribbon, Sheet, Web, FinalProduct, PartialProduct, Proof };
        public enum eComponentOrientation { XY, XZ, YZ };
        public enum eCompressionFilter { CCITTFaxEncode, DCTEncode, FlateEncode, WaveletEncode, JBIG2Encode };
        public enum eCompressionType { ASCII85, ASCIIHex, CCITT, JBIG2, JPEG, JPEG2000, LZW, None, RunLength, ZIP };
        public enum eCondition { PagePoolStart, PagePoolListStart, PagePoolListEnd };
        public enum eConsumption { Full, Partial };
        public enum eContext { Resource, Link, JMF, Element };
        public enum eContext_MDM
        {
            Set, Document, SubDoc0, SubDoc1, SubDoc2, SubDoc3, SubDoc4, SubDoc5, 
            SubDoc6, SubDoc7, SubDoc8, SubDoc9, PagePool, Page, Object
        };
        public enum eCostType { Chargeable, NonChargeable };
        public enum eCoverType { Front, Back };
        public enum eCurrencyCodes
        {
            AED, AFN, ALL, AMD, ANG, AOA, ARS, AUD, AWG, AZM, BAM, BBD, BDT, BGN, BHD, BIF, BMD, BRL, BSD,
            BWP, BYR, BZD, CAD, CDF, CHF, CNY, CRC, CUP, CVE, CYP, CZK, DJF, DKK, DOP, DZD, EEK, EGP, ERN,
            ETB, EUR, FJD, FKP, GBP, GEL, GHC, GIP, GMD, GNF, GTQ, GYD, HKD, HNL, HRK, HUF, IDR, ILS, INR,
            IQD, IRR, ISK, JMD, JOD, JPY, KES, KGS, KHR, KMF, KPW, KRW, KWD, KYD, KZT, LAK, LBP, LKR, LRD,
            LTL, LVL, LYD, MAD, MDL, MKD, MMK, MNT, MOP, MRO, MTL, MUR, MVR, MWK, MYR, MZM, NGN, NIO, NOK,
            NPR, NZD, OMR, PEN, PGK, PHP, PKR, PLN, PYG, QAR, ROL, RUB, RWF, SAR, SBD, SCR, SDD, SEK, SGD,
            SHP, SIT, SKK, SLL, SOS, SRD, STD, SYP, SZL, THB, TJS, TMM, TND, TOP, TTD, TWD, TZS, UAH, UGX,
            USD, UYU, UZS, VEB, VND, VUV, WST, XAF, XAG, XAU, XBA, XBB, XBC, XBD, XCD, XDR, XFO, XFU, XOF,
            XPD, XPF, XPT, XTS, XXX, YER, ZAR, ZMK, ZWD
        };
        public enum eCutMarkType
        {
            CrossCutMark, TopVerticalCutMark, BottomVerticalCutMark, LeftHorizontalCutMark,
            RightHorizontalCutMark, LowerLeftCutMark, UpperLeftCutMark, LowerRightCutMark,
            UpperRightCutMark
        };
        public enum eCutType { Cut, Perforate };
        public enum eDBSchemaType { CommaDelimited, SQL, XML };
        public enum eDeadLine { InTime, Warning, Late };
        public enum eDefaultPriority { Application, DefaultJDF };
        public enum eDeliveryMode { FullSheet, RemoveGripperMargin, SeparateBlanks };
        public enum eDeliveryTransfer
        {
            BuyerToPrinterDeliver, BuyerToPrinterPickup, PrinterToBuyerDeliver, PrinterToBuyerPickup
        };
        public enum eDeviceCondition { OK, NeedsAttention, Failure, OffLine };
        public enum eDeviceDetails { None, Brief, Modules, Details, NamedFeature, Capability, Full };
        public enum eDeviceOperationMode { Productive, NonProductive, Maintenance };
        public enum eDeviceStatus { Unknown, Idle, Down, Setup, Running, Cleanup, Stopped };
        public enum eDescriptionType { FoldProc, FoldCatalog };
        public enum eDiffusion { On, Off };
        public enum eDigitalDeliveryDirection { Push, Pull };
        public enum eDigitalPrintingCollate { None, Sheet, SheetAndSet, SheetSetAndJob, SystemSpecified };
        public enum eDigitalPrintingPageDelivery
        {
            FanFold, SameOrderFaceUp, SameOrderFaceDown, ReverseOrderFaceUp, ReverseOrderFaceDown, SystemSpecified
        };
        public enum eDigitalPrintingPrintingType { SystemSpecified, SheetFed, WebFed, ContinuousFed };
        public enum eDigitalPrintingPrintingQuality { SystemSpecified, High, Normal, Draft };
        public enum eDigitalPrintingSheetLay { SystemSpecified, Left, Right, Center };
        public enum eDirection { LongEdge, ShortEdge, XDirection, YDirection };
        public enum eDisposition { Unlink, Delete, Retain };
        public enum eDispositionAction { Delete, Archive };
        public enum eDisjointingOffsetDirection { Alternate, Left, None, Right, Straight, SystemSpecified };
        public enum eDrying { UV, Heatset, IR, On, Off };
        public enum eDueLevel { Unknown, Trivial, Penalty, JobCancelled };
        public enum eElementType
        {
            Auxiliary, Barcode, Composed, Document, Graphic, IdentificationField, Image,
            MultiDocument, MultiSet, Page, Reservation, Surface, Text, Tile, Unknown
        };
        public enum eEmbossingDirection { Both, Flat, Raised, Depressed };
        public enum eEmbossingEdgeShare { Beveled, Rounded };
        public enum eEmbossingType
        {
            BlindEmbossing, Braille, EmbossedFinish,
            FoilEmbossing, FoilStamping, RegisteredEmbossing
        };
        public enum eEmbossingLevel { SingleLevel, MultiLevel, Sculpted };
        public enum eEncoding { ASCII, Barcode, BarCode1D, BarCode2D, Braille, RFID };
        public enum eEncoding1 { ASCII, Binary };
        public enum eEndStatusOfNode { Aborted, Completed, FailedTestRun, Ready, Stopped };
        public enum eErrorState { TestNotSupported, TestWrongPDL };
        public enum eExecutionPolicy { RootNode, FirstFound, AllFound };
        public enum eExposedMediaColorType { Color, GrayScale, Monochrome };
        public enum eExposedMediaProofQuality { None, Halftone, Contone, Conceptual };
        public enum eExposedMediaProofType { None, Imposition, Page };
        public enum eFeederSynchronization { Alternate, Backup, Chain, Primary };
        public enum eFillColorType
        {
            CMYGray, CMYBlack, Other, PureBlack, PureGray,
            RegistrationBlack, RegistrationGray, RichBlack, White
        };
        public enum eFinishingOrder { FoldGather, FoldCollect, Gather, GatherFold };
        public enum eFirstSurface { Either, Front, Back };
        public enum eFitPolicyGutterPolicy { Distribute, Fixed };
        public enum eFitPolicyRotatePolicy { NoRotate, RotateOrthogonal, RotateClockwise, RotateCounterClockwise };
        public enum eFitPolicySizePolicy { ClipToMaxPage, Abort, FitToPage, ReduceToFit, Tile };
        public enum eFlushPolicy { Complete, QueueEntry, Intermediate };
        public enum eFolioCount { Booklet, Flat };
        public enum eFontType
        {
            CIDFontType0, CIDFontType1, CIDFontType2, CIDFontType3, CIDFontType4,
            OpenType, TrueType, Type0, Type1, Type1MultipleMaster, Type2C, Type3,
            PDFType3, Type42, Unknown, Other
        };
        public enum eFountainSolution { On, Off };
        public enum eFrom { Front, Left };
        public enum eGangPolicy { Gang, GangAndForce, NoGang };
        public enum eGlueType { ColdGlue, Hotmelt, PUR };
        public enum eGluingTechnique { SpineGluing, SideGluingFront, SideGluingBack };
        public enum eGrainDirection { ShortEdge, LongEdge };
        public enum eHoleReferenceEdge { Left, Right, Top, Bottom, Pattern };
        public enum eHoleShape { Eliptical, Round, Rectangular };
        public string[] eHoleType = new string[]
        {
            "R2-generic", "S1-generic", "S-generic", "R2m-DIN", "R2m-ISO", "R2m-MIB", "R2i-US-a", 
            "R2i-US-b", "R3-generic", "R3i-US", "R4-generic", "R4m-DIN-A4", "R4m-DIN-A5", "R4m-swedish", 
            "R4i-US", "R5-generic", "R5i-US-a", "R5i-US-b", "R5i-US-c", "R6-generic", "R6m-4h2s", 
            "R6m-DIN-A5", "R7-generic", "R7i-US-a", "R7i-US-b", "R7i-US-c", "R11m-7h4s", "P16_9i-rect-0t", 
            "P12m-rect-0t", "W2_1i-round-0t", "W2_1i-square-0t", "W3_1i-square-0t", "C9.5m-round-0t"
        };
        public string[] eHoleType1 = new string[]
        {
            "None", "S1-generic", "S-generic", "R2-generic", "R2m-DIN", "R2m-ISO", "R2m-MIB", "R2i-US-a",
            "R2i-US-b", "R3-generic", "R3i-US", "R4-generic", "R4m-DIN-A4", "R4m-DIN-A5", "R4m-swedish",
            "R4i-US", "R5-generic", "R5i-US-a", "R5i-US-b", "R5i-US-c", "R6-generic", "R6m-4h2s",
            "R6m-DIN-A5", "R7-generic", "R7i-US-a", "R7i-US-b", "R7i-US-c", "R11m-7h4s", "P16_9i-rect-0t",
            "P12m-rect-0t", "W2_1i-round-0t", "W2_1i-square-0t", "W3_1i-square-0t", "C9.5m-round-0t", "Explicit"
        };
        public enum eHorizontalFitPolicy { NoRepeat, StretchToFit, UndistortedScaleToFit, RepeatToFill, RepeatUnclipped };
        public enum eICCOutputProfileUsage { PDLActual, PDLReference, IgnorePDL };
        public enum eICCProfileUsage { UsePDL, UseSupplied };
        public enum eIconType { Unknown, Idle, Down, Setup, Running, Cleanup, Stopped };
        public int[] eIDPFinishings = new int[] { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 50, 51, 52, 53 };
        public enum eIDPParamsJobSheetOccurrence { None, Always, End, OnError, Slip, Start, Both };
        public enum eIDPParamsJobSheetType { AccountingSheet, ErrorSheet, JobSheet, SeparatorSheet };
        public enum eIDPParamsStitchingPosition
        {
            None, TopLeft, BottomLeft, TopRight, BottomRight, LeftEdge, TopEdge, RightEdge,
            BottomEdge, DualLeftEdge, DualTopEdge, DualRightEdge, DualBottomEdge
        };
        public enum eIDPParamsStitchingRefEdge { Bottom, Top, Left, Right };
        public enum eIllumination { D50, D65, Unknown };
        public enum eImageDownsampleType { Average, Bicubic, Subsample };
        public enum eImageFlipped { Horizontal, Vertical, None };
        public enum eImageMaskType { NoMask, BitmapMask, ColorKeyMask };
        public enum eImageShiftPosition1 { None, Left, Right, Center, Spine };
        public enum eImageShiftPosition2 { None, Bottom, Top, Center, Spine };
        public enum eImageReplacementStrategy { Omit, Proxy, Replace, AttemptReplacement };
        public enum eImageType { Color, Grayscale, Monochrome };
        public enum eImageTrapPlacement { Center, Choke, Normal, Spread };
        public enum eImagableSide { Front, Back, Both, Neither };
        public enum eIncludeInBundleItem { After, Before, None, New };
        public enum eIncorrectComponentQuality { NotActive, Check, Waste, StopNoWaste, StopWaste };
        public enum eIncludePerPage { IncludeNever, IncludeOncePerDoc, IncludeOncePerPage };
        public enum eInkState { Dry, Wet, NA };
        public enum eJogSide { None, Left, Right, Top, Bottom };
        public enum eJMFRole { Receiver, Sender };
        public enum eLaminatingMethod { CompoundFoil, DispersionGlue, Fusing, Unknown };
        public enum eListPolicy { All, Available };
        public enum eListType
        {
            CompleteList, CompleteOrderedList, ContainedList, List, OrderedList, OrderedRangeList,
            Range, RangeList, SingleValue, Span, UniqueList, UniqueRangeList, UniqueOrderedList,
            UniqueOrderedRangeList
        };
        public enum eLocation { Front, Back, OverfoldLeft, OverfoldRight, Overfold, FinishedPage };
        public enum eLotControl { Controlled, NotControlled };
        public enum eLotDetails { Brief, Full, Amount };
        public enum eMarkActivationContext
        {
            CollectIndex, DocIndex, SetDocIndex, SetIndex, SheetIndex, SubDocIndex0, SubDocIndex1,
            SubDocIndex2, SubDocIndex3, SubDocIndex4, SubDocIndex5, SubDocIndex6, SubDocIndex7,
            SubDocIndex8, SubDocIndex9
        };
        public enum eMarkContext { Sheet, BinderySignature, Cell, CellPair };
        public enum eMappingSelection { UsePDLValues, UseLocalPrinterValues, UseProcessColorValues };
        public enum eMarkJustification { Left, Right, Center };
        public enum eMarkOrientation { Vertical, Horizontal };
        public enum eMarkPosition { Left, Right, Top, Bottom };
        public enum eMarkSide { Front, Back, TwoSidedBackToBack, TwoSidedIndependent };
        public enum eMarkUsage { Color, PaperPath, Tile };
        public enum eMask { None, TrimBox, BleedBox, SourceTrimBox, SourceBleedBox, PDL, DieCut, DieBleed };
        public enum eMasking { None, WhiteBox };
        public enum eMaterial { LaqueredSteel, NylonCoatedSteel, PVC, TinnedSteel, ZincsSteel };
        public enum eMaterial1 { AdhesiveTape, Strap, String };
        public enum eMeasurementFilter { None, Pol, UV };
        public enum eMediaSide { Front, Back, Both };
        public enum eMediaType
        {
            CorrugatedBoard, Disc, EndBoard, EmbossingFoil, Film, Foil, GravureCylinder, ImagingCylinder,
            LaminatingFoil, MountingTape, Other, Paper, Plate, SelfAdhesive, Sleeve, ShrinkFoil,
            Transparency, Unknown
        };
        public enum eMediaUnit { Continuous, Roll, Sheet };
        public static TypeRectangle BOX(string value) { return new TypeRectangle(value); }
    }
}
