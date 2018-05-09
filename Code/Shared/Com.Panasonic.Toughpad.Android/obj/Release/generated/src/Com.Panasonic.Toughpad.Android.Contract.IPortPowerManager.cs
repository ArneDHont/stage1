using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Contract {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IPortPowerManager.Stub']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IPortPowerManager$Stub", DoNotGenerateAcw=true)]
	public abstract partial class PortPowerManagerStub : global::Android.OS.Binder, global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IPortPowerManager.Stub.Proxy']"
		[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IPortPowerManager$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Java.Lang.Object, global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/panasonic/toughpad/android/contract/IPortPowerManager$Stub$Proxy", ref java_class_handle);
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
				global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.InterfaceDescriptor);
			}
#pragma warning restore 0169

			static IntPtr id_getInterfaceDescriptor;
			public virtual unsafe string InterfaceDescriptor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IPortPowerManager.Stub.Proxy']/method[@name='getInterfaceDescriptor' and count(parameter)=0]"
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
				global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinder;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IPortPowerManager.Stub.Proxy']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate cb_isPortAvailable_I;
#pragma warning disable 0169
			static Delegate GetIsPortAvailable_IHandler ()
			{
				if (cb_isPortAvailable_I == null)
					cb_isPortAvailable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsPortAvailable_I);
				return cb_isPortAvailable_I;
			}

			static bool n_IsPortAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsPortAvailable (p0);
			}
#pragma warning restore 0169

			static IntPtr id_isPortAvailable_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IPortPowerManager.Stub.Proxy']/method[@name='isPortAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("isPortAvailable", "(I)Z", "GetIsPortAvailable_IHandler")]
			public virtual unsafe bool IsPortAvailable (int p0)
			{
				if (id_isPortAvailable_I == IntPtr.Zero)
					id_isPortAvailable_I = JNIEnv.GetMethodID (class_ref, "isPortAvailable", "(I)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPortAvailable_I, __args);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPortAvailable", "(I)Z"), __args);
				} finally {
				}
			}

			static Delegate cb_isSelectiveSuspend_I;
#pragma warning disable 0169
			static Delegate GetIsSelectiveSuspend_IHandler ()
			{
				if (cb_isSelectiveSuspend_I == null)
					cb_isSelectiveSuspend_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsSelectiveSuspend_I);
				return cb_isSelectiveSuspend_I;
			}

			static bool n_IsSelectiveSuspend_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsSelectiveSuspend (p0);
			}
#pragma warning restore 0169

			static IntPtr id_isSelectiveSuspend_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IPortPowerManager.Stub.Proxy']/method[@name='isSelectiveSuspend' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("isSelectiveSuspend", "(I)Z", "GetIsSelectiveSuspend_IHandler")]
			public virtual unsafe bool IsSelectiveSuspend (int p0)
			{
				if (id_isSelectiveSuspend_I == IntPtr.Zero)
					id_isSelectiveSuspend_I = JNIEnv.GetMethodID (class_ref, "isSelectiveSuspend", "(I)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSelectiveSuspend_I, __args);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSelectiveSuspend", "(I)Z"), __args);
				} finally {
				}
			}

			static Delegate cb_isVBUSSupply_I;
#pragma warning disable 0169
			static Delegate GetIsVBUSSupply_IHandler ()
			{
				if (cb_isVBUSSupply_I == null)
					cb_isVBUSSupply_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsVBUSSupply_I);
				return cb_isVBUSSupply_I;
			}

			static bool n_IsVBUSSupply_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsVBUSSupply (p0);
			}
#pragma warning restore 0169

			static IntPtr id_isVBUSSupply_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IPortPowerManager.Stub.Proxy']/method[@name='isVBUSSupply' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("isVBUSSupply", "(I)Z", "GetIsVBUSSupply_IHandler")]
			public virtual unsafe bool IsVBUSSupply (int p0)
			{
				if (id_isVBUSSupply_I == IntPtr.Zero)
					id_isVBUSSupply_I = JNIEnv.GetMethodID (class_ref, "isVBUSSupply", "(I)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVBUSSupply_I, __args);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVBUSSupply", "(I)Z"), __args);
				} finally {
				}
			}

			static Delegate cb_setSelectiveSuspend_IZ;
#pragma warning disable 0169
			static Delegate GetSetSelectiveSuspend_IZHandler ()
			{
				if (cb_setSelectiveSuspend_IZ == null)
					cb_setSelectiveSuspend_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetSelectiveSuspend_IZ);
				return cb_setSelectiveSuspend_IZ;
			}

			static void n_SetSelectiveSuspend_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetSelectiveSuspend (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_setSelectiveSuspend_IZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IPortPowerManager.Stub.Proxy']/method[@name='setSelectiveSuspend' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
			[Register ("setSelectiveSuspend", "(IZ)V", "GetSetSelectiveSuspend_IZHandler")]
			public virtual unsafe void SetSelectiveSuspend (int p0, bool p1)
			{
				if (id_setSelectiveSuspend_IZ == IntPtr.Zero)
					id_setSelectiveSuspend_IZ = JNIEnv.GetMethodID (class_ref, "setSelectiveSuspend", "(IZ)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectiveSuspend_IZ, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectiveSuspend", "(IZ)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setVBUSSupply_IZ;
#pragma warning disable 0169
			static Delegate GetSetVBUSSupply_IZHandler ()
			{
				if (cb_setVBUSSupply_IZ == null)
					cb_setVBUSSupply_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetVBUSSupply_IZ);
				return cb_setVBUSSupply_IZ;
			}

			static void n_SetVBUSSupply_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetVBUSSupply (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_setVBUSSupply_IZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IPortPowerManager.Stub.Proxy']/method[@name='setVBUSSupply' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
			[Register ("setVBUSSupply", "(IZ)V", "GetSetVBUSSupply_IZHandler")]
			public virtual unsafe void SetVBUSSupply (int p0, bool p1)
			{
				if (id_setVBUSSupply_IZ == IntPtr.Zero)
					id_setVBUSSupply_IZ = JNIEnv.GetMethodID (class_ref, "setVBUSSupply", "(IZ)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVBUSSupply_IZ, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVBUSSupply", "(IZ)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/contract/IPortPowerManager$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PortPowerManagerStub); }
		}

		protected PortPowerManagerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IPortPowerManager.Stub']/constructor[@name='IPortPowerManager.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PortPowerManagerStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PortPowerManagerStub)) {
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
			global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IPortPowerManager.Stub']/method[@name='asBinder' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IPortPowerManager.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/panasonic/toughpad/android/contract/IPortPowerManager;", "")]
		public static unsafe global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/panasonic/toughpad/android/contract/IPortPowerManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager __ret = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IPortPowerManager.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_isPortAvailable_I;
#pragma warning disable 0169
		static Delegate GetIsPortAvailable_IHandler ()
		{
			if (cb_isPortAvailable_I == null)
				cb_isPortAvailable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsPortAvailable_I);
			return cb_isPortAvailable_I;
		}

		static bool n_IsPortAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPortAvailable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']/method[@name='isPortAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isPortAvailable", "(I)Z", "GetIsPortAvailable_IHandler")]
		public abstract bool IsPortAvailable (int p0);

		static Delegate cb_isSelectiveSuspend_I;
#pragma warning disable 0169
		static Delegate GetIsSelectiveSuspend_IHandler ()
		{
			if (cb_isSelectiveSuspend_I == null)
				cb_isSelectiveSuspend_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsSelectiveSuspend_I);
			return cb_isSelectiveSuspend_I;
		}

		static bool n_IsSelectiveSuspend_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSelectiveSuspend (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']/method[@name='isSelectiveSuspend' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isSelectiveSuspend", "(I)Z", "GetIsSelectiveSuspend_IHandler")]
		public abstract bool IsSelectiveSuspend (int p0);

		static Delegate cb_isVBUSSupply_I;
#pragma warning disable 0169
		static Delegate GetIsVBUSSupply_IHandler ()
		{
			if (cb_isVBUSSupply_I == null)
				cb_isVBUSSupply_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsVBUSSupply_I);
			return cb_isVBUSSupply_I;
		}

		static bool n_IsVBUSSupply_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVBUSSupply (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']/method[@name='isVBUSSupply' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isVBUSSupply", "(I)Z", "GetIsVBUSSupply_IHandler")]
		public abstract bool IsVBUSSupply (int p0);

		static Delegate cb_setSelectiveSuspend_IZ;
#pragma warning disable 0169
		static Delegate GetSetSelectiveSuspend_IZHandler ()
		{
			if (cb_setSelectiveSuspend_IZ == null)
				cb_setSelectiveSuspend_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetSelectiveSuspend_IZ);
			return cb_setSelectiveSuspend_IZ;
		}

		static void n_SetSelectiveSuspend_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectiveSuspend (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']/method[@name='setSelectiveSuspend' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setSelectiveSuspend", "(IZ)V", "GetSetSelectiveSuspend_IZHandler")]
		public abstract void SetSelectiveSuspend (int p0, bool p1);

		static Delegate cb_setVBUSSupply_IZ;
#pragma warning disable 0169
		static Delegate GetSetVBUSSupply_IZHandler ()
		{
			if (cb_setVBUSSupply_IZ == null)
				cb_setVBUSSupply_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetVBUSSupply_IZ);
			return cb_setVBUSSupply_IZ;
		}

		static void n_SetVBUSSupply_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVBUSSupply (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']/method[@name='setVBUSSupply' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setVBUSSupply", "(IZ)V", "GetSetVBUSSupply_IZHandler")]
		public abstract void SetVBUSSupply (int p0, bool p1);

	}

	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IPortPowerManager$Stub", DoNotGenerateAcw=true)]
	internal partial class PortPowerManagerStubInvoker : PortPowerManagerStub {

		public PortPowerManagerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PortPowerManagerStubInvoker); }
		}

		static IntPtr id_isPortAvailable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']/method[@name='isPortAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isPortAvailable", "(I)Z", "GetIsPortAvailable_IHandler")]
		public override unsafe bool IsPortAvailable (int p0)
		{
			if (id_isPortAvailable_I == IntPtr.Zero)
				id_isPortAvailable_I = JNIEnv.GetMethodID (class_ref, "isPortAvailable", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPortAvailable_I, __args);
			} finally {
			}
		}

		static IntPtr id_isSelectiveSuspend_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']/method[@name='isSelectiveSuspend' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isSelectiveSuspend", "(I)Z", "GetIsSelectiveSuspend_IHandler")]
		public override unsafe bool IsSelectiveSuspend (int p0)
		{
			if (id_isSelectiveSuspend_I == IntPtr.Zero)
				id_isSelectiveSuspend_I = JNIEnv.GetMethodID (class_ref, "isSelectiveSuspend", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSelectiveSuspend_I, __args);
			} finally {
			}
		}

		static IntPtr id_isVBUSSupply_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']/method[@name='isVBUSSupply' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isVBUSSupply", "(I)Z", "GetIsVBUSSupply_IHandler")]
		public override unsafe bool IsVBUSSupply (int p0)
		{
			if (id_isVBUSSupply_I == IntPtr.Zero)
				id_isVBUSSupply_I = JNIEnv.GetMethodID (class_ref, "isVBUSSupply", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVBUSSupply_I, __args);
			} finally {
			}
		}

		static IntPtr id_setSelectiveSuspend_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']/method[@name='setSelectiveSuspend' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setSelectiveSuspend", "(IZ)V", "GetSetSelectiveSuspend_IZHandler")]
		public override unsafe void SetSelectiveSuspend (int p0, bool p1)
		{
			if (id_setSelectiveSuspend_IZ == IntPtr.Zero)
				id_setSelectiveSuspend_IZ = JNIEnv.GetMethodID (class_ref, "setSelectiveSuspend", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectiveSuspend_IZ, __args);
			} finally {
			}
		}

		static IntPtr id_setVBUSSupply_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']/method[@name='setVBUSSupply' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setVBUSSupply", "(IZ)V", "GetSetVBUSSupply_IZHandler")]
		public override unsafe void SetVBUSSupply (int p0, bool p1)
		{
			if (id_setVBUSSupply_IZ == IntPtr.Zero)
				id_setVBUSSupply_IZ = JNIEnv.GetMethodID (class_ref, "setVBUSSupply", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVBUSSupply_IZ, __args);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']"
	[Register ("com/panasonic/toughpad/android/contract/IPortPowerManager", "", "Com.Panasonic.Toughpad.Android.Contract.IPortPowerManagerInvoker")]
	public partial interface IPortPowerManager : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']/method[@name='isPortAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isPortAvailable", "(I)Z", "GetIsPortAvailable_IHandler:Com.Panasonic.Toughpad.Android.Contract.IPortPowerManagerInvoker, Com.Panasonic.Toughpad.Android")]
		bool IsPortAvailable (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']/method[@name='isSelectiveSuspend' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isSelectiveSuspend", "(I)Z", "GetIsSelectiveSuspend_IHandler:Com.Panasonic.Toughpad.Android.Contract.IPortPowerManagerInvoker, Com.Panasonic.Toughpad.Android")]
		bool IsSelectiveSuspend (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']/method[@name='isVBUSSupply' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isVBUSSupply", "(I)Z", "GetIsVBUSSupply_IHandler:Com.Panasonic.Toughpad.Android.Contract.IPortPowerManagerInvoker, Com.Panasonic.Toughpad.Android")]
		bool IsVBUSSupply (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']/method[@name='setSelectiveSuspend' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setSelectiveSuspend", "(IZ)V", "GetSetSelectiveSuspend_IZHandler:Com.Panasonic.Toughpad.Android.Contract.IPortPowerManagerInvoker, Com.Panasonic.Toughpad.Android")]
		void SetSelectiveSuspend (int p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IPortPowerManager']/method[@name='setVBUSSupply' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setVBUSSupply", "(IZ)V", "GetSetVBUSSupply_IZHandler:Com.Panasonic.Toughpad.Android.Contract.IPortPowerManagerInvoker, Com.Panasonic.Toughpad.Android")]
		void SetVBUSSupply (int p0, bool p1);

	}

	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IPortPowerManager", DoNotGenerateAcw=true)]
	internal class IPortPowerManagerInvoker : global::Java.Lang.Object, IPortPowerManager {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/panasonic/toughpad/android/contract/IPortPowerManager");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPortPowerManagerInvoker); }
		}

		IntPtr class_ref;

		public static IPortPowerManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPortPowerManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.panasonic.toughpad.android.contract.IPortPowerManager"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPortPowerManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isPortAvailable_I;
#pragma warning disable 0169
		static Delegate GetIsPortAvailable_IHandler ()
		{
			if (cb_isPortAvailable_I == null)
				cb_isPortAvailable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsPortAvailable_I);
			return cb_isPortAvailable_I;
		}

		static bool n_IsPortAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPortAvailable (p0);
		}
#pragma warning restore 0169

		IntPtr id_isPortAvailable_I;
		public unsafe bool IsPortAvailable (int p0)
		{
			if (id_isPortAvailable_I == IntPtr.Zero)
				id_isPortAvailable_I = JNIEnv.GetMethodID (class_ref, "isPortAvailable", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPortAvailable_I, __args);
		}

		static Delegate cb_isSelectiveSuspend_I;
#pragma warning disable 0169
		static Delegate GetIsSelectiveSuspend_IHandler ()
		{
			if (cb_isSelectiveSuspend_I == null)
				cb_isSelectiveSuspend_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsSelectiveSuspend_I);
			return cb_isSelectiveSuspend_I;
		}

		static bool n_IsSelectiveSuspend_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSelectiveSuspend (p0);
		}
#pragma warning restore 0169

		IntPtr id_isSelectiveSuspend_I;
		public unsafe bool IsSelectiveSuspend (int p0)
		{
			if (id_isSelectiveSuspend_I == IntPtr.Zero)
				id_isSelectiveSuspend_I = JNIEnv.GetMethodID (class_ref, "isSelectiveSuspend", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSelectiveSuspend_I, __args);
		}

		static Delegate cb_isVBUSSupply_I;
#pragma warning disable 0169
		static Delegate GetIsVBUSSupply_IHandler ()
		{
			if (cb_isVBUSSupply_I == null)
				cb_isVBUSSupply_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsVBUSSupply_I);
			return cb_isVBUSSupply_I;
		}

		static bool n_IsVBUSSupply_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVBUSSupply (p0);
		}
#pragma warning restore 0169

		IntPtr id_isVBUSSupply_I;
		public unsafe bool IsVBUSSupply (int p0)
		{
			if (id_isVBUSSupply_I == IntPtr.Zero)
				id_isVBUSSupply_I = JNIEnv.GetMethodID (class_ref, "isVBUSSupply", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVBUSSupply_I, __args);
		}

		static Delegate cb_setSelectiveSuspend_IZ;
#pragma warning disable 0169
		static Delegate GetSetSelectiveSuspend_IZHandler ()
		{
			if (cb_setSelectiveSuspend_IZ == null)
				cb_setSelectiveSuspend_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetSelectiveSuspend_IZ);
			return cb_setSelectiveSuspend_IZ;
		}

		static void n_SetSelectiveSuspend_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectiveSuspend (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setSelectiveSuspend_IZ;
		public unsafe void SetSelectiveSuspend (int p0, bool p1)
		{
			if (id_setSelectiveSuspend_IZ == IntPtr.Zero)
				id_setSelectiveSuspend_IZ = JNIEnv.GetMethodID (class_ref, "setSelectiveSuspend", "(IZ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectiveSuspend_IZ, __args);
		}

		static Delegate cb_setVBUSSupply_IZ;
#pragma warning disable 0169
		static Delegate GetSetVBUSSupply_IZHandler ()
		{
			if (cb_setVBUSSupply_IZ == null)
				cb_setVBUSSupply_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetVBUSSupply_IZ);
			return cb_setVBUSSupply_IZ;
		}

		static void n_SetVBUSSupply_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVBUSSupply (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setVBUSSupply_IZ;
		public unsafe void SetVBUSSupply (int p0, bool p1)
		{
			if (id_setVBUSSupply_IZ == IntPtr.Zero)
				id_setVBUSSupply_IZ = JNIEnv.GetMethodID (class_ref, "setVBUSSupply", "(IZ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVBUSSupply_IZ, __args);
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
			global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IPortPowerManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
