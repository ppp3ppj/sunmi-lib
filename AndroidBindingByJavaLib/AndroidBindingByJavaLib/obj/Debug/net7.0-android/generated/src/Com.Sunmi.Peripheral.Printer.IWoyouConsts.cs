using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Sunmi.Peripheral.Printer {

	[Register ("com/sunmi/peripheral/printer/WoyouConsts", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'Com.Sunmi.Peripheral.Printer.IWoyouConsts' type. This class will be removed in a future release.")]
	public abstract class WoyouConsts : Java.Lang.Object {
		internal WoyouConsts ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='DISABLE']"
		[Register ("DISABLE")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.Disable'. This class will be removed in a future release.")]
		public const int Disable = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE']"
		[Register ("ENABLE")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.Enable'. This class will be removed in a future release.")]
		public const int Enable = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_ANTI_WHITE']"
		[Register ("ENABLE_ANTI_WHITE")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.EnableAntiWhite'. This class will be removed in a future release.")]
		public const int EnableAntiWhite = (int) 1004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_BOLD']"
		[Register ("ENABLE_BOLD")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.EnableBold'. This class will be removed in a future release.")]
		public const int EnableBold = (int) 1002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_DOUBLE_HEIGHT']"
		[Register ("ENABLE_DOUBLE_HEIGHT")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.EnableDoubleHeight'. This class will be removed in a future release.")]
		public const int EnableDoubleHeight = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_DOUBLE_WIDTH']"
		[Register ("ENABLE_DOUBLE_WIDTH")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.EnableDoubleWidth'. This class will be removed in a future release.")]
		public const int EnableDoubleWidth = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_ILALIC']"
		[Register ("ENABLE_ILALIC")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.EnableIlalic'. This class will be removed in a future release.")]
		public const int EnableIlalic = (int) 1006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_INVERT']"
		[Register ("ENABLE_INVERT")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.EnableInvert'. This class will be removed in a future release.")]
		public const int EnableInvert = (int) 1007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_STRIKETHROUGH']"
		[Register ("ENABLE_STRIKETHROUGH")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.EnableStrikethrough'. This class will be removed in a future release.")]
		public const int EnableStrikethrough = (int) 1005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_UNDERLINE']"
		[Register ("ENABLE_UNDERLINE")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.EnableUnderline'. This class will be removed in a future release.")]
		public const int EnableUnderline = (int) 1003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='SET_ABSOLUATE_POSITION']"
		[Register ("SET_ABSOLUATE_POSITION")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.SetAbsoluatePosition'. This class will be removed in a future release.")]
		public const int SetAbsoluatePosition = (int) 2002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='SET_LEFT_SPACING']"
		[Register ("SET_LEFT_SPACING")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.SetLeftSpacing'. This class will be removed in a future release.")]
		public const int SetLeftSpacing = (int) 2004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='SET_LINE_SPACING']"
		[Register ("SET_LINE_SPACING")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.SetLineSpacing'. This class will be removed in a future release.")]
		public const int SetLineSpacing = (int) 2003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='SET_RELATIVE_POSITION']"
		[Register ("SET_RELATIVE_POSITION")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.SetRelativePosition'. This class will be removed in a future release.")]
		public const int SetRelativePosition = (int) 2001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='SET_STRIKETHROUGH_STYLE']"
		[Register ("SET_STRIKETHROUGH_STYLE")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.SetStrikethroughStyle'. This class will be removed in a future release.")]
		public const int SetStrikethroughStyle = (int) 2005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='SET_TEXT_RIGHT_SPACING']"
		[Register ("SET_TEXT_RIGHT_SPACING")]
		[global::System.Obsolete (@"Use 'Com.Sunmi.Peripheral.Printer.IWoyouConsts.SetTextRightSpacing'. This class will be removed in a future release.")]
		public const int SetTextRightSpacing = (int) 2000;

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']"
	[Register ("com/sunmi/peripheral/printer/WoyouConsts", "", "Com.Sunmi.Peripheral.Printer.IWoyouConstsInvoker")]
	public partial interface IWoyouConsts : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='DISABLE']"
		[Register ("DISABLE")]
		public const int Disable = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE']"
		[Register ("ENABLE")]
		public const int Enable = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_ANTI_WHITE']"
		[Register ("ENABLE_ANTI_WHITE")]
		public const int EnableAntiWhite = (int) 1004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_BOLD']"
		[Register ("ENABLE_BOLD")]
		public const int EnableBold = (int) 1002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_DOUBLE_HEIGHT']"
		[Register ("ENABLE_DOUBLE_HEIGHT")]
		public const int EnableDoubleHeight = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_DOUBLE_WIDTH']"
		[Register ("ENABLE_DOUBLE_WIDTH")]
		public const int EnableDoubleWidth = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_ILALIC']"
		[Register ("ENABLE_ILALIC")]
		public const int EnableIlalic = (int) 1006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_INVERT']"
		[Register ("ENABLE_INVERT")]
		public const int EnableInvert = (int) 1007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_STRIKETHROUGH']"
		[Register ("ENABLE_STRIKETHROUGH")]
		public const int EnableStrikethrough = (int) 1005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='ENABLE_UNDERLINE']"
		[Register ("ENABLE_UNDERLINE")]
		public const int EnableUnderline = (int) 1003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='SET_ABSOLUATE_POSITION']"
		[Register ("SET_ABSOLUATE_POSITION")]
		public const int SetAbsoluatePosition = (int) 2002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='SET_LEFT_SPACING']"
		[Register ("SET_LEFT_SPACING")]
		public const int SetLeftSpacing = (int) 2004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='SET_LINE_SPACING']"
		[Register ("SET_LINE_SPACING")]
		public const int SetLineSpacing = (int) 2003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='SET_RELATIVE_POSITION']"
		[Register ("SET_RELATIVE_POSITION")]
		public const int SetRelativePosition = (int) 2001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='SET_STRIKETHROUGH_STYLE']"
		[Register ("SET_STRIKETHROUGH_STYLE")]
		public const int SetStrikethroughStyle = (int) 2005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/interface[@name='WoyouConsts']/field[@name='SET_TEXT_RIGHT_SPACING']"
		[Register ("SET_TEXT_RIGHT_SPACING")]
		public const int SetTextRightSpacing = (int) 2000;

	}

	[global::Android.Runtime.Register ("com/sunmi/peripheral/printer/WoyouConsts", DoNotGenerateAcw=true)]
	internal partial class IWoyouConstsInvoker : global::Java.Lang.Object, IWoyouConsts {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/peripheral/printer/WoyouConsts", typeof (IWoyouConstsInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IWoyouConsts? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWoyouConsts> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.sunmi.peripheral.printer.WoyouConsts'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWoyouConstsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
