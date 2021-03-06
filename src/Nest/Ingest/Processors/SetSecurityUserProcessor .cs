﻿using System;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	/// <summary>
	/// Sets user-related details (such as username, roles, email, full_name and metadata ) from the
	/// current authenticated user to the current document by pre-processing the ingest.
	/// </summary>
	[InterfaceDataContract]
	public interface ISetSecurityUserProcessor : IProcessor
	{
		/// <summary>The field to store the user information into. </summary>
		[DataMember(Name = "field")]
		Field Field { get; set; }
	}


	/// <inheritdoc cref="ISetSecurityUserProcessor" />
	public class SetSecurityUserProcessor : ProcessorBase, ISetSecurityUserProcessor
	{
		/// <inheritdoc cref="ISetSecurityUserProcessor.Field"/>
		public Field Field { get; set; }
		protected override string Name => "set_security_user";
	}

	/// <inheritdoc cref="ISetSecurityUserProcessor" />
	public class SetSecurityUserProcessorDescriptor<T>
		: ProcessorDescriptorBase<SetSecurityUserProcessorDescriptor<T>, ISetSecurityUserProcessor>, ISetSecurityUserProcessor
		where T : class
	{
		protected override string Name => "set_security_user";
		Field ISetSecurityUserProcessor.Field { get; set; }

		/// <inheritdoc cref="ISetSecurityUserProcessor.Field"/>
		public SetSecurityUserProcessorDescriptor<T> Field(Field field) => Assign(field, (a, v) => a.Field = v);

		/// <inheritdoc cref="ISetSecurityUserProcessor.Field"/>
		public SetSecurityUserProcessorDescriptor<T> Field(Expression<Func<T, object>> objectPath) =>
			Assign(objectPath, (a, v) => a.Field = v);
	}
}
