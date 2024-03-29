﻿namespace Relativity.DataExchange.Wrapper
{
	using System;

	public sealed class ImportCompleteEventArgs : EventArgs
	{
		public ImportCompleteEventArgs(
			long fileBytes,
			long metadataBytes,
			int totalImportCount,
			int totalErrorCount,
			DateTime startTime,
			DateTime endTime)
		{
			this.FileBytes = fileBytes;
			this.MetadataBytes = metadataBytes;
			this.TotalImportCount = totalImportCount;
			this.TotalErrorCount = totalErrorCount;
			this.StartTime = startTime;
			this.EndTime = endTime;
		}

		public long FileBytes
		{
			get;
		}

		public long MetadataBytes
		{
			get;
		}

		public int TotalImportCount
		{
			get;
		}

		public int TotalErrorCount
		{
			get;
		}

		public DateTime StartTime
		{
			get;
		}

		public DateTime EndTime
		{
			get;
		}
	}
}