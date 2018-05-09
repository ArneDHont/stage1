using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Api.Barcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/api/barcode/BarcodeData", DoNotGenerateAcw=true)]
	public sealed partial class BarcodeData : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_ANKERCODE']"
		[Register ("SYMBOLOGY_ANKERCODE")]
		public const string SymbologyAnkercode = (string) "ankercode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_AUSTRALIA_POST']"
		[Register ("SYMBOLOGY_AUSTRALIA_POST")]
		public const string SymbologyAustraliaPost = (string) "australiapost";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_AZTEC']"
		[Register ("SYMBOLOGY_AZTEC")]
		public const string SymbologyAztec = (string) "aztec";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_BOOKLANDEAN']"
		[Register ("SYMBOLOGY_BOOKLANDEAN")]
		public const string SymbologyBooklandean = (string) "booklandean";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_BPO']"
		[Register ("SYMBOLOGY_BPO")]
		public const string SymbologyBpo = (string) "bpo";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CANADA_POST']"
		[Register ("SYMBOLOGY_CANADA_POST")]
		public const string SymbologyCanadaPost = (string) "canadapost";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCA_EAN128']"
		[Register ("SYMBOLOGY_CCA_EAN128")]
		public const string SymbologyCcaEan128 = (string) "ccaean128";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCA_EAN13']"
		[Register ("SYMBOLOGY_CCA_EAN13")]
		public const string SymbologyCcaEan13 = (string) "ccaean13";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCA_EAN8']"
		[Register ("SYMBOLOGY_CCA_EAN8")]
		public const string SymbologyCcaEan8 = (string) "ccaean8";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCA_RSS14']"
		[Register ("SYMBOLOGY_CCA_RSS14")]
		public const string SymbologyCcaRss14 = (string) "ccarss14";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCA_RSSEXPANDED']"
		[Register ("SYMBOLOGY_CCA_RSSEXPANDED")]
		public const string SymbologyCcaRssexpanded = (string) "ccarssexpanded";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCA_RSSLIMITED']"
		[Register ("SYMBOLOGY_CCA_RSSLIMITED")]
		public const string SymbologyCcaRsslimited = (string) "ccarsslimited";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCA_UPCA']"
		[Register ("SYMBOLOGY_CCA_UPCA")]
		public const string SymbologyCcaUpca = (string) "ccaupca";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCA_UPCE']"
		[Register ("SYMBOLOGY_CCA_UPCE")]
		public const string SymbologyCcaUpce = (string) "ccaupce";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCB_EAN128']"
		[Register ("SYMBOLOGY_CCB_EAN128")]
		public const string SymbologyCcbEan128 = (string) "ccbean128";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCB_EAN13']"
		[Register ("SYMBOLOGY_CCB_EAN13")]
		public const string SymbologyCcbEan13 = (string) "ccbean13";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCB_EAN8']"
		[Register ("SYMBOLOGY_CCB_EAN8")]
		public const string SymbologyCcbEan8 = (string) "ccbean8";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCB_RSS14']"
		[Register ("SYMBOLOGY_CCB_RSS14")]
		public const string SymbologyCcbRss14 = (string) "ccbrss14";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCB_RSSEXPANDED']"
		[Register ("SYMBOLOGY_CCB_RSSEXPANDED")]
		public const string SymbologyCcbRssexpanded = (string) "ccbrssexpanded";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCB_RSSLIMITED']"
		[Register ("SYMBOLOGY_CCB_RSSLIMITED")]
		public const string SymbologyCcbRsslimited = (string) "ccbrsslimited";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCB_UPCA']"
		[Register ("SYMBOLOGY_CCB_UPCA")]
		public const string SymbologyCcbUpca = (string) "ccbupca";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CCB_UPCE']"
		[Register ("SYMBOLOGY_CCB_UPCE")]
		public const string SymbologyCcbUpce = (string) "ccbupce";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CHINESE2OF5']"
		[Register ("SYMBOLOGY_CHINESE2OF5")]
		public const string SymbologyChinese2of5 = (string) "chinese2of5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CODABAR']"
		[Register ("SYMBOLOGY_CODABAR")]
		public const string SymbologyCodabar = (string) "codabar";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CODABLOCK']"
		[Register ("SYMBOLOGY_CODABLOCK")]
		public const string SymbologyCodablock = (string) "codablock";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CODE1']"
		[Register ("SYMBOLOGY_CODE1")]
		public const string SymbologyCode1 = (string) "code1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CODE11']"
		[Register ("SYMBOLOGY_CODE11")]
		public const string SymbologyCode11 = (string) "code11";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CODE128']"
		[Register ("SYMBOLOGY_CODE128")]
		public const string SymbologyCode128 = (string) "code128";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CODE16K']"
		[Register ("SYMBOLOGY_CODE16K")]
		public const string SymbologyCode16k = (string) "code16k";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CODE32']"
		[Register ("SYMBOLOGY_CODE32")]
		public const string SymbologyCode32 = (string) "code32";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CODE39']"
		[Register ("SYMBOLOGY_CODE39")]
		public const string SymbologyCode39 = (string) "code39";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CODE49']"
		[Register ("SYMBOLOGY_CODE49")]
		public const string SymbologyCode49 = (string) "code49";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_CODE93']"
		[Register ("SYMBOLOGY_CODE93")]
		public const string SymbologyCode93 = (string) "code93";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_COUPONCODE']"
		[Register ("SYMBOLOGY_COUPONCODE")]
		public const string SymbologyCouponcode = (string) "couponcode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_DATAMATRIX']"
		[Register ("SYMBOLOGY_DATAMATRIX")]
		public const string SymbologyDatamatrix = (string) "datamatrix";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_DISCRETE2OF5']"
		[Register ("SYMBOLOGY_DISCRETE2OF5")]
		public const string SymbologyDiscrete2of5 = (string) "discrete2of5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_DUTCH_POST']"
		[Register ("SYMBOLOGY_DUTCH_POST")]
		public const string SymbologyDutchPost = (string) "dutchpost";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_EAN128']"
		[Register ("SYMBOLOGY_EAN128")]
		public const string SymbologyEan128 = (string) "ean128";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_EAN13']"
		[Register ("SYMBOLOGY_EAN13")]
		public const string SymbologyEan13 = (string) "ean13";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_EAN13_SUPPLEMENTAL2']"
		[Register ("SYMBOLOGY_EAN13_SUPPLEMENTAL2")]
		public const string SymbologyEan13Supplemental2 = (string) "ean13supplemental2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_EAN13_SUPPLEMENTAL5']"
		[Register ("SYMBOLOGY_EAN13_SUPPLEMENTAL5")]
		public const string SymbologyEan13Supplemental5 = (string) "ean13supplemental5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_EAN8']"
		[Register ("SYMBOLOGY_EAN8")]
		public const string SymbologyEan8 = (string) "ean8";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_EAN8_SUPPLEMENTAL2']"
		[Register ("SYMBOLOGY_EAN8_SUPPLEMENTAL2")]
		public const string SymbologyEan8Supplemental2 = (string) "ean8supplemental2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_EAN8_SUPPLEMENTAL5']"
		[Register ("SYMBOLOGY_EAN8_SUPPLEMENTAL5")]
		public const string SymbologyEan8Supplemental5 = (string) "ean8supplemental5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_EAN_UPC']"
		[Register ("SYMBOLOGY_EAN_UPC")]
		public const string SymbologyEanUpc = (string) "ean_upc";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_GS1COMPOSITE']"
		[Register ("SYMBOLOGY_GS1COMPOSITE")]
		public const string SymbologyGs1composite = (string) "gs1composite";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_HANXIN']"
		[Register ("SYMBOLOGY_HANXIN")]
		public const string SymbologyHanxin = (string) "hanxin";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_IATA2OF5']"
		[Register ("SYMBOLOGY_IATA2OF5")]
		public const string SymbologyIata2of5 = (string) "iata2of5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_INFOMAIL']"
		[Register ("SYMBOLOGY_INFOMAIL")]
		public const string SymbologyInfomail = (string) "infomail";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_INTELLEGENT_MAIL']"
		[Register ("SYMBOLOGY_INTELLEGENT_MAIL")]
		public const string SymbologyIntellegentMail = (string) "intellegentmail";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_INTERLEAVED2OF5']"
		[Register ("SYMBOLOGY_INTERLEAVED2OF5")]
		public const string SymbologyInterleaved2of5 = (string) "interleaved2of5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_ISBT128']"
		[Register ("SYMBOLOGY_ISBT128")]
		public const string SymbologyIsbt128 = (string) "isbt128";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_ISBT128_CON']"
		[Register ("SYMBOLOGY_ISBT128_CON")]
		public const string SymbologyIsbt128Con = (string) "isbt123con";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_ISSN_EAN']"
		[Register ("SYMBOLOGY_ISSN_EAN")]
		public const string SymbologyIssnEan = (string) "issnean";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_JAPAN_POST']"
		[Register ("SYMBOLOGY_JAPAN_POST")]
		public const string SymbologyJapanPost = (string) "japanpost";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_KOREAN_POST']"
		[Register ("SYMBOLOGY_KOREAN_POST")]
		public const string SymbologyKoreanPost = (string) "koreanpost";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_MACRO_MICRO_PDF']"
		[Register ("SYMBOLOGY_MACRO_MICRO_PDF")]
		public const string SymbologyMacroMicroPdf = (string) "macromicropdf";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_MACRO_PDF']"
		[Register ("SYMBOLOGY_MACRO_PDF")]
		public const string SymbologyMacroPdf = (string) "macropdf";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_MATRIX2OF5']"
		[Register ("SYMBOLOGY_MATRIX2OF5")]
		public const string SymbologyMatrix2of5 = (string) "matrix2of5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_MAXICODE']"
		[Register ("SYMBOLOGY_MAXICODE")]
		public const string SymbologyMaxicode = (string) "maxicode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_MICRO_PDF']"
		[Register ("SYMBOLOGY_MICRO_PDF")]
		public const string SymbologyMicroPdf = (string) "micropdf";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_MICRO_PDF_CCA']"
		[Register ("SYMBOLOGY_MICRO_PDF_CCA")]
		public const string SymbologyMicroPdfCca = (string) "micropdfcca";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_MICRO_QRCODE']"
		[Register ("SYMBOLOGY_MICRO_QRCODE")]
		public const string SymbologyMicroQrcode = (string) "microqrcode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_MSI']"
		[Register ("SYMBOLOGY_MSI")]
		public const string SymbologyMsi = (string) "msi";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_NW7']"
		[Register ("SYMBOLOGY_NW7")]
		public const string SymbologyNw7 = (string) "nw7";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_PDF417']"
		[Register ("SYMBOLOGY_PDF417")]
		public const string SymbologyPdf417 = (string) "pdf417";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_PLANET']"
		[Register ("SYMBOLOGY_PLANET")]
		public const string SymbologyPlanet = (string) "planet";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_PLESSEYCODE']"
		[Register ("SYMBOLOGY_PLESSEYCODE")]
		public const string SymbologyPlesseycode = (string) "plesseycode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_POSTNET']"
		[Register ("SYMBOLOGY_POSTNET")]
		public const string SymbologyPostnet = (string) "postnet";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_QRCODE']"
		[Register ("SYMBOLOGY_QRCODE")]
		public const string SymbologyQrcode = (string) "qrcode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_RSS14']"
		[Register ("SYMBOLOGY_RSS14")]
		public const string SymbologyRss14 = (string) "rss14";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_RSSEXPANDED']"
		[Register ("SYMBOLOGY_RSSEXPANDED")]
		public const string SymbologyRssexpanded = (string) "rssexpanded";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_RSSLIMITED']"
		[Register ("SYMBOLOGY_RSSLIMITED")]
		public const string SymbologyRsslimited = (string) "rsslimited";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_SCANLET']"
		[Register ("SYMBOLOGY_SCANLET")]
		public const string SymbologyScanlet = (string) "scanlet";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_SIGNATURE_CAPTURE']"
		[Register ("SYMBOLOGY_SIGNATURE_CAPTURE")]
		public const string SymbologySignatureCapture = (string) "signaturecapture";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_SWEDEN_POST']"
		[Register ("SYMBOLOGY_SWEDEN_POST")]
		public const string SymbologySwedenPost = (string) "swedenpost";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_TELEPEN']"
		[Register ("SYMBOLOGY_TELEPEN")]
		public const string SymbologyTelepen = (string) "telepen";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_TLC39']"
		[Register ("SYMBOLOGY_TLC39")]
		public const string SymbologyTlc39 = (string) "tlc39";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_TRIOPTICCODE39']"
		[Register ("SYMBOLOGY_TRIOPTICCODE39")]
		public const string SymbologyTriopticcode39 = (string) "triopticcode39";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_UCC_COUPON']"
		[Register ("SYMBOLOGY_UCC_COUPON")]
		public const string SymbologyUccCoupon = (string) "ucccoupon";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_UK_POST']"
		[Register ("SYMBOLOGY_UK_POST")]
		public const string SymbologyUkPost = (string) "ukpost";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_UNKNOWN']"
		[Register ("SYMBOLOGY_UNKNOWN")]
		public const string SymbologyUnknown = (string) "unknown";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_UPCA']"
		[Register ("SYMBOLOGY_UPCA")]
		public const string SymbologyUpca = (string) "upca";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_UPCA_SUPPLEMENTAL2']"
		[Register ("SYMBOLOGY_UPCA_SUPPLEMENTAL2")]
		public const string SymbologyUpcaSupplemental2 = (string) "upcasupplemental2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_UPCA_SUPPLEMENTAL5']"
		[Register ("SYMBOLOGY_UPCA_SUPPLEMENTAL5")]
		public const string SymbologyUpcaSupplemental5 = (string) "upcasupplemental5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_UPCD']"
		[Register ("SYMBOLOGY_UPCD")]
		public const string SymbologyUpcd = (string) "upcd";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_UPCE0']"
		[Register ("SYMBOLOGY_UPCE0")]
		public const string SymbologyUpce0 = (string) "upce0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_UPCE0_SUPPLEMENTAL2']"
		[Register ("SYMBOLOGY_UPCE0_SUPPLEMENTAL2")]
		public const string SymbologyUpce0Supplemental2 = (string) "upce0supplemental2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_UPCE0_SUPPLEMENTAL5']"
		[Register ("SYMBOLOGY_UPCE0_SUPPLEMENTAL5")]
		public const string SymbologyUpce0Supplemental5 = (string) "upceosupplemental5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_UPCE1']"
		[Register ("SYMBOLOGY_UPCE1")]
		public const string SymbologyUpce1 = (string) "upce1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_UPCE1_SUPPLEMENTAL2']"
		[Register ("SYMBOLOGY_UPCE1_SUPPLEMENTAL2")]
		public const string SymbologyUpce1Supplemental2 = (string) "upce1supplemental2";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_UPCE1_SUPPLEMENTAL5']"
		[Register ("SYMBOLOGY_UPCE1_SUPPLEMENTAL5")]
		public const string SymbologyUpce1Supplemental5 = (string) "upce1supplemental5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/field[@name='SYMBOLOGY_USPS4CB']"
		[Register ("SYMBOLOGY_USPS4CB")]
		public const string SymbologyUsps4cb = (string) "usps4cb";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/api/barcode/BarcodeData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BarcodeData); }
		}

		internal BarcodeData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/constructor[@name='BarcodeData' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "([BLjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BarcodeData (byte[] p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (BarcodeData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([BLjava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([BLjava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_arrayBLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_arrayBLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "([BLjava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBLjava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayBLjava_lang_String_Ljava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getEncoding;
		public unsafe string Encoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/method[@name='getEncoding' and count(parameter)=0]"
			[Register ("getEncoding", "()Ljava/lang/String;", "GetGetEncodingHandler")]
			get {
				if (id_getEncoding == IntPtr.Zero)
					id_getEncoding = JNIEnv.GetMethodID (class_ref, "getEncoding", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncoding), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSymbology;
		public unsafe string Symbology {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/method[@name='getSymbology' and count(parameter)=0]"
			[Register ("getSymbology", "()Ljava/lang/String;", "GetGetSymbologyHandler")]
			get {
				if (id_getSymbology == IntPtr.Zero)
					id_getSymbology = JNIEnv.GetMethodID (class_ref, "getSymbology", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSymbology), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTextData;
		public unsafe string TextData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/method[@name='getTextData' and count(parameter)=0]"
			[Register ("getTextData", "()Ljava/lang/String;", "GetGetTextDataHandler")]
			get {
				if (id_getTextData == IntPtr.Zero)
					id_getTextData = JNIEnv.GetMethodID (class_ref, "getTextData", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_getBinaryData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/method[@name='getBinaryData' and count(parameter)=0]"
		[Register ("getBinaryData", "()[B", "")]
		public unsafe byte[] GetBinaryData ()
		{
			if (id_getBinaryData == IntPtr.Zero)
				id_getBinaryData = JNIEnv.GetMethodID (class_ref, "getBinaryData", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBinaryData), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeData']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
