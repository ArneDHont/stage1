using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.panasonic.toughpad.android.api']/interface[@name='ToughpadApiListener']"
	[Register ("com/panasonic/toughpad/android/api/ToughpadApiListener", "", "Com.Panasonic.Toughpad.Android.Api.IToughpadApiListenerInvoker")]
	public partial interface IToughpadApiListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api']/interface[@name='ToughpadApiListener']/method[@name='onApiConnected' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onApiConnected", "(I)V", "GetOnApiConnected_IHandler:Com.Panasonic.Toughpad.Android.Api.IToughpadApiListenerInvoker, Com.Panasonic.Toughpad.Android")]
		void OnApiConnected (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api']/interface[@name='ToughpadApiListener']/method[@name='onApiDisconnected' and count(parameter)=0]"
		[Register ("onApiDisconnected", "()V", "GetOnApiDisconnectedHandler:Com.Panasonic.Toughpad.Android.Api.IToughpadApiListenerInvoker, Com.Panasonic.Toughpad.Android")]
		void OnApiDisconnected ();

	}

	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/api/ToughpadApiListener", DoNotGenerateAcw=true)]
	internal class IToughpadApiListenerInvoker : global::Java.Lang.Object, IToughpadApiListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/panasonic/toughpad/android/api/ToughpadApiListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IToughpadApiListenerInvoker); }
		}

		IntPtr class_ref;

		public static IToughpadApiListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IToughpadApiListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.panasonic.toughpad.android.api.ToughpadApiListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IToughpadApiListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onApiConnected_I;
#pragma warning disable 0169
		static Delegate GetOnApiConnected_IHandler ()
		{
			if (cb_onApiConnected_I == null)
				cb_onApiConnected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnApiConnected_I);
			return cb_onApiConnected_I;
		}

		static void n_OnApiConnected_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Panasonic.Toughpad.Android.Api.IToughpadApiListener __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.IToughpadApiListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnApiConnected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onApiConnected_I;
		public unsafe void OnApiConnected (int p0)
		{
			if (id_onApiConnected_I == IntPtr.Zero)
				id_onApiConnected_I = JNIEnv.GetMethodID (class_ref, "onApiConnected", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApiConnected_I, __args);
		}

		static Delegate cb_onApiDisconnected;
#pragma warning disable 0169
		static Delegate GetOnApiDisconnectedHandler ()
		{
			if (cb_onApiDisconnected == null)
				cb_onApiDisconnected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnApiDisconnected);
			return cb_onApiDisconnected;
		}

		static void n_OnApiDisconnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.IToughpadApiListener __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.IToughpadApiListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnApiDisconnected ();
		}
#pragma warning restore 0169

		IntPtr id_onApiDisconnected;
		public unsafe void OnApiDisconnected ()
		{
			if (id_onApiDisconnected == IntPtr.Zero)
				id_onApiDisconnected = JNIEnv.GetMethodID (class_ref, "onApiDisconnected", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApiDisconnected);
		}

	}

	public partial class ApiConnectedEventArgs : global::System.EventArgs {

		public ApiConnectedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/panasonic/toughpad/android/api/ToughpadApiListenerImplementor")]
	internal sealed partial class IToughpadApiListenerImplementor : global::Java.Lang.Object, IToughpadApiListener {

		object sender;

		public IToughpadApiListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/panasonic/toughpad/android/api/ToughpadApiListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ApiConnectedEventArgs> OnApiConnectedHandler;
#pragma warning restore 0649

		public void OnApiConnected (int p0)
		{
			var __h = OnApiConnectedHandler;
			if (__h != null)
				__h (sender, new ApiConnectedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnApiDisconnectedHandler;
#pragma warning restore 0649

		public void OnApiDisconnected ()
		{
			var __h = OnApiDisconnectedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IToughpadApiListenerImplementor value)
		{
			return value.OnApiConnectedHandler == null && value.OnApiDisconnectedHandler == null;
		}
	}

}
