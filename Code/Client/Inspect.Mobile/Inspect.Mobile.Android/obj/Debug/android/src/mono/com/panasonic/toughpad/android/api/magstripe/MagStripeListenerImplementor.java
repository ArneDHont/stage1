package mono.com.panasonic.toughpad.android.api.magstripe;


public class MagStripeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.panasonic.toughpad.android.api.magstripe.MagStripeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onRead:(Lcom/panasonic/toughpad/android/api/magstripe/MagStripeReader;Lcom/panasonic/toughpad/android/api/magstripe/MagStripeData;)V:GetOnRead_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_Handler:Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListenerInvoker, Com.Panasonic.Toughpad.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListenerImplementor, Com.Panasonic.Toughpad.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MagStripeListenerImplementor.class, __md_methods);
	}


	public MagStripeListenerImplementor ()
	{
		super ();
		if (getClass () == MagStripeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListenerImplementor, Com.Panasonic.Toughpad.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onRead (com.panasonic.toughpad.android.api.magstripe.MagStripeReader p0, com.panasonic.toughpad.android.api.magstripe.MagStripeData p1)
	{
		n_onRead (p0, p1);
	}

	private native void n_onRead (com.panasonic.toughpad.android.api.magstripe.MagStripeReader p0, com.panasonic.toughpad.android.api.magstripe.MagStripeData p1);

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
