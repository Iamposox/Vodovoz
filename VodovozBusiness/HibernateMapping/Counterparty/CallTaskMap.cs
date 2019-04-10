﻿using System;
using FluentNHibernate.Mapping;
using Vodovoz.Domain.Client;

namespace Vodovoz.HibernateMapping.Counterparty
{
	public class CallTaskMap : ClassMap<CallTask>
	{
		public CallTaskMap()
		{
			Table("call_tasks"); 
			Id(x => x.Id).Column("id").GeneratedBy.Native();

			Map(x => x.CreationDate).Column("date_of_task_creation");
			Map(x => x.CompleteDate).Column("date_complete");
			Map(x => x.EndActivePeriod).Column("deadline");
			Map(x => x.TaskState).Column("task_state").CustomType<CallTaskStatusStringType>();
			Map(x => x.Comment).Column("comment");
			Map(x => x.IsTaskComplete).Column("is_task_complete");
			Map(x => x.TareReturn).Column("tare_return");

			References(x => x.DeliveryPoint).Column("delivery_point_id");
			References(x => x.AssignedEmployee).Column("employee_id");
			References(x => x.TaskCreator).Column("task_creator_id");
		}
	}
}