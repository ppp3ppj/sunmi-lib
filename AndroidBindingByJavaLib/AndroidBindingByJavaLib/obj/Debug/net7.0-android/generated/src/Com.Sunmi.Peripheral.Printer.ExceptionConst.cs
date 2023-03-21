using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Sunmi.Peripheral.Printer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='ExceptionConst']"
	[global::Android.Runtime.Register ("com/sunmi/peripheral/printer/ExceptionConst", DoNotGenerateAcw=true)]
	public partial class ExceptionConst : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='ExceptionConst']/field[@name='IP_INVALID_CALL']"
		[Register ("IP_INVALID_CALL")]
		public const string IpInvalidCall = (string) "invalid interface call temporarily";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='ExceptionConst']/field[@name='IP_MODEL_CALL']"
		[Register ("IP_MODEL_CALL")]
		public const string IpModelCall = (string) "this model does not support this method!";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='ExceptionConst']/field[@name='IP_SYSTEM_CALL']"
		[Register ("IP_SYSTEM_CALL")]
		public const string IpSystemCall = (string) "only system calls are supported";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='ExceptionConst']/field[@name='IP_VERSION_CALL']"
		[Register ("IP_VERSION_CALL")]
		public const string IpVersionCall = (string) "this version does not support this method!";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/peripheral/printer/ExceptionConst", typeof (ExceptionConst));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected ExceptionConst (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='ExceptionConst']/constructor[@name='ExceptionConst' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExceptionConst () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}
