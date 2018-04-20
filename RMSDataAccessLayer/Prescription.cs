//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RMSDataAccessLayer
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;
    using TrackableEntities;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    using System.Collections.ObjectModel;

    using System;
    using System.Collections.Generic;
    using TrackableEntities.Client;
    
    public partial class Prescription : TransactionBase
    {
        [DataMember]
                    [Required(ErrorMessage="DoctorId is required")]
    	public int DoctorId
    	{ 
    		get { return _DoctorId; }
    		set
    		{
    			if (Equals(value, _DoctorId)) return;
    			_DoctorId = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private int _DoctorId;
        [DataMember]
                    [Required(ErrorMessage="PatientId is required")]
    	public int PatientId
    	{ 
    		get { return _PatientId; }
    		set
    		{
    			if (Equals(value, _PatientId)) return;
    			_PatientId = value;
                ValidateModelProperty(this, value);
    			NotifyPropertyChanged();
    		}
    	}
    	private int _PatientId;
        [DataMember]
    	public Doctor Doctor
    	{
    		get { return _Doctor; }
    		set
    		{
    			if (Equals(value, _Doctor)) return;
    			_Doctor = value;
    			DoctorChangeTracker = _Doctor == null ? null
    				: new ChangeTrackingCollection<Doctor> { _Doctor };
    			NotifyPropertyChanged();
    		}
    	}
    	private Doctor _Doctor;
    	private ChangeTrackingCollection<Doctor> DoctorChangeTracker { get; set; }
        [DataMember]
    	public Patient Patient
    	{
    		get { return _Patient; }
    		set
    		{
    			if (Equals(value, _Patient)) return;
    			_Patient = value;
    			PatientChangeTracker = _Patient == null ? null
    				: new ChangeTrackingCollection<Patient> { _Patient };
    			NotifyPropertyChanged();
    		}
    	}
    	private Patient _Patient;
    	private ChangeTrackingCollection<Patient> PatientChangeTracker { get; set; }
    }
}