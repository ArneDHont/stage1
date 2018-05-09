using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.api']/class[@name='ToughpadApi']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/api/ToughpadApi", DoNotGenerateAcw=true)]
	public partial class ToughpadApi : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/api/ToughpadApi", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ToughpadApi); }
		}

		protected ToughpadApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getClientVersion;
		public static unsafe int ClientVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api']/class[@name='ToughpadApi']/method[@name='getClientVersion' and count(parameter)=0]"
			[Register ("getClientVersion", "()I", "GetGetClientVersionHandler")]
			get {
				if (id_getClientVersion == IntPtr.Zero)
					id_getClientVersion = JNIEnv.GetStaticMethodID (class_ref, "getClientVersion", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getClientVersion);
				} finally {
				}
			}
		}

		static IntPtr id_isAlreadyInitialized;
		public static unsafe bool IsAlreadyInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api']/class[@name='ToughpadApi']/method[@name='isAlreadyInitialized' and count(parameter)=0]"
			[Register ("isAlreadyInitialized", "()Z", "GetIsAlreadyInitializedHandler")]
			get {
				if (id_isAlreadyInitialized == IntPtr.Zero)
					id_isAlreadyInitialized = JNIEnv.GetStaticMethodID (class_ref, "isAlreadyInitialized", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAlreadyInitialized);
				} finally {
				}
			}
		}

		static IntPtr id_getServerVersion;
		public static unsafe int ServerVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api']/class[@name='ToughpadApi']/method[@name='getServerVersion' and count(parameter)=0]"
			[Register ("getServerVersion", "()I", "GetGetServerVersionHandler")]
			get {
				if (id_getServerVersion == IntPtr.Zero)
					id_getServerVersion = JNIEnv.GetStaticMethodID (class_ref, "getServerVersion", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getServerVersion);
				} finally {
				}
			}
		}

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api']/class[@name='ToughpadApi']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "")]
		public static unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetStaticMethodID (class_ref, "destroy", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_destroy);
			} finally {
			}
		}

		static IntPtr id_getToughpadApi;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api']/class[@name='ToughpadApi']/method[@name='getToughpadApi' and count(parameter)=0]"
		[Register ("getToughpadApi", "()Lcom/panasonic/toughpad/android/contract/IToughpadApi;", "")]
		public static unsafe global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi GetToughpadApi ()
		{
			if (id_getToughpadApi == IntPtr.Zero)
				id_getToughpadApi = JNIEnv.GetStaticMethodID (class_ref, "getToughpadApi", "()Lcom/panasonic/toughpad/android/contract/IToughpadApi;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getToughpadApi), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_initialize_Landroid_content_Context_Lcom_panasonic_toughpad_android_api_ToughpadApiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api']/class[@name='ToughpadApi']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.panasonic.toughpad.android.api.ToughpadApiListener']]"
		[Register ("initialize", "(Landroid/content/Context;Lcom/panasonic/toughpad/android/api/ToughpadApiListener;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context p0, global::Com.Panasonic.Toughpad.Android.Api.IToughpadApiListener p1)
		{
			if (id_initialize_Landroid_content_Context_Lcom_panasonic_toughpad_android_api_ToughpadApiListener_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_Lcom_panasonic_toughpad_android_api_ToughpadApiListener_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;Lcom/panasonic/toughpad/android/api/ToughpadApiListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_content_Context_Lcom_panasonic_toughpad_android_api_ToughpadApiListener_, __args);
			} finally {
			}
		}

	}
}
