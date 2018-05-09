using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Api.Barcode {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeReaderManager']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/api/barcode/BarcodeReaderManager", DoNotGenerateAcw=true)]
	public partial class BarcodeReaderManager : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/api/barcode/BarcodeReaderManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BarcodeReaderManager); }
		}

		protected BarcodeReaderManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeReaderManager']/constructor[@name='BarcodeReaderManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BarcodeReaderManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BarcodeReaderManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getBarcodeReaders;
		public static unsafe global::System.Collections.Generic.IList<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> BarcodeReaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/class[@name='BarcodeReaderManager']/method[@name='getBarcodeReaders' and count(parameter)=0]"
			[Register ("getBarcodeReaders", "()Ljava/util/List;", "GetGetBarcodeReadersHandler")]
			get {
				if (id_getBarcodeReaders == IntPtr.Zero)
					id_getBarcodeReaders = JNIEnv.GetStaticMethodID (class_ref, "getBarcodeReaders", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBarcodeReaders), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
