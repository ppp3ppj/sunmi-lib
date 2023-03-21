using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']"
	[global::Android.Runtime.Register ("com/google/zxing/common/BitArray", DoNotGenerateAcw=true)]
	public sealed partial class BitArray : global::Java.Lang.Object, global::Java.Lang.ICloneable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/common/BitArray", typeof (BitArray));

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

		internal BitArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/constructor[@name='BitArray' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BitArray () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/constructor[@name='BitArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe BitArray (int size) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "")]
			get {
				const string __id = "getSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int SizeInBytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='getSizeInBytes' and count(parameter)=0]"
			[Register ("getSizeInBytes", "()I", "")]
			get {
				const string __id = "getSizeInBytes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='appendBit' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("appendBit", "(Z)V", "")]
		public unsafe void AppendBit (bool bit)
		{
			const string __id = "appendBit.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bit);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='appendBitArray' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitArray']]"
		[Register ("appendBitArray", "(Lcom/google/zxing/common/BitArray;)V", "")]
		public unsafe void AppendBitArray (global::Com.Google.Zxing.Common.BitArray? other)
		{
			const string __id = "appendBitArray.(Lcom/google/zxing/common/BitArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='appendBits' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("appendBits", "(II)V", "")]
		public unsafe void AppendBits (int value, int numBits)
		{
			const string __id = "appendBits.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (value);
				__args [1] = new JniArgumentValue (numBits);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/google/zxing/common/BitArray;", "")]
		public unsafe global::Com.Google.Zxing.Common.BitArray? Clone ()
		{
			const string __id = "clone.()Lcom/google/zxing/common/BitArray;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='flip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("flip", "(I)V", "")]
		public unsafe void Flip (int i)
		{
			const string __id = "flip.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Z", "")]
		public unsafe bool Get (int i)
		{
			const string __id = "get.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='getBitArray' and count(parameter)=0]"
		[Register ("getBitArray", "()[I", "")]
		public unsafe int[]? GetBitArray ()
		{
			const string __id = "getBitArray.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (int[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='getNextSet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getNextSet", "(I)I", "")]
		public unsafe int GetNextSet (int from)
		{
			const string __id = "getNextSet.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (from);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='getNextUnset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getNextUnset", "(I)I", "")]
		public unsafe int GetNextUnset (int from)
		{
			const string __id = "getNextUnset.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (from);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='isRange' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("isRange", "(IIZ)Z", "")]
		public unsafe bool IsRange (int start, int end, bool value)
		{
			const string __id = "isRange.(IIZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (start);
				__args [1] = new JniArgumentValue (end);
				__args [2] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='reverse' and count(parameter)=0]"
		[Register ("reverse", "()V", "")]
		public unsafe void Reverse ()
		{
			const string __id = "reverse.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='set' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("set", "(I)V", "")]
		public unsafe void Set (int i)
		{
			const string __id = "set.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='setBulk' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setBulk", "(II)V", "")]
		public unsafe void SetBulk (int i, int newBits)
		{
			const string __id = "setBulk.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (i);
				__args [1] = new JniArgumentValue (newBits);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='setRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setRange", "(II)V", "")]
		public unsafe void SetRange (int start, int end)
		{
			const string __id = "setRange.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (start);
				__args [1] = new JniArgumentValue (end);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='toBytes' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("toBytes", "(I[BII)V", "")]
		public unsafe void ToBytes (int bitOffset, byte[]? array, int offset, int numBytes)
		{
			const string __id = "toBytes.(I[BII)V";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (bitOffset);
				__args [1] = new JniArgumentValue (native_array);
				__args [2] = new JniArgumentValue (offset);
				__args [3] = new JniArgumentValue (numBytes);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				global::System.GC.KeepAlive (array);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='BitArray']/method[@name='xor' and count(parameter)=1 and parameter[1][@type='com.google.zxing.common.BitArray']]"
		[Register ("xor", "(Lcom/google/zxing/common/BitArray;)V", "")]
		public unsafe void Xor (global::Com.Google.Zxing.Common.BitArray? other)
		{
			const string __id = "xor.(Lcom/google/zxing/common/BitArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

	}
}
