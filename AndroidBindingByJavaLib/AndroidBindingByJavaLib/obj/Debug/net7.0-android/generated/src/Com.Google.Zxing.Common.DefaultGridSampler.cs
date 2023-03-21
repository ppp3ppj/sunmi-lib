using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DefaultGridSampler']"
	[global::Android.Runtime.Register ("com/google/zxing/common/DefaultGridSampler", DoNotGenerateAcw=true)]
	public sealed partial class DefaultGridSampler : global::Com.Google.Zxing.Common.GridSampler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/common/DefaultGridSampler", typeof (DefaultGridSampler));

		internal static new IntPtr class_ref {
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

		internal DefaultGridSampler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DefaultGridSampler']/constructor[@name='DefaultGridSampler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultGridSampler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DefaultGridSampler']/method[@name='sampleGrid' and count(parameter)=4 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.google.zxing.common.PerspectiveTransform']]"
		[Register ("sampleGrid", "(Lcom/google/zxing/common/BitMatrix;IILcom/google/zxing/common/PerspectiveTransform;)Lcom/google/zxing/common/BitMatrix;", "")]
		public override unsafe global::Com.Google.Zxing.Common.BitMatrix? SampleGrid (global::Com.Google.Zxing.Common.BitMatrix? image, int dimensionX, int dimensionY, global::Com.Google.Zxing.Common.PerspectiveTransform? transform)
		{
			const string __id = "sampleGrid.(Lcom/google/zxing/common/BitMatrix;IILcom/google/zxing/common/PerspectiveTransform;)Lcom/google/zxing/common/BitMatrix;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				__args [1] = new JniArgumentValue (dimensionX);
				__args [2] = new JniArgumentValue (dimensionY);
				__args [3] = new JniArgumentValue ((transform == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transform).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (image);
				global::System.GC.KeepAlive (transform);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='DefaultGridSampler']/method[@name='sampleGrid' and count(parameter)=19 and parameter[1][@type='com.google.zxing.common.BitMatrix'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='float'] and parameter[9][@type='float'] and parameter[10][@type='float'] and parameter[11][@type='float'] and parameter[12][@type='float'] and parameter[13][@type='float'] and parameter[14][@type='float'] and parameter[15][@type='float'] and parameter[16][@type='float'] and parameter[17][@type='float'] and parameter[18][@type='float'] and parameter[19][@type='float']]"
		[Register ("sampleGrid", "(Lcom/google/zxing/common/BitMatrix;IIFFFFFFFFFFFFFFFF)Lcom/google/zxing/common/BitMatrix;", "")]
		public override unsafe global::Com.Google.Zxing.Common.BitMatrix? SampleGrid (global::Com.Google.Zxing.Common.BitMatrix? image, int dimensionX, int dimensionY, float p1ToX, float p1ToY, float p2ToX, float p2ToY, float p3ToX, float p3ToY, float p4ToX, float p4ToY, float p1FromX, float p1FromY, float p2FromX, float p2FromY, float p3FromX, float p3FromY, float p4FromX, float p4FromY)
		{
			const string __id = "sampleGrid.(Lcom/google/zxing/common/BitMatrix;IIFFFFFFFFFFFFFFFF)Lcom/google/zxing/common/BitMatrix;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [19];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				__args [1] = new JniArgumentValue (dimensionX);
				__args [2] = new JniArgumentValue (dimensionY);
				__args [3] = new JniArgumentValue (p1ToX);
				__args [4] = new JniArgumentValue (p1ToY);
				__args [5] = new JniArgumentValue (p2ToX);
				__args [6] = new JniArgumentValue (p2ToY);
				__args [7] = new JniArgumentValue (p3ToX);
				__args [8] = new JniArgumentValue (p3ToY);
				__args [9] = new JniArgumentValue (p4ToX);
				__args [10] = new JniArgumentValue (p4ToY);
				__args [11] = new JniArgumentValue (p1FromX);
				__args [12] = new JniArgumentValue (p1FromY);
				__args [13] = new JniArgumentValue (p2FromX);
				__args [14] = new JniArgumentValue (p2FromY);
				__args [15] = new JniArgumentValue (p3FromX);
				__args [16] = new JniArgumentValue (p3FromY);
				__args [17] = new JniArgumentValue (p4FromX);
				__args [18] = new JniArgumentValue (p4FromY);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (image);
			}
		}

	}
}
