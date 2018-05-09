package mono.com.panasonic.toughpad.android.api.barcode;


public class BarcodeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.panasonic.toughpad.android.api.barcode.BarcodeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onRead:(Lcom/panasonic/toughpad/android/api/barcode/BarcodeReader;Lcom/panasonic/toughpad/android/api/barcode/BarcodeData;)V:GetOnRead_Lcom_panasonic_toughpad_android_api_barcode_BarcodeReader_Lcom_panasonic_toughpad_android_api_barcode_BarcodeData_Handler:Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListenerInvoker, Com.Panasonic.Toughpad.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListenerImplementor, Com.Panasonic.Toughpad.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BarcodeListenerImplementor.class, __md_methods);
	}


	public BarcodeListenerImplementor ()
	{
		super ();
		if (getClass () == BarcodeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Panasonic.Toughpad.Android.Api.Barcode.IBarcodeListenerImplementor, Com.Panasonic.Toughpad.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onRead (com.panasonic.toughpad.android.api.barcode.BarcodeReader p0, com.panasonic.toughpad.android.api.barcode.BarcodeData p1)
	{
		n_onRead (p0, p1);
	}

	private native void n_onRead (com.panasonic.toughpad.android.api.barcode.BarcodeReader p0, com.panasonic.toughpad.android.api.barcode.BarcodeData p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
