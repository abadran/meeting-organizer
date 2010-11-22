﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
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
namespace Meeting_Organizer
{

[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="meetingorganizer")]
public partial class Meetingorganizer : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertEvent(Event instance);
  partial void UpdateEvent(Event instance);
  partial void DeleteEvent(Event instance);
  partial void InsertEventInviteeRelation(EventInviteeRelation instance);
  partial void UpdateEventInviteeRelation(EventInviteeRelation instance);
  partial void DeleteEventInviteeRelation(EventInviteeRelation instance);
  partial void InsertUser(User instance);
  partial void UpdateUser(User instance);
  partial void DeleteUser(User instance);
  #endregion
	
	public Meetingorganizer(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public Meetingorganizer(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public Meetingorganizer(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public Meetingorganizer(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Event> Event
	{
		get
		{
			return this.GetTable<Event>();
		}
	}
	
	public System.Data.Linq.Table<EventInviteeRelation> EventInviteeRelation
	{
		get
		{
			return this.GetTable<EventInviteeRelation>();
		}
	}
	
	public System.Data.Linq.Table<User> User
	{
		get
		{
			return this.GetTable<User>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Event")]
public partial class Event : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private int _CreatorId;
	
	private string _Title;
	
	private string _Subject;
	
	private System.DateTime _Start;
	
	private int _Duration;
	
	private int _Deleted;
	
	private EntityRef<User> _User;
	
	private EntitySet<EventInviteeRelation> _EventInviteeRelation;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCreatorIdChanging(int value);
    partial void OnCreatorIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnSubjectChanging(string value);
    partial void OnSubjectChanged();
    partial void OnStartChanging(System.DateTime value);
    partial void OnStartChanged();
    partial void OnDurationChanging(int value);
    partial void OnDurationChanged();
    partial void OnDeletedChanging(int value);
    partial void OnDeletedChanged();
    #endregion
	
	public Event()
	{
		this._User = default(EntityRef<User>);
		this._EventInviteeRelation = new EntitySet<EventInviteeRelation>(new Action<EventInviteeRelation>(this.attach_EventInviteeRelation), new Action<EventInviteeRelation>(this.detach_EventInviteeRelation));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id", Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="creatorId", Storage="_CreatorId", DbType="Int NOT NULL")]
	public int CreatorId
	{
		get
		{
			return this._CreatorId;
		}
		set
		{
			if ((this._CreatorId != value))
			{
				this.OnCreatorIdChanging(value);
				this.SendPropertyChanging();
				this._CreatorId = value;
				this.SendPropertyChanged("CreatorId");
				this.OnCreatorIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="title", Storage="_Title", DbType="NVarChar(2000)")]
	public string Title
	{
		get
		{
			return this._Title;
		}
		set
		{
			if ((this._Title != value))
			{
				this.OnTitleChanging(value);
				this.SendPropertyChanging();
				this._Title = value;
				this.SendPropertyChanged("Title");
				this.OnTitleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="subject", Storage="_Subject", DbType="NVarChar(4000)")]
	public string Subject
	{
		get
		{
			return this._Subject;
		}
		set
		{
			if ((this._Subject != value))
			{
				this.OnSubjectChanging(value);
				this.SendPropertyChanging();
				this._Subject = value;
				this.SendPropertyChanged("Subject");
				this.OnSubjectChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="start", Storage="_Start", DbType="DateTime NOT NULL")]
	public System.DateTime Start
	{
		get
		{
			return this._Start;
		}
		set
		{
			if ((this._Start != value))
			{
				this.OnStartChanging(value);
				this.SendPropertyChanging();
				this._Start = value;
				this.SendPropertyChanged("Start");
				this.OnStartChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="duration", Storage="_Duration", DbType="Int NOT NULL")]
	public int Duration
	{
		get
		{
			return this._Duration;
		}
		set
		{
			if ((this._Duration != value))
			{
				this.OnDurationChanging(value);
				this.SendPropertyChanging();
				this._Duration = value;
				this.SendPropertyChanged("Duration");
				this.OnDurationChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="deleted", Storage="_Deleted", DbType="Int NOT NULL")]
	public int Deleted
	{
		get
		{
			return this._Deleted;
		}
		set
		{
			if ((this._Deleted != value))
			{
				this.OnDeletedChanging(value);
				this.SendPropertyChanging();
				this._Deleted = value;
				this.SendPropertyChanged("Deleted");
				this.OnDeletedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Event_User", Storage="_User", ThisKey="CreatorId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true)]
	public User User
	{
		get
		{
			return this._User.Entity;
		}
		set
		{
			User previousValue = this._User.Entity;
			if (((previousValue != value) 
						|| (this._User.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._User.Entity = null;
					previousValue.Event.Remove(this);
				}
				this._User.Entity = value;
				if ((value != null))
				{
					value.Event.Add(this);
					this._CreatorId = value.Id;
				}
				else
				{
					this._CreatorId = default(int);
				}
				this.SendPropertyChanged("User");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_EventInviteeRelation_Event", Storage="_EventInviteeRelation", ThisKey="Id", OtherKey="EventId", DeleteRule="CASCADE")]
	public EntitySet<EventInviteeRelation> EventInviteeRelation
	{
		get
		{
			return this._EventInviteeRelation;
		}
		set
		{
			this._EventInviteeRelation.Assign(value);
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
	
	private void attach_EventInviteeRelation(EventInviteeRelation entity)
	{
		this.SendPropertyChanging();
		entity.Event = this;
	}
	
	private void detach_EventInviteeRelation(EventInviteeRelation entity)
	{
		this.SendPropertyChanging();
		entity.Event = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EventInviteeRelation")]
public partial class EventInviteeRelation : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _EventId;
	
	private int _InviteeId;
	
	private int _InviteeResponse;
	
	private int _InviteeAckDeletion;
	
	private EntityRef<Event> _Event;
	
	private EntityRef<User> _User;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEventIdChanging(int value);
    partial void OnEventIdChanged();
    partial void OnInviteeIdChanging(int value);
    partial void OnInviteeIdChanged();
    partial void OnInviteeResponseChanging(int value);
    partial void OnInviteeResponseChanged();
    partial void OnInviteeAckDeletionChanging(int value);
    partial void OnInviteeAckDeletionChanged();
    #endregion
	
	public EventInviteeRelation()
	{
		this._Event = default(EntityRef<Event>);
		this._User = default(EntityRef<User>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="eventId", Storage="_EventId", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int EventId
	{
		get
		{
			return this._EventId;
		}
		set
		{
			if ((this._EventId != value))
			{
				this.OnEventIdChanging(value);
				this.SendPropertyChanging();
				this._EventId = value;
				this.SendPropertyChanged("EventId");
				this.OnEventIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="inviteeId", Storage="_InviteeId", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int InviteeId
	{
		get
		{
			return this._InviteeId;
		}
		set
		{
			if ((this._InviteeId != value))
			{
				this.OnInviteeIdChanging(value);
				this.SendPropertyChanging();
				this._InviteeId = value;
				this.SendPropertyChanged("InviteeId");
				this.OnInviteeIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="inviteeResponse", Storage="_InviteeResponse", DbType="Int NOT NULL")]
	public int InviteeResponse
	{
		get
		{
			return this._InviteeResponse;
		}
		set
		{
			if ((this._InviteeResponse != value))
			{
				this.OnInviteeResponseChanging(value);
				this.SendPropertyChanging();
				this._InviteeResponse = value;
				this.SendPropertyChanged("InviteeResponse");
				this.OnInviteeResponseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="inviteeAckDeletion", Storage="_InviteeAckDeletion", DbType="Int NOT NULL")]
	public int InviteeAckDeletion
	{
		get
		{
			return this._InviteeAckDeletion;
		}
		set
		{
			if ((this._InviteeAckDeletion != value))
			{
				this.OnInviteeAckDeletionChanging(value);
				this.SendPropertyChanging();
				this._InviteeAckDeletion = value;
				this.SendPropertyChanged("InviteeAckDeletion");
				this.OnInviteeAckDeletionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_EventInviteeRelation_Event", Storage="_Event", ThisKey="EventId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true)]
	public Event Event
	{
		get
		{
			return this._Event.Entity;
		}
		set
		{
			Event previousValue = this._Event.Entity;
			if (((previousValue != value) 
						|| (this._Event.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Event.Entity = null;
					previousValue.EventInviteeRelation.Remove(this);
				}
				this._Event.Entity = value;
				if ((value != null))
				{
					value.EventInviteeRelation.Add(this);
					this._EventId = value.Id;
				}
				else
				{
					this._EventId = default(int);
				}
				this.SendPropertyChanged("Event");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_EventInviteeRelation_User", Storage="_User", ThisKey="InviteeId", OtherKey="Id", IsForeignKey=true)]
	public User User
	{
		get
		{
			return this._User.Entity;
		}
		set
		{
			User previousValue = this._User.Entity;
			if (((previousValue != value) 
						|| (this._User.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._User.Entity = null;
					previousValue.EventInviteeRelation.Remove(this);
				}
				this._User.Entity = value;
				if ((value != null))
				{
					value.EventInviteeRelation.Add(this);
					this._InviteeId = value.Id;
				}
				else
				{
					this._InviteeId = default(int);
				}
				this.SendPropertyChanged("User");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.User")]
public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Name;
	
	private string _Login;
	
	private string _Password;
	
	private EntitySet<Event> _Event;
	
	private EntitySet<EventInviteeRelation> _EventInviteeRelation;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLoginChanging(string value);
    partial void OnLoginChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
	
	public User()
	{
		this._Event = new EntitySet<Event>(new Action<Event>(this.attach_Event), new Action<Event>(this.detach_Event));
		this._EventInviteeRelation = new EntitySet<EventInviteeRelation>(new Action<EventInviteeRelation>(this.attach_EventInviteeRelation), new Action<EventInviteeRelation>(this.detach_EventInviteeRelation));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id", Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="name", Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="login", Storage="_Login", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
	public string Login
	{
		get
		{
			return this._Login;
		}
		set
		{
			if ((this._Login != value))
			{
				this.OnLoginChanging(value);
				this.SendPropertyChanging();
				this._Login = value;
				this.SendPropertyChanged("Login");
				this.OnLoginChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="password", Storage="_Password", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_Event_User", Storage="_Event", ThisKey="Id", OtherKey="CreatorId", DeleteRule="CASCADE")]
	public EntitySet<Event> Event
	{
		get
		{
			return this._Event;
		}
		set
		{
			this._Event.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FK_EventInviteeRelation_User", Storage="_EventInviteeRelation", ThisKey="Id", OtherKey="InviteeId", DeleteRule="NO ACTION")]
	public EntitySet<EventInviteeRelation> EventInviteeRelation
	{
		get
		{
			return this._EventInviteeRelation;
		}
		set
		{
			this._EventInviteeRelation.Assign(value);
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
	
	private void attach_Event(Event entity)
	{
		this.SendPropertyChanging();
		entity.User = this;
	}
	
	private void detach_Event(Event entity)
	{
		this.SendPropertyChanging();
		entity.User = null;
	}
	
	private void attach_EventInviteeRelation(EventInviteeRelation entity)
	{
		this.SendPropertyChanging();
		entity.User = this;
	}
	
	private void detach_EventInviteeRelation(EventInviteeRelation entity)
	{
		this.SendPropertyChanging();
		entity.User = null;
	}
}
}










#pragma warning restore 1591