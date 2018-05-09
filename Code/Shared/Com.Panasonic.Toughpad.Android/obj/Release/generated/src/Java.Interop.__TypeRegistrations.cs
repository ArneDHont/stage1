using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/panasonic/toughpad/android/contract",
					},
					new Converter<string, Type>[]{
						lookup_com_panasonic_toughpad_android_contract_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_panasonic_toughpad_android_contract_mappings;
		static Type lookup_com_panasonic_toughpad_android_contract_package (string klass)
		{
			if (package_com_panasonic_toughpad_android_contract_mappings == null) {
				package_com_panasonic_toughpad_android_contract_mappings = new string[]{
					"com/panasonic/toughpad/android/contract/IAppButtonManager$Stub:Com.Panasonic.Toughpad.Android.Contract.AppButtonManagerStub",
					"com/panasonic/toughpad/android/contract/IAppButtonManager$Stub$Proxy:Com.Panasonic.Toughpad.Android.Contract.AppButtonManagerStub/Proxy",
					"com/panasonic/toughpad/android/contract/IBarcodeListener$Stub:Com.Panasonic.Toughpad.Android.Contract.BarcodeListenerStub",
					"com/panasonic/toughpad/android/contract/IBarcodeListener$Stub$Proxy:Com.Panasonic.Toughpad.Android.Contract.BarcodeListenerStub/Proxy",
					"com/panasonic/toughpad/android/contract/IBarcodeReader$Stub:Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub",
					"com/panasonic/toughpad/android/contract/IBarcodeReader$Stub$Proxy:Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderStub/Proxy",
					"com/panasonic/toughpad/android/contract/IBarcodeReaderManager$Stub:Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderManagerStub",
					"com/panasonic/toughpad/android/contract/IBarcodeReaderManager$Stub$Proxy:Com.Panasonic.Toughpad.Android.Contract.BarcodeReaderManagerStub/Proxy",
					"com/panasonic/toughpad/android/contract/ICradle$Stub:Com.Panasonic.Toughpad.Android.Contract.CradleStub",
					"com/panasonic/toughpad/android/contract/ICradle$Stub$Proxy:Com.Panasonic.Toughpad.Android.Contract.CradleStub/Proxy",
					"com/panasonic/toughpad/android/contract/IMagStripeListener$Stub:Com.Panasonic.Toughpad.Android.Contract.MagStripeListenerStub",
					"com/panasonic/toughpad/android/contract/IMagStripeListener$Stub$Proxy:Com.Panasonic.Toughpad.Android.Contract.MagStripeListenerStub/Proxy",
					"com/panasonic/toughpad/android/contract/IMagStripeReader$Stub:Com.Panasonic.Toughpad.Android.Contract.MagStripeReaderStub",
					"com/panasonic/toughpad/android/contract/IMagStripeReader$Stub$Proxy:Com.Panasonic.Toughpad.Android.Contract.MagStripeReaderStub/Proxy",
					"com/panasonic/toughpad/android/contract/IMagStripeReaderManager$Stub:Com.Panasonic.Toughpad.Android.Contract.MagStripeReaderManagerStub",
					"com/panasonic/toughpad/android/contract/IMagStripeReaderManager$Stub$Proxy:Com.Panasonic.Toughpad.Android.Contract.MagStripeReaderManagerStub/Proxy",
					"com/panasonic/toughpad/android/contract/IPortPowerManager$Stub:Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub",
					"com/panasonic/toughpad/android/contract/IPortPowerManager$Stub$Proxy:Com.Panasonic.Toughpad.Android.Contract.PortPowerManagerStub/Proxy",
					"com/panasonic/toughpad/android/contract/ISerialPort$Stub:Com.Panasonic.Toughpad.Android.Contract.SerialPortStub",
					"com/panasonic/toughpad/android/contract/ISerialPort$Stub$Proxy:Com.Panasonic.Toughpad.Android.Contract.SerialPortStub/Proxy",
					"com/panasonic/toughpad/android/contract/ISerialPortManager$Stub:Com.Panasonic.Toughpad.Android.Contract.SerialPortManagerStub",
					"com/panasonic/toughpad/android/contract/ISerialPortManager$Stub$Proxy:Com.Panasonic.Toughpad.Android.Contract.SerialPortManagerStub/Proxy",
					"com/panasonic/toughpad/android/contract/IToughpadApi$Stub:Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub",
					"com/panasonic/toughpad/android/contract/IToughpadApi$Stub$Proxy:Com.Panasonic.Toughpad.Android.Contract.ToughpadApiStub/Proxy",
				};
			}

			return Lookup (package_com_panasonic_toughpad_android_contract_mappings, klass);
		}
	}
}
