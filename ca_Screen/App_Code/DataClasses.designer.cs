﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MaisonExpertData")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertPropertyData(PropertyData instance);
  partial void UpdatePropertyData(PropertyData instance);
  partial void DeletePropertyData(PropertyData instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MaisonExpertDataConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<PropertyData> PropertyDatas
	{
		get
		{
			return this.GetTable<PropertyData>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PropertyData")]
public partial class PropertyData : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PropertyID;
	
	private string _Heading;
	
	private string _Address;
	
	private System.Nullable<int> _PostalCode;
	
	private System.Nullable<double> _Size;
	
	private System.Nullable<double> _Prize;
	
	private string _UserName;
	
	private string _Description;
	
	private System.Nullable<int> _Bedroom;
	
	private System.Nullable<double> _Bathroom;
	
	private string _PropertyImage;
	
	private string _Email;
	
	private System.Nullable<int> _Phone;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPropertyIDChanging(int value);
    partial void OnPropertyIDChanged();
    partial void OnHeadingChanging(string value);
    partial void OnHeadingChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnPostalCodeChanging(System.Nullable<int> value);
    partial void OnPostalCodeChanged();
    partial void OnSizeChanging(System.Nullable<double> value);
    partial void OnSizeChanged();
    partial void OnPrizeChanging(System.Nullable<double> value);
    partial void OnPrizeChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnBedroomChanging(System.Nullable<int> value);
    partial void OnBedroomChanged();
    partial void OnBathroomChanging(System.Nullable<double> value);
    partial void OnBathroomChanged();
    partial void OnPropertyImageChanging(string value);
    partial void OnPropertyImageChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneChanging(System.Nullable<int> value);
    partial void OnPhoneChanged();
    #endregion
	
	public PropertyData()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int PropertyID
	{
		get
		{
			return this._PropertyID;
		}
		set
		{
			if ((this._PropertyID != value))
			{
				this.OnPropertyIDChanging(value);
				this.SendPropertyChanging();
				this._PropertyID = value;
				this.SendPropertyChanged("PropertyID");
				this.OnPropertyIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Heading", DbType="NVarChar(255)")]
	public string Heading
	{
		get
		{
			return this._Heading;
		}
		set
		{
			if ((this._Heading != value))
			{
				this.OnHeadingChanging(value);
				this.SendPropertyChanging();
				this._Heading = value;
				this.SendPropertyChanged("Heading");
				this.OnHeadingChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(255)")]
	public string Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			if ((this._Address != value))
			{
				this.OnAddressChanging(value);
				this.SendPropertyChanging();
				this._Address = value;
				this.SendPropertyChanged("Address");
				this.OnAddressChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalCode", DbType="Int")]
	public System.Nullable<int> PostalCode
	{
		get
		{
			return this._PostalCode;
		}
		set
		{
			if ((this._PostalCode != value))
			{
				this.OnPostalCodeChanging(value);
				this.SendPropertyChanging();
				this._PostalCode = value;
				this.SendPropertyChanged("PostalCode");
				this.OnPostalCodeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="Float")]
	public System.Nullable<double> Size
	{
		get
		{
			return this._Size;
		}
		set
		{
			if ((this._Size != value))
			{
				this.OnSizeChanging(value);
				this.SendPropertyChanging();
				this._Size = value;
				this.SendPropertyChanged("Size");
				this.OnSizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prize", DbType="Float")]
	public System.Nullable<double> Prize
	{
		get
		{
			return this._Prize;
		}
		set
		{
			if ((this._Prize != value))
			{
				this.OnPrizeChanging(value);
				this.SendPropertyChanging();
				this._Prize = value;
				this.SendPropertyChanged("Prize");
				this.OnPrizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
	public string UserName
	{
		get
		{
			return this._UserName;
		}
		set
		{
			if ((this._UserName != value))
			{
				this.OnUserNameChanging(value);
				this.SendPropertyChanging();
				this._UserName = value;
				this.SendPropertyChanged("UserName");
				this.OnUserNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
	public string Description
	{
		get
		{
			return this._Description;
		}
		set
		{
			if ((this._Description != value))
			{
				this.OnDescriptionChanging(value);
				this.SendPropertyChanging();
				this._Description = value;
				this.SendPropertyChanged("Description");
				this.OnDescriptionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bedroom", DbType="Int")]
	public System.Nullable<int> Bedroom
	{
		get
		{
			return this._Bedroom;
		}
		set
		{
			if ((this._Bedroom != value))
			{
				this.OnBedroomChanging(value);
				this.SendPropertyChanging();
				this._Bedroom = value;
				this.SendPropertyChanged("Bedroom");
				this.OnBedroomChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bathroom", DbType="Float")]
	public System.Nullable<double> Bathroom
	{
		get
		{
			return this._Bathroom;
		}
		set
		{
			if ((this._Bathroom != value))
			{
				this.OnBathroomChanging(value);
				this.SendPropertyChanging();
				this._Bathroom = value;
				this.SendPropertyChanged("Bathroom");
				this.OnBathroomChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyImage", DbType="NVarChar(MAX)")]
	public string PropertyImage
	{
		get
		{
			return this._PropertyImage;
		}
		set
		{
			if ((this._PropertyImage != value))
			{
				this.OnPropertyImageChanging(value);
				this.SendPropertyChanging();
				this._PropertyImage = value;
				this.SendPropertyChanged("PropertyImage");
				this.OnPropertyImageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="Int")]
	public System.Nullable<int> Phone
	{
		get
		{
			return this._Phone;
		}
		set
		{
			if ((this._Phone != value))
			{
				this.OnPhoneChanging(value);
				this.SendPropertyChanging();
				this._Phone = value;
				this.SendPropertyChanged("Phone");
				this.OnPhoneChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#pragma warning restore 1591