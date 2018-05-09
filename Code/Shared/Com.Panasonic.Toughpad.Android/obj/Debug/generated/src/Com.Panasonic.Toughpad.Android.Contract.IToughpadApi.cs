using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Contract {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IToughpadApi$Stub", DoNotGenerateAcw=true)]
	public abstract partial class ToughpadApiStub : global::Android.OS.Binder, global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub.Proxy']"
		[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IToughpadApi$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Java.Lang.Object, global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/panasonic/toughpad/android/contract/IToughpadApi$Stub$Proxy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Proxy); }
			}

			protected Proxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getAppButtonManager;
#pragma warning disable 0169
			static Delegate GetGetAppButtonManagerHandler ()
			{
				if (cb_getAppButtonManager == null)
					cb_getAppButtonManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppButtonManager);
				return cb_getAppButtonManager;
			}

			static IntPtr n_GetAppButtonManager (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AppButtonManager);
			}
#pragma warning restore 0169

			static IntPtr id_getAppButtonManager;
			public virtual unsafe global::Com.Panasonic.Toughpad.Android.Contract.IAppButtonManager AppButtonManager {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub.Proxy']/method[@name='getAppButtonManager' and count(parameter)=0]"
				[Register ("getAppButtonManager", "()Lcom/panasonic/toughpad/android/contract/IAppButtonManager;", "GetGetAppButtonManagerHandler")]
				get {
					if (id_getAppButtonManager == IntPtr.Zero)
						id_getAppButtonManager = JNIEnv.GetMethodID (class_ref, "getAppButtonManager", "()Lcom/panasonic/toughpad/android/contract/IAppButtonManager;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IAppButtonManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppButtonManager), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IAppButtonManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppButtonManager", "()Lcom/panasonic/toughpad/android/contract/IAppButtonManager;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getBarcodeReaderManager;
#pragma warning disable 0169
			static Delegate GetGetBarcodeReaderManagerHandler ()
			{
				if (cb_getBarcodeReaderManager == null)
					cb_getBarcodeReaderManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBarcodeReaderManager);
				return cb_getBarcodeReaderManager;
			}

			static IntPtr n_GetBarcodeReaderManager (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BarcodeReaderManager);
			}
#pragma warning restore 0169

			static IntPtr id_getBarcodeReaderManager;
			public virtual unsafe global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderManager BarcodeReaderManager {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub.Proxy']/method[@name='getBarcodeReaderManager' and count(parameter)=0]"
				[Register ("getBarcodeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IBarcodeReaderManager;", "GetGetBarcodeReaderManagerHandler")]
				get {
					if (id_getBarcodeReaderManager == IntPtr.Zero)
						id_getBarcodeReaderManager = JNIEnv.GetMethodID (class_ref, "getBarcodeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IBarcodeReaderManager;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBarcodeReaderManager), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBarcodeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IBarcodeReaderManager;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getCradle;
#pragma warning disable 0169
			static Delegate GetGetCradleHandler ()
			{
				if (cb_getCradle == null)
					cb_getCradle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCradle);
				return cb_getCradle;
			}

			static IntPtr n_GetCradle (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Cradle);
			}
#pragma warning restore 0169

			static IntPtr id_getCradle;
			public virtual unsafe global::Com.Panasonic.Toughpad.Android.Contract.ICradle Cradle {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub.Proxy']/method[@name='getCradle' and count(parameter)=0]"
				[Register ("getCradle", "()Lcom/panasonic/toughpad/android/contract/ICradle;", "GetGetCradleHandler")]
				get {
					if (id_getCradle == IntPtr.Zero)
						id_getCradle = JNIEnv.GetMethodID (class_ref, "getCradle", "()Lcom/panasonic/toughpad/android/contract/ICradle;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ICradle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCradle), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ICradle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCradle", "()Lcom/panasonic/toughpad/android/contract/ICradle;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

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
				global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.InterfaceDescriptor);
			}
#pragma warning restore 0169

			static IntPtr id_getInterfaceDescriptor;
			public virtual unsafe string InterfaceDescriptor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub.Proxy']/method[@name='getInterfaceDescriptor' and count(parameter)=0]"
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

			static Delegate cb_getMagStripeReaderManager;
#pragma warning disable 0169
			static Delegate GetGetMagStripeReaderManagerHandler ()
			{
				if (cb_getMagStripeReaderManager == null)
					cb_getMagStripeReaderManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMagStripeReaderManager);
				return cb_getMagStripeReaderManager;
			}

			static IntPtr n_GetMagStripeReaderManager (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.MagStripeReaderManager);
			}
#pragma warning restore 0169

			static IntPtr id_getMagStripeReaderManager;
			public virtual unsafe global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReaderManager MagStripeReaderManager {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub.Proxy']/method[@name='getMagStripeReaderManager' and count(parameter)=0]"
				[Register ("getMagStripeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IMagStripeReaderManager;", "GetGetMagStripeReaderManagerHandler")]
				get {
					if (id_getMagStripeReaderManager == IntPtr.Zero)
						id_getMagStripeReaderManager = JNIEnv.GetMethodID (class_ref, "getMagStripeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IMagStripeReaderManager;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReaderManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMagStripeReaderManager), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReaderManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMagStripeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IMagStripeReaderManager;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getPortPowerManager;
#pragma warning disable 0169
			static Delegate GetGetPortPowerManagerHandler ()
			{
				if (cb_getPortPowerManager == null)
					cb_getPortPowerManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPortPowerManager);
				return cb_getPortPowerManager;
			}

			static IntPtr n_GetPortPowerManager (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.PortPowerManager);
			}
#pragma warning restore 0169

			static IntPtr id_getPortPowerManager;
			public virtual unsafe global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager PortPowerManager {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub.Proxy']/method[@name='getPortPowerManager' and count(parameter)=0]"
				[Register ("getPortPowerManager", "()Lcom/panasonic/toughpad/android/contract/IPortPowerManager;", "GetGetPortPowerManagerHandler")]
				get {
					if (id_getPortPowerManager == IntPtr.Zero)
						id_getPortPowerManager = JNIEnv.GetMethodID (class_ref, "getPortPowerManager", "()Lcom/panasonic/toughpad/android/contract/IPortPowerManager;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPortPowerManager), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPortPowerManager", "()Lcom/panasonic/toughpad/android/contract/IPortPowerManager;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getSerialPortManager;
#pragma warning disable 0169
			static Delegate GetGetSerialPortManagerHandler ()
			{
				if (cb_getSerialPortManager == null)
					cb_getSerialPortManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialPortManager);
				return cb_getSerialPortManager;
			}

			static IntPtr n_GetSerialPortManager (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SerialPortManager);
			}
#pragma warning restore 0169

			static IntPtr id_getSerialPortManager;
			public virtual unsafe global::Com.Panasonic.Toughpad.Android.Contract.ISerialPortManager SerialPortManager {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub.Proxy']/method[@name='getSerialPortManager' and count(parameter)=0]"
				[Register ("getSerialPortManager", "()Lcom/panasonic/toughpad/android/contract/ISerialPortManager;", "GetGetSerialPortManagerHandler")]
				get {
					if (id_getSerialPortManager == IntPtr.Zero)
						id_getSerialPortManager = JNIEnv.GetMethodID (class_ref, "getSerialPortManager", "()Lcom/panasonic/toughpad/android/contract/ISerialPortManager;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ISerialPortManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerialPortManager), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ISerialPortManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSerialPortManager", "()Lcom/panasonic/toughpad/android/contract/ISerialPortManager;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getVersion;
#pragma warning disable 0169
			static Delegate GetGetVersionHandler ()
			{
				if (cb_getVersion == null)
					cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersion);
				return cb_getVersion;
			}

			static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Version;
			}
#pragma warning restore 0169

			static IntPtr id_getVersion;
			public virtual unsafe int Version {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub.Proxy']/method[@name='getVersion' and count(parameter)=0]"
				[Register ("getVersion", "()I", "GetGetVersionHandler")]
				get {
					if (id_getVersion == IntPtr.Zero)
						id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVersion);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersion", "()I"));
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
				global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinder;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub.Proxy']/method[@name='asBinder' and count(parameter)=0]"
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

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/contract/IToughpadApi$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ToughpadApiStub); }
		}

		protected ToughpadApiStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/constructor[@name='IToughpadApi.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ToughpadApiStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ToughpadApiStub)) {
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
			global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='asBinder' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/panasonic/toughpad/android/contract/IToughpadApi;", "")]
		public static unsafe global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/panasonic/toughpad/android/contract/IToughpadApi;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi __ret = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_getAppButtonManager;
#pragma warning disable 0169
		static Delegate GetGetAppButtonManagerHandler ()
		{
			if (cb_getAppButtonManager == null)
				cb_getAppButtonManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppButtonManager);
			return cb_getAppButtonManager;
		}

		static IntPtr n_GetAppButtonManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppButtonManager);
		}
#pragma warning restore 0169

		public abstract global::Com.Panasonic.Toughpad.Android.Contract.IAppButtonManager AppButtonManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='getAppButtonManager' and count(parameter)=0]"
			[Register ("getAppButtonManager", "()Lcom/panasonic/toughpad/android/contract/IAppButtonManager;", "GetGetAppButtonManagerHandler")] get;
		}

		static Delegate cb_getBarcodeReaderManager;
#pragma warning disable 0169
		static Delegate GetGetBarcodeReaderManagerHandler ()
		{
			if (cb_getBarcodeReaderManager == null)
				cb_getBarcodeReaderManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBarcodeReaderManager);
			return cb_getBarcodeReaderManager;
		}

		static IntPtr n_GetBarcodeReaderManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BarcodeReaderManager);
		}
#pragma warning restore 0169

		public abstract global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderManager BarcodeReaderManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='getBarcodeReaderManager' and count(parameter)=0]"
			[Register ("getBarcodeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IBarcodeReaderManager;", "GetGetBarcodeReaderManagerHandler")] get;
		}

		static Delegate cb_getCradle;
#pragma warning disable 0169
		static Delegate GetGetCradleHandler ()
		{
			if (cb_getCradle == null)
				cb_getCradle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCradle);
			return cb_getCradle;
		}

		static IntPtr n_GetCradle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cradle);
		}
#pragma warning restore 0169

		public abstract global::Com.Panasonic.Toughpad.Android.Contract.ICradle Cradle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='getCradle' and count(parameter)=0]"
			[Register ("getCradle", "()Lcom/panasonic/toughpad/android/contract/ICradle;", "GetGetCradleHandler")] get;
		}

		static Delegate cb_getMagStripeReaderManager;
#pragma warning disable 0169
		static Delegate GetGetMagStripeReaderManagerHandler ()
		{
			if (cb_getMagStripeReaderManager == null)
				cb_getMagStripeReaderManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMagStripeReaderManager);
			return cb_getMagStripeReaderManager;
		}

		static IntPtr n_GetMagStripeReaderManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MagStripeReaderManager);
		}
#pragma warning restore 0169

		public abstract global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReaderManager MagStripeReaderManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='getMagStripeReaderManager' and count(parameter)=0]"
			[Register ("getMagStripeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IMagStripeReaderManager;", "GetGetMagStripeReaderManagerHandler")] get;
		}

		static Delegate cb_getPortPowerManager;
#pragma warning disable 0169
		static Delegate GetGetPortPowerManagerHandler ()
		{
			if (cb_getPortPowerManager == null)
				cb_getPortPowerManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPortPowerManager);
			return cb_getPortPowerManager;
		}

		static IntPtr n_GetPortPowerManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PortPowerManager);
		}
#pragma warning restore 0169

		public abstract global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager PortPowerManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='getPortPowerManager' and count(parameter)=0]"
			[Register ("getPortPowerManager", "()Lcom/panasonic/toughpad/android/contract/IPortPowerManager;", "GetGetPortPowerManagerHandler")] get;
		}

		static Delegate cb_getSerialPortManager;
#pragma warning disable 0169
		static Delegate GetGetSerialPortManagerHandler ()
		{
			if (cb_getSerialPortManager == null)
				cb_getSerialPortManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialPortManager);
			return cb_getSerialPortManager;
		}

		static IntPtr n_GetSerialPortManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SerialPortManager);
		}
#pragma warning restore 0169

		public abstract global::Com.Panasonic.Toughpad.Android.Contract.ISerialPortManager SerialPortManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='getSerialPortManager' and count(parameter)=0]"
			[Register ("getSerialPortManager", "()Lcom/panasonic/toughpad/android/contract/ISerialPortManager;", "GetGetSerialPortManagerHandler")] get;
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersion);
			return cb_getVersion;
		}

		static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		public abstract int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IToughpadApi$Stub", DoNotGenerateAcw=true)]
	internal partial class ToughpadApiStubInvoker : ToughpadApiStub {

		public ToughpadApiStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ToughpadApiStubInvoker); }
		}

		static IntPtr id_getAppButtonManager;
		public override unsafe global::Com.Panasonic.Toughpad.Android.Contract.IAppButtonManager AppButtonManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='getAppButtonManager' and count(parameter)=0]"
			[Register ("getAppButtonManager", "()Lcom/panasonic/toughpad/android/contract/IAppButtonManager;", "GetGetAppButtonManagerHandler")]
			get {
				if (id_getAppButtonManager == IntPtr.Zero)
					id_getAppButtonManager = JNIEnv.GetMethodID (class_ref, "getAppButtonManager", "()Lcom/panasonic/toughpad/android/contract/IAppButtonManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IAppButtonManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppButtonManager), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getBarcodeReaderManager;
		public override unsafe global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderManager BarcodeReaderManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='getBarcodeReaderManager' and count(parameter)=0]"
			[Register ("getBarcodeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IBarcodeReaderManager;", "GetGetBarcodeReaderManagerHandler")]
			get {
				if (id_getBarcodeReaderManager == IntPtr.Zero)
					id_getBarcodeReaderManager = JNIEnv.GetMethodID (class_ref, "getBarcodeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IBarcodeReaderManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBarcodeReaderManager), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCradle;
		public override unsafe global::Com.Panasonic.Toughpad.Android.Contract.ICradle Cradle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='getCradle' and count(parameter)=0]"
			[Register ("getCradle", "()Lcom/panasonic/toughpad/android/contract/ICradle;", "GetGetCradleHandler")]
			get {
				if (id_getCradle == IntPtr.Zero)
					id_getCradle = JNIEnv.GetMethodID (class_ref, "getCradle", "()Lcom/panasonic/toughpad/android/contract/ICradle;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ICradle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCradle), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMagStripeReaderManager;
		public override unsafe global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReaderManager MagStripeReaderManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='getMagStripeReaderManager' and count(parameter)=0]"
			[Register ("getMagStripeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IMagStripeReaderManager;", "GetGetMagStripeReaderManagerHandler")]
			get {
				if (id_getMagStripeReaderManager == IntPtr.Zero)
					id_getMagStripeReaderManager = JNIEnv.GetMethodID (class_ref, "getMagStripeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IMagStripeReaderManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReaderManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMagStripeReaderManager), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPortPowerManager;
		public override unsafe global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager PortPowerManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='getPortPowerManager' and count(parameter)=0]"
			[Register ("getPortPowerManager", "()Lcom/panasonic/toughpad/android/contract/IPortPowerManager;", "GetGetPortPowerManagerHandler")]
			get {
				if (id_getPortPowerManager == IntPtr.Zero)
					id_getPortPowerManager = JNIEnv.GetMethodID (class_ref, "getPortPowerManager", "()Lcom/panasonic/toughpad/android/contract/IPortPowerManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPortPowerManager), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSerialPortManager;
		public override unsafe global::Com.Panasonic.Toughpad.Android.Contract.ISerialPortManager SerialPortManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='getSerialPortManager' and count(parameter)=0]"
			[Register ("getSerialPortManager", "()Lcom/panasonic/toughpad/android/contract/ISerialPortManager;", "GetGetSerialPortManagerHandler")]
			get {
				if (id_getSerialPortManager == IntPtr.Zero)
					id_getSerialPortManager = JNIEnv.GetMethodID (class_ref, "getSerialPortManager", "()Lcom/panasonic/toughpad/android/contract/ISerialPortManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ISerialPortManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerialPortManager), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVersion;
		public override unsafe int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IToughpadApi.Stub']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVersion);
				} finally {
				}
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IToughpadApi']"
	[Register ("com/panasonic/toughpad/android/contract/IToughpadApi", "", "Com.Panasonic.Toughpad.Android.Contract.IToughpadApiInvoker")]
	public partial interface IToughpadApi : global::Android.OS.IInterface {

		global::Com.Panasonic.Toughpad.Android.Contract.IAppButtonManager AppButtonManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IToughpadApi']/method[@name='getAppButtonManager' and count(parameter)=0]"
			[Register ("getAppButtonManager", "()Lcom/panasonic/toughpad/android/contract/IAppButtonManager;", "GetGetAppButtonManagerHandler:Com.Panasonic.Toughpad.Android.Contract.IToughpadApiInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderManager BarcodeReaderManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IToughpadApi']/method[@name='getBarcodeReaderManager' and count(parameter)=0]"
			[Register ("getBarcodeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IBarcodeReaderManager;", "GetGetBarcodeReaderManagerHandler:Com.Panasonic.Toughpad.Android.Contract.IToughpadApiInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		global::Com.Panasonic.Toughpad.Android.Contract.ICradle Cradle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IToughpadApi']/method[@name='getCradle' and count(parameter)=0]"
			[Register ("getCradle", "()Lcom/panasonic/toughpad/android/contract/ICradle;", "GetGetCradleHandler:Com.Panasonic.Toughpad.Android.Contract.IToughpadApiInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReaderManager MagStripeReaderManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IToughpadApi']/method[@name='getMagStripeReaderManager' and count(parameter)=0]"
			[Register ("getMagStripeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IMagStripeReaderManager;", "GetGetMagStripeReaderManagerHandler:Com.Panasonic.Toughpad.Android.Contract.IToughpadApiInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager PortPowerManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IToughpadApi']/method[@name='getPortPowerManager' and count(parameter)=0]"
			[Register ("getPortPowerManager", "()Lcom/panasonic/toughpad/android/contract/IPortPowerManager;", "GetGetPortPowerManagerHandler:Com.Panasonic.Toughpad.Android.Contract.IToughpadApiInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		global::Com.Panasonic.Toughpad.Android.Contract.ISerialPortManager SerialPortManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IToughpadApi']/method[@name='getSerialPortManager' and count(parameter)=0]"
			[Register ("getSerialPortManager", "()Lcom/panasonic/toughpad/android/contract/ISerialPortManager;", "GetGetSerialPortManagerHandler:Com.Panasonic.Toughpad.Android.Contract.IToughpadApiInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IToughpadApi']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler:Com.Panasonic.Toughpad.Android.Contract.IToughpadApiInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

	}

	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IToughpadApi", DoNotGenerateAcw=true)]
	internal class IToughpadApiInvoker : global::Java.Lang.Object, IToughpadApi {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/panasonic/toughpad/android/contract/IToughpadApi");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IToughpadApiInvoker); }
		}

		IntPtr class_ref;

		public static IToughpadApi GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IToughpadApi> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.panasonic.toughpad.android.contract.IToughpadApi"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IToughpadApiInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAppButtonManager;
#pragma warning disable 0169
		static Delegate GetGetAppButtonManagerHandler ()
		{
			if (cb_getAppButtonManager == null)
				cb_getAppButtonManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppButtonManager);
			return cb_getAppButtonManager;
		}

		static IntPtr n_GetAppButtonManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppButtonManager);
		}
#pragma warning restore 0169

		IntPtr id_getAppButtonManager;
		public unsafe global::Com.Panasonic.Toughpad.Android.Contract.IAppButtonManager AppButtonManager {
			get {
				if (id_getAppButtonManager == IntPtr.Zero)
					id_getAppButtonManager = JNIEnv.GetMethodID (class_ref, "getAppButtonManager", "()Lcom/panasonic/toughpad/android/contract/IAppButtonManager;");
				return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IAppButtonManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppButtonManager), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBarcodeReaderManager;
#pragma warning disable 0169
		static Delegate GetGetBarcodeReaderManagerHandler ()
		{
			if (cb_getBarcodeReaderManager == null)
				cb_getBarcodeReaderManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBarcodeReaderManager);
			return cb_getBarcodeReaderManager;
		}

		static IntPtr n_GetBarcodeReaderManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BarcodeReaderManager);
		}
#pragma warning restore 0169

		IntPtr id_getBarcodeReaderManager;
		public unsafe global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderManager BarcodeReaderManager {
			get {
				if (id_getBarcodeReaderManager == IntPtr.Zero)
					id_getBarcodeReaderManager = JNIEnv.GetMethodID (class_ref, "getBarcodeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IBarcodeReaderManager;");
				return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBarcodeReaderManager), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCradle;
#pragma warning disable 0169
		static Delegate GetGetCradleHandler ()
		{
			if (cb_getCradle == null)
				cb_getCradle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCradle);
			return cb_getCradle;
		}

		static IntPtr n_GetCradle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cradle);
		}
#pragma warning restore 0169

		IntPtr id_getCradle;
		public unsafe global::Com.Panasonic.Toughpad.Android.Contract.ICradle Cradle {
			get {
				if (id_getCradle == IntPtr.Zero)
					id_getCradle = JNIEnv.GetMethodID (class_ref, "getCradle", "()Lcom/panasonic/toughpad/android/contract/ICradle;");
				return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ICradle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCradle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMagStripeReaderManager;
#pragma warning disable 0169
		static Delegate GetGetMagStripeReaderManagerHandler ()
		{
			if (cb_getMagStripeReaderManager == null)
				cb_getMagStripeReaderManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMagStripeReaderManager);
			return cb_getMagStripeReaderManager;
		}

		static IntPtr n_GetMagStripeReaderManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MagStripeReaderManager);
		}
#pragma warning restore 0169

		IntPtr id_getMagStripeReaderManager;
		public unsafe global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReaderManager MagStripeReaderManager {
			get {
				if (id_getMagStripeReaderManager == IntPtr.Zero)
					id_getMagStripeReaderManager = JNIEnv.GetMethodID (class_ref, "getMagStripeReaderManager", "()Lcom/panasonic/toughpad/android/contract/IMagStripeReaderManager;");
				return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReaderManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMagStripeReaderManager), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPortPowerManager;
#pragma warning disable 0169
		static Delegate GetGetPortPowerManagerHandler ()
		{
			if (cb_getPortPowerManager == null)
				cb_getPortPowerManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPortPowerManager);
			return cb_getPortPowerManager;
		}

		static IntPtr n_GetPortPowerManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PortPowerManager);
		}
#pragma warning restore 0169

		IntPtr id_getPortPowerManager;
		public unsafe global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager PortPowerManager {
			get {
				if (id_getPortPowerManager == IntPtr.Zero)
					id_getPortPowerManager = JNIEnv.GetMethodID (class_ref, "getPortPowerManager", "()Lcom/panasonic/toughpad/android/contract/IPortPowerManager;");
				return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPortPowerManager), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSerialPortManager;
#pragma warning disable 0169
		static Delegate GetGetSerialPortManagerHandler ()
		{
			if (cb_getSerialPortManager == null)
				cb_getSerialPortManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialPortManager);
			return cb_getSerialPortManager;
		}

		static IntPtr n_GetSerialPortManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SerialPortManager);
		}
#pragma warning restore 0169

		IntPtr id_getSerialPortManager;
		public unsafe global::Com.Panasonic.Toughpad.Android.Contract.ISerialPortManager SerialPortManager {
			get {
				if (id_getSerialPortManager == IntPtr.Zero)
					id_getSerialPortManager = JNIEnv.GetMethodID (class_ref, "getSerialPortManager", "()Lcom/panasonic/toughpad/android/contract/ISerialPortManager;");
				return global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.ISerialPortManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerialPortManager), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersion);
			return cb_getVersion;
		}

		static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		IntPtr id_getVersion;
		public unsafe int Version {
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVersion);
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
			global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IToughpadApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
