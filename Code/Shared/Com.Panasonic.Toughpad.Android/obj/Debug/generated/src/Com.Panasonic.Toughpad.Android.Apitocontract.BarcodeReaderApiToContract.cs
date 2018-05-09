using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Apitocontract {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/apitocontract/BarcodeReaderApiToContract", DoNotGenerateAcw=true)]
	public sealed partial class BarcodeReaderApiToContract : global::Com.Panasonic.Toughpad.Android.Contract.BarcodeListenerStub, global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeReader {


		public static class InterfaceConsts {

			// The following are fields from: com.panasonic.toughpad.android.api.barcode.BarcodeReader

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

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/apitocontract/BarcodeReaderApiToContract", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BarcodeReaderApiToContract); }
		}

		internal BarcodeReaderApiToContract (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_panasonic_toughpad_android_contract_IBarcodeReader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/constructor[@name='BarcodeReaderApiToContract' and count(parameter)=1 and parameter[1][@type='com.panasonic.toughpad.android.contract.IBarcodeReader']]"
		[Register (".ctor", "(Lcom/panasonic/toughpad/android/contract/IBarcodeReader;)V", "")]
		public unsafe BarcodeReaderApiToContract (global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BarcodeReaderApiToContract)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/panasonic/toughpad/android/contract/IBarcodeReader;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/panasonic/toughpad/android/contract/IBarcodeReader;)V", __args);
					return;
				}

				if (id_ctor_Lcom_panasonic_toughpad_android_contract_IBarcodeReader_ == IntPtr.Zero)
					id_ctor_Lcom_panasonic_toughpad_android_contract_IBarcodeReader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/panasonic/toughpad/android/contract/IBarcodeReader;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_panasonic_toughpad_android_contract_IBarcodeReader_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_panasonic_toughpad_android_contract_IBarcodeReader_, __args);
			} finally {
			}
		}

		static IntPtr id_getBarcodeType;
		public unsafe int BarcodeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='getBarcodeType' and count(parameter)=0]"
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
		public unsafe int BatteryCharge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='getBatteryCharge' and count(parameter)=0]"
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
		public unsafe string DeviceFirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='getDeviceFirmwareVersion' and count(parameter)=0]"
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
		public unsafe string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='getDeviceName' and count(parameter)=0]"
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
		public unsafe string DeviceSerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='getDeviceSerialNumber' and count(parameter)=0]"
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
		public unsafe bool HardwareTriggerEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='isHardwareTriggerEnabled' and count(parameter)=0]"
			[Register ("isHardwareTriggerEnabled", "()Z", "GetIsHardwareTriggerEnabledHandler")]
			get {
				if (id_isHardwareTriggerEnabled == IntPtr.Zero)
					id_isHardwareTriggerEnabled = JNIEnv.GetMethodID (class_ref, "isHardwareTriggerEnabled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHardwareTriggerEnabled);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='setHardwareTriggerEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
		public unsafe bool IsBatteryCharging {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='isBatteryCharging' and count(parameter)=0]"
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
		public unsafe bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='isEnabled' and count(parameter)=0]"
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
		public unsafe bool IsExternal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='isExternal' and count(parameter)=0]"
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
		public unsafe bool IsHardwareTriggerAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='isHardwareTriggerAvailable' and count(parameter)=0]"
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

		static IntPtr id_addBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='addBarcodeListener' and count(parameter)=1 and parameter[1][@type='com.panasonic.toughpad.android.api.barcode.BarcodeListener']]"
		[Register ("addBarcodeListener", "(Lcom/panasonic/toughpad/android/api/barcode/BarcodeListener;)V", "")]
		public unsafe void AddBarcodeListener (global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener p0)
		{
			if (id_addBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_ == IntPtr.Zero)
				id_addBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_ = JNIEnv.GetMethodID (class_ref, "addBarcodeListener", "(Lcom/panasonic/toughpad/android/api/barcode/BarcodeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_, __args);
			} finally {
			}
		}

		static IntPtr id_clearBarcodeListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='clearBarcodeListener' and count(parameter)=0]"
		[Register ("clearBarcodeListener", "()V", "")]
		public unsafe void ClearBarcodeListener ()
		{
			if (id_clearBarcodeListener == IntPtr.Zero)
				id_clearBarcodeListener = JNIEnv.GetMethodID (class_ref, "clearBarcodeListener", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearBarcodeListener);
			} finally {
			}
		}

		static IntPtr id_disable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "")]
		public unsafe void Disable ()
		{
			if (id_disable == IntPtr.Zero)
				id_disable = JNIEnv.GetMethodID (class_ref, "disable", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disable);
			} finally {
			}
		}

		static IntPtr id_enable_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='enable' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("enable", "(J)V", "")]
		public unsafe void Enable (long p0)
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

		static IntPtr id_onRead_Lcom_panasonic_toughpad_android_contract_IBarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='onRead' and count(parameter)=2 and parameter[1][@type='com.panasonic.toughpad.android.contract.IBarcodeReader'] and parameter[2][@type='com.panasonic.toughpad.android.api.barcode.BarcodeData']]"
		[Register ("onRead", "(Lcom/panasonic/toughpad/android/contract/IBarcodeReader;Lcom/panasonic/toughpad/android/api/barcode/BarcodeData;)V", "")]
		public override unsafe void OnRead (global::Com.Panasonic.Toughpad.Android.Contract.IBarcodeReader p0, global::Com.Panasonic.Toughpad.Android.Api.Barcode.BarcodeData p1)
		{
			if (id_onRead_Lcom_panasonic_toughpad_android_contract_IBarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_ == IntPtr.Zero)
				id_onRead_Lcom_panasonic_toughpad_android_contract_IBarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_ = JNIEnv.GetMethodID (class_ref, "onRead", "(Lcom/panasonic/toughpad/android/contract/IBarcodeReader;Lcom/panasonic/toughpad/android/api/barcode/BarcodeData;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRead_Lcom_panasonic_toughpad_android_contract_IBarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_, __args);
			} finally {
			}
		}

		static IntPtr id_pressSoftwareTrigger_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='pressSoftwareTrigger' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("pressSoftwareTrigger", "(Z)V", "")]
		public unsafe void PressSoftwareTrigger (bool p0)
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

		static IntPtr id_removeBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='BarcodeReaderApiToContract']/method[@name='removeBarcodeListener' and count(parameter)=1 and parameter[1][@type='com.panasonic.toughpad.android.api.barcode.BarcodeListener']]"
		[Register ("removeBarcodeListener", "(Lcom/panasonic/toughpad/android/api/barcode/BarcodeListener;)V", "")]
		public unsafe void RemoveBarcodeListener (global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener p0)
		{
			if (id_removeBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_ == IntPtr.Zero)
				id_removeBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_ = JNIEnv.GetMethodID (class_ref, "removeBarcodeListener", "(Lcom/panasonic/toughpad/android/api/barcode/BarcodeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeBarcodeListener_Lcom_panasonic_toughpad_android_api_barcode_BarcodeListener_, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener"
		public event EventHandler<global::Com.Panasonic.Toughpad.Android.Api.Barcode.BarcodeEventArgs> Barcode {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener, global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListenerImplementor>(
						ref weak_implementor_AddBarcodeListener,
						__CreateIBarcodeListenerImplementor,
						AddBarcodeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListener, global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListenerImplementor>(
						ref weak_implementor_AddBarcodeListener,
						global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListenerImplementor.__IsEmpty,
						__v => RemoveBarcodeListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddBarcodeListener;

		global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListenerImplementor __CreateIBarcodeListenerImplementor ()
		{
			return new global::Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListenerImplementor (this);
		}
#endregion
	}
}
