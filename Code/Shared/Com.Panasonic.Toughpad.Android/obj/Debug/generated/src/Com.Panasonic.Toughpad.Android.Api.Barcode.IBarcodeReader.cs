using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Api.Barcode {

	[Register ("com/panasonic/toughpad/android/api/barcode/BarcodeReader", DoNotGenerateAcw=true)]
	public abstract class BarcodeReader : Java.Lang.Object {

		internal BarcodeReader ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/field[@name='BARCODE_TYPE_CAMERA']"
		[Register ("BARCODE_TYPE_CAMERA")]
		public const int BarcodeTypeCamera = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/field[@name='BARCODE_TYPE_ONE_DIMENSIONAL']"
		[Register ("BARCODE_TYPE_ONE_DIMENSIONAL")]
		public const int BarcodeTypeOneDimensional = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/field[@name='BARCODE_TYPE_TWO_DIMENSIONAL']"
		[Register ("BARCODE_TYPE_TWO_DIMENSIONAL")]
		public const int BarcodeTypeTwoDimensional = (int) 2;
	}

	[Register ("com/panasonic/toughpad/android/api/barcode/BarcodeReader", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'BarcodeReader' type. This type will be removed in a future release.")]
	public abstract class BarcodeReaderConsts : BarcodeReader {

		private BarcodeReaderConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']"
	[Register ("com/panasonic/toughpad/android/api/barcode/BarcodeReader", "", "Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker")]
	public partial interface IBarcodeReader : IJavaObject {

		int BarcodeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='getBarcodeType' and count(parameter)=0]"
			[Register ("getBarcodeType", "()I", "GetGetBarcodeTypeHandler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		int BatteryCharge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='getBatteryCharge' and count(parameter)=0]"
			[Register ("getBatteryCharge", "()I", "GetGetBatteryChargeHandler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		string DeviceFirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='getDeviceFirmwareVersion' and count(parameter)=0]"
			[Register ("getDeviceFirmwareVersion", "()Ljava/lang/String;", "GetGetDeviceFirmwareVersionHandler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "GetGetDeviceNameHandler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		string DeviceSerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='getDeviceSerialNumber' and count(parameter)=0]"
			[Register ("getDeviceSerialNumber", "()Ljava/lang/String;", "GetGetDeviceSerialNumberHandler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		bool HardwareTriggerEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='isHardwareTriggerEnabled' and count(parameter)=0]"
			[Register ("isHardwareTriggerEnabled", "()Z", "GetIsHardwareTriggerEnabledHandler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='setHardwareTriggerEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHardwareTriggerEnabled", "(Z)V", "GetSetHardwareTriggerEnabled_ZHandler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] set;
		}

		bool IsBatteryCharging {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='isBatteryCharging' and count(parameter)=0]"
			[Register ("isBatteryCharging", "()Z", "GetIsBatteryChargingHandler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		bool IsExternal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='isExternal' and count(parameter)=0]"
			[Register ("isExternal", "()Z", "GetIsExternalHandler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		bool IsHardwareTriggerAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='isHardwareTriggerAvailable' and count(parameter)=0]"
			[Register ("isHardwareTriggerAvailable", "()Z", "GetIsHardwareTriggerAvailableHandler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='addBarcodeListener' and count(parameter)=1 and parameter[1][@type='com.panasonic.toughpad.android.api.barcode.BarcodeListener']]"
		[Register ("addBarcodeListener", "(Lcom/panasonic/toughpad/android/api/barcode/BarcodeListener;)V", "GetAddBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_Handler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")]
		void AddBarcodeListener (global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='clearBarcodeListener' and count(parameter)=0]"
		[Register ("clearBarcodeListener", "()V", "GetClearBarcodeListenerHandler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")]
		void ClearBarcodeListener ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "GetDisableHandler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")]
		void Disable ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='enable' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("enable", "(J)V", "GetEnable_JHandler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")]
		void Enable (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='pressSoftwareTrigger' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("pressSoftwareTrigger", "(Z)V", "GetPressSoftwareTrigger_ZHandler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")]
		void PressSoftwareTrigger (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.barcode']/interface[@name='BarcodeReader']/method[@name='removeBarcodeListener' and count(parameter)=1 and parameter[1][@type='com.panasonic.toughpad.android.api.barcode.BarcodeListener']]"
		[Register ("removeBarcodeListener", "(Lcom/panasonic/toughpad/android/api/barcode/BarcodeListener;)V", "GetRemoveBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_Handler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReaderInvoker, Com.Panasonic.Toughpad.Android")]
		void RemoveBarcodeListener (global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener p0);

	}

	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/api/barcode/BarcodeReader", DoNotGenerateAcw=true)]
	internal class IBarcodeReaderInvoker : global::Java.Lang.Object, IBarcodeReader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/panasonic/toughpad/android/api/barcode/BarcodeReader");

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
							JNIEnv.GetClassNameFromInstance (handle), "com.panasonic.toughpad.android.api.barcode.BarcodeReader"));
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
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_addBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_;
#pragma warning disable 0169
		static Delegate GetAddBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_Handler ()
		{
			if (cb_addBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_ == null)
				cb_addBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_);
			return cb_addBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_;
		}

		static void n_AddBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener p0 = (global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener)global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddBarcodeListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_;
		public unsafe void AddBarcodeListener (global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener p0)
		{
			if (id_addBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_ == IntPtr.Zero)
				id_addBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_ = JNIEnv.GetMethodID (class_ref, "addBarcodeListener", "(Lcom/panasonic/toughpad/android/api/barcode/BarcodeListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_, __args);
		}

		static Delegate cb_clearBarcodeListener;
#pragma warning disable 0169
		static Delegate GetClearBarcodeListenerHandler ()
		{
			if (cb_clearBarcodeListener == null)
				cb_clearBarcodeListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearBarcodeListener);
			return cb_clearBarcodeListener;
		}

		static void n_ClearBarcodeListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearBarcodeListener ();
		}
#pragma warning restore 0169

		IntPtr id_clearBarcodeListener;
		public unsafe void ClearBarcodeListener ()
		{
			if (id_clearBarcodeListener == IntPtr.Zero)
				id_clearBarcodeListener = JNIEnv.GetMethodID (class_ref, "clearBarcodeListener", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearBarcodeListener);
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
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_removeBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_;
#pragma warning disable 0169
		static Delegate GetRemoveBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_Handler ()
		{
			if (cb_removeBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_ == null)
				cb_removeBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_);
			return cb_removeBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_;
		}

		static void n_RemoveBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener p0 = (global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener)global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveBarcodeListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_;
		public unsafe void RemoveBarcodeListener (global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener p0)
		{
			if (id_removeBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_ == IntPtr.Zero)
				id_removeBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_ = JNIEnv.GetMethodID (class_ref, "removeBarcodeListener", "(Lcom/panasonic/toughpad/android/api/barcode/BarcodeListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_, __args);
		}

	}

}
