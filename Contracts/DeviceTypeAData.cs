﻿using System.Collections.Generic;

namespace DeviceDataApi.Contracts
{
	public class DeviceTypeAData
	{
		public int PartnerId { get; set; }
		public string PartnerName { get; set; }
		public List<Tracker> Trackers { get; set; }
	}
	public class Tracker
	{
		public int Id { get; set; }
		public string Model { get; set; }
		public string ShipmentStartDtm { get; set; }
		public List<Sensor> Sensors { get; set; }
	}

	public class Sensor
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Crumb> Crumbs { get; set; }
	}

	public class Crumb
	{
		public string CreatedDtm { get; set; }
		public double Value { get; set; }
	}

}
