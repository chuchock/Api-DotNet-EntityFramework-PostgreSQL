﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_postgresql.Models;

namespace api_postgresql.DataAccess
{
	public interface IDataAccessProvider
	{
		void AddPatientRecord(Patient patient);
		void UpdatePatientRecord(Patient patient);
		void DeletePatientRecord(string id);
		Patient GetPatientSingleRecord(string id);
		List<Patient> GetPatientRecords();
	}
}
