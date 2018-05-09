using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Api.Barcode {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeListener']"
	[Register ("com/panasonic/toughpad/android/api/barcode/BarcodeListener", "", "Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListenerInvoker")]
	public partial interface IBarcodeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeListener']/method[@name='onRead' and count(parameter)=2 and parameter[1][@type='com.panasonic.toughpad.android.api.barcode.BarcodeReader'] and parameter[2][@type='com.panasonic.toughpad.android.api.barcode.BarcodeData']]"
		[Register ("onRead", "(Lcom/panasonic/toughpad/android/api/barcode/BarcodeReader;Lcom/panasonic/toughpad/android/api/barcode/BarcodeData;)V", "GetOnRead_Lcom_panasonic_toughpad_android_api_barcode_BarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_Handler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListenerInvoker, Com.Panasonic.Toughpad.Android")]
		void OnRead (global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader p0, global::Com.Panasonic.Toughpad.Android.Api.Barcode.BarcodeData p1);

	}

	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/api/barcode/BarcodeListener", DoNotGenerateAcw=true)]
	internal class IBarcodeListenerInvoker : global::Java.Lang.Object, IBarcodeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/panasonic/toughpad/android/api/barcode/BarcodeListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBarcodeListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBarcodeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBarcodeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.panasonic.toughpad.android.api.barcode.BarcodeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBarcodeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRead_Lcom_panasonic_toughpad_android_api_barcode_BarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_;
#pragma warning disable 0169
		static Delegate GetOnRead_Lcom_panasonic_toughpad_android_api_barcode_BarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_Handler ()
		{
			if (cb_onRead_Lcom_panasonic_toughpad_android_api_barcode_BarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_ == null)
				cb_onRead_Lcom_panasonic_toughpad_android_api_barcode_BarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRead_Lcom_panasonic_toughpad_android_api_barcode_BarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_);
			return cb_onRead_Lcom_panasonic_toughpad_android_api_barcode_BarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_;
		}

		static void n_OnRead_Lcom_panasonic_toughpad_android_api_barcode_BarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader p0 = (global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader)global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.BarcodeData p1 = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.BarcodeData> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRead (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRead_Lcom_panasonic_toughpad_android_api_barcode_BarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_;
		public unsafe void OnRead (global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader p0, global::Com.Panasonic.Toughpad.Android.Api.Barcode.BarcodeData p1)
		{
			if (id_onRead_Lcom_panasonic_toughpad_android_api_barcode_BarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_ == IntPtr.Zero)
				id_onRead_Lcom_panasonic_toughpad_android_api_barcode_BarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_ = JNIEnv.GetMethodID (class_ref, "onRead", "(Lcom/panasonic/toughpad/android/api/barcode/BarcodeReader;Lcom/panasonic/toughpad/android/api/barcode/BarcodeData;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRead_Lcom_panasonic_toughpad_android_api_barcode_BarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_, __args);
		}

	}

	public partial class BarcodeEventArgs : global::System.EventArgs {

		public BarcodeEventArgs (global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader p0, global::Com.Panasonic.Toughpad.Android.Api.Barcode.BarcodeData p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader p0;
		public global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader P0 {
			get { return p0; }
		}

		global::Com.Panasonic.Toughpad.Android.Api.Barcode.BarcodeData p1;
		public global::Com.Panasonic.Toughpad.Android.Api.Barcode.BarcodeData P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/panasonic/toughpad/android/api/barcode/BarcodeListenerImplementor")]
	internal sealed partial class IBarcodeListenerImplementor : global::Java.Lang.Object, IBarcodeListener {

		object sender;

		public IBarcodeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/panasonic/toughpad/android/api/barcode/BarcodeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BarcodeEventArgs> Handler;
#pragma warning restore 0649

		public void OnRead (global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader p0, global::Com.Panasonic.Toughpad.Android.Api.Barcode.BarcodeData p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BarcodeEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBarcodeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
