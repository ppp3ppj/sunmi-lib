using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/sunmi/aidl",
						"org/greenrobot/greendao/query",
					},
					new Converter<string, Type?>[]{
						lookup_com_sunmi_aidl_package,
						lookup_org_greenrobot_greendao_query_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

#if NET5_0_OR_GREATER
		[System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage ("Trimming", "IL2057")]
#endif
		static Type? Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[]? package_com_sunmi_aidl_mappings;
		static Type? lookup_com_sunmi_aidl_package (string klass)
		{
			if (package_com_sunmi_aidl_mappings == null) {
				package_com_sunmi_aidl_mappings = new string[]{
					"com/sunmi/aidl/SendService$Stub:Com.Sunmi.Aidl.ISendService/Stub",
					"com/sunmi/aidl/SendServiceCallback$Stub:Com.Sunmi.Aidl.ISendServiceCallback/Stub",
				};
			}

			return Lookup (package_com_sunmi_aidl_mappings, klass);
		}

		static string[]? package_org_greenrobot_greendao_query_mappings;
		static Type? lookup_org_greenrobot_greendao_query_package (string klass)
		{
			if (package_org_greenrobot_greendao_query_mappings == null) {
				package_org_greenrobot_greendao_query_mappings = new string[]{
					"org/greenrobot/greendao/query/WhereCondition$AbstractCondition:Org.Greenrobot.Greendao.Query.IWhereCondition/AbstractCondition",
					"org/greenrobot/greendao/query/WhereCondition$PropertyCondition:Org.Greenrobot.Greendao.Query.IWhereCondition/PropertyCondition",
					"org/greenrobot/greendao/query/WhereCondition$StringCondition:Org.Greenrobot.Greendao.Query.IWhereCondition/StringCondition",
				};
			}

			return Lookup (package_org_greenrobot_greendao_query_mappings, klass);
		}
	}
}
