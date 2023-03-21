using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Oned.Rss {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']"
	[global::Android.Runtime.Register ("com/google/zxing/oned/rss/AbstractRSSReader", DoNotGenerateAcw=true)]
	public abstract partial class AbstractRSSReader : global::Com.Google.Zxing.Oned.OneDReader {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/oned/rss/AbstractRSSReader", typeof (AbstractRSSReader));

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

		protected AbstractRSSReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/constructor[@name='AbstractRSSReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe AbstractRSSReader () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='count' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[global::System.Obsolete (@"deprecated")]
		[Register ("count", "([I)I", "")]
		protected static unsafe int Count (int[]? array)
		{
			const string __id = "count.([I)I";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_array);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				global::System.GC.KeepAlive (array);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='decrement' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='float[]']]"
		[Register ("decrement", "([I[F)V", "")]
		protected static unsafe void Decrement (int[]? array, float[]? errors)
		{
			const string __id = "decrement.([I[F)V";
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_errors = JNIEnv.NewArray (errors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (native_errors);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (errors != null) {
					JNIEnv.CopyArray (native_errors, errors);
					JNIEnv.DeleteLocalRef (native_errors);
				}
				global::System.GC.KeepAlive (array);
				global::System.GC.KeepAlive (errors);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='getDataCharacterCounters' and count(parameter)=0]"
		[Register ("getDataCharacterCounters", "()[I", "")]
		protected unsafe int[]? GetDataCharacterCounters ()
		{
			const string __id = "getDataCharacterCounters.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (int[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='getDecodeFinderCounters' and count(parameter)=0]"
		[Register ("getDecodeFinderCounters", "()[I", "")]
		protected unsafe int[]? GetDecodeFinderCounters ()
		{
			const string __id = "getDecodeFinderCounters.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (int[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='getEvenCounts' and count(parameter)=0]"
		[Register ("getEvenCounts", "()[I", "")]
		protected unsafe int[]? GetEvenCounts ()
		{
			const string __id = "getEvenCounts.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (int[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='getEvenRoundingErrors' and count(parameter)=0]"
		[Register ("getEvenRoundingErrors", "()[F", "")]
		protected unsafe float[]? GetEvenRoundingErrors ()
		{
			const string __id = "getEvenRoundingErrors.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (float[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='getOddCounts' and count(parameter)=0]"
		[Register ("getOddCounts", "()[I", "")]
		protected unsafe int[]? GetOddCounts ()
		{
			const string __id = "getOddCounts.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (int[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='getOddRoundingErrors' and count(parameter)=0]"
		[Register ("getOddRoundingErrors", "()[F", "")]
		protected unsafe float[]? GetOddRoundingErrors ()
		{
			const string __id = "getOddRoundingErrors.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (float[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='increment' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='float[]']]"
		[Register ("increment", "([I[F)V", "")]
		protected static unsafe void Increment (int[]? array, float[]? errors)
		{
			const string __id = "increment.([I[F)V";
			IntPtr native_array = JNIEnv.NewArray (array);
			IntPtr native_errors = JNIEnv.NewArray (errors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (native_errors);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				if (errors != null) {
					JNIEnv.CopyArray (native_errors, errors);
					JNIEnv.DeleteLocalRef (native_errors);
				}
				global::System.GC.KeepAlive (array);
				global::System.GC.KeepAlive (errors);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='isFinderPattern' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("isFinderPattern", "([I)Z", "")]
		protected static unsafe bool IsFinderPattern (int[]? counters)
		{
			const string __id = "isFinderPattern.([I)Z";
			IntPtr native_counters = JNIEnv.NewArray (counters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_counters);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (counters != null) {
					JNIEnv.CopyArray (native_counters, counters);
					JNIEnv.DeleteLocalRef (native_counters);
				}
				global::System.GC.KeepAlive (counters);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned.rss']/class[@name='AbstractRSSReader']/method[@name='parseFinderValue' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[][]']]"
		[Register ("parseFinderValue", "([I[[I)I", "")]
		protected static unsafe int ParseFinderValue (int[]? counters, int[][]? finderPatterns)
		{
			const string __id = "parseFinderValue.([I[[I)I";
			IntPtr native_counters = JNIEnv.NewArray (counters);
			IntPtr native_finderPatterns = JNIEnv.NewArray (finderPatterns);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_counters);
				__args [1] = new JniArgumentValue (native_finderPatterns);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (counters != null) {
					JNIEnv.CopyArray (native_counters, counters);
					JNIEnv.DeleteLocalRef (native_counters);
				}
				if (finderPatterns != null) {
					JNIEnv.CopyArray (native_finderPatterns, finderPatterns);
					JNIEnv.DeleteLocalRef (native_finderPatterns);
				}
				global::System.GC.KeepAlive (counters);
				global::System.GC.KeepAlive (finderPatterns);
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/zxing/oned/rss/AbstractRSSReader", DoNotGenerateAcw=true)]
	internal partial class AbstractRSSReaderInvoker : AbstractRSSReader {
		public AbstractRSSReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/oned/rss/AbstractRSSReader", typeof (AbstractRSSReaderInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.oned']/class[@name='OneDReader']/method[@name='decodeRow' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray'] and parameter[3][@type='java.util.Map&lt;com.google.zxing.DecodeHintType, ?&gt;']]"
		[Register ("decodeRow", "(ILcom/google/zxing/common/BitArray;Ljava/util/Map;)Lcom/google/zxing/Result;", "GetDecodeRow_ILcom_google_zxing_common_BitArray_Ljava_util_Map_Handler")]
		public override unsafe global::Com.Google.Zxing.Result? DecodeRow (int p0, global::Com.Google.Zxing.Common.BitArray? p1, global::System.Collections.Generic.IDictionary<global::Com.Google.Zxing.DecodeHintType, object>? p2)
		{
			const string __id = "decodeRow.(ILcom/google/zxing/common/BitArray;Ljava/util/Map;)Lcom/google/zxing/Result;";
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<global::Com.Google.Zxing.DecodeHintType, object>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

	}
}
