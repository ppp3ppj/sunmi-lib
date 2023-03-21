using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Aztec.Encoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']"
	[global::Android.Runtime.Register ("com/google/zxing/aztec/encoder/AztecCode", DoNotGenerateAcw=true)]
	public sealed partial class AztecCode : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/aztec/encoder/AztecCode", typeof (AztecCode));

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

		internal AztecCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/constructor[@name='AztecCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AztecCode () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe int CodeWords {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='getCodeWords' and count(parameter)=0]"
			[Register ("getCodeWords", "()I", "")]
			get {
				const string __id = "getCodeWords.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='setCodeWords' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCodeWords", "(I)V", "")]
			set {
				const string __id = "setCodeWords.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool Compact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='isCompact' and count(parameter)=0]"
			[Register ("isCompact", "()Z", "")]
			get {
				const string __id = "isCompact.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='setCompact' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCompact", "(Z)V", "")]
			set {
				const string __id = "setCompact.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int Layers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='getLayers' and count(parameter)=0]"
			[Register ("getLayers", "()I", "")]
			get {
				const string __id = "getLayers.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='setLayers' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLayers", "(I)V", "")]
			set {
				const string __id = "setLayers.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Google.Zxing.Common.BitMatrix? Matrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='getMatrix' and count(parameter)=0]"
			[Register ("getMatrix", "()Lcom/google/zxing/common/BitMatrix;", "")]
			get {
				const string __id = "getMatrix.()Lcom/google/zxing/common/BitMatrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='setMatrix' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitMatrix']]"
			[Register ("setMatrix", "(Lcom/google/zxing/common/BitMatrix;)V", "")]
			set {
				const string __id = "setMatrix.(Lcom/google/zxing/common/BitMatrix;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "")]
			get {
				const string __id = "getSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.aztec.encoder']/class[@name='AztecCode']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSize", "(I)V", "")]
			set {
				const string __id = "setSize.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
