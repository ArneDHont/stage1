using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Contract {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IBarcodeReader$Stub", DoNotGenerateAcw=true)]
	public abstract partial class BarcodeReaderStub : global::Android.OS.Binder, global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']"
		[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IBarcodeReader$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Java.Lang.Object, global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/panasonic/toughpad/android/contract/IBarcodeReader$Stub$Proxy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Proxy); }
			}

			protected Proxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getBarcodeType;
#pragma warning disable 0169
			static Delegate GetGetBarcodeTypeHandler ()
			{
				if (cb_getBarcodeType == null)
					cb_getBarcodeType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBarcodeType);
				return cb_getBarcodeType;
			}

			static int n_GetBarcodeType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.BarcodeType;
			}
#pragma warning restore 0169

			static IntPtr id_getBarcodeType;
			public virtual unsafe int BarcodeType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='getBarcodeType' and count(parameter)=0]"
				[Register ("getBarcodeType", "()I", "GetGetBarcodeTypeHandler")]
				get {
					if (id_getBarcodeType == IntPtr.Zero)
						id_getBarcodeType = JNIEnv.GetMethodID (class_ref, "getBarcodeType", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBarcodeType);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBarcodeType", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getBatteryCharge;
#pragma warning disable 0169
			static Delegate GetGetBatteryChargeHandler ()
			{
				if (cb_getBatteryCharge == null)
					cb_getBatteryCharge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBatteryCharge);
				return cb_getBatteryCharge;
			}

			static int n_GetBatteryCharge (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.BatteryCharge;
			}
#pragma warning restore 0169

			static IntPtr id_getBatteryCharge;
			public virtual unsafe int BatteryCharge {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='getBatteryCharge' and count(parameter)=0]"
				[Register ("getBatteryCharge", "()I", "GetGetBatteryChargeHandler")]
				get {
					if (id_getBatteryCharge == IntPtr.Zero)
						id_getBatteryCharge = JNIEnv.GetMethodID (class_ref, "getBatteryCharge", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBatteryCharge);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBatteryCharge", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getDeviceFirmwareVersion;
#pragma warning disable 0169
			static Delegate GetGetDeviceFirmwareVersionHandler ()
			{
				if (cb_getDeviceFirmwareVersion == null)
					cb_getDeviceFirmwareVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceFirmwareVersion);
				return cb_getDeviceFirmwareVersion;
			}

			static IntPtr n_GetDeviceFirmwareVersion (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.DeviceFirmwareVersion);
			}
#pragma warning restore 0169

			static IntPtr id_getDeviceFirmwareVersion;
			public virtual unsafe string DeviceFirmwareVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='getDeviceFirmwareVersion' and count(parameter)=0]"
				[Register ("getDeviceFirmwareVersion", "()Ljava/lang/String;", "GetGetDeviceFirmwareVersionHandler")]
				get {
					if (id_getDeviceFirmwareVersion == IntPtr.Zero)
						id_getDeviceFirmwareVersion = JNIEnv.GetMethodID (class_ref, "getDeviceFirmwareVersion", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceFirmwareVersion), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceFirmwareVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getDeviceName;
#pragma warning disable 0169
			static Delegate GetGetDeviceNameHandler ()
			{
				if (cb_getDeviceName == null)
					cb_getDeviceName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceName);
				return cb_getDeviceName;
			}

			static IntPtr n_GetDeviceName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.DeviceName);
			}
#pragma warning restore 0169

			static IntPtr id_getDeviceName;
			public virtual unsafe string DeviceName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='getDeviceName' and count(parameter)=0]"
				[Register ("getDeviceName", "()Ljava/lang/String;", "GetGetDeviceNameHandler")]
				get {
					if (id_getDeviceName == IntPtr.Zero)
						id_getDeviceName = JNIEnv.GetMethodID (class_ref, "getDeviceName", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceName), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getDeviceSerialNumber;
#pragma warning disable 0169
			static Delegate GetGetDeviceSerialNumberHandler ()
			{
				if (cb_getDeviceSerialNumber == null)
					cb_getDeviceSerialNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceSerialNumber);
				return cb_getDeviceSerialNumber;
			}

			static IntPtr n_GetDeviceSerialNumber (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.DeviceSerialNumber);
			}
#pragma warning restore 0169

			static IntPtr id_getDeviceSerialNumber;
			public virtual unsafe string DeviceSerialNumber {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='getDeviceSerialNumber' and count(parameter)=0]"
				[Register ("getDeviceSerialNumber", "()Ljava/lang/String;", "GetGetDeviceSerialNumberHandler")]
				get {
					if (id_getDeviceSerialNumber == IntPtr.Zero)
						id_getDeviceSerialNumber = JNIEnv.GetMethodID (class_ref, "getDeviceSerialNumber", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceSerialNumber), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceSerialNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_isHardwareTriggerEnabled;
#pragma warning disable 0169
			static Delegate GetIsHardwareTriggerEnabledHandler ()
			{
				if (cb_isHardwareTriggerEnabled == null)
					cb_isHardwareTriggerEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHardwareTriggerEnabled);
				return cb_isHardwareTriggerEnabled;
			}

			static bool n_IsHardwareTriggerEnabled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HardwareTriggerEnabled;
			}
#pragma warning restore 0169

			static Delegate cb_setHardwareTriggerEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetHardwareTriggerEnabled_ZHandler ()
			{
				if (cb_setHardwareTriggerEnabled_Z == null)
					cb_setHardwareTriggerEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHardwareTriggerEnabled_Z);
				return cb_setHardwareTriggerEnabled_Z;
			}

			static void n_SetHardwareTriggerEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.HardwareTriggerEnabled = p0;
			}
#pragma warning restore 0169

			static IntPtr id_isHardwareTriggerEnabled;
			static IntPtr id_setHardwareTriggerEnabled_Z;
			public virtual unsafe bool HardwareTriggerEnabled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='isHardwareTriggerEnabled' and count(parameter)=0]"
				[Register ("isHardwareTriggerEnabled", "()Z", "GetIsHardwareTriggerEnabledHandler")]
				get {
					if (id_isHardwareTriggerEnabled == IntPtr.Zero)
						id_isHardwareTriggerEnabled = JNIEnv.GetMethodID (class_ref, "isHardwareTriggerEnabled", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHardwareTriggerEnabled);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHardwareTriggerEnabled", "()Z"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='setHardwareTriggerEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setHardwareTriggerEnabled", "(Z)V", "GetSetHardwareTriggerEnabled_ZHandler")]
				set {
					if (id_setHardwareTriggerEnabled_Z == IntPtr.Zero)
						id_setHardwareTriggerEnabled_Z = JNIEnv.GetMethodID (class_ref, "setHardwareTriggerEnabled", "(Z)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHardwareTriggerEnabled_Z, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHardwareTriggerEnabled", "(Z)V"), __args);
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
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.InterfaceDescriptor);
			}
#pragma warning restore 0169

			static IntPtr id_getInterfaceDescriptor;
			public virtual unsafe string InterfaceDescriptor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='getInterfaceDescriptor' and count(parameter)=0]"
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

			static Delegate cb_isBatteryCharging;
#pragma warning disable 0169
			static Delegate GetIsBatteryChargingHandler ()
			{
				if (cb_isBatteryCharging == null)
					cb_isBatteryCharging = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBatteryCharging);
				return cb_isBatteryCharging;
			}

			static bool n_IsBatteryCharging (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsBatteryCharging;
			}
#pragma warning restore 0169

			static IntPtr id_isBatteryCharging;
			public virtual unsafe bool IsBatteryCharging {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='isBatteryCharging' and count(parameter)=0]"
				[Register ("isBatteryCharging", "()Z", "GetIsBatteryChargingHandler")]
				get {
					if (id_isBatteryCharging == IntPtr.Zero)
						id_isBatteryCharging = JNIEnv.GetMethodID (class_ref, "isBatteryCharging", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBatteryCharging);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBatteryCharging", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_isEnabled;
#pragma warning disable 0169
			static Delegate GetIsEnabledHandler ()
			{
				if (cb_isEnabled == null)
					cb_isEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
				return cb_isEnabled;
			}

			static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsEnabled;
			}
#pragma warning restore 0169

			static IntPtr id_isEnabled;
			public virtual unsafe bool IsEnabled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='isEnabled' and count(parameter)=0]"
				[Register ("isEnabled", "()Z", "GetIsEnabledHandler")]
				get {
					if (id_isEnabled == IntPtr.Zero)
						id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnabled);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnabled", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_isExternal;
#pragma warning disable 0169
			static Delegate GetIsExternalHandler ()
			{
				if (cb_isExternal == null)
					cb_isExternal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExternal);
				return cb_isExternal;
			}

			static bool n_IsExternal (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsExternal;
			}
#pragma warning restore 0169

			static IntPtr id_isExternal;
			public virtual unsafe bool IsExternal {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='isExternal' and count(parameter)=0]"
				[Register ("isExternal", "()Z", "GetIsExternalHandler")]
				get {
					if (id_isExternal == IntPtr.Zero)
						id_isExternal = JNIEnv.GetMethodID (class_ref, "isExternal", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExternal);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isExternal", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_isHardwareTriggerAvailable;
#pragma warning disable 0169
			static Delegate GetIsHardwareTriggerAvailableHandler ()
			{
				if (cb_isHardwareTriggerAvailable == null)
					cb_isHardwareTriggerAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHardwareTriggerAvailable);
				return cb_isHardwareTriggerAvailable;
			}

			static bool n_IsHardwareTriggerAvailable (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsHardwareTriggerAvailable;
			}
#pragma warning restore 0169

			static IntPtr id_isHardwareTriggerAvailable;
			public virtual unsafe bool IsHardwareTriggerAvailable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='isHardwareTriggerAvailable' and count(parameter)=0]"
				[Register ("isHardwareTriggerAvailable", "()Z", "GetIsHardwareTriggerAvailableHandler")]
				get {
					if (id_isHardwareTriggerAvailable == IntPtr.Zero)
						id_isHardwareTriggerAvailable = JNIEnv.GetMethodID (class_ref, "isHardwareTriggerAvailable", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHardwareTriggerAvailable);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHardwareTriggerAvailable", "()Z"));
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
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinder;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate cb_disable;
#pragma warning disable 0169
			static Delegate GetDisableHandler ()
			{
				if (cb_disable == null)
					cb_disable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disable);
				return cb_disable;
			}

			static void n_Disable (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Disable ();
			}
#pragma warning restore 0169

			static IntPtr id_disable;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='disable' and count(parameter)=0]"
			[Register ("disable", "()V", "GetDisableHandler")]
			public virtual unsafe void Disable ()
			{
				if (id_disable == IntPtr.Zero)
					id_disable = JNIEnv.GetMethodID (class_ref, "disable", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disable);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disable", "()V"));
				} finally {
				}
			}

			static Delegate cb_enable_J;
#pragma warning disable 0169
			static Delegate GetEnable_JHandler ()
			{
				if (cb_enable_J == null)
					cb_enable_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Enable_J);
				return cb_enable_J;
			}

			static void n_Enable_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Enable (p0);
			}
#pragma warning restore 0169

			static IntPtr id_enable_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='enable' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("enable", "(J)V", "GetEnable_JHandler")]
			public virtual unsafe void Enable (long p0)
			{
				if (id_enable_J == IntPtr.Zero)
					id_enable_J = JNIEnv.GetMethodID (class_ref, "enable", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enable_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enable", "(J)V"), __args);
				} finally {
				}
			}

			static Delegate cb_pressSoftwareTrigger_Z;
#pragma warning disable 0169
			static Delegate GetPressSoftwareTrigger_ZHandler ()
			{
				if (cb_pressSoftwareTrigger_Z == null)
					cb_pressSoftwareTrigger_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_PressSoftwareTrigger_Z);
				return cb_pressSoftwareTrigger_Z;
			}

			static void n_PressSoftwareTrigger_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.PressSoftwareTrigger (p0);
			}
#pragma warning restore 0169

			static IntPtr id_pressSoftwareTrigger_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='pressSoftwareTrigger' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("pressSoftwareTrigger", "(Z)V", "GetPressSoftwareTrigger_ZHandler")]
			public virtual unsafe void PressSoftwareTrigger (bool p0)
			{
				if (id_pressSoftwareTrigger_Z == IntPtr.Zero)
					id_pressSoftwareTrigger_Z = JNIEnv.GetMethodID (class_ref, "pressSoftwareTrigger", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pressSoftwareTrigger_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pressSoftwareTrigger", "(Z)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_;
#pragma warning disable 0169
			static Delegate GetSetBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_Handler ()
			{
				if (cb_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_ == null)
					cb_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_);
				return cb_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_;
			}

			static void n_SetBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeListener p0 = (global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeListener)global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetBarcodeListener (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub.Proxy']/method[@name='setBarcodeListener' and count(parameter)=1 and parameter[1][@type='com.panasonic.toughpad.android.contract.IBarcodeListener']]"
			[Register ("setBarcodeListener", "(Lcom/panasonic/toughpad/android/contract/IBarcodeListener;)V", "GetSetBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_Handler")]
			public virtual unsafe void SetBarcodeListener (global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeListener p0)
			{
				if (id_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_ == IntPtr.Zero)
					id_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_ = JNIEnv.GetMethodID (class_ref, "setBarcodeListener", "(Lcom/panasonic/toughpad/android/contract/IBarcodeListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBarcodeListener", "(Lcom/panasonic/toughpad/android/contract/IBarcodeListener;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/contract/IBarcodeReader$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BarcodeReaderStub); }
		}

		protected BarcodeReaderStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/constructor[@name='IBarcodeReader.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BarcodeReaderStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BarcodeReaderStub)) {
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
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='asBinder' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/panasonic/toughpad/android/contract/IBarcodeReader;", "")]
		public static unsafe global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/panasonic/toughpad/android/contract/IBarcodeReader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __ret = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_disable;
#pragma warning disable 0169
		static Delegate GetDisableHandler ()
		{
			if (cb_disable == null)
				cb_disable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disable);
			return cb_disable;
		}

		static void n_Disable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "GetDisableHandler")]
		public abstract void Disable ();

		static Delegate cb_enable_J;
#pragma warning disable 0169
		static Delegate GetEnable_JHandler ()
		{
			if (cb_enable_J == null)
				cb_enable_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Enable_J);
			return cb_enable_J;
		}

		static void n_Enable_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='enable' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("enable", "(J)V", "GetEnable_JHandler")]
		public abstract void Enable (long p0);

		static Delegate cb_pressSoftwareTrigger_Z;
#pragma warning disable 0169
		static Delegate GetPressSoftwareTrigger_ZHandler ()
		{
			if (cb_pressSoftwareTrigger_Z == null)
				cb_pressSoftwareTrigger_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_PressSoftwareTrigger_Z);
			return cb_pressSoftwareTrigger_Z;
		}

		static void n_PressSoftwareTrigger_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PressSoftwareTrigger (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='pressSoftwareTrigger' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("pressSoftwareTrigger", "(Z)V", "GetPressSoftwareTrigger_ZHandler")]
		public abstract void PressSoftwareTrigger (bool p0);

		static Delegate cb_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_;
#pragma warning disable 0169
		static Delegate GetSetBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_Handler ()
		{
			if (cb_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_ == null)
				cb_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_);
			return cb_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_;
		}

		static void n_SetBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeListener p0 = (global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeListener)global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBarcodeListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='setBarcodeListener' and count(parameter)=1 and parameter[1][@type='com.panasonic.toughpad.android.contract.IBarcodeListener']]"
		[Register ("setBarcodeListener", "(Lcom/panasonic/toughpad/android/contract/IBarcodeListener;)V", "GetSetBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_Handler")]
		public abstract void SetBarcodeListener (global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeListener p0);

		static Delegate cb_getBarcodeType;
#pragma warning disable 0169
		static Delegate GetGetBarcodeTypeHandler ()
		{
			if (cb_getBarcodeType == null)
				cb_getBarcodeType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBarcodeType);
			return cb_getBarcodeType;
		}

		static int n_GetBarcodeType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarcodeType;
		}
#pragma warning restore 0169

		public abstract int BarcodeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='getBarcodeType' and count(parameter)=0]"
			[Register ("getBarcodeType", "()I", "GetGetBarcodeTypeHandler")] get;
		}

		static Delegate cb_getBatteryCharge;
#pragma warning disable 0169
		static Delegate GetGetBatteryChargeHandler ()
		{
			if (cb_getBatteryCharge == null)
				cb_getBatteryCharge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBatteryCharge);
			return cb_getBatteryCharge;
		}

		static int n_GetBatteryCharge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BatteryCharge;
		}
#pragma warning restore 0169

		public abstract int BatteryCharge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='getBatteryCharge' and count(parameter)=0]"
			[Register ("getBatteryCharge", "()I", "GetGetBatteryChargeHandler")] get;
		}

		static Delegate cb_getDeviceFirmwareVersion;
#pragma warning disable 0169
		static Delegate GetGetDeviceFirmwareVersionHandler ()
		{
			if (cb_getDeviceFirmwareVersion == null)
				cb_getDeviceFirmwareVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceFirmwareVersion);
			return cb_getDeviceFirmwareVersion;
		}

		static IntPtr n_GetDeviceFirmwareVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceFirmwareVersion);
		}
#pragma warning restore 0169

		public abstract string DeviceFirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='getDeviceFirmwareVersion' and count(parameter)=0]"
			[Register ("getDeviceFirmwareVersion", "()Ljava/lang/String;", "GetGetDeviceFirmwareVersionHandler")] get;
		}

		static Delegate cb_getDeviceName;
#pragma warning disable 0169
		static Delegate GetGetDeviceNameHandler ()
		{
			if (cb_getDeviceName == null)
				cb_getDeviceName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceName);
			return cb_getDeviceName;
		}

		static IntPtr n_GetDeviceName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceName);
		}
#pragma warning restore 0169

		public abstract string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "GetGetDeviceNameHandler")] get;
		}

		static Delegate cb_getDeviceSerialNumber;
#pragma warning disable 0169
		static Delegate GetGetDeviceSerialNumberHandler ()
		{
			if (cb_getDeviceSerialNumber == null)
				cb_getDeviceSerialNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceSerialNumber);
			return cb_getDeviceSerialNumber;
		}

		static IntPtr n_GetDeviceSerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceSerialNumber);
		}
#pragma warning restore 0169

		public abstract string DeviceSerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='getDeviceSerialNumber' and count(parameter)=0]"
			[Register ("getDeviceSerialNumber", "()Ljava/lang/String;", "GetGetDeviceSerialNumberHandler")] get;
		}

		static Delegate cb_isHardwareTriggerEnabled;
#pragma warning disable 0169
		static Delegate GetIsHardwareTriggerEnabledHandler ()
		{
			if (cb_isHardwareTriggerEnabled == null)
				cb_isHardwareTriggerEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHardwareTriggerEnabled);
			return cb_isHardwareTriggerEnabled;
		}

		static bool n_IsHardwareTriggerEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HardwareTriggerEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setHardwareTriggerEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHardwareTriggerEnabled_ZHandler ()
		{
			if (cb_setHardwareTriggerEnabled_Z == null)
				cb_setHardwareTriggerEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHardwareTriggerEnabled_Z);
			return cb_setHardwareTriggerEnabled_Z;
		}

		static void n_SetHardwareTriggerEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HardwareTriggerEnabled = p0;
		}
#pragma warning restore 0169

		public abstract bool HardwareTriggerEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='isHardwareTriggerEnabled' and count(parameter)=0]"
			[Register ("isHardwareTriggerEnabled", "()Z", "GetIsHardwareTriggerEnabledHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='setHardwareTriggerEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHardwareTriggerEnabled", "(Z)V", "GetSetHardwareTriggerEnabled_ZHandler")] set;
		}

		static Delegate cb_isBatteryCharging;
#pragma warning disable 0169
		static Delegate GetIsBatteryChargingHandler ()
		{
			if (cb_isBatteryCharging == null)
				cb_isBatteryCharging = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBatteryCharging);
			return cb_isBatteryCharging;
		}

		static bool n_IsBatteryCharging (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBatteryCharging;
		}
#pragma warning restore 0169

		public abstract bool IsBatteryCharging {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='isBatteryCharging' and count(parameter)=0]"
			[Register ("isBatteryCharging", "()Z", "GetIsBatteryChargingHandler")] get;
		}

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnabled;
		}
#pragma warning restore 0169

		public abstract bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler")] get;
		}

		static Delegate cb_isExternal;
#pragma warning disable 0169
		static Delegate GetIsExternalHandler ()
		{
			if (cb_isExternal == null)
				cb_isExternal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExternal);
			return cb_isExternal;
		}

		static bool n_IsExternal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExternal;
		}
#pragma warning restore 0169

		public abstract bool IsExternal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='isExternal' and count(parameter)=0]"
			[Register ("isExternal", "()Z", "GetIsExternalHandler")] get;
		}

		static Delegate cb_isHardwareTriggerAvailable;
#pragma warning disable 0169
		static Delegate GetIsHardwareTriggerAvailableHandler ()
		{
			if (cb_isHardwareTriggerAvailable == null)
				cb_isHardwareTriggerAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHardwareTriggerAvailable);
			return cb_isHardwareTriggerAvailable;
		}

		static bool n_IsHardwareTriggerAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHardwareTriggerAvailable;
		}
#pragma warning restore 0169

		public abstract bool IsHardwareTriggerAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='isHardwareTriggerAvailable' and count(parameter)=0]"
			[Register ("isHardwareTriggerAvailable", "()Z", "GetIsHardwareTriggerAvailableHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IBarcodeReader$Stub", DoNotGenerateAcw=true)]
	internal partial class BarcodeReaderStubInvoker : BarcodeReaderStub {

		public BarcodeReaderStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BarcodeReaderStubInvoker); }
		}

		static IntPtr id_getBarcodeType;
		public override unsafe int BarcodeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='getBarcodeType' and count(parameter)=0]"
			[Register ("getBarcodeType", "()I", "GetGetBarcodeTypeHandler")]
			get {
				if (id_getBarcodeType == IntPtr.Zero)
					id_getBarcodeType = JNIEnv.GetMethodID (class_ref, "getBarcodeType", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBarcodeType);
				} finally {
				}
			}
		}

		static IntPtr id_getBatteryCharge;
		public override unsafe int BatteryCharge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='getBatteryCharge' and count(parameter)=0]"
			[Register ("getBatteryCharge", "()I", "GetGetBatteryChargeHandler")]
			get {
				if (id_getBatteryCharge == IntPtr.Zero)
					id_getBatteryCharge = JNIEnv.GetMethodID (class_ref, "getBatteryCharge", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBatteryCharge);
				} finally {
				}
			}
		}

		static IntPtr id_getDeviceFirmwareVersion;
		public override unsafe string DeviceFirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='getDeviceFirmwareVersion' and count(parameter)=0]"
			[Register ("getDeviceFirmwareVersion", "()Ljava/lang/String;", "GetGetDeviceFirmwareVersionHandler")]
			get {
				if (id_getDeviceFirmwareVersion == IntPtr.Zero)
					id_getDeviceFirmwareVersion = JNIEnv.GetMethodID (class_ref, "getDeviceFirmwareVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceFirmwareVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDeviceName;
		public override unsafe string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "GetGetDeviceNameHandler")]
			get {
				if (id_getDeviceName == IntPtr.Zero)
					id_getDeviceName = JNIEnv.GetMethodID (class_ref, "getDeviceName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDeviceSerialNumber;
		public override unsafe string DeviceSerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='getDeviceSerialNumber' and count(parameter)=0]"
			[Register ("getDeviceSerialNumber", "()Ljava/lang/String;", "GetGetDeviceSerialNumberHandler")]
			get {
				if (id_getDeviceSerialNumber == IntPtr.Zero)
					id_getDeviceSerialNumber = JNIEnv.GetMethodID (class_ref, "getDeviceSerialNumber", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceSerialNumber), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isHardwareTriggerEnabled;
		static IntPtr id_setHardwareTriggerEnabled_Z;
		public override unsafe bool HardwareTriggerEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='isHardwareTriggerEnabled' and count(parameter)=0]"
			[Register ("isHardwareTriggerEnabled", "()Z", "GetIsHardwareTriggerEnabledHandler")]
			get {
				if (id_isHardwareTriggerEnabled == IntPtr.Zero)
					id_isHardwareTriggerEnabled = JNIEnv.GetMethodID (class_ref, "isHardwareTriggerEnabled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHardwareTriggerEnabled);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='setHardwareTriggerEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHardwareTriggerEnabled", "(Z)V", "GetSetHardwareTriggerEnabled_ZHandler")]
			set {
				if (id_setHardwareTriggerEnabled_Z == IntPtr.Zero)
					id_setHardwareTriggerEnabled_Z = JNIEnv.GetMethodID (class_ref, "setHardwareTriggerEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHardwareTriggerEnabled_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isBatteryCharging;
		public override unsafe bool IsBatteryCharging {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='isBatteryCharging' and count(parameter)=0]"
			[Register ("isBatteryCharging", "()Z", "GetIsBatteryChargingHandler")]
			get {
				if (id_isBatteryCharging == IntPtr.Zero)
					id_isBatteryCharging = JNIEnv.GetMethodID (class_ref, "isBatteryCharging", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBatteryCharging);
				} finally {
				}
			}
		}

		static IntPtr id_isEnabled;
		public override unsafe bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler")]
			get {
				if (id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnabled);
				} finally {
				}
			}
		}

		static IntPtr id_isExternal;
		public override unsafe bool IsExternal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='isExternal' and count(parameter)=0]"
			[Register ("isExternal", "()Z", "GetIsExternalHandler")]
			get {
				if (id_isExternal == IntPtr.Zero)
					id_isExternal = JNIEnv.GetMethodID (class_ref, "isExternal", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExternal);
				} finally {
				}
			}
		}

		static IntPtr id_isHardwareTriggerAvailable;
		public override unsafe bool IsHardwareTriggerAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='IBarcodeReader.Stub']/method[@name='isHardwareTriggerAvailable' and count(parameter)=0]"
			[Register ("isHardwareTriggerAvailable", "()Z", "GetIsHardwareTriggerAvailableHandler")]
			get {
				if (id_isHardwareTriggerAvailable == IntPtr.Zero)
					id_isHardwareTriggerAvailable = JNIEnv.GetMethodID (class_ref, "isHardwareTriggerAvailable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHardwareTriggerAvailable);
				} finally {
				}
			}
		}

		static IntPtr id_disable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "GetDisableHandler")]
		public override unsafe void Disable ()
		{
			if (id_disable == IntPtr.Zero)
				id_disable = JNIEnv.GetMethodID (class_ref, "disable", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disable);
			} finally {
			}
		}

		static IntPtr id_enable_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='enable' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("enable", "(J)V", "GetEnable_JHandler")]
		public override unsafe void Enable (long p0)
		{
			if (id_enable_J == IntPtr.Zero)
				id_enable_J = JNIEnv.GetMethodID (class_ref, "enable", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enable_J, __args);
			} finally {
			}
		}

		static IntPtr id_pressSoftwareTrigger_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='pressSoftwareTrigger' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("pressSoftwareTrigger", "(Z)V", "GetPressSoftwareTrigger_ZHandler")]
		public override unsafe void PressSoftwareTrigger (bool p0)
		{
			if (id_pressSoftwareTrigger_Z == IntPtr.Zero)
				id_pressSoftwareTrigger_Z = JNIEnv.GetMethodID (class_ref, "pressSoftwareTrigger", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pressSoftwareTrigger_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='setBarcodeListener' and count(parameter)=1 and parameter[1][@type='com.panasonic.toughpad.android.contract.IBarcodeListener']]"
		[Register ("setBarcodeListener", "(Lcom/panasonic/toughpad/android/contract/IBarcodeListener;)V", "GetSetBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_Handler")]
		public override unsafe void SetBarcodeListener (global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeListener p0)
		{
			if (id_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_ == IntPtr.Zero)
				id_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_ = JNIEnv.GetMethodID (class_ref, "setBarcodeListener", "(Lcom/panasonic/toughpad/android/contract/IBarcodeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_, __args);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']"
	[Register ("com/panasonic/toughpad/android/contract/IBarcodeReader", "", "Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker")]
	public partial interface IBarcodeReader : global::Android.OS.IInterface {

		int BarcodeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='getBarcodeType' and count(parameter)=0]"
			[Register ("getBarcodeType", "()I", "GetGetBarcodeTypeHandler:Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		int BatteryCharge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='getBatteryCharge' and count(parameter)=0]"
			[Register ("getBatteryCharge", "()I", "GetGetBatteryChargeHandler:Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		string DeviceFirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='getDeviceFirmwareVersion' and count(parameter)=0]"
			[Register ("getDeviceFirmwareVersion", "()Ljava/lang/String;", "GetGetDeviceFirmwareVersionHandler:Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "GetGetDeviceNameHandler:Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		string DeviceSerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='getDeviceSerialNumber' and count(parameter)=0]"
			[Register ("getDeviceSerialNumber", "()Ljava/lang/String;", "GetGetDeviceSerialNumberHandler:Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		bool HardwareTriggerEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='isHardwareTriggerEnabled' and count(parameter)=0]"
			[Register ("isHardwareTriggerEnabled", "()Z", "GetIsHardwareTriggerEnabledHandler:Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='setHardwareTriggerEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHardwareTriggerEnabled", "(Z)V", "GetSetHardwareTriggerEnabled_ZHandler:Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] set;
		}

		bool IsBatteryCharging {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='isBatteryCharging' and count(parameter)=0]"
			[Register ("isBatteryCharging", "()Z", "GetIsBatteryChargingHandler:Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler:Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		bool IsExternal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='isExternal' and count(parameter)=0]"
			[Register ("isExternal", "()Z", "GetIsExternalHandler:Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		bool IsHardwareTriggerAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='isHardwareTriggerAvailable' and count(parameter)=0]"
			[Register ("isHardwareTriggerAvailable", "()Z", "GetIsHardwareTriggerAvailableHandler:Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "GetDisableHandler:Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")]
		void Disable ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='enable' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("enable", "(J)V", "GetEnable_JHandler:Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")]
		void Enable (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='pressSoftwareTrigger' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("pressSoftwareTrigger", "(Z)V", "GetPressSoftwareTrigger_ZHandler:Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")]
		void PressSoftwareTrigger (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/interface[@name='IBarcodeReader']/method[@name='setBarcodeListener' and count(parameter)=1 and parameter[1][@type='com.panasonic.toughpad.android.contract.IBarcodeListener']]"
		[Register ("setBarcodeListener", "(Lcom/panasonic/toughpad/android/contract/IBarcodeListener;)V", "GetSetBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_Handler:Com.Panasonic.Toughpad.Android.Contract.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")]
		void SetBarcodeListener (global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeListener p0);

	}

	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/IBarcodeReader", DoNotGenerateAcw=true)]
	internal class IBarcodeReaderInvoker : global::Java.Lang.Object, IBarcodeReader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/panasonic/toughpad/android/contract/IBarcodeReader");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBarcodeReaderInvoker); }
		}

		IntPtr class_ref;

		public static IBarcodeReader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBarcodeReader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.panasonic.toughpad.android.contract.IBarcodeReader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBarcodeReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBarcodeType;
#pragma warning disable 0169
		static Delegate GetGetBarcodeTypeHandler ()
		{
			if (cb_getBarcodeType == null)
				cb_getBarcodeType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBarcodeType);
			return cb_getBarcodeType;
		}

		static int n_GetBarcodeType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarcodeType;
		}
#pragma warning restore 0169

		IntPtr id_getBarcodeType;
		public unsafe int BarcodeType {
			get {
				if (id_getBarcodeType == IntPtr.Zero)
					id_getBarcodeType = JNIEnv.GetMethodID (class_ref, "getBarcodeType", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBarcodeType);
			}
		}

		static Delegate cb_getBatteryCharge;
#pragma warning disable 0169
		static Delegate GetGetBatteryChargeHandler ()
		{
			if (cb_getBatteryCharge == null)
				cb_getBatteryCharge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBatteryCharge);
			return cb_getBatteryCharge;
		}

		static int n_GetBatteryCharge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BatteryCharge;
		}
#pragma warning restore 0169

		IntPtr id_getBatteryCharge;
		public unsafe int BatteryCharge {
			get {
				if (id_getBatteryCharge == IntPtr.Zero)
					id_getBatteryCharge = JNIEnv.GetMethodID (class_ref, "getBatteryCharge", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBatteryCharge);
			}
		}

		static Delegate cb_getDeviceFirmwareVersion;
#pragma warning disable 0169
		static Delegate GetGetDeviceFirmwareVersionHandler ()
		{
			if (cb_getDeviceFirmwareVersion == null)
				cb_getDeviceFirmwareVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceFirmwareVersion);
			return cb_getDeviceFirmwareVersion;
		}

		static IntPtr n_GetDeviceFirmwareVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceFirmwareVersion);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceFirmwareVersion;
		public unsafe string DeviceFirmwareVersion {
			get {
				if (id_getDeviceFirmwareVersion == IntPtr.Zero)
					id_getDeviceFirmwareVersion = JNIEnv.GetMethodID (class_ref, "getDeviceFirmwareVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceFirmwareVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDeviceName;
#pragma warning disable 0169
		static Delegate GetGetDeviceNameHandler ()
		{
			if (cb_getDeviceName == null)
				cb_getDeviceName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceName);
			return cb_getDeviceName;
		}

		static IntPtr n_GetDeviceName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceName);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceName;
		public unsafe string DeviceName {
			get {
				if (id_getDeviceName == IntPtr.Zero)
					id_getDeviceName = JNIEnv.GetMethodID (class_ref, "getDeviceName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDeviceSerialNumber;
#pragma warning disable 0169
		static Delegate GetGetDeviceSerialNumberHandler ()
		{
			if (cb_getDeviceSerialNumber == null)
				cb_getDeviceSerialNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceSerialNumber);
			return cb_getDeviceSerialNumber;
		}

		static IntPtr n_GetDeviceSerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceSerialNumber);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceSerialNumber;
		public unsafe string DeviceSerialNumber {
			get {
				if (id_getDeviceSerialNumber == IntPtr.Zero)
					id_getDeviceSerialNumber = JNIEnv.GetMethodID (class_ref, "getDeviceSerialNumber", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceSerialNumber), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isHardwareTriggerEnabled;
#pragma warning disable 0169
		static Delegate GetIsHardwareTriggerEnabledHandler ()
		{
			if (cb_isHardwareTriggerEnabled == null)
				cb_isHardwareTriggerEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHardwareTriggerEnabled);
			return cb_isHardwareTriggerEnabled;
		}

		static bool n_IsHardwareTriggerEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HardwareTriggerEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setHardwareTriggerEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHardwareTriggerEnabled_ZHandler ()
		{
			if (cb_setHardwareTriggerEnabled_Z == null)
				cb_setHardwareTriggerEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHardwareTriggerEnabled_Z);
			return cb_setHardwareTriggerEnabled_Z;
		}

		static void n_SetHardwareTriggerEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HardwareTriggerEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isHardwareTriggerEnabled;
		IntPtr id_setHardwareTriggerEnabled_Z;
		public unsafe bool HardwareTriggerEnabled {
			get {
				if (id_isHardwareTriggerEnabled == IntPtr.Zero)
					id_isHardwareTriggerEnabled = JNIEnv.GetMethodID (class_ref, "isHardwareTriggerEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHardwareTriggerEnabled);
			}
			set {
				if (id_setHardwareTriggerEnabled_Z == IntPtr.Zero)
					id_setHardwareTriggerEnabled_Z = JNIEnv.GetMethodID (class_ref, "setHardwareTriggerEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHardwareTriggerEnabled_Z, __args);
			}
		}

		static Delegate cb_isBatteryCharging;
#pragma warning disable 0169
		static Delegate GetIsBatteryChargingHandler ()
		{
			if (cb_isBatteryCharging == null)
				cb_isBatteryCharging = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBatteryCharging);
			return cb_isBatteryCharging;
		}

		static bool n_IsBatteryCharging (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBatteryCharging;
		}
#pragma warning restore 0169

		IntPtr id_isBatteryCharging;
		public unsafe bool IsBatteryCharging {
			get {
				if (id_isBatteryCharging == IntPtr.Zero)
					id_isBatteryCharging = JNIEnv.GetMethodID (class_ref, "isBatteryCharging", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBatteryCharging);
			}
		}

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isEnabled;
		public unsafe bool IsEnabled {
			get {
				if (id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnabled);
			}
		}

		static Delegate cb_isExternal;
#pragma warning disable 0169
		static Delegate GetIsExternalHandler ()
		{
			if (cb_isExternal == null)
				cb_isExternal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExternal);
			return cb_isExternal;
		}

		static bool n_IsExternal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExternal;
		}
#pragma warning restore 0169

		IntPtr id_isExternal;
		public unsafe bool IsExternal {
			get {
				if (id_isExternal == IntPtr.Zero)
					id_isExternal = JNIEnv.GetMethodID (class_ref, "isExternal", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExternal);
			}
		}

		static Delegate cb_isHardwareTriggerAvailable;
#pragma warning disable 0169
		static Delegate GetIsHardwareTriggerAvailableHandler ()
		{
			if (cb_isHardwareTriggerAvailable == null)
				cb_isHardwareTriggerAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHardwareTriggerAvailable);
			return cb_isHardwareTriggerAvailable;
		}

		static bool n_IsHardwareTriggerAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHardwareTriggerAvailable;
		}
#pragma warning restore 0169

		IntPtr id_isHardwareTriggerAvailable;
		public unsafe bool IsHardwareTriggerAvailable {
			get {
				if (id_isHardwareTriggerAvailable == IntPtr.Zero)
					id_isHardwareTriggerAvailable = JNIEnv.GetMethodID (class_ref, "isHardwareTriggerAvailable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHardwareTriggerAvailable);
			}
		}

		static Delegate cb_disable;
#pragma warning disable 0169
		static Delegate GetDisableHandler ()
		{
			if (cb_disable == null)
				cb_disable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disable);
			return cb_disable;
		}

		static void n_Disable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disable ();
		}
#pragma warning restore 0169

		IntPtr id_disable;
		public unsafe void Disable ()
		{
			if (id_disable == IntPtr.Zero)
				id_disable = JNIEnv.GetMethodID (class_ref, "disable", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disable);
		}

		static Delegate cb_enable_J;
#pragma warning disable 0169
		static Delegate GetEnable_JHandler ()
		{
			if (cb_enable_J == null)
				cb_enable_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Enable_J);
			return cb_enable_J;
		}

		static void n_Enable_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0);
		}
#pragma warning restore 0169

		IntPtr id_enable_J;
		public unsafe void Enable (long p0)
		{
			if (id_enable_J == IntPtr.Zero)
				id_enable_J = JNIEnv.GetMethodID (class_ref, "enable", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enable_J, __args);
		}

		static Delegate cb_pressSoftwareTrigger_Z;
#pragma warning disable 0169
		static Delegate GetPressSoftwareTrigger_ZHandler ()
		{
			if (cb_pressSoftwareTrigger_Z == null)
				cb_pressSoftwareTrigger_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_PressSoftwareTrigger_Z);
			return cb_pressSoftwareTrigger_Z;
		}

		static void n_PressSoftwareTrigger_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PressSoftwareTrigger (p0);
		}
#pragma warning restore 0169

		IntPtr id_pressSoftwareTrigger_Z;
		public unsafe void PressSoftwareTrigger (bool p0)
		{
			if (id_pressSoftwareTrigger_Z == IntPtr.Zero)
				id_pressSoftwareTrigger_Z = JNIEnv.GetMethodID (class_ref, "pressSoftwareTrigger", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pressSoftwareTrigger_Z, __args);
		}

		static Delegate cb_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_;
#pragma warning disable 0169
		static Delegate GetSetBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_Handler ()
		{
			if (cb_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_ == null)
				cb_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_);
			return cb_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_;
		}

		static void n_SetBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeListener p0 = (global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeListener)global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBarcodeListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_;
		public unsafe void SetBarcodeListener (global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeListener p0)
		{
			if (id_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_ == IntPtr.Zero)
				id_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_ = JNIEnv.GetMethodID (class_ref, "setBarcodeListener", "(Lcom/panasonic/toughpad/android/contract/IBarcodeListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBarcodeListener_Lcom_panasonic_toughpad_android_contract_IBarcodeListener_, __args);
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
			global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
