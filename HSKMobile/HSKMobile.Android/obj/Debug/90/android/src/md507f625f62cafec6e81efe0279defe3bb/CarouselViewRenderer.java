package md507f625f62cafec6e81efe0279defe3bb;


public class CarouselViewRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAttachedToWindow:()V:GetOnAttachedToWindowHandler\n" +
			"";
		mono.android.Runtime.register ("CarouselView.FormsPlugin.Android.CarouselViewRenderer, CarouselView.FormsPlugin.Android", CarouselViewRenderer.class, __md_methods);
	}


	public CarouselViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CarouselViewRenderer.class)
			mono.android.TypeManager.Activate ("CarouselView.FormsPlugin.Android.CarouselViewRenderer, CarouselView.FormsPlugin.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CarouselViewRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CarouselViewRenderer.class)
			mono.android.TypeManager.Activate ("CarouselView.FormsPlugin.Android.CarouselViewRenderer, CarouselView.FormsPlugin.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CarouselViewRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CarouselViewRenderer.class)
			mono.android.TypeManager.Activate ("CarouselView.FormsPlugin.Android.CarouselViewRenderer, CarouselView.FormsPlugin.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onAttachedToWindow ()
	{
		n_onAttachedToWindow ();
	}

	private native void n_onAttachedToWindow ();

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
