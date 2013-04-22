﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MacGym_DB
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MacGym")]
	public partial class MacGymDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBodyPart(BodyPart instance);
    partial void UpdateBodyPart(BodyPart instance);
    partial void DeleteBodyPart(BodyPart instance);
    partial void InsertWorkoutTool(WorkoutTool instance);
    partial void UpdateWorkoutTool(WorkoutTool instance);
    partial void DeleteWorkoutTool(WorkoutTool instance);
    partial void InsertTool(Tool instance);
    partial void UpdateTool(Tool instance);
    partial void DeleteTool(Tool instance);
    partial void InsertWorkoutBodyPart(WorkoutBodyPart instance);
    partial void UpdateWorkoutBodyPart(WorkoutBodyPart instance);
    partial void DeleteWorkoutBodyPart(WorkoutBodyPart instance);
    partial void InsertWorkout(Workout instance);
    partial void UpdateWorkout(Workout instance);
    partial void DeleteWorkout(Workout instance);
    #endregion
		
		public MacGymDataContext() : 
				base(global::MacGym_DB.Properties.Settings.Default.MacGymConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MacGymDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MacGymDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MacGymDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MacGymDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BodyPart> BodyParts
		{
			get
			{
				return this.GetTable<BodyPart>();
			}
		}
		
		public System.Data.Linq.Table<WorkoutTool> WorkoutTools
		{
			get
			{
				return this.GetTable<WorkoutTool>();
			}
		}
		
		public System.Data.Linq.Table<Tool> Tools
		{
			get
			{
				return this.GetTable<Tool>();
			}
		}
		
		public System.Data.Linq.Table<WorkoutBodyPart> WorkoutBodyParts
		{
			get
			{
				return this.GetTable<WorkoutBodyPart>();
			}
		}
		
		public System.Data.Linq.Table<Workout> Workouts
		{
			get
			{
				return this.GetTable<Workout>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BodyParts")]
	public partial class BodyPart : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _bodyPartID;
		
		private string _name;
		
		private EntitySet<WorkoutBodyPart> _WorkoutBodyParts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnbodyPartIDChanging(int value);
    partial void OnbodyPartIDChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public BodyPart()
		{
			this._WorkoutBodyParts = new EntitySet<WorkoutBodyPart>(new Action<WorkoutBodyPart>(this.attach_WorkoutBodyParts), new Action<WorkoutBodyPart>(this.detach_WorkoutBodyParts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bodyPartID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int bodyPartID
		{
			get
			{
				return this._bodyPartID;
			}
			set
			{
				if ((this._bodyPartID != value))
				{
					this.OnbodyPartIDChanging(value);
					this.SendPropertyChanging();
					this._bodyPartID = value;
					this.SendPropertyChanged("bodyPartID");
					this.OnbodyPartIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BodyPart_WorkoutBodyPart", Storage="_WorkoutBodyParts", ThisKey="bodyPartID", OtherKey="bodyPartID")]
		public EntitySet<WorkoutBodyPart> WorkoutBodyParts
		{
			get
			{
				return this._WorkoutBodyParts;
			}
			set
			{
				this._WorkoutBodyParts.Assign(value);
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
		
		private void attach_WorkoutBodyParts(WorkoutBodyPart entity)
		{
			this.SendPropertyChanging();
			entity.BodyPart = this;
		}
		
		private void detach_WorkoutBodyParts(WorkoutBodyPart entity)
		{
			this.SendPropertyChanging();
			entity.BodyPart = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WorkoutTools")]
	public partial class WorkoutTool : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _workoutToolID;
		
		private int _workoutID;
		
		private int _toolID;
		
		private EntityRef<Tool> _Tool;
		
		private EntityRef<Workout> _Workout;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnworkoutToolIDChanging(int value);
    partial void OnworkoutToolIDChanged();
    partial void OnworkoutIDChanging(int value);
    partial void OnworkoutIDChanged();
    partial void OntoolIDChanging(int value);
    partial void OntoolIDChanged();
    #endregion
		
		public WorkoutTool()
		{
			this._Tool = default(EntityRef<Tool>);
			this._Workout = default(EntityRef<Workout>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_workoutToolID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int workoutToolID
		{
			get
			{
				return this._workoutToolID;
			}
			set
			{
				if ((this._workoutToolID != value))
				{
					this.OnworkoutToolIDChanging(value);
					this.SendPropertyChanging();
					this._workoutToolID = value;
					this.SendPropertyChanged("workoutToolID");
					this.OnworkoutToolIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_workoutID", DbType="Int NOT NULL")]
		public int workoutID
		{
			get
			{
				return this._workoutID;
			}
			set
			{
				if ((this._workoutID != value))
				{
					if (this._Workout.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnworkoutIDChanging(value);
					this.SendPropertyChanging();
					this._workoutID = value;
					this.SendPropertyChanged("workoutID");
					this.OnworkoutIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_toolID", DbType="Int NOT NULL")]
		public int toolID
		{
			get
			{
				return this._toolID;
			}
			set
			{
				if ((this._toolID != value))
				{
					if (this._Tool.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OntoolIDChanging(value);
					this.SendPropertyChanging();
					this._toolID = value;
					this.SendPropertyChanged("toolID");
					this.OntoolIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tool_WorkoutTool", Storage="_Tool", ThisKey="toolID", OtherKey="toolID", IsForeignKey=true)]
		public Tool Tool
		{
			get
			{
				return this._Tool.Entity;
			}
			set
			{
				Tool previousValue = this._Tool.Entity;
				if (((previousValue != value) 
							|| (this._Tool.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tool.Entity = null;
						previousValue.WorkoutTools.Remove(this);
					}
					this._Tool.Entity = value;
					if ((value != null))
					{
						value.WorkoutTools.Add(this);
						this._toolID = value.toolID;
					}
					else
					{
						this._toolID = default(int);
					}
					this.SendPropertyChanged("Tool");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Workout_WorkoutTool", Storage="_Workout", ThisKey="workoutID", OtherKey="workoutID", IsForeignKey=true)]
		public Workout Workout
		{
			get
			{
				return this._Workout.Entity;
			}
			set
			{
				Workout previousValue = this._Workout.Entity;
				if (((previousValue != value) 
							|| (this._Workout.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Workout.Entity = null;
						previousValue.WorkoutTools.Remove(this);
					}
					this._Workout.Entity = value;
					if ((value != null))
					{
						value.WorkoutTools.Add(this);
						this._workoutID = value.workoutID;
					}
					else
					{
						this._workoutID = default(int);
					}
					this.SendPropertyChanged("Workout");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tools")]
	public partial class Tool : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _toolID;
		
		private string _name;
		
		private EntitySet<WorkoutTool> _WorkoutTools;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntoolIDChanging(int value);
    partial void OntoolIDChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public Tool()
		{
			this._WorkoutTools = new EntitySet<WorkoutTool>(new Action<WorkoutTool>(this.attach_WorkoutTools), new Action<WorkoutTool>(this.detach_WorkoutTools));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_toolID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int toolID
		{
			get
			{
				return this._toolID;
			}
			set
			{
				if ((this._toolID != value))
				{
					this.OntoolIDChanging(value);
					this.SendPropertyChanging();
					this._toolID = value;
					this.SendPropertyChanged("toolID");
					this.OntoolIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tool_WorkoutTool", Storage="_WorkoutTools", ThisKey="toolID", OtherKey="toolID")]
		public EntitySet<WorkoutTool> WorkoutTools
		{
			get
			{
				return this._WorkoutTools;
			}
			set
			{
				this._WorkoutTools.Assign(value);
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
		
		private void attach_WorkoutTools(WorkoutTool entity)
		{
			this.SendPropertyChanging();
			entity.Tool = this;
		}
		
		private void detach_WorkoutTools(WorkoutTool entity)
		{
			this.SendPropertyChanging();
			entity.Tool = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WorkoutBodyParts")]
	public partial class WorkoutBodyPart : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _workoutBodyPartID;
		
		private int _workoutID;
		
		private int _bodyPartID;
		
		private EntityRef<BodyPart> _BodyPart;
		
		private EntityRef<Workout> _Workout;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnworkoutBodyPartIDChanging(int value);
    partial void OnworkoutBodyPartIDChanged();
    partial void OnworkoutIDChanging(int value);
    partial void OnworkoutIDChanged();
    partial void OnbodyPartIDChanging(int value);
    partial void OnbodyPartIDChanged();
    #endregion
		
		public WorkoutBodyPart()
		{
			this._BodyPart = default(EntityRef<BodyPart>);
			this._Workout = default(EntityRef<Workout>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_workoutBodyPartID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int workoutBodyPartID
		{
			get
			{
				return this._workoutBodyPartID;
			}
			set
			{
				if ((this._workoutBodyPartID != value))
				{
					this.OnworkoutBodyPartIDChanging(value);
					this.SendPropertyChanging();
					this._workoutBodyPartID = value;
					this.SendPropertyChanged("workoutBodyPartID");
					this.OnworkoutBodyPartIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_workoutID", DbType="Int NOT NULL")]
		public int workoutID
		{
			get
			{
				return this._workoutID;
			}
			set
			{
				if ((this._workoutID != value))
				{
					if (this._Workout.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnworkoutIDChanging(value);
					this.SendPropertyChanging();
					this._workoutID = value;
					this.SendPropertyChanged("workoutID");
					this.OnworkoutIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bodyPartID", DbType="Int NOT NULL")]
		public int bodyPartID
		{
			get
			{
				return this._bodyPartID;
			}
			set
			{
				if ((this._bodyPartID != value))
				{
					if (this._BodyPart.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnbodyPartIDChanging(value);
					this.SendPropertyChanging();
					this._bodyPartID = value;
					this.SendPropertyChanged("bodyPartID");
					this.OnbodyPartIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BodyPart_WorkoutBodyPart", Storage="_BodyPart", ThisKey="bodyPartID", OtherKey="bodyPartID", IsForeignKey=true)]
		public BodyPart BodyPart
		{
			get
			{
				return this._BodyPart.Entity;
			}
			set
			{
				BodyPart previousValue = this._BodyPart.Entity;
				if (((previousValue != value) 
							|| (this._BodyPart.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BodyPart.Entity = null;
						previousValue.WorkoutBodyParts.Remove(this);
					}
					this._BodyPart.Entity = value;
					if ((value != null))
					{
						value.WorkoutBodyParts.Add(this);
						this._bodyPartID = value.bodyPartID;
					}
					else
					{
						this._bodyPartID = default(int);
					}
					this.SendPropertyChanged("BodyPart");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Workout_WorkoutBodyPart", Storage="_Workout", ThisKey="workoutID", OtherKey="workoutID", IsForeignKey=true)]
		public Workout Workout
		{
			get
			{
				return this._Workout.Entity;
			}
			set
			{
				Workout previousValue = this._Workout.Entity;
				if (((previousValue != value) 
							|| (this._Workout.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Workout.Entity = null;
						previousValue.WorkoutBodyParts.Remove(this);
					}
					this._Workout.Entity = value;
					if ((value != null))
					{
						value.WorkoutBodyParts.Add(this);
						this._workoutID = value.workoutID;
					}
					else
					{
						this._workoutID = default(int);
					}
					this.SendPropertyChanged("Workout");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Workouts")]
	public partial class Workout : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _workoutID;
		
		private string _name;
		
		private string _shortDescription;
		
		private string _longDescription;
		
		private EntitySet<WorkoutTool> _WorkoutTools;
		
		private EntitySet<WorkoutBodyPart> _WorkoutBodyParts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnworkoutIDChanging(int value);
    partial void OnworkoutIDChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnshortDescriptionChanging(string value);
    partial void OnshortDescriptionChanged();
    partial void OnlongDescriptionChanging(string value);
    partial void OnlongDescriptionChanged();
    #endregion
		
		public Workout()
		{
			this._WorkoutTools = new EntitySet<WorkoutTool>(new Action<WorkoutTool>(this.attach_WorkoutTools), new Action<WorkoutTool>(this.detach_WorkoutTools));
			this._WorkoutBodyParts = new EntitySet<WorkoutBodyPart>(new Action<WorkoutBodyPart>(this.attach_WorkoutBodyParts), new Action<WorkoutBodyPart>(this.detach_WorkoutBodyParts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_workoutID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int workoutID
		{
			get
			{
				return this._workoutID;
			}
			set
			{
				if ((this._workoutID != value))
				{
					this.OnworkoutIDChanging(value);
					this.SendPropertyChanging();
					this._workoutID = value;
					this.SendPropertyChanged("workoutID");
					this.OnworkoutIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_shortDescription", DbType="NVarChar(255)")]
		public string shortDescription
		{
			get
			{
				return this._shortDescription;
			}
			set
			{
				if ((this._shortDescription != value))
				{
					this.OnshortDescriptionChanging(value);
					this.SendPropertyChanging();
					this._shortDescription = value;
					this.SendPropertyChanged("shortDescription");
					this.OnshortDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_longDescription", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string longDescription
		{
			get
			{
				return this._longDescription;
			}
			set
			{
				if ((this._longDescription != value))
				{
					this.OnlongDescriptionChanging(value);
					this.SendPropertyChanging();
					this._longDescription = value;
					this.SendPropertyChanged("longDescription");
					this.OnlongDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Workout_WorkoutTool", Storage="_WorkoutTools", ThisKey="workoutID", OtherKey="workoutID")]
		public EntitySet<WorkoutTool> WorkoutTools
		{
			get
			{
				return this._WorkoutTools;
			}
			set
			{
				this._WorkoutTools.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Workout_WorkoutBodyPart", Storage="_WorkoutBodyParts", ThisKey="workoutID", OtherKey="workoutID")]
		public EntitySet<WorkoutBodyPart> WorkoutBodyParts
		{
			get
			{
				return this._WorkoutBodyParts;
			}
			set
			{
				this._WorkoutBodyParts.Assign(value);
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
		
		private void attach_WorkoutTools(WorkoutTool entity)
		{
			this.SendPropertyChanging();
			entity.Workout = this;
		}
		
		private void detach_WorkoutTools(WorkoutTool entity)
		{
			this.SendPropertyChanging();
			entity.Workout = null;
		}
		
		private void attach_WorkoutBodyParts(WorkoutBodyPart entity)
		{
			this.SendPropertyChanging();
			entity.Workout = this;
		}
		
		private void detach_WorkoutBodyParts(WorkoutBodyPart entity)
		{
			this.SendPropertyChanging();
			entity.Workout = null;
		}
	}
}
#pragma warning restore 1591
