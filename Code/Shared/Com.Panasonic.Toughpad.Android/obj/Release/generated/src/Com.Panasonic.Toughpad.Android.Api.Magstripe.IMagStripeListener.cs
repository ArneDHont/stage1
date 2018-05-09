using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Api.Magstripe {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/interface[@name='MagStripeListener']"
	[Register ("com/panasonic/toughpad/android/api/magstripe/MagStripeListener", "", "Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListenerInvoker")]
	public partial interface IMagStripeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/interface[@name='MagStripeListener']/method[@name='onRead' and count(parameter)=2 and parameter[1][@type='com.panasonic.toughpad.android.api.magstripe.MagStripeReader'] and parameter[2][@type='com.panasonic.toughpad.android.api.magstripe.MagStripeData']]"
		[Register ("onRead", "(Lcom/panasonic/toughpad/android/api/magstripe/MagStripeReader;Lcom/panasonic/toughpad/android/api/magstripe/MagStripeData;)V", "GetOnRead_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_Handler:Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListenerInvoker, Com.Panasonic.Toughpad.Android")]
		void OnRead (global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader p0, global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1);

	}

	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/api/magstripe/MagStripeListener", DoNotGenerateAcw=true)]
	internal class IMagStripeListenerInvoker : global::Java.Lang.Object, IMagStripeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/panasonic/toughpad/android/api/magstripe/MagStripeListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMagStripeListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMagStripeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMagStripeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.panasonic.toughpad.android.api.magstripe.MagStripeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMagStripeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRead_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_;
#pragma warning disable 0169
		static Delegate GetOnRead_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_Handler ()
		{
			if (cb_onRead_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ == null)
				cb_onRead_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRead_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_);
			return cb_onRead_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_;
		}

		static void n_OnRead_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader p0 = (global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader)global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1 = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRead (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRead_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_;
		public unsafe void OnRead (global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader p0, global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1)
		{
			if (id_onRead_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ == IntPtr.Zero)
				id_onRead_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ = JNIEnv.GetMethodID (class_ref, "onRead", "(Lcom/panasonic/toughpad/android/api/magstripe/MagStripeReader;Lcom/panasonic/toughpad/android/api/magstripe/MagStripeData;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRead_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_, __args);
		}

	}

	public partial class MagStripeEventArgs : global::System.EventArgs {

		public MagStripeEventArgs (global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader p0, global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader p0;
		public global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader P0 {
			get { return p0; }
		}

		global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1;
		public global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/panasonic/toughpad/android/api/magstripe/MagStripeListenerImplementor")]
	internal sealed partial class IMagStripeListenerImplementor : global::Java.Lang.Object, IMagStripeListener {

		object sender;

		public IMagStripeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/panasonic/toughpad/android/api/magstripe/MagStripeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MagStripeEventArgs> Handler;
#pragma warning restore 0649

		public void OnRead (global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader p0, global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MagStripeEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IMagStripeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
