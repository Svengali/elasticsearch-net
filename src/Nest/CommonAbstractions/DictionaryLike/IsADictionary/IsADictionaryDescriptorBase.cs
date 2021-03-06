namespace Nest
{
	public abstract class IsADictionaryDescriptorBase<TDescriptor, TInterface, TKey, TValue>
		: DescriptorPromiseBase<TDescriptor, TInterface>
		where TDescriptor : IsADictionaryDescriptorBase<TDescriptor, TInterface, TKey, TValue>
		where TInterface : class, IIsADictionary<TKey, TValue>
	{
		protected IsADictionaryDescriptorBase(TInterface instance) : base(instance) { }

		protected TDescriptor Assign(TKey key, TValue value)
		{
			PromisedValue.Add(key, value);
			return Self;
		}
	}
}
