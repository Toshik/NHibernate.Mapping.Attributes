//
// NHibernate.Mapping.Attributes
// This product is under the terms of the GNU Lesser General Public License.
//
namespace NHibernate.Mapping.Attributes
{
	/// <summary>
	/// Return the value to use when a (required) attribute is not specified.
	/// Note: Implementations of Get_XXX_YYY_DefaultValue()
	///   return [type|property].Name; // YYY is the "identifier" of XXX
	///   ThrowRequiredValueNotProvidedException(); // There is no way to get it
	/// </summary>
	public class HbmWriterHelper
    {
        public static string GetNameWithAssembly(System.Type type)
        {
            //return type.FullName + ", " + type.Assembly.GetName().Name; // Requires FileIOPermission in medium-trust
            string assemblyName = type.Assembly.FullName;
            int comma = assemblyName.IndexOf(",");
            assemblyName = assemblyName.Substring(0, comma);
            return type.FullName + ", " + assemblyName;
        }

		protected virtual string ThrowRequiredValueNotProvidedException(System.Reflection.MemberInfo member)
		{
			throw new MappingException(
				string.Format("This required value hasn't been provided (your mapping is incomplete).\nClass: {0}\nMember: {1}\nUse the name of the method causing this exception to know which value is missing (it is YYY in the method called: Get_XXX_YYY_DefaultValue()).",
					member==null? "Unknow" : member.DeclaringType.ToString(), member==null? "Unknow" : member.Name) );
		}


		public virtual string Get_Component_Name_DefaultValue(System.Type type)
		{
			throw new MappingException( "You must specify the name of the property to which the component " + type + " is applied." );
		}


		public virtual string Get_Import_Class_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_Version_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return member.Name;
		}


		public virtual string Get_Timestamp_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return member.Name;
		}


		public virtual string Get_Property_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return member.Name;
		}


		public virtual string Get_MetaValue_Value_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_MetaValue_Class_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_Any_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return member.Name;
		}


		public virtual string Get_Any_IdType_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_Array_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return member.Name;
		}


		public virtual string Get_Cache_Usage_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_CollectionId_Column_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_CollectionId_Type_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_Column_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_DynamicComponent_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return member.Name;
		}


		public virtual string Get_CompositeElement_Class_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_CompositeIndex_Class_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_Element_Type_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_Generator_Class_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_IdBag_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return member.Name;
		}


		public virtual string Get_IndexManyToAny_IdType_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_IndexManyToMany_Class_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_JcsCache_Usage_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_KeyManyToOne_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_KeyProperty_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_ManyToAny_IdType_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_ManyToMany_Class_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_ManyToOne_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return member.Name;
		}


		public virtual string Get_Meta_Attribute_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_NestedCompositeElement_Class_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_NestedCompositeElement_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_OneToMany_Class_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_OneToOne_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return member.Name;
		}


		public virtual string Get_Param_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_Parent_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_PrimitiveArray_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return member.Name;
		}


		public virtual string Get_List_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return member.Name;
		}


		public virtual string Get_Bag_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return member.Name;
		}


		public virtual string Get_Set_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return member.Name;
		}


		public virtual string Get_Map_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return member.Name;
		}


		public virtual string Get_Type_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_FilterDef_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_Filter_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_FilterParam_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_FilterParam_Type_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_Loader_QueryRef_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_ResultSet_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_Query_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_SqlQuery_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_ReturnProperty_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_ReturnJoin_Alias_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_ReturnJoin_Property_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_ReturnScalar_Column_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_ReturnScalar_Type_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_LoadCollection_Alias_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_LoadCollection_Role_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_DialectScope_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_ReturnDiscriminator_Column_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_ReturnColumn_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}


		public virtual string Get_Synchronize_Table_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}

		public virtual string Get_Definition_Class_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}

		public virtual string Get_QueryParam_Name_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}

		public virtual string Get_QueryParam_Type_DefaultValue(System.Reflection.MemberInfo member)
		{
			return ThrowRequiredValueNotProvidedException(member);
		}

	    public string Get_CompositeMapKey_Class_DefaultValue(System.Reflection.MemberInfo member)
        {
            return ThrowRequiredValueNotProvidedException(member);
	    }

	    public string Get_Tuplizer_Class_DefaultValue(System.Reflection.MemberInfo member)
        {
            return ThrowRequiredValueNotProvidedException(member);
	    }

	    public string Get_TypeDef_Class_DefaultValue(System.Reflection.MemberInfo member)
        {
            return ThrowRequiredValueNotProvidedException(member);
	    }

	    public string Get_TypeDef_Name_DefaultValue(System.Reflection.MemberInfo member)
        {
            return ThrowRequiredValueNotProvidedException(member);
	    }

	    public string Get_MapKey_Type_DefaultValue(System.Reflection.MemberInfo member)
        {
            return ThrowRequiredValueNotProvidedException(member);
	    }

	    public string Get_Properties_Name_DefaultValue(System.Reflection.MemberInfo member)
        {
            return ThrowRequiredValueNotProvidedException(member);
	    }

	    public string Get_Join_Table_DefaultValue(System.Reflection.MemberInfo member)
        {
            return ThrowRequiredValueNotProvidedException(member);
	    }
	}
}
