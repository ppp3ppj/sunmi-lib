using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/AddressBookParsedResult", DoNotGenerateAcw=true)]
	public sealed partial class AddressBookParsedResult : global::Com.Google.Zxing.Client.Result.ParsedResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/client/result/AddressBookParsedResult", typeof (AddressBookParsedResult));

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

		internal AddressBookParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/constructor[@name='AddressBookParsedResult' and count(parameter)=16 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String[]'] and parameter[6][@type='java.lang.String[]'] and parameter[7][@type='java.lang.String[]'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String[]'] and parameter[11][@type='java.lang.String[]'] and parameter[12][@type='java.lang.String'] and parameter[13][@type='java.lang.String'] and parameter[14][@type='java.lang.String'] and parameter[15][@type='java.lang.String[]'] and parameter[16][@type='java.lang.String[]']]"
		[Register (".ctor", "([Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public unsafe AddressBookParsedResult (string[]? names, string[]? nicknames, string? pronunciation, string[]? phoneNumbers, string[]? phoneTypes, string[]? emails, string[]? emailTypes, string? instantMessenger, string? note, string[]? addresses, string[]? addressTypes, string? org, string? birthday, string? title, string[]? urls, string[]? geo) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_names = JNIEnv.NewArray (names);
			IntPtr native_nicknames = JNIEnv.NewArray (nicknames);
			IntPtr native_pronunciation = JNIEnv.NewString ((string?)pronunciation);
			IntPtr native_phoneNumbers = JNIEnv.NewArray (phoneNumbers);
			IntPtr native_phoneTypes = JNIEnv.NewArray (phoneTypes);
			IntPtr native_emails = JNIEnv.NewArray (emails);
			IntPtr native_emailTypes = JNIEnv.NewArray (emailTypes);
			IntPtr native_instantMessenger = JNIEnv.NewString ((string?)instantMessenger);
			IntPtr native_note = JNIEnv.NewString ((string?)note);
			IntPtr native_addresses = JNIEnv.NewArray (addresses);
			IntPtr native_addressTypes = JNIEnv.NewArray (addressTypes);
			IntPtr native_org = JNIEnv.NewString ((string?)org);
			IntPtr native_birthday = JNIEnv.NewString ((string?)birthday);
			IntPtr native_title = JNIEnv.NewString ((string?)title);
			IntPtr native_urls = JNIEnv.NewArray (urls);
			IntPtr native_geo = JNIEnv.NewArray (geo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [16];
				__args [0] = new JniArgumentValue (native_names);
				__args [1] = new JniArgumentValue (native_nicknames);
				__args [2] = new JniArgumentValue (native_pronunciation);
				__args [3] = new JniArgumentValue (native_phoneNumbers);
				__args [4] = new JniArgumentValue (native_phoneTypes);
				__args [5] = new JniArgumentValue (native_emails);
				__args [6] = new JniArgumentValue (native_emailTypes);
				__args [7] = new JniArgumentValue (native_instantMessenger);
				__args [8] = new JniArgumentValue (native_note);
				__args [9] = new JniArgumentValue (native_addresses);
				__args [10] = new JniArgumentValue (native_addressTypes);
				__args [11] = new JniArgumentValue (native_org);
				__args [12] = new JniArgumentValue (native_birthday);
				__args [13] = new JniArgumentValue (native_title);
				__args [14] = new JniArgumentValue (native_urls);
				__args [15] = new JniArgumentValue (native_geo);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (names != null) {
					JNIEnv.CopyArray (native_names, names);
					JNIEnv.DeleteLocalRef (native_names);
				}
				if (nicknames != null) {
					JNIEnv.CopyArray (native_nicknames, nicknames);
					JNIEnv.DeleteLocalRef (native_nicknames);
				}
				JNIEnv.DeleteLocalRef (native_pronunciation);
				if (phoneNumbers != null) {
					JNIEnv.CopyArray (native_phoneNumbers, phoneNumbers);
					JNIEnv.DeleteLocalRef (native_phoneNumbers);
				}
				if (phoneTypes != null) {
					JNIEnv.CopyArray (native_phoneTypes, phoneTypes);
					JNIEnv.DeleteLocalRef (native_phoneTypes);
				}
				if (emails != null) {
					JNIEnv.CopyArray (native_emails, emails);
					JNIEnv.DeleteLocalRef (native_emails);
				}
				if (emailTypes != null) {
					JNIEnv.CopyArray (native_emailTypes, emailTypes);
					JNIEnv.DeleteLocalRef (native_emailTypes);
				}
				JNIEnv.DeleteLocalRef (native_instantMessenger);
				JNIEnv.DeleteLocalRef (native_note);
				if (addresses != null) {
					JNIEnv.CopyArray (native_addresses, addresses);
					JNIEnv.DeleteLocalRef (native_addresses);
				}
				if (addressTypes != null) {
					JNIEnv.CopyArray (native_addressTypes, addressTypes);
					JNIEnv.DeleteLocalRef (native_addressTypes);
				}
				JNIEnv.DeleteLocalRef (native_org);
				JNIEnv.DeleteLocalRef (native_birthday);
				JNIEnv.DeleteLocalRef (native_title);
				if (urls != null) {
					JNIEnv.CopyArray (native_urls, urls);
					JNIEnv.DeleteLocalRef (native_urls);
				}
				if (geo != null) {
					JNIEnv.CopyArray (native_geo, geo);
					JNIEnv.DeleteLocalRef (native_geo);
				}
				global::System.GC.KeepAlive (names);
				global::System.GC.KeepAlive (nicknames);
				global::System.GC.KeepAlive (phoneNumbers);
				global::System.GC.KeepAlive (phoneTypes);
				global::System.GC.KeepAlive (emails);
				global::System.GC.KeepAlive (emailTypes);
				global::System.GC.KeepAlive (addresses);
				global::System.GC.KeepAlive (addressTypes);
				global::System.GC.KeepAlive (urls);
				global::System.GC.KeepAlive (geo);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/constructor[@name='AddressBookParsedResult' and count(parameter)=7 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String[]'] and parameter[6][@type='java.lang.String[]'] and parameter[7][@type='java.lang.String[]']]"
		[Register (".ctor", "([Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public unsafe AddressBookParsedResult (string[]? names, string[]? phoneNumbers, string[]? phoneTypes, string[]? emails, string[]? emailTypes, string[]? addresses, string[]? addressTypes) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;[Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_names = JNIEnv.NewArray (names);
			IntPtr native_phoneNumbers = JNIEnv.NewArray (phoneNumbers);
			IntPtr native_phoneTypes = JNIEnv.NewArray (phoneTypes);
			IntPtr native_emails = JNIEnv.NewArray (emails);
			IntPtr native_emailTypes = JNIEnv.NewArray (emailTypes);
			IntPtr native_addresses = JNIEnv.NewArray (addresses);
			IntPtr native_addressTypes = JNIEnv.NewArray (addressTypes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_names);
				__args [1] = new JniArgumentValue (native_phoneNumbers);
				__args [2] = new JniArgumentValue (native_phoneTypes);
				__args [3] = new JniArgumentValue (native_emails);
				__args [4] = new JniArgumentValue (native_emailTypes);
				__args [5] = new JniArgumentValue (native_addresses);
				__args [6] = new JniArgumentValue (native_addressTypes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (names != null) {
					JNIEnv.CopyArray (native_names, names);
					JNIEnv.DeleteLocalRef (native_names);
				}
				if (phoneNumbers != null) {
					JNIEnv.CopyArray (native_phoneNumbers, phoneNumbers);
					JNIEnv.DeleteLocalRef (native_phoneNumbers);
				}
				if (phoneTypes != null) {
					JNIEnv.CopyArray (native_phoneTypes, phoneTypes);
					JNIEnv.DeleteLocalRef (native_phoneTypes);
				}
				if (emails != null) {
					JNIEnv.CopyArray (native_emails, emails);
					JNIEnv.DeleteLocalRef (native_emails);
				}
				if (emailTypes != null) {
					JNIEnv.CopyArray (native_emailTypes, emailTypes);
					JNIEnv.DeleteLocalRef (native_emailTypes);
				}
				if (addresses != null) {
					JNIEnv.CopyArray (native_addresses, addresses);
					JNIEnv.DeleteLocalRef (native_addresses);
				}
				if (addressTypes != null) {
					JNIEnv.CopyArray (native_addressTypes, addressTypes);
					JNIEnv.DeleteLocalRef (native_addressTypes);
				}
				global::System.GC.KeepAlive (names);
				global::System.GC.KeepAlive (phoneNumbers);
				global::System.GC.KeepAlive (phoneTypes);
				global::System.GC.KeepAlive (emails);
				global::System.GC.KeepAlive (emailTypes);
				global::System.GC.KeepAlive (addresses);
				global::System.GC.KeepAlive (addressTypes);
			}
		}

		public unsafe string? Birthday {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getBirthday' and count(parameter)=0]"
			[Register ("getBirthday", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getBirthday.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string? DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
			[Register ("getDisplayResult", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDisplayResult.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? InstantMessenger {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getInstantMessenger' and count(parameter)=0]"
			[Register ("getInstantMessenger", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getInstantMessenger.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? Note {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getNote' and count(parameter)=0]"
			[Register ("getNote", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getNote.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? Org {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getOrg' and count(parameter)=0]"
			[Register ("getOrg", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getOrg.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? Pronunciation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getPronunciation' and count(parameter)=0]"
			[Register ("getPronunciation", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getPronunciation.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getAddressTypes' and count(parameter)=0]"
		[Register ("getAddressTypes", "()[Ljava/lang/String;", "")]
		public unsafe string[]? GetAddressTypes ()
		{
			const string __id = "getAddressTypes.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getAddresses' and count(parameter)=0]"
		[Register ("getAddresses", "()[Ljava/lang/String;", "")]
		public unsafe string[]? GetAddresses ()
		{
			const string __id = "getAddresses.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getEmailTypes' and count(parameter)=0]"
		[Register ("getEmailTypes", "()[Ljava/lang/String;", "")]
		public unsafe string[]? GetEmailTypes ()
		{
			const string __id = "getEmailTypes.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getEmails' and count(parameter)=0]"
		[Register ("getEmails", "()[Ljava/lang/String;", "")]
		public unsafe string[]? GetEmails ()
		{
			const string __id = "getEmails.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getGeo' and count(parameter)=0]"
		[Register ("getGeo", "()[Ljava/lang/String;", "")]
		public unsafe string[]? GetGeo ()
		{
			const string __id = "getGeo.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getNames' and count(parameter)=0]"
		[Register ("getNames", "()[Ljava/lang/String;", "")]
		public unsafe string[]? GetNames ()
		{
			const string __id = "getNames.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getNicknames' and count(parameter)=0]"
		[Register ("getNicknames", "()[Ljava/lang/String;", "")]
		public unsafe string[]? GetNicknames ()
		{
			const string __id = "getNicknames.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getPhoneNumbers' and count(parameter)=0]"
		[Register ("getPhoneNumbers", "()[Ljava/lang/String;", "")]
		public unsafe string[]? GetPhoneNumbers ()
		{
			const string __id = "getPhoneNumbers.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getPhoneTypes' and count(parameter)=0]"
		[Register ("getPhoneTypes", "()[Ljava/lang/String;", "")]
		public unsafe string[]? GetPhoneTypes ()
		{
			const string __id = "getPhoneTypes.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='AddressBookParsedResult']/method[@name='getURLs' and count(parameter)=0]"
		[Register ("getURLs", "()[Ljava/lang/String;", "")]
		public unsafe string[]? GetURLs ()
		{
			const string __id = "getURLs.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
