using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Contract {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IMagStripeListener.Stub']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IMagStripeListener$Stub", DoNotGenerateAcw=true)]
	public abstract partial class MagStripeListenerStub : global::Android.OS.Binder, global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeListener {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IMagStripeListener.Stub.Proxy']"
		[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IMagStripeListener$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Java.Lang.Object, global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/panasonic/toughpad/android/contract/IMagStripeListener$Stub$Proxy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Proxy); }
			}

			protected Proxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getInterfaceDescriptor;
#pragma warning disable 0169
			static Delegate GetGetInterfaceDescriptorHandler ()
			{
				if (cb_getInterfaceDescriptor == null)
					cb_getInterfaceDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInterfaceDescriptor);
				return cb_getInterfaceDescriptor;
			}

			static IntPtr n_GetInterfaceDescriptor (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.MagStripeListenerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.MagStripeListenerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.InterfaceDescriptor);
			}
#pragma warning restore 0169

			static IntPtr id_getInterfaceDescriptor;
			public virtual unsafe string InterfaceDescriptor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IMagStripeListener.Stub.Proxy']/method[@name='getInterfaceDescriptor' and count(parameter)=0]"
				[Register ("getInterfaceDescriptor", "()Ljava/lang/String;", "GetGetInterfaceDescriptorHandler")]
				get {
					if (id_getInterfaceDescriptor == IntPtr.Zero)
						id_getInterfaceDescriptor = JNIEnv.GetMethodID (class_ref, "getInterfaceDescriptor", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInterfaceDescriptor), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInterfaceDescriptor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_asBinder;
#pragma warning disable 0169
			static Delegate GetAsBinderHandler ()
			{
				if (cb_asBinder == null)
					cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
				return cb_asBinder;
			}

			static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.MagStripeListenerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.MagStripeListenerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinder;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IMagStripeListener.Stub.Proxy']/method[@name='asBinder' and count(parameter)=0]"
			[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
			public virtual unsafe global::Android.OS.IBinder AsBinder ()
			{
				if (id_asBinder == IntPtr.Zero)
					id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinder", "()Landroid/os/IBinder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_;
#pragma warning disable 0169
			static Delegate GetOnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_Handler ()
			{
				if (cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ == null)
					cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_);
				return cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_;
			}

			static void n_OnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.MagStripeListenerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.MagStripeListenerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader p0 = (global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader)global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1 = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnRead (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IMagStripeListener.Stub.Proxy']/method[@name='onRead' and count(parameter)=2 and parameter[1][@type='com.panasonic.toughpad.android.contract.IMagStripeReader'] and parameter[2][@type='com.panasonic.toughpad.android.api.magstripe.MagStripeData']]"
			[Register ("onRead", "(Lcom/panasonic/toughpad/android/contract/IMagStripeReader;Lcom/panasonic/toughpad/android/api/magstripe/MagStripeData;)V", "GetOnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_Handler")]
			public virtual unsafe void OnRead (global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader p0, global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1)
			{
				if (id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ == IntPtr.Zero)
					id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ = JNIEnv.GetMethodID (class_ref, "onRead", "(Lcom/panasonic/toughpad/android/contract/IMagStripeReader;Lcom/panasonic/toughpad/android/api/magstripe/MagStripeData;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRead", "(Lcom/panasonic/toughpad/android/contract/IMagStripeReader;Lcom/panasonic/toughpad/android/api/magstripe/MagStripeData;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/contract/IMagStripeListener$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MagStripeListenerStub); }
		}

		protected MagStripeListenerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IMagStripeListener.Stub']/constructor[@name='IMagStripeListener.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MagStripeListenerStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MagStripeListenerStub)) {
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.MagStripeListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.MagStripeListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IMagStripeListener.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinder", "()Landroid/os/IBinder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_asInterface_Landroid_os_IBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IMagStripeListener.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/panasonic/toughpad/android/contract/IMagStripeListener;", "")]
		public static unsafe global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeListener AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/panasonic/toughpad/android/contract/IMagStripeListener;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeListener __ret = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeListener> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.MagStripeListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.MagStripeListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IMagStripeListener.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int p0, global::Android.OS.Parcel p1, global::Android.OS.Parcel p2, int p3)
		{
			if (id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_;
#pragma warning disable 0169
		static Delegate GetOnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_Handler ()
		{
			if (cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ == null)
				cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_);
			return cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_;
		}

		static void n_OnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.MagStripeListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.MagStripeListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader p0 = (global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader)global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1 = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRead (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IMagStripeListener']/method[@name='onRead' and count(parameter)=2 and parameter[1][@type='com.panasonic.toughpad.android.contract.IMagStripeReader'] and parameter[2][@type='com.panasonic.toughpad.android.api.magstripe.MagStripeData']]"
		[Register ("onRead", "(Lcom/panasonic/toughpad/android/contract/IMagStripeReader;Lcom/panasonic/toughpad/android/api/magstripe/MagStripeData;)V", "GetOnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_Handler")]
		public abstract void OnRead (global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader p0, global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1);

	}

	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IMagStripeListener$Stub", DoNotGenerateAcw=true)]
	internal partial class MagStripeListenerStubInvoker : MagStripeListenerStub {

		public MagStripeListenerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MagStripeListenerStubInvoker); }
		}

		static IntPtr id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IMagStripeListener']/method[@name='onRead' and count(parameter)=2 and parameter[1][@type='com.panasonic.toughpad.android.contract.IMagStripeReader'] and parameter[2][@type='com.panasonic.toughpad.android.api.magstripe.MagStripeData']]"
		[Register ("onRead", "(Lcom/panasonic/toughpad/android/contract/IMagStripeReader;Lcom/panasonic/toughpad/android/api/magstripe/MagStripeData;)V", "GetOnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_Handler")]
		public override unsafe void OnRead (global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader p0, global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1)
		{
			if (id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ == IntPtr.Zero)
				id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ = JNIEnv.GetMethodID (class_ref, "onRead", "(Lcom/panasonic/toughpad/android/contract/IMagStripeReader;Lcom/panasonic/toughpad/android/api/magstripe/MagStripeData;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_, __args);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IMagStripeListener']"
	[Register ("com/panasonic/toughpad/android/contract/IMagStripeListener", "", "Com.Panasonic.Toughpad.Android.Contract.IMagStripeListenerInvoker")]
	public partial interface IMagStripeListener : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IMagStripeListener']/method[@name='onRead' and count(parameter)=2 and parameter[1][@type='com.panasonic.toughpad.android.contract.IMagStripeReader'] and parameter[2][@type='com.panasonic.toughpad.android.api.magstripe.MagStripeData']]"
		[Register ("onRead", "(Lcom/panasonic/toughpad/android/contract/IMagStripeReader;Lcom/panasonic/toughpad/android/api/magstripe/MagStripeData;)V", "GetOnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_Handler:Com.Panasonic.Toughpad.Android.Contract.IMagStripeListenerInvoker, Com.Panasonic.Toughpad.Android")]
		void OnRead (global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader p0, global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1);

	}

	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IMagStripeListener", DoNotGenerateAcw=true)]
	internal class IMagStripeListenerInvoker : global::Java.Lang.Object, IMagStripeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/panasonic/toughpad/android/contract/IMagStripeListener");

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
							JNIEnv.GetClassNameFromInstance (handle), "com.panasonic.toughpad.android.contract.IMagStripeListener"));
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

		static Delegate cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_;
#pragma warning disable 0169
		static Delegate GetOnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_Handler ()
		{
			if (cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ == null)
				cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_);
			return cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_;
		}

		static void n_OnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeListener __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader p0 = (global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader)global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1 = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRead (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_;
		public unsafe void OnRead (global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader p0, global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1)
		{
			if (id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ == IntPtr.Zero)
				id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ = JNIEnv.GetMethodID (class_ref, "onRead", "(Lcom/panasonic/toughpad/android/contract/IMagStripeReader;Lcom/panasonic/toughpad/android/api/magstripe/MagStripeData;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_, __args);
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeListener __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
